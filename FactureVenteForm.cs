using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;

namespace Gestion_de_stock
{

    public partial class FactureVenteForm : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable factureTable;
        public FactureVenteForm()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            LoadFactures();
            initialiser_combobox();
        }

        private void InitializeDatabaseConnection()
        {
            string connectionString = @"Data Source =DESKTOP-7P14TAD\SQLEXPRESS; Initial Catalog = tempdb; Integrated Security = True; Encrypt = True; Trust Server Certificate = True";

            connection = new SqlConnection(connectionString);
        }



        public void initialiser_combobox()
        {
            try
            {
              
                string connectionString = "Data Source=DESKTOP-7P14TAD\\SQLEXPRESS;Initial Catalog=tempdb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";

   
                string query = "SELECT id FROM Personne where type='client'";

              
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand(query, connection))
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        comboBox1.Items.Clear();

                        // Parcourir les résultats et ajouter les id à la ComboBox
                        while (dr.Read())
                        {
                            comboBox1.Items.Add(dr["id"].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Gestion des erreurs
                MessageBox.Show("Erreur lors du chargement des id : " + ex.Message);
            }
        }
        

        private void LoadFactures()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-7P14TAD\\SQLEXPRESS;Initial Catalog=tempdb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"))
                {
                    connection.Open();
                    string query = "SELECT * FROM Factures where type='vente'";
                    adapter = new SqlDataAdapter(query, connection);
                    factureTable = new DataTable();
                    adapter.Fill(factureTable);
                    dataGridView1.DataSource = factureTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error loading factures: {ex.Message}");
            }
           
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {

          
            try
            {
              
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-7P14TAD\\SQLEXPRESS;Initial Catalog=tempdb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"))
                {
                    connection.Open(); 
                    int id_personne = Convert.ToInt32(comboBox1.SelectedItem);
                    string query = "INSERT INTO Factures (date_facture, id_personne, statut,type) VALUES (@date_facture, @id_personne, @statut,@type)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@date_facture", dateTimePicker1.Value);
                        command.Parameters.AddWithValue("@id_personne", id_personne);
                        command.Parameters.AddWithValue("@statut", checkPAYEE.Checked ? "payée" : "non payée");
                        command.Parameters.AddWithValue("@type", "vente");

                        command.ExecuteNonQuery();
                    }
                    LoadFactures();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding facture: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }

        /*
        private void button2_Click(object sender, EventArgs e)
        {

            try
            {
                connection.Open();
                string query = "DELETE FROM Factures WHERE id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id_personne", comboBox1.SelectedValue);
                    command.ExecuteNonQuery();
                }
                LoadFactures();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error deleting facture: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }
        
        private void buttonModifier_Click(object sender, EventArgs e)
        {

            try
            {
                connection.Open();
                string query = "UPDATE Factures SET date_facture = @date_facture, id_personne = @id_personne, statut = @statut WHERE id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@date_facture", dateTimePicker1.Value);
                    command.Parameters.AddWithValue("@id_personne", comboBox1.SelectedValue);
                    command.Parameters.AddWithValue("@statut", checkPAYEE.Checked ? "payée" : "non payée");

                    command.ExecuteNonQuery();
                }
                LoadFactures();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating facture: {ex.Message}");
            }
            finally
            {
                connection.Close();
            }
        }
        */

        private void buttonQuitter_Click(object sender, EventArgs e)
        {

            comboBox1.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
            checkPAYEE.Checked = false;
        }

        private void IDPERSONNE_Click(object sender, EventArgs e)
        {

        }

        private void DATEFACTURE_Click(object sender, EventArgs e)
        {

        }

        private void STATU_Click(object sender, EventArgs e)
        {

        }

        private void textIDFACTURE_TextChanged(object sender, EventArgs e)
        {

        }

        private void textIDPERSONNE_TextChanged(object sender, EventArgs e)
        {

        }

        private void checkPAYEE_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void checkNONPAYEE_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FactureVenteForm_Load(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
