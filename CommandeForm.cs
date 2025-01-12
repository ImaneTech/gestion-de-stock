using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Gestion_de_stock
{
    public partial class CommandeForm : Form
    {
        private readonly string connectionString = @"Data Source=DESKTOP-10A38RQ\SQLEXPRESS;Initial Catalog=master;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        public CommandeForm()
        {
            InitializeComponent();
            ChargerCOMMANDE();
        }

        private void ChargerCOMMANDE()
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    string query = "SELECT * FROM Operations WHERE type = 'vente'";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connect);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur lors du chargement des commandes : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
       
            id_personne.Clear();
            id_produit.Clear();
            quantite.Clear();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(id_personne.Text) || string.IsNullOrEmpty(id_produit.Text) || string.IsNullOrEmpty(quantite.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    string query = "INSERT INTO Operations (id_personne, id_produit, quantite, type) VALUES (@id_personne, @id_produit, @quantite, 'COMMANDE')";
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@id_personne", id_personne.Text);
                        cmd.Parameters.AddWithValue("@id_produit", id_produit.Text);
                        cmd.Parameters.AddWithValue("@quantite", quantite.Text);

                        cmd.ExecuteNonQuery();
                        ChargerCOMMANDE();

                        MessageBox.Show("Commande ajoutée avec succès.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erreur : {ex.Message}", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Add logic if required, else leave empty.
        }
    }
}

