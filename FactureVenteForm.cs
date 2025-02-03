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

        private SqlDataAdapter adapter;
        private DataTable factureTable;
        public FactureVenteForm()
        {
            InitializeComponent();
            LoadFactures();
            initialiser_combobox();
        }

        public void initialiser_combobox()
        {
            try
            {

                using (SqlConnection connect = new SqlConnection(DatabaseConfig.GetConnectionString()))
                {
                    connect.Open();
                    string query = "SELECT id FROM Personne where type='client'";
                    using (SqlCommand cmd = new SqlCommand(query, connect))
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

                using (SqlConnection connect = new SqlConnection(DatabaseConfig.GetConnectionString()))
                {
                    connect.Open();
                    string query = "SELECT * FROM Factures where type='vente'";
                    adapter = new SqlDataAdapter(query, connect);
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

                using (SqlConnection connect = new SqlConnection(DatabaseConfig.GetConnectionString()))
                {
                    connect.Open();
                    int id_personne = Convert.ToInt32(comboBox1.SelectedItem);
                    string query = "INSERT INTO Factures (date_facture, id_personne, statut,type) VALUES (@date_facture, @id_personne, @statut,@type)";
                    using (SqlCommand command = new SqlCommand(query, connect))
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

        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {

            comboBox1.SelectedIndex = -1;
            dateTimePicker1.Value = DateTime.Now;
            checkPAYEE.Checked = false;
            checkNONPAYEE.Checked = false;
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
