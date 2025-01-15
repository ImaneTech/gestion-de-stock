using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Metrics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using TestStack.White.UIItems.TreeItems;

namespace Gestion_de_stock
{
    public partial class FactureAchatForm : Form
    {
        private SqlConnection connection;
        private SqlDataAdapter adapter;
        private DataTable factureTable;
        public FactureAchatForm()
        {
            InitializeComponent();
            InitializeDatabaseConnection();
            LoadFactures();
            initialiser_combobox();

        }
        private void InitializeDatabaseConnection()
        {
            string connectionString = @"Data Source =DESKTOP-7P14TAD\SQLEXPRESS; Initial Catalog = tempdb ; Integrated Security = True; Encrypt = True; Trust Server Certificate = True";

            connection = new SqlConnection(connectionString);
        }


        public void initialiser_combobox()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-7P14TAD\\SQLEXPRESS;Initial Catalog=tempdb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"))
                {
                    connection.Open();

                    using (SqlCommand cmd = new SqlCommand("SELECT id FROM Personne WHERE type = 'fournisseur'", connection))
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            comboBox1.Items.Add(dr[0].ToString());
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void LoadFactures()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-7P14TAD\\SQLEXPRESS;Initial Catalog=tempdb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"))
                {
                    connection.Open();
                    string query = "SELECT * FROM Factures where type='achat'";
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
            finally
            {
                connection.Close();
            }
        }


        private void checkPAYEE_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void IDFACTURE_Click(object sender, EventArgs e)
        {

        }

        private void textFACTURE_TextChanged(object sender, EventArgs e)
        {

        }

        private void DATEFACTURE_Click(object sender, EventArgs e)
        {

        }

        private void textDATE_TextChanged(object sender, EventArgs e)
        {

        }

        private void IDPERSONNE_Click(object sender, EventArgs e)
        {

        }

        private void textPERSONNE_TextChanged(object sender, EventArgs e)
        {

        }

        private void STATUS_Click(object sender, EventArgs e)
        {

        }

        private void checkNONPAYEE_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {


            try


            {
                using (SqlConnection connection = new SqlConnection("Data Source=DESKTOP-7P14TAD\\SQLEXPRESS;Initial Catalog=tempdb;Integrated Security=True;Encrypt=True;Trust Server Certificate=True"))
                {
                    int id_personne = Convert.ToInt32(comboBox1.SelectedItem);
                    connection.Open();
                    string query = "INSERT INTO Factures (date_facture, id_personne, statut,type) VALUES (@date_facture, @id_personne, @statut,@type)";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@date_facture", dateTimePicker1.Value);
                        command.Parameters.AddWithValue("@id_personne", id_personne);
                        command.Parameters.AddWithValue("@statut", checkPAYEE.Checked ? "payée" : "non payée");
                        command.Parameters.AddWithValue("@type", "Achat");

                        command.ExecuteNonQuery();
                    }
                    LoadFactures();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error adding facture: {ex.Message}");
            }
         
        }

        /*
        private void buttonSupprimer_Click(object sender, EventArgs e)
        {

            int idFacture = Convert.ToInt32(dataGridView1.SelectedRows[0].Cells["id"].Value);
            try
            {
                connection.Open();
                string query = "DELETE FROM Factures WHERE id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", (idFacture));
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
                    command.Parameters.AddWithValue("@id", textFACTURE.Text);
                    command.Parameters.AddWithValue("@date_facture", dateTimePicker1.Value);
                    command.Parameters.AddWithValue("@id_personne", textPERSONNE.Text);
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
            dateTimePicker1.Value = DateTime.Now;
            comboBox1.SelectedIndex = -1;

            checkPAYEE.Checked = false;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FactureAchatForm_Load(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
