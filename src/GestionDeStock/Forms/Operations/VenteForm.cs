using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Gestion_de_stock
{
    public partial class VenteForm : Form
    {
        private BindingSource bindingSource;
        private DataTable panier;

        public VenteForm()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            dataGridView1.DataSource = bindingSource;
            panier = new DataTable();
            panier.Columns.Add("Id Produit", typeof(int));
            panier.Columns.Add("Quantite", typeof(int));
            panier.Columns.Add("Prix Total", typeof(decimal));
            ChargerVente();
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            initFormulaireVente();
        }

        private void initFormulaireVente()
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
                ErrorHandler.Show(ex, "Erreur lors du chargement des clients et des produits.");
            }
        }

        private void ChargerVente()
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(DatabaseConfig.GetConnectionString()))
                {
                    connect.Open();
                    SqlDataAdapter dataAdapter = new SqlDataAdapter("SELECT * FROM Operation WHERE type = 'vente'", connect);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    bindingSource.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.Show(ex, "Erreur lors du chargement des ventes.");
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

                if (!int.TryParse(textBox1.Text, out int quantite) || quantite <= 0)
                {
                    MessageBox.Show("La quantité doit être un nombre entier positif.");
                    return;
                }

                int id_produit = Convert.ToInt32(comboBox2.SelectedItem);

                using (SqlConnection connect = new SqlConnection(DatabaseConfig.GetConnectionString()))
                {
                    connect.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT qte_stock, prix_unitaire FROM Produit WHERE id = @id_produit", connect))
                    {
                        cmd.Parameters.AddWithValue("@id_produit", id_produit);
                        using (SqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                int qte_stock = (int)reader["qte_stock"];
                                decimal prix_unitaire = (decimal)reader["prix_unitaire"];

                                // Un produit déjà présent dans le panier est fusionné avec la nouvelle quantité
                                DataRow? ligneExistante = TrouverLignePanier(id_produit);
                                int quantiteTotale = quantite + (ligneExistante != null ? (int)ligneExistante["Quantite"] : 0);

                                if (qte_stock < quantiteTotale)
                                {
                                    MessageBox.Show("Le stock est insuffisant.");
                                    return;
                                }

                                if (ligneExistante != null)
                                {
                                    ligneExistante["Quantite"] = quantiteTotale;
                                    ligneExistante["Prix Total"] = prix_unitaire * quantiteTotale;
                                }
                                else
                                {
                                    panier.Rows.Add(id_produit, quantite, prix_unitaire * quantite);
                                }
                                dataGridView2.DataSource = panier;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.Show(ex, "Erreur lors de l'ajout du produit au panier.");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBox1.SelectedItem == null || panier.Rows.Count == 0)
                {
                    MessageBox.Show("Sélectionnez un client et ajoutez un produit au panier.");
                    return;
                }

                int id_personne = Convert.ToInt32(comboBox1.SelectedItem);
                decimal montant_total = panier.AsEnumerable().Sum(r => r.Field<decimal>("Prix Total"));

                if (montant_total <= 0)
                {
                    MessageBox.Show("Le montant total de la vente doit être supérieur à zéro.");
                    return;
                }

                using (SqlConnection connect = new SqlConnection(DatabaseConfig.GetConnectionString()))
                {
                    connect.Open();
                    // Opération, lignes et mise à jour du stock : tout est validé ou tout est annulé
                    using (SqlTransaction transaction = connect.BeginTransaction())
                    {
                        try
                        {
                            int lastOperationId;
                            using (SqlCommand cmd = new SqlCommand("INSERT INTO Operation (type, id_personne, date_operation, montant_total) VALUES ('vente', @id_personne, GETDATE(), @montant_total); SELECT SCOPE_IDENTITY();", connect, transaction))
                            {
                                cmd.Parameters.AddWithValue("@id_personne", id_personne);
                                cmd.Parameters.AddWithValue("@montant_total", montant_total);
                                lastOperationId = Convert.ToInt32(cmd.ExecuteScalar());
                            }

                            foreach (DataRow row in panier.Rows)
                            {
                                int id_produit = row.Field<int>("Id Produit");
                                int quantite = row.Field<int>("Quantite");
                                decimal prix_total = row.Field<decimal>("Prix Total");

                                // Revérifie le stock au moment de la confirmation : la mise à jour échoue si le stock est insuffisant
                                using (SqlCommand cmd3 = new SqlCommand("UPDATE Produit SET qte_stock = qte_stock - @quantite WHERE id = @id_produit AND qte_stock >= @quantite", connect, transaction))
                                {
                                    cmd3.Parameters.AddWithValue("@quantite", quantite);
                                    cmd3.Parameters.AddWithValue("@id_produit", id_produit);
                                    if (cmd3.ExecuteNonQuery() == 0)
                                    {
                                        transaction.Rollback();
                                        MessageBox.Show($"Le stock du produit {id_produit} est insuffisant. La vente a été annulée.");
                                        return;
                                    }
                                }

                                using (SqlCommand cmd2 = new SqlCommand("INSERT INTO LigneOperation (id_Operation, id_produit, quantite, prix_total) VALUES (@id_Operation, @id_produit, @quantite, @prix_total)", connect, transaction))
                                {
                                    cmd2.Parameters.AddWithValue("@id_Operation", lastOperationId);
                                    cmd2.Parameters.AddWithValue("@id_produit", id_produit);
                                    cmd2.Parameters.AddWithValue("@quantite", quantite);
                                    cmd2.Parameters.AddWithValue("@prix_total", prix_total);
                                    cmd2.ExecuteNonQuery();
                                }
                            }

                            transaction.Commit();
                        }
                        catch
                        {
                            transaction.Rollback();
                            throw;
                        }
                    }
                }
                MessageBox.Show("Vente confirmée avec succès !");
                panier.Rows.Clear();
                dataGridView2.DataSource = null;
                ChargerVente(); // Rafraîchir le DataGridView après confirmation
            }
            catch (Exception ex)
            {
                ErrorHandler.Show(ex, "Erreur lors de la confirmation de la vente. Aucune modification n'a été enregistrée.");
            }
        }

        private DataRow? TrouverLignePanier(int id_produit)
        {
            return panier.AsEnumerable().FirstOrDefault(r => r.Field<int>("Id Produit") == id_produit);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            panier.Rows.Clear();
            dataGridView2.DataSource = null;
        }

        private void VenteForm_Load(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            comboBox1.SelectedIndex = -1;
            comboBox2.SelectedIndex = -1;
            textBox1.Clear();
        }
    }
}
