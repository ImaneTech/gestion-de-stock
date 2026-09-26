namespace Gestion_de_stock
{
    public partial class ClientForm : Form
    {
        public ClientForm()
        {
            InitializeComponent();
            ChargerClients();
        }

        private void ChargerClients()
        {
            try
            {
                dataGridView1.DataSource = Db.Query("SELECT * FROM Personne WHERE type = 'client'");
            }
            catch (Exception ex)
            {
                ErrorHandler.Show(ex, "Erreur lors du chargement des clients.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Nom.Text) || string.IsNullOrEmpty(Adresse.Text) || string.IsNullOrEmpty(Tele.Text) || string.IsNullOrEmpty(Email.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                Db.Execute("INSERT INTO Personne (nom, adresse, telephone, email, type) VALUES (@nom, @adresse, @telephone, @email, 'client')",
                    ("@nom", Nom.Text), ("@adresse", Adresse.Text), ("@telephone", Tele.Text), ("@email", Email.Text));

                ChargerClients();
                MessageBox.Show("Client ajoutée avec succès.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ErrorHandler.Show(ex, "Erreur lors de l'ajout du client.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nom.Clear();
            Adresse.Clear();
            Tele.Clear();
            Email.Clear();
            Nom.Focus();
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void textBox2_TextChanged(object sender, EventArgs e) { }
        private void label5_Click(object sender, EventArgs e) { }
        private void Nom_TextChanged(object sender, EventArgs e) { }

        private void button5_Click(object sender, EventArgs e)
        {
            string rechercheNom = Nom.Text.Trim(); // 'Nom' est le nom de votre TextBox contenant le nom à rechercher

            if (string.IsNullOrEmpty(rechercheNom))
            {
                MessageBox.Show("Veuillez saisir un nom de fournisseur pour effectuer la recherche.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                dataGridView1.DataSource = Db.Query("SELECT * FROM Personne WHERE type = 'client' AND nom LIKE @nom",
                    ("@nom", "%" + rechercheNom + "%"));
            }
            catch (Exception ex)
            {
                ErrorHandler.Show(ex, "Erreur lors de la recherche.");
            }
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {


        }

        private void button4_Click(object sender, EventArgs e)
        {
            // Vérifier si une ligne est sélectionnée dans le DataGridView
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une personne à mettre à jour.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Récupérer l'ID de la personne sélectionnée
            int idPersonne = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

            // Vérification des champs de texte
            if (string.IsNullOrWhiteSpace(Nom.Text) || string.IsNullOrWhiteSpace(Adresse.Text) || string.IsNullOrWhiteSpace(Tele.Text) || string.IsNullOrWhiteSpace(Email.Text))
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Confirmation avant de mettre à jour
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir mettre à jour les informations de cette personne ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return; // Annuler la mise à jour si l'utilisateur clique sur "Non"
            }

            try
            {
                Db.Execute("UPDATE Personne SET nom = @nom, adresse = @adresse, telephone = @telephone, email = @email WHERE id = @id",
                    ("@nom", Nom.Text), ("@adresse", Adresse.Text), ("@telephone", Tele.Text), ("@email", Email.Text), ("@id", idPersonne));

                // Recharger les données dans le DataGridView (optionnel)
                ChargerClients();

                MessageBox.Show("Informations mises à jour avec succès.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ErrorHandler.Show(ex, "Erreur lors de la mise à jour du client.");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!Session.EnsureAdmin())
                return;

            // Vérifier si une ligne est sélectionnée dans le DataGridView
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une personne à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Récupérer l'ID de la personne sélectionnée (le nom n'est pas unique)
            int idPersonne = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

            // Confirmation avant de supprimer
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette personne ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return; // Annuler la suppression si l'utilisateur clique sur "Non"
            }

            try
            {
                if (Db.Execute("DELETE FROM Personne WHERE id = @id AND type = 'client'", ("@id", idPersonne)) == 0)
                {
                    MessageBox.Show("La personne sélectionnée n'a pas été trouvée.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                // Recharger les données dans le DataGridView (optionnel)
                ChargerClients();

                MessageBox.Show("Personne supprimée avec succès.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                ErrorHandler.Show(ex, "Erreur lors de la suppression du client.");
            }
        }
    }
}

