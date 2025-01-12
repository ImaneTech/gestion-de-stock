CREATE TABLE users (
    id INT IDENTITY(1,1) PRIMARY KEY,
    username VARCHAR(255) NOT NULL,
    mail VARCHAR(255) NOT NULL,
    password VARCHAR(255) NOT NULL
);

SELECT * FROM users ;



CREATE TABLE Produit (
    id INT PRIMARY KEY ,
    nom VARCHAR(255),
    description TEXT,
    categorie VARCHAR(255),
    prix_unitaire DECIMAL(10, 2),
    qte_stock INT DEFAULT 0,
    qte_stock_max INT,
    qte_stock_min INT
);


select * from produit;

INSERT INTO Produit (id, nom, description, categorie, prix_unitaire, qte_stock, qte_stock_max, qte_stock_min) VALUES
(1, 'Smartphone Samsung A12', 'Téléphone abordable et performant', 'Smartphones', 2000, 100, 300, 20),
(2, 'Laptop HP 15', 'PC portable pour bureautique', 'Ordinateurs', 5000, 50, 150, 10),
(3, 'TV LED 32"', 'Téléviseur compact et HD', 'Téléviseurs', 2500, 30, 80, 5),
(4, 'Écouteurs Xiaomi', 'Écouteurs sans fil simples', 'Accessoires', 300, 200, 500, 50),
(5, 'Clavier Logitech K120', 'Clavier USB basique', 'Périphériques', 200, 150, 400, 30),
(6, 'Souris Logitech M185', 'Souris sans fil compacte', 'Périphériques', 150, 180, 400, 30),
(7, 'Tablette Lenovo M10', 'Tablette pour enfants et famille', 'Tablettes', 1800, 40, 100, 10),
(8, 'Montre Connectée Amazfit', 'Suivi santé et fitness', 'Montres Connectées', 700, 70, 200, 15),
(9, 'Imprimante Canon LBP6030', 'Imprimante laser compacte', 'Imprimantes', 1000, 20, 50, 5),
(10, 'Disque Dur WD 1TB', 'Stockage fiable et rapide', 'Stockage', 600, 120, 300, 20),
(11, 'Barre de Son Sony', 'Son clair et compact', 'Audio', 1500, 25, 60, 5),
(12, 'Caméra IP TP-Link', 'Surveillance simple et efficace', 'Sécurité', 500, 50, 150, 10),
(13, 'Console Nintendo Switch', 'Console portable populaire', 'Consoles', 3500, 15, 40, 5),
(14, 'Router TP-Link AC750', 'Internet rapide et fiable', 'Réseaux', 350, 60, 200, 15),
(15, 'Chargeur Rapide Anker', 'Chargeur USB rapide', 'Accessoires', 200, 100, 300, 20),
(16, 'Power Bank Xiaomi 10,000mAh', 'Batterie portable durable', 'Accessoires', 250, 90, 200, 15),
(17, 'Processeur Intel i3', 'Entrée de gamme pour PC', 'Composants', 1000, 20, 50, 5),
(18, 'Carte SD 64GB SanDisk', 'Stockage compact et rapide', 'Stockage', 130, 150, 400, 30),
(19, 'Enceinte JBL Go', 'Enceinte Bluetooth portable', 'Audio', 400, 80, 200, 10),
(20, 'Câble HDMI 2.0', 'Câble pour TV et consoles', 'Accessoires', 100, 100, 300, 20);

CREATE TABLE Personne (
    id INT IDENTITY(1,1) PRIMARY KEY,  
    nom VARCHAR(100) NOT NULL,
    adresse VARCHAR(255),
    telephone VARCHAR(15),
    email VARCHAR(100),
    type VARCHAR(20) NOT NULL CHECK (type IN ('fournisseur', 'client'))
);


INSERT INTO Personne (nom, adresse, telephone, email, type)
VALUES 
('Alice Dupont', '123 Rue de Paris, 75001 Paris', '0123456789', 'alice.dupont@email.com', 'client'),
('Bob Martin', '456 Avenue des Champs-Élysées, 75008 Paris', '0987654321', 'bob.martin@email.com', 'client'),
('Claire Leclerc', '789 Boulevard Saint-Germain, 75005 Paris', '0147258369', 'claire.leclerc@email.com', 'client');


INSERT INTO Personne (nom, adresse, telephone, email, type)
VALUES 
('Fournisseur A', '12 Rue de la Logistique, 69001 Lyon', '0203040506', 'contact@fournisseura.com', 'fournisseur'),
('Fournisseur B', '34 Rue des Industriels, 33000 Bordeaux', '0321567890', 'info@fournisseurb.com', 'fournisseur'),
('Fournisseur C', '56 Boulevard des Commerces, 13001 Marseille', '0478923456', 'service@fournisseure.com', 'fournisseur');

select * from Personne;

create table Factures (
    id INT IDENTITY(1,1) PRIMARY KEY,
    date_facture DATE NOT NULL,
    id_personne INT NOT NULL,
    FOREIGN KEY (id_personne) REFERENCES Personne(id),
    statut VARCHAR(20) NOT NULL CHECK (statut IN ('payée', 'non payée'))

);