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

        }
        private void InitializeDatabaseConnection()
        {
            string connectionString = @"Data Source =DELL-NASRO\SQLEXPRESS; Initial Catalog = master; Integrated Security = True; Encrypt = True; Trust Server Certificate = True";

            connection = new SqlConnection(connectionString);
        }

        private void LoadFactures()
        {
            try
            {
                connection.Open();
                string query = "SELECT * FROM GestionStock.dbo.Factures where type=achat";
                adapter = new SqlDataAdapter(query, connection);
                factureTable = new DataTable();
                adapter.Fill(factureTable);
                dataGridView1.DataSource = factureTable;
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
                connection.Open();
                string query = "INSERT INTO Factures (date_facture, id_personne, statut) VALUES (@date_facture, @id_personne, @statut)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@date_facture", textDATE.Text);
                    command.Parameters.AddWithValue("@id_personne", textPERSONNE.Text);
                    command.Parameters.AddWithValue("@statut", checkPAYEE.Checked ? "payée" : "non payée");

                    command.ExecuteNonQuery();
                }
                LoadFactures();
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

        private void buttonSupprimer_Click(object sender, EventArgs e)
        {

            try
            {
                connection.Open();
                string query = "DELETE FROM Factures WHERE id = @id";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", textFACTURE.Text);
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
                    command.Parameters.AddWithValue("@date_facture", textDATE.Text);
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

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            Application.Exit();
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
    }
}
