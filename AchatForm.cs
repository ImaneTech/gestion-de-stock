using Microsoft.Data.SqlClient;
using System;
using System.Data;
using System.Windows.Forms;

namespace Gestion_de_stock
{
    public partial class AchatForm : Form
    {
        private SqlCommand cmd;
        private SqlDataReader dr;
        private BindingSource bindingSource;
       
        public AchatForm()
        {
            InitializeComponent();
            bindingSource = new BindingSource();
            dataGridView1.DataSource = bindingSource;
            GetAchat();
            initFormulaireAchat();
            ChargerAchat();
        }

        public void initFormulaireAchat()
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

        public void ChargerAchat()
        {
            try
            {

                using (SqlConnection connect = new SqlConnection(DatabaseConfig.GetConnectionString()))
                {
                    connect.Open();
                    string query = "SELECT * FROM Operation WHERE type = 'achat'";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connect);

                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);

                    bindingSource.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des Achats : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void GetAchat()
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
                                      "WHERE o.type = 'COMMANDE'";

                    dr = cmd.ExecuteReader();
                    DataTable dataTable = new DataTable();
                    dataTable.Columns.Add("Id Operation");
                    dataTable.Columns.Add("Id Fournisseur");
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

        // Confirmer Achat
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
                    int qte_stock_max = 0;
                    using (SqlCommand cmd = new SqlCommand("SELECT qte_stock, qte_stock_max FROM Produit WHERE id = @id_produit", connect))
                    {
                        cmd.Parameters.AddWithValue("@id_produit", id_produit);
                        using (SqlDataReader dr = cmd.ExecuteReader())
                        {
                            if (dr.Read())
                            {
                                qte_stock = dr.GetInt32(0);
                                qte_stock_max = dr.GetInt32(1);
                            }
                        }
                    }

                    if (qte_stock + quantite > qte_stock_max)
                    {
                        MessageBox.Show("Le stock dépasse la limite maximale.");
                        return;
                    }

                    // Insertion de l'opération
                    using (SqlCommand cmd = new SqlCommand("INSERT INTO Operation (type, id_personne, id_produit, quantite) VALUES ('achat', @id_personne, @id_produit, @quantite)", connect))
                    {
                        cmd.Parameters.AddWithValue("@id_personne", id_personne);
                        cmd.Parameters.AddWithValue("@id_produit", id_produit);
                        cmd.Parameters.AddWithValue("@quantite", quantite);
                        cmd.ExecuteNonQuery();
                        ChargerAchat(); // Refresh the DataGridView using the BindingSource
                    }

                    // Mise à jour du stock du produit
                    using (SqlCommand cmd = new SqlCommand("UPDATE Produit SET qte_stock = qte_stock + @quantite WHERE id = @id_produit", connect))
                    {
                        cmd.Parameters.AddWithValue("@quantite", quantite);
                        cmd.Parameters.AddWithValue("@id_produit", id_produit);
                        cmd.ExecuteNonQuery();
                    }
                }

                MessageBox.Show("Achat ajouté avec succès !");
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void AchatForm_Load(object sender, EventArgs e)
        {

        }
    }
}
