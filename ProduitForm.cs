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
            if (string.IsNullOrEmpty(txtNom.Text) || string.IsNullOrEmpty(txtDescription.Text) || string.IsNullOrEmpty(txtCategorie.Text) || string.IsNullOrEmpty(txtPrix.Text) || string.IsNullOrEmpty(txtQteStock.Text) || string.IsNullOrEmpty(txtQteMax.Text) || string.IsNullOrEmpty(txtQteMin.Text))
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
                        cmd.Parameters.AddWithValue("@categorie", txtCategorie.Text);
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

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Veuillez entrer l'ID du produit à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
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
            txtCategorie.Clear();
            txtPrix.Clear();
            txtQteStock.Clear();
            txtQteMax.Clear();
            txtQteMin.Clear();
        }

        // Other event handlers
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void ProduitForm_Load(object sender, EventArgs e) { }
        private void button4_Click(object sender, EventArgs e) { }
        private void label1_Click(object sender, EventArgs e) { }
        private void label2_Click(object sender, EventArgs e) { }
        private void label3_Click(object sender, EventArgs e) { }
        private void panel1_Paint(object sender, PaintEventArgs e) { }
        private void panel4_Paint(object sender, PaintEventArgs e) { }
        private void panel5_Paint(object sender, PaintEventArgs e) { }
        private void panel6_Paint(object sender, PaintEventArgs e) { }
        private void label6_Click(object sender, EventArgs e) { }
        private void panel2_Paint(object sender, PaintEventArgs e) { }
        private void button5_Click(object sender, EventArgs e) { }
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
