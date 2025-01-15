using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Gestion_de_stock
{
    public partial class FournisseurForm : Form
    {
        private readonly string connectionString = @"Data Source=Houssam7\SQLEXPRESS ;Initial Catalog=tempdb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        public FournisseurForm()
        {
            InitializeComponent();
            ChargerFournisseur();
        }

        private void ChargerFournisseur()
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    string query = "SELECT * FROM Personne WHERE type = 'fournisseur'";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connect);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des Fournisseurs : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

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
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    string query = "INSERT INTO Personne (nom, adresse, telephone, email, type) VALUES (@nom, @adresse, @telephone, @email, 'fournisseur')";
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@nom", Nom.Text);
                        cmd.Parameters.AddWithValue("@adresse", Adresse.Text);
                        cmd.Parameters.AddWithValue("@telephone", Tele.Text);
                        cmd.Parameters.AddWithValue("@email", Email.Text);

                        cmd.ExecuteNonQuery();
                        ChargerFournisseur();

                        MessageBox.Show("Fournisseur ajouté avec succès.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                string errorMessage = "Erreur: " + ex.Message;
                if (ex.InnerException != null)
                {
                    errorMessage += "\nInner Exception: " + ex.InnerException.Message;
                }
                MessageBox.Show(errorMessage + "\n" + ex.StackTrace, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FournisseurForm_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            // Vérifier si une ligne est sélectionnée dans le DataGridView
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner une personne à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Récupérer le nom de la personne sélectionnée
            string nomPersonne = dataGridView1.SelectedRows[0].Cells["nom"].Value.ToString();

            // Confirmation avant de supprimer
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer cette personne ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return; // Annuler la suppression si l'utilisateur clique sur "Non"
            }

            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    // Rechercher l'ID de la personne par son nom
                    string queryId = "SELECT id FROM Personne WHERE nom = @nom";
                    using (SqlCommand cmdId = new SqlCommand(queryId, connect))
                    {
                        cmdId.Parameters.AddWithValue("@nom", nomPersonne);

                        object resultId = cmdId.ExecuteScalar();
                        if (resultId == null)
                        {
                            MessageBox.Show("La personne avec ce nom n'a pas été trouvée.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            return;
                        }

                        // Récupérer l'ID
                        int idPersonne = Convert.ToInt32(resultId);

                        // Supprimer la personne avec l'ID récupéré
                        string queryDelete = "DELETE FROM Personne WHERE id = @id";
                        using (SqlCommand cmdDelete = new SqlCommand(queryDelete, connect))
                        {
                            cmdDelete.Parameters.AddWithValue("@id", idPersonne);
                            cmdDelete.ExecuteNonQuery();

                            // Recharger les données dans le DataGridView (optionnel)
                            ChargerFournisseur();

                            MessageBox.Show("Personne supprimée avec succès.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    string query = "UPDATE Personne SET nom = @nom, adresse = @adresse, telephone = @telephone, email = @email WHERE id = @id";
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        // Ajouter les paramètres à la commande
                        cmd.Parameters.AddWithValue("@nom", Nom.Text);
                        cmd.Parameters.AddWithValue("@adresse", Adresse.Text);
                        cmd.Parameters.AddWithValue("@telephone", Tele.Text);
                        cmd.Parameters.AddWithValue("@email", Email.Text);
                        cmd.Parameters.AddWithValue("@id", idPersonne);

                        // Exécuter la commande pour mettre à jour les données
                        cmd.ExecuteNonQuery();

                        // Recharger les données dans le DataGridView (optionnel)
                        ChargerFournisseur();

                        MessageBox.Show("Informations mises à jour avec succès.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
