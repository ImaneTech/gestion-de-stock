using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Gestion_de_stock
{
    public partial class ProduitForm : Form
    {
        private readonly string connectionString = @"Data Source=SERVER_NAME;Initial Catalog=master;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        public ProduitForm()
        {
            InitializeComponent();
            ChargerProduits();
        }

        private void ChargerProduits()
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    string query = "SELECT * FROM Produit";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connect);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des produits : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtNom.Text) || string.IsNullOrEmpty(txtDescription.Text) || comboBox1.SelectedItem == null || string.IsNullOrEmpty(txtPrix.Text) || string.IsNullOrEmpty(txtQteStock.Text) || string.IsNullOrEmpty(txtQteMax.Text) || string.IsNullOrEmpty(txtQteMin.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    string query = "INSERT INTO Produit (id, nom, description, categorie, prix_unitaire, qte_stock, qte_stock_max, qte_stock_min) VALUES (@id, @nom, @description, @categorie, @prix, @qteStock, @qteMax, @qteMin)";
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@id", txtId.Text);
                        cmd.Parameters.AddWithValue("@nom", txtNom.Text);
                        cmd.Parameters.AddWithValue("@description", txtDescription.Text);
                        cmd.Parameters.AddWithValue("@categorie",comboBox1.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@prix", Convert.ToDecimal(txtPrix.Text));
                        cmd.Parameters.AddWithValue("@qteStock", Convert.ToInt32(txtQteStock.Text));
                        cmd.Parameters.AddWithValue("@qteMax", Convert.ToInt32(txtQteMax.Text));
                        cmd.Parameters.AddWithValue("@qteMin", Convert.ToInt32(txtQteMin.Text));

                        cmd.ExecuteNonQuery();
                        ChargerProduits();
                        MessageBox.Show("Produit ajouté avec succès.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        //confirmation
        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Veuillez entrer l'ID du produit à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir supprimer ce produit ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return; // Annuler la suppression si l'utilisateur clique sur "Non"
            }

            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    string query = "DELETE FROM Produit WHERE id = @id";
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@id", txtId.Text);
                        cmd.ExecuteNonQuery();
                        ChargerProduits();
                        MessageBox.Show("Produit supprimé avec succès.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtId.Clear();
            txtNom.Clear();
            txtDescription.Clear();
            comboBox1.SelectedIndex = -1;
            txtPrix.Clear();
            txtQteStock.Clear();
            txtQteMax.Clear();
            txtQteMin.Clear();
        }

    
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void ProduitForm_Load(object sender, EventArgs e) {
        
        
        }
        private void button4_Click(object sender, EventArgs e) {
            //mettre à jour

            // Verifie si l'ID du produit a mettre a jour est vide
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Veuillez entrer l'ID du produit à mettre à jour.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Verifie que tous les champs obligatoires sont remplis
            if (string.IsNullOrEmpty(txtNom.Text) || string.IsNullOrEmpty(txtDescription.Text) || comboBox1.SelectedItem == null || string.IsNullOrEmpty(txtPrix.Text) || string.IsNullOrEmpty(txtQteStock.Text) || string.IsNullOrEmpty(txtQteMax.Text) || string.IsNullOrEmpty(txtQteMin.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            // Confirmation 
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir mettre à jour ce produit ?", "Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (result == DialogResult.No)
            {
                return; // Annule la mise a jour si l'utilisateur clique sur "Non"
            }

            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    // Requete SQL pour mettre a jour un produit en fonction de son ID
                    string query = "UPDATE Produit SET nom = @nom, description = @description, categorie = @categorie, prix_unitaire = @prix, qte_stock = @qteStock, qte_stock_max = @qteMax, qte_stock_min = @qteMin WHERE id = @id";
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.CommandTimeout = 120;
                        cmd.Parameters.AddWithValue("@id", txtId.Text);
                        cmd.Parameters.AddWithValue("@nom", txtNom.Text);
                        cmd.Parameters.AddWithValue("@description", txtDescription.Text);
                        cmd.Parameters.AddWithValue("@categorie", comboBox1.SelectedItem.ToString());
                        cmd.Parameters.AddWithValue("@prix", Convert.ToDecimal(txtPrix.Text));
                        cmd.Parameters.AddWithValue("@qteStock", Convert.ToInt32(txtQteStock.Text));
                        cmd.Parameters.AddWithValue("@qteMax", Convert.ToInt32(txtQteMax.Text));
                        cmd.Parameters.AddWithValue("@qteMin", Convert.ToInt32(txtQteMin.Text));

                   
                        int rowsAffected = cmd.ExecuteNonQuery();

                        // verifie si la mise à jour a reussi
                        if (rowsAffected > 0)
                        {
                            // Recharge la liste des produits apres la mise a jour
                            ChargerProduits();
                            MessageBox.Show("Produit mis à jour avec succès.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else
                        {
                            MessageBox.Show("Aucun produit trouvé avec cet ID.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Affiche un message d'erreur en cas d'exception
                MessageBox.Show("Erreur: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void panel4_Paint(object sender, PaintEventArgs e) { }
        private void panel5_Paint(object sender, PaintEventArgs e) { }
        private void panel6_Paint(object sender, PaintEventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void button5_Click(object sender, EventArgs e) {

        //chercher

            // Verifie si le champ de recherche est vide
            if (string.IsNullOrEmpty(txtNom.Text))
            {
                MessageBox.Show("Veuillez entrer un nom de produit à rechercher.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
               
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();
                    //  rechercher un produit par son nom
                    // on a utiliser ici  LIKE pour  faire une recherche partielle
                    string query = "SELECT * FROM Produit WHERE nom LIKE @nom";
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    { 
                        cmd.Parameters.AddWithValue("@nom", "%" + txtNom.Text + "%");

                        
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Affiche les resultats dans le DataGridView
                        dataGridView1.DataSource = dataTable;

                        // Verifie si on a trouver des produits ou non
                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("Aucun produit trouvé avec ce nom.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Affiche un message d'erreur en cas d'exception
                MessageBox.Show("Erreur: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        
        
        private void textBox1_TextChanged(object sender, EventArgs e) { }
        private void label10_Click(object sender, EventArgs e) { }
        private void label9_Click(object sender, EventArgs e) { }
        private void label7_Click(object sender, EventArgs e) { }
        private void label9_Click_1(object sender, EventArgs e) { }
        private void label11_Click(object sender, EventArgs e) { }
        private void textBox4_TextChanged(object sender, EventArgs e) { }
        private void label12_Click(object sender, EventArgs e) { }
    }
}
