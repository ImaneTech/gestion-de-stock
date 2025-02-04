CREATE TABLE users(
    id INT IDENTITY(1,1) PRIMARY KEY,
    username VARCHAR(255) NOT NULL,
    mail VARCHAR(255) NOT NULL,
    password VARCHAR(255) NOT NULL
);

SELECT * FROM users ;



CREATE TABLE Produit (
    id INT IDENTITY (1,1) PRIMARY KEY ,
    nom VARCHAR(255),
    description TEXT,
    categorie VARCHAR(255),
    prix_unitaire DECIMAL(10, 2),
    qte_stock INT DEFAULT 0,
    qte_stock_max INT,
    qte_stock_min INT
);


INSERT INTO Produit(nom, description, categorie, prix_unitaire, qte_stock, qte_stock_max, qte_stock_min) VALUES
('Smartphone Samsung A12', 'Téléphone abordable et performant', 'Smartphones', 2000, 100, 300, 20),
('Laptop HP 15', 'PC portable pour bureautique', 'Ordinateurs', 5000, 50, 150, 10),
('TV LED 32"', 'Téléviseur compact et HD', 'Téléviseurs', 2500, 30, 80, 5),
('Écouteurs Xiaomi', 'Écouteurs sans fil simples', 'Accessoires', 300, 200, 500, 50),
('Clavier Logitech K120', 'Clavier USB basique', 'Périphériques', 200, 150, 400, 30),
('Souris Logitech M185', 'Souris sans fil compacte', 'Périphériques', 150, 180, 400, 30),
('Tablette Lenovo M10', 'Tablette pour enfants et famille', 'Tablettes', 1800, 40, 100, 10),
('Montre Connectée Amazfit', 'Suivi santé et fitness', 'Montres Connectées', 700, 70, 200, 15),
('Imprimante Canon LBP6030', 'Imprimante laser compacte', 'Imprimantes', 1000, 20, 50, 5),
('Disque Dur WD 1TB', 'Stockage fiable et rapide', 'Stockage', 600, 120, 300, 20),
('Barre de Son Sony', 'Son clair et compact', 'Audio', 1500, 25, 60, 5),
('Caméra IP TP-Link', 'Surveillance simple et efficace', 'Sécurité', 500, 50, 150, 10);

select * from Produit;
-- quantité de stock < qte_stock_min
INSERT INTO Produit(nom, description, categorie, prix_unitaire, qte_stock, qte_stock_max, qte_stock_min) VALUES
( 'Clavier Mécanique RGB', 'Clavier gaming avec rétroéclairage', 'Périphériques', 800, 8, 50, 10),
('Souris Gaming RGB', 'Souris haute précision pour gamers', 'Périphériques', 600, 4, 30, 5),
('Disque Dur Externe 2To', 'Stockage portable USB 3.0', 'Stockage', 1200, 2, 20, 3),
('Casque Audio Sony WH-1000XM4', 'Casque sans fil avec réduction de bruit', 'Audio', 3000, 3, 15, 5),
('Écran 27" 4K', 'Écran haute résolution pour professionnels', 'Moniteurs', 5000, 4, 10, 5),
('Batterie Externe 20,000mAh', 'Batterie portable haute capacité', 'Accessoires', 400, 10, 50, 15),
('Carte Graphique NVIDIA RTX 3060', 'Carte graphique pour gaming', 'Composants', 7000, 2, 10, 3),
('Imprimante HP LaserJet', 'Imprimante laser professionnelle', 'Imprimantes', 2500, 3, 10, 5),
('Routeur Wi-Fi 6', 'Routeur haute vitesse pour gaming', 'Réseaux', 1500, 4, 15, 5),
('Tablette Graphique Wacom', 'Tablette pour dessin numérique', 'Périphériques', 2000, 2, 10, 3);

CREATE TABLE Personne(
    id INT IDENTITY(1,1) PRIMARY KEY,  
    nom VARCHAR(100) NOT NULL,
    adresse VARCHAR(255),
    telephone VARCHAR(15),
    email VARCHAR(100),
    type VARCHAR(20) NOT NULL CHECK (type IN ('fournisseur', 'client'))
);
select * from Personne;

INSERT INTO Personne(nom, adresse, telephone, email, type)
VALUES 
('Alice Dupont', '123 Rue de Paris, 75001 Paris', '0123456789', 'alice.dupont@email.com', 'client'),
('Bob Martin', '456 Avenue des Champs-Élysées, 75008 Paris', '0987654321', 'bob.martin@email.com', 'client'),
('Claire Leclerc', '789 Boulevard Saint-Germain, 75005 Paris', '0147258369', 'claire.leclerc@email.com', 'client');


