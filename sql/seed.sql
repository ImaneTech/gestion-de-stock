-- =============================================================================
-- Données de démonstration pour GestionStock (à exécuter après schema.sql)
-- Ré-exécutable : les lignes déjà présentes ne sont pas dupliquées.
-- Aucun utilisateur n'est créé : le premier compte inscrit dans l'application
-- devient administrateur.
-- =============================================================================

USE GestionStock;
GO

SET NOCOUNT ON;
SET XACT_ABORT ON;
SET ANSI_NULLS ON;
SET QUOTED_IDENTIFIER ON;
BEGIN TRANSACTION;

-- -----------------------------------------------------------------------------
-- Produits (les dix derniers sont sous leur seuil minimum, pour les alertes)
-- -----------------------------------------------------------------------------
INSERT INTO Produit (nom, description, categorie, prix_unitaire, qte_stock, qte_stock_max, qte_stock_min)
SELECT v.nom, v.description, v.categorie, v.prix_unitaire, v.qte_stock, v.qte_stock_max, v.qte_stock_min
FROM (VALUES
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
    ('Caméra IP TP-Link', 'Surveillance simple et efficace', 'Sécurité', 500, 50, 150, 10),
    ('Clavier Mécanique RGB', 'Clavier gaming avec rétroéclairage', 'Périphériques', 800, 8, 50, 10),
    ('Souris Gaming RGB', 'Souris haute précision pour gamers', 'Périphériques', 600, 4, 30, 5),
    ('Disque Dur Externe 2To', 'Stockage portable USB 3.0', 'Stockage', 1200, 2, 20, 3),
    ('Casque Audio Sony WH-1000XM4', 'Casque sans fil avec réduction de bruit', 'Audio', 3000, 3, 15, 5),
    ('Écran 27" 4K', 'Écran haute résolution pour professionnels', 'Moniteurs', 5000, 4, 10, 5),
    ('Batterie Externe 20,000mAh', 'Batterie portable haute capacité', 'Accessoires', 400, 10, 50, 15),
    ('Carte Graphique NVIDIA RTX 3060', 'Carte graphique pour gaming', 'Composants', 7000, 2, 10, 3),
    ('Imprimante HP LaserJet', 'Imprimante laser professionnelle', 'Imprimantes', 2500, 3, 10, 5),
    ('Routeur Wi-Fi 6', 'Routeur haute vitesse pour gaming', 'Réseaux', 1500, 4, 15, 5),
    ('Tablette Graphique Wacom', 'Tablette pour dessin numérique', 'Périphériques', 2000, 2, 10, 3)
) AS v (nom, description, categorie, prix_unitaire, qte_stock, qte_stock_max, qte_stock_min)
WHERE NOT EXISTS (SELECT 1 FROM Produit p WHERE p.nom = v.nom);

-- -----------------------------------------------------------------------------
-- Clients et fournisseurs
-- -----------------------------------------------------------------------------
INSERT INTO Personne (nom, adresse, telephone, email, type)
SELECT v.nom, v.adresse, v.telephone, v.email, v.type
FROM (VALUES
    ('Alice Dupont', '123 Rue de Paris, 75001 Paris', '0123456789', 'alice.dupont@email.com', 'client'),
    ('Bob Martin', '456 Avenue des Champs-Élysées, 75008 Paris', '0987654321', 'bob.martin@email.com', 'client'),
    ('Claire Leclerc', '789 Boulevard Saint-Germain, 75005 Paris', '0147258369', 'claire.leclerc@email.com', 'client'),
    ('Fournisseur A', '12 Rue de la Logistique, 69001 Lyon', '0203040506', 'contact@fournisseura.com', 'fournisseur'),
    ('Fournisseur B', '34 Rue des Industriels, 33000 Bordeaux', '0321567890', 'info@fournisseurb.com', 'fournisseur'),
    ('Fournisseur C', '56 Boulevard des Commerces, 13001 Marseille', '0478923456', 'service@fournisseure.com', 'fournisseur')
) AS v (nom, adresse, telephone, email, type)
WHERE NOT EXISTS (SELECT 1 FROM Personne p WHERE p.nom = v.nom AND p.type = v.type);

-- -----------------------------------------------------------------------------
-- Historique des ventes et achats (achats auprès de fournisseurs, ventes à des clients)
-- -----------------------------------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM Operation)
BEGIN
    DECLARE @seed TABLE (n INT, type VARCHAR(25), personne VARCHAR(100), produit VARCHAR(255), quantite INT, prix_total DECIMAL(10, 2));
    INSERT INTO @seed VALUES
        (1, 'achat', 'Fournisseur A', 'Smartphone Samsung A12', 2, 4000.00),
        (2, 'achat', 'Fournisseur B', 'Clavier Logitech K120', 3, 600.00),
        (3, 'vente', 'Alice Dupont', 'Laptop HP 15', 1, 5000.00),
        (4, 'achat', 'Fournisseur C', 'Montre Connectée Amazfit', 1, 700.00),
        (5, 'vente', 'Bob Martin', 'Disque Dur WD 1TB', 3, 1800.00);

    DECLARE @operations TABLE (n INT, id_Operation INT);

    -- MERGE permet de récupérer la correspondance n -> id_Operation généré
    MERGE INTO Operation AS cible
    USING (
        SELECT s.n, s.type, pe.id AS id_personne, s.prix_total
        FROM @seed s
        JOIN Personne pe ON pe.nom = s.personne
    ) AS source
    ON 1 = 0
    WHEN NOT MATCHED THEN
        INSERT (type, id_personne, date_operation, montant_total)
        VALUES (source.type, source.id_personne, GETDATE(), source.prix_total)
    OUTPUT source.n, inserted.id_Operation INTO @operations (n, id_Operation);

    INSERT INTO LigneOperation (id_Operation, id_produit, quantite, prix_total)
    SELECT o.id_Operation, pr.id, s.quantite, s.prix_total
    FROM @seed s
    JOIN @operations o ON o.n = s.n
    JOIN Produit pr ON pr.nom = s.produit;
END;

-- -----------------------------------------------------------------------------
-- Factures (source des rapports mensuels)
-- -----------------------------------------------------------------------------
IF NOT EXISTS (SELECT 1 FROM Factures)
BEGIN
    INSERT INTO Factures (date_facture, id_personne, statut, type, montant)
    SELECT v.date_facture, pe.id, v.statut, v.type, v.montant
    FROM (VALUES
        ('2023-12-05', 'Fournisseur A', 'payée', 'achat', 1000.00),
        ('2023-12-10', 'Alice Dupont', 'non payée', 'vente', 2500.00),
        ('2024-01-05', 'Fournisseur B', 'non payée', 'achat', 3000.00),
        ('2024-01-10', 'Bob Martin', 'payée', 'vente', 2000.00),
        ('2024-02-05', 'Fournisseur C', 'payée', 'achat', 1500.00),
        ('2024-02-10', 'Claire Leclerc', 'payée', 'vente', 1500.00),
        ('2024-03-05', 'Fournisseur A', 'payée', 'achat', 500.00),
        ('2024-03-10', 'Alice Dupont', 'payée', 'vente', 1000.00),
        ('2024-04-05', 'Fournisseur B', 'payée', 'achat', 2000.00),
        ('2024-04-10', 'Bob Martin', 'payée', 'vente', 500.00)
    ) AS v (date_facture, personne, statut, type, montant)
    JOIN Personne pe ON pe.nom = v.personne;
END;

COMMIT TRANSACTION;
GO
