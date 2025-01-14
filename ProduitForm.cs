using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Gestion_de_stock
{
    public partial class ProduitForm : Form
    {
        private readonly string connectionString = @"Data Source=server ;Initial Catalog=master;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

        public ProduitForm()
        {
            InitializeComponent();
            ChargerProduits();
            dataGridView1.SelectionChanged += dataGridView1_SelectionChanged;
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

        //bouton ajouter
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
                        cmd.Parameters.AddWithValue("@categorie", comboBox1.SelectedItem.ToString());
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

        //bouton supprimer
        private void button2_Click(object sender, EventArgs e)
        {
            // Verifier si une ligne est selectionnee dans le DataGridView
            if (dataGridView1.SelectedRows.Count == 0)
            {
                MessageBox.Show("Veuillez sélectionner un produit à supprimer.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Recuperer l'ID du produit selectionne
            int idProduit = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);

            // confirmation avant de supprimer
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
                        cmd.Parameters.AddWithValue("@id", idProduit);
                        cmd.ExecuteNonQuery();

                        // Recharger les produits dans le DataGridView
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
            // Reinitialiser la liste totale des produits apres une recherche
            ChargerProduits();
        }


        // cette methode permet de remplir les champs de texte avec les données de la ligne selectionnée pour que l'utilisateur puisse modifier uniquement les champs qu'il souhaite
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                // Récupérer la ligne sélectionnée
                DataGridViewRow selectedRow = dataGridView1.SelectedRows[0];

                // Afficher les données dans les TextBox et ComboBox
                txtId.Text = selectedRow.Cells["id"].Value.ToString();
                txtNom.Text = selectedRow.Cells["nom"].Value.ToString();
                txtDescription.Text = selectedRow.Cells["description"].Value.ToString();
                comboBox1.SelectedItem = selectedRow.Cells["categorie"].Value.ToString();
                txtPrix.Text = selectedRow.Cells["prix_unitaire"].Value.ToString();
                txtQteStock.Text = selectedRow.Cells["qte_stock"].Value.ToString();
                txtQteMax.Text = selectedRow.Cells["qte_stock_max"].Value.ToString();
                txtQteMin.Text = selectedRow.Cells["qte_stock_min"].Value.ToString();
            }
        }


        private void button4_Click(object sender, EventArgs e) {
            //mettre a jour

            // Vérifier si un ID est sélectionné
            if (string.IsNullOrEmpty(txtId.Text))
            {
                MessageBox.Show("Veuillez sélectionner un produit à mettre à jour.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validation des champs
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
        private void button5_Click(object sender, EventArgs e)
        {
            //chercher
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    // Construire la requete SQL dynamiquement
                    string query = "SELECT * FROM Produit WHERE 1=1"; // 1=1 pour faciliter l'ajout de conditions

                    // Ajouter des conditions en fonction des champs remplis
                    if (!string.IsNullOrEmpty(txtNom.Text))
                    {
                        query += " AND nom LIKE @nom";
                    }
                    if (!string.IsNullOrEmpty(txtDescription.Text))
                    {
                        query += " AND description LIKE @description";
                    }
                    if (comboBox1.SelectedItem != null)
                    {
                        query += " AND categorie = @categorie";
                    }
                    if (!string.IsNullOrEmpty(txtPrix.Text))
                    {
                        query += " AND prix_unitaire = @prix";
                    }
                    if (!string.IsNullOrEmpty(txtQteStock.Text))
                    {
                        query += " AND qte_stock = @qteStock";
                    }
                    if (!string.IsNullOrEmpty(txtQteMax.Text))
                    {
                        query += " AND qte_stock_max = @qteMax";
                    }
                    if (!string.IsNullOrEmpty(txtQteMin.Text))
                    {
                        query += " AND qte_stock_min = @qteMin";
                    }

                    // Executer la requête
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    { 
                        cmd.Parameters.AddWithValue("@nom", "%" + txtNom.Text + "%");

                        
                        SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                        DataTable dataTable = new DataTable();
                        adapter.Fill(dataTable);

                        // Afficher les resultats dans le DataGridView
                        dataGridView1.DataSource = dataTable;

                 
                        if (dataTable.Rows.Count == 0)
                        {
                            MessageBox.Show("Aucun produit trouvé avec les critères spécifiés.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e) { }
        private void ProduitForm_Load(object sender, EventArgs e)
        {


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
    }
}
