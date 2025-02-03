using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Gestion_de_stock
{
    public partial class AchatForm : Form
    {
        private BindingSource bindingSource;
        private DataTable panier;

        public AchatForm()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            dataGridView1.DataSource = bindingSource;
            panier = new DataTable();
            panier.Columns.Add("Id Produit");
            panier.Columns.Add("Quantite");
            panier.Columns.Add("Prix Total");
            initFormulaireAchat();
            ChargerAchat();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;

        }

        private void initFormulaireAchat()
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(DatabaseConfig.GetConnectionString()))
                {
                    connect.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT id FROM Personne WHERE type = 'fournisseur'", connect))
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                            comboBox1.Items.Add(dr[0].ToString());
                    }
                    using (SqlCommand cmd = new SqlCommand("SELECT id FROM Produit", connect))
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                            comboBox2.Items.Add(dr[0].ToString());
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox2.SelectedItem == null || string.IsNullOrWhiteSpace(textBox1.Text))
                {
                    MessageBox.Show("Sélectionnez un produit et entrez une quantité.");
                    return;
                }

                int id_produit = Convert.ToInt32(comboBox2.SelectedItem);
                int quantite = Convert.ToInt32(textBox1.Text);

                using (SqlConnection connect = new SqlConnection(DatabaseConfig.GetConnectionString()))
                {
                    connect.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT prix_unitaire FROM Produit WHERE id = @id_produit", connect))
                    {
                        cmd.Parameters.AddWithValue("@id_produit", id_produit);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                decimal prix_unitaire = (decimal)reader["prix_unitaire"];
                                decimal prix_total = prix_unitaire * quantite;
                                panier.Rows.Add(id_produit, quantite, prix_total);
                                dataGridView2.DataSource = panier;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem == null || panier.Rows.Count == 0)
                {
                    MessageBox.Show("Sélectionnez un fournisseur et ajoutez un produit au panier.");
                    return;
                }

                int id_personne = Convert.ToInt32(comboBox1.SelectedItem);

                using (SqlConnection connect = new SqlConnection(DatabaseConfig.GetConnectionString()))
                {
                    connect.Open();
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Operation (type, id_personne, date_operation) VALUES ('achat', @id_personne, GETDATE()); SELECT SCOPE_IDENTITY();", connect))
                    {
                        cmd.Parameters.AddWithValue("@id_personne", id_personne);
                        int lastOperationId = Convert.ToInt32(cmd.ExecuteScalar());

                        foreach (DataRow row in panier.Rows)
                        {
                            int id_produit = Convert.ToInt32(row["Id Produit"]);
                            int quantite = Convert.ToInt32(row["Quantite"]);
                            decimal prix_total = Convert.ToDecimal(row["Prix Total"]);

                            using (SqlCommand cmd2 = new SqlCommand("INSERT INTO LigneOperation (id_Operation, id_produit, quantite, prix_total) VALUES (@id_Operation, @id_produit, @quantite, @prix_total)", connect))
                            {
                                cmd2.Parameters.AddWithValue("@id_Operation", lastOperationId);
                                cmd2.Parameters.AddWithValue("@id_produit", id_produit);
                                cmd2.Parameters.AddWithValue("@quantite", quantite);
                                cmd2.Parameters.AddWithValue("@prix_total", prix_total);
                                cmd2.ExecuteNonQuery();
                            }

                            using (SqlCommand cmd3 = new SqlCommand("UPDATE Produit SET qte_stock = qte_stock + @quantite WHERE id = @id_produit", connect))
                            {
                                cmd3.Parameters.AddWithValue("@quantite", quantite);
                                cmd3.Parameters.AddWithValue("@id_produit", id_produit);
                                cmd3.ExecuteNonQuery();
                            }
                        }
                    }
                }
                MessageBox.Show("Achat confirmé avec succès !");
                panier.Rows.Clear();
                dataGridView2.DataSource = null;
                ChargerAchat();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panier.Rows.Clear();
            dataGridView2.DataSource = null;
        }

        private void ChargerAchat()
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(DatabaseConfig.GetConnectionString()))
                {
                    connect.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Operation WHERE type = 'achat'", connect);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    bindingSource.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des achats : " + ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            textBox1.Clear();
        }
    }
}
