-- =============================================================================
-- Schéma de la base GestionStock
-- Ré-exécutable : chaque objet n'est créé que s'il n'existe pas encore, et une
-- base créée avec l'ancien script (SQLQuery1.sql) est mise à niveau.
-- =============================================================================

-- Requis pour la colonne calculée PERSISTED (actifs par défaut dans SSMS, pas dans sqlcmd)
SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;
GO

IF DB_ID(N'GestionStock') IS NULL
    CREATE DATABASE GestionStock;
GO

USE GestionStock;
GO

-- -----------------------------------------------------------------------------
-- Utilisateurs
-- -----------------------------------------------------------------------------
IF OBJECT_ID(N'dbo.users', N'U') IS NULL
CREATE TABLE users (
    id INT IDENTITY(1,1) PRIMARY KEY,
    username VARCHAR(255) NOT NULL,
    mail VARCHAR(255) NOT NULL,
    password VARCHAR(255) NULL,          -- ancien mot de passe en clair, vidé à la première connexion
    password_hash VARBINARY(32) NULL,    -- PBKDF2-SHA256
    password_salt VARBINARY(16) NULL,
    role VARCHAR(10) NOT NULL CONSTRAINT DF_users_role DEFAULT 'user'
        CONSTRAINT CK_users_role CHECK (role IN ('admin', 'user')),
    failed_attempts INT NOT NULL CONSTRAINT DF_users_failed_attempts DEFAULT 0,
    lockout_until DATETIME2 NULL          -- UTC
);
GO

-- Mise à niveau d'une ancienne table users
IF EXISTS (SELECT 1 FROM sys.columns WHERE object_id = OBJECT_ID(N'dbo.users') AND name = 'password' AND is_nullable = 0)
    ALTER TABLE users ALTER COLUMN password VARCHAR(255) NULL;
IF COL_LENGTH('dbo.users', 'password_hash') IS NULL
    ALTER TABLE users ADD password_hash VARBINARY(32) NULL;
IF COL_LENGTH('dbo.users', 'password_salt') IS NULL
    ALTER TABLE users ADD password_salt VARBINARY(16) NULL;
IF COL_LENGTH('dbo.users', 'role') IS NULL
    ALTER TABLE users ADD role VARCHAR(10) NOT NULL CONSTRAINT DF_users_role DEFAULT 'user'
        CONSTRAINT CK_users_role CHECK (role IN ('admin', 'user'));
IF COL_LENGTH('dbo.users', 'failed_attempts') IS NULL
    ALTER TABLE users ADD failed_attempts INT NOT NULL CONSTRAINT DF_users_failed_attempts DEFAULT 0;
IF COL_LENGTH('dbo.users', 'lockout_until') IS NULL
    ALTER TABLE users ADD lockout_until DATETIME2 NULL;
GO

-- Une base existante sans administrateur : le premier compte créé le devient
IF NOT EXISTS (SELECT 1 FROM users WHERE role = 'admin')
    UPDATE users SET role = 'admin' WHERE id = (SELECT MIN(id) FROM users);

-- Noms d'utilisateur uniques (uniquement si les données existantes le permettent)
IF NOT EXISTS (SELECT 1 FROM sys.indexes WHERE object_id = OBJECT_ID(N'dbo.users') AND name = 'UX_users_username')
   AND NOT EXISTS (SELECT username FROM users GROUP BY username HAVING COUNT(*) > 1)
    CREATE UNIQUE INDEX UX_users_username ON users (username);
GO

-- -----------------------------------------------------------------------------
-- Produits
-- -----------------------------------------------------------------------------
IF OBJECT_ID(N'dbo.Produit', N'U') IS NULL
CREATE TABLE Produit (
    id INT IDENTITY(1,1) PRIMARY KEY,
    nom VARCHAR(255),
    description TEXT,
    categorie VARCHAR(255),
    prix_unitaire DECIMAL(10, 2),
    qte_stock INT DEFAULT 0,
    qte_stock_max INT,
    qte_stock_min INT
);
GO

-- -----------------------------------------------------------------------------
-- Clients et fournisseurs
-- -----------------------------------------------------------------------------
IF OBJECT_ID(N'dbo.Personne', N'U') IS NULL
CREATE TABLE Personne (
    id INT IDENTITY(1,1) PRIMARY KEY,
    nom VARCHAR(100) NOT NULL,
    adresse VARCHAR(255),
    telephone VARCHAR(15),
    email VARCHAR(100),
    type VARCHAR(20) NOT NULL CHECK (type IN ('fournisseur', 'client'))
);
GO

-- -----------------------------------------------------------------------------
-- Ventes et achats
-- -----------------------------------------------------------------------------
IF OBJECT_ID(N'dbo.Operation', N'U') IS NULL
CREATE TABLE Operation (
    id_Operation INT IDENTITY(1,1) PRIMARY KEY,
    type VARCHAR(25) CHECK (type IN ('vente', 'achat')),
    id_personne INT NOT NULL,
    date_operation DATETIME DEFAULT GETDATE(),
    montant_total DECIMAL(18, 2) NOT NULL CHECK (montant_total > 0),
    CONSTRAINT FK_Operation_Personne FOREIGN KEY (id_personne)
        REFERENCES Personne(id) ON DELETE CASCADE
);
GO

IF OBJECT_ID(N'dbo.LigneOperation', N'U') IS NULL
CREATE TABLE LigneOperation (
    id_Operation INT NOT NULL,
    id_produit INT NOT NULL,
    quantite INT NOT NULL CHECK (quantite > 0),
    prix_total DECIMAL(10, 2) CHECK (prix_total >= 0),
    PRIMARY KEY (id_Operation, id_produit),
    CONSTRAINT FK_LigneOperation_Operation FOREIGN KEY (id_Operation)
        REFERENCES Operation(id_Operation) ON DELETE CASCADE,
    CONSTRAINT FK_LigneOperation_Produit FOREIGN KEY (id_produit)
        REFERENCES Produit(id) ON DELETE CASCADE
);
GO

-- -----------------------------------------------------------------------------
-- Factures
-- -----------------------------------------------------------------------------
IF OBJECT_ID(N'dbo.Factures', N'U') IS NULL
CREATE TABLE Factures (
    id INT IDENTITY(1,1) PRIMARY KEY,
    date_facture DATE NOT NULL,
    id_personne INT NOT NULL,
    statut VARCHAR(20) NOT NULL CHECK (statut IN ('payée', 'non payée')),
    type VARCHAR(20) NOT NULL CHECK (type IN ('achat', 'vente')),
    montant DECIMAL(15, 2) NOT NULL CHECK (montant > 0),
    FOREIGN KEY (id_personne) REFERENCES Personne(id)
);
GO

-- -----------------------------------------------------------------------------
-- Rapports mensuels (alimentés par l'application à partir des factures)
-- -----------------------------------------------------------------------------
IF OBJECT_ID(N'dbo.Rapport_Mensuel', N'U') IS NULL
CREATE TABLE Rapport_Mensuel (
    id INT IDENTITY(1,1) PRIMARY KEY,
    mois_annee VARCHAR(7) NOT NULL,                   -- format YYYY-MM
    recettes DECIMAL(15, 2) NOT NULL,
    depenses DECIMAL(15, 2) NOT NULL,
    benefices AS (recettes - depenses) PERSISTED
);
GO
