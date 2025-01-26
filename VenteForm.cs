using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Gestion_de_stock
{
    public partial class VenteForm : Form
    {
        private SqlCommand cmd;
        private SqlDataReader dr;
        private BindingSource bindingSource;

        public VenteForm()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            dataGridView1.DataSource = bindingSource;
            GetVente();
            initFormulaireVente();
            ChargerVente();
        }

        public void initFormulaireVente()
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(DatabaseConfig.GetConnectionString()))
                {
                    connect.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT id FROM Personne WHERE type = 'client'", connect))
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            comboBox1.Items.Add(dr[0].ToString());
                        }
                    }

                    using (SqlCommand cmd = new SqlCommand("SELECT id FROM Produit", connect))
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            comboBox2.Items.Add(dr[0].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        public void ChargerVente()
        {
            try
            {

                using (SqlConnection connect = new SqlConnection(DatabaseConfig.GetConnectionString()))
                {
                    connect.Open();
                    string query = "SELECT * FROM Operation WHERE type = 'vente'";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connect);

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    bindingSource.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des Ventes : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GetVente()
        {
            try
            {

                using (SqlConnection connect = new SqlConnection(DatabaseConfig.GetConnectionString()))
                {
                    connect.Open();
                    cmd = connect.CreateCommand();
                    cmd.CommandText = "SELECT lo.id_Operation, o.id_personne, lo.id_produit, lo.quantite, lo.prix_total " +
                                      "FROM LigneOperation lo " +
                                      "JOIN Operation o ON lo.id_Operation = o.id_Operation " +
                                      "JOIN Produit p ON lo.id_produit = p.id " +
                                      "WHERE o.type = 'vente'";

                    dr = cmd.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("Id Operation");
                    dataTable.Columns.Add("Id Client");
                    dataTable.Columns.Add("Produit");
                    dataTable.Columns.Add("Quantite");
                    dataTable.Columns.Add("Total Prix(Dh)");

                    while (dr.Read())
                    {
                        dataTable.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
                    }

                    bindingSource.DataSource = dataTable;
                    dr.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Confirmer Vente
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                int id_personne = Convert.ToInt32(comboBox1.SelectedItem);
                int id_produit = Convert.ToInt32(comboBox2.SelectedItem);
                int quantite = Convert.ToInt32(textBox1.Text);


                using (SqlConnection connect = new SqlConnection(DatabaseConfig.GetConnectionString()))
                {
                    connect.Open();

                    // Vérification du stock
                    int qte_stock = 0;
                    using (SqlCommand cmd = new SqlCommand("SELECT qte_stock FROM Produit WHERE id = @id_produit", connect))
                    {
                        cmd.Parameters.AddWithValue("@id_produit", id_produit);
                        qte_stock = (int)cmd.ExecuteScalar(); // Executer la requête
                    }

                    if (qte_stock < quantite)
                    {
                        MessageBox.Show("Le stock est insuffisant pour cette vente.");
                        return;
                    }

                    // Insertion de l'opération
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Operation (type, id_personne, id_produit, quantite) VALUES ('vente', @id_personne, @id_produit, @quantite)", connect))
                    {
                        cmd.Parameters.AddWithValue("@id_personne", id_personne);
                        cmd.Parameters.AddWithValue("@id_produit", id_produit);
                        cmd.Parameters.AddWithValue("@quantite", quantite);
                        cmd.ExecuteNonQuery();
                        ChargerVente(); // Refresh the DataGridView using the BindingSource
                    }

                    // Mise à jour du stock du produit
                    using (SqlCommand cmd = new SqlCommand("UPDATE Produit SET qte_stock = qte_stock - @quantite WHERE id = @id_produit", connect))
                    {
                        cmd.Parameters.AddWithValue("@quantite", quantite);
                        cmd.Parameters.AddWithValue("@id_produit", id_produit);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Vente ajoutée avec succès !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        // Effacer les champs du formulaire
        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            textBox1.Clear();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void VenteForm_Load(object sender, EventArgs e)
        {
            // Empty method
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Empty method
        }

        private void label1_Click(object sender, EventArgs e)
        {
            // Empty method
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {
            // Empty method
        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            // Empty method
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Empty method
        }
    }
}