INSERT INTO Personne(nom, adresse, telephone, email, type)
VALUES 
('Fournisseur A', '12 Rue de la Logistique, 69001 Lyon', '0203040506', 'contact@fournisseura.com', 'fournisseur'),
('Fournisseur B', '34 Rue des Industriels, 33000 Bordeaux', '0321567890', 'info@fournisseurb.com', 'fournisseur'),
('Fournisseur C', '56 Boulevard des Commerces, 13001 Marseille', '0478923456', 'service@fournisseure.com', 'fournisseur');

CREATE TABLE Operation (
    id_Operation INT IDENTITY(1,1) PRIMARY KEY,
    type VARCHAR(25) CHECK (type IN ('vente', 'achat')),
    id_personne INT NOT NULL,
    date_operation DATETIME DEFAULT GETDATE(),
   montant_total DECIMAL(18,2) NOT NULL CHECK (montant_total > 0),
    CONSTRAINT FK_Operation_Personne FOREIGN KEY (id_personne) 
        REFERENCES Personne(id) ON DELETE CASCADE
);
select * from Operation;

CREATE TABLE LigneOperation (
    id_Operation INT NOT NULL,
    id_produit INT NOT NULL,
    quantite INT NOT NULL CHECK (quantite > 0), -- Vérification que la quantité est positive
    prix_total DECIMAL(10, 2) CHECK (prix_total >= 0),
    PRIMARY KEY (id_Operation, id_produit),
    CONSTRAINT FK_LigneOperation_Operation FOREIGN KEY (id_Operation) 
        REFERENCES Operation(id_Operation) ON DELETE CASCADE,
    CONSTRAINT FK_LigneOperation_Produit FOREIGN KEY (id_produit) 
        REFERENCES Produit(id) ON DELETE CASCADE

);
select * from LigneOperation;

 INSERT INTO Operation (type, id_personne, date_operation) VALUES
('achat', 1, DEFAULT),  
('achat', 2, DEFAULT),  
('vente', 4, DEFAULT),  
('achat', 3, DEFAULT),  
('vente', 5, DEFAULT);  

INSERT INTO LigneOperation (id_Operation, id_produit, quantite, prix_total) VALUES
(1, 1, 2, 4000.00),  
(2, 5, 3, 600.00),   
(3, 2, 1, 5000.00),
(4, 8, 1, 700.00),  
(5, 10, 3, 1800.00); 


-- Table Factures

create table Factures (
    id INT IDENTITY(1,1) PRIMARY KEY,
    date_facture DATE NOT NULL,
    id_personne INT NOT NULL,
    FOREIGN KEY (id_personne) REFERENCES Personne(id),
    statut VARCHAR(20) NOT NULL CHECK (statut IN ('payée', 'non payée')),
     type VARCHAR(20) NOT NULL CHECK (type IN ('achat', 'vente'))
);
ALTER TABLE Factures 
ADD montant DECIMAL(15, 2) NOT NULL CHECK (montant > 0);

DELETE FROM Factures
WHERE montant = 0 OR montant IS NULL;

INSERT INTO Factures (date_facture, id_personne, statut, type, montant) VALUES
('2023-12-05', 1, 'payée', 'achat', 1000.00),
('2023-12-10', 1, 'non payée', 'vente', 2500.00), -- Bénéfice = 1500
('2024-01-05', 2, 'non payée', 'achat', 3000.00),
('2024-01-10', 2, 'payée', 'vente', 2000.00), -- Bénéfice = -1000
('2024-02-05', 3, 'payée', 'achat', 1500.00),
('2024-02-10', 3, 'payée', 'vente', 1500.00),
('2024-03-05', 4, 'payée', 'achat', 500.00),
('2024-03-10', 4, 'payée', 'vente', 1000.00), -- Bénéfice = 500 (positif)
('2024-04-05', 5, 'payée', 'achat', 2000.00),
('2024-04-10', 5, 'payée', 'vente', 500.00); -- Bénéfice = -1500 (négatif)

select * from Factures;



-- Créer la table Rapport_Mensuel :
CREATE TABLE Rapport_Mensuel (
    id INT PRIMARY KEY IDENTITY(1,1),   -- Identifiant unique, incrémenté automatiquement
   mois_annee VARCHAR(7) NOT NULL,                 -- Date, obligatoire pour chaque enregistrement
    recettes DECIMAL(15, 2) NOT NULL,   -- Recettes, avec précision pour les valeurs monétaires
    depenses DECIMAL(15, 2) NOT NULL,   -- Dépenses, avec précision pour les valeurs monétaires
    benefices AS (recettes - depenses) PERSISTED  -- Calcul automatique des bénéfices
);



select * from Rapport_Mensuel;


select lo.id_Operation,o.id_personne,lo.id_produit,p.nom,lo.quantite,lo.prix_total from LigneOperation lo
join Operation o on lo.id_Operation = o.id_Operation
join Produit p on lo.id_produit = p.id
where o.type = 'COMMANDE';



