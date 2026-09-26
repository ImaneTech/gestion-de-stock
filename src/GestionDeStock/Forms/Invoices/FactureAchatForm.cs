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
using System.Reflection.Metadata;

namespace Gestion_de_stock
{
    public partial class FactureAchatForm : Form
    {
        private SqlDataAdapter adapter;
        private DataTable factureTable;
        public FactureAchatForm()
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

                    using (SqlCommand cmd = new SqlCommand("SELECT id FROM Personne WHERE type = 'fournisseur'", connect))
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
                ErrorHandler.Show(ex, "Erreur lors du chargement des fournisseurs.");
            }
        }
        private void LoadFactures()
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(DatabaseConfig.GetConnectionString()))
                {
                    connect.Open();
                    string query = "SELECT * FROM Factures where type='achat'";
                    adapter = new SqlDataAdapter(query, connect);
                    factureTable = new DataTable();
                    adapter.Fill(factureTable);
                    dataGridView1.DataSource = factureTable;
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.Show(ex, "Erreur lors du chargement des factures.");
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
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un fournisseur.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!decimal.TryParse(montant.Text, out decimal valeurMontant) || valeurMontant <= 0)
            {
                MessageBox.Show("Le montant doit être un nombre supérieur à zéro.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // payée / non payée sont des boutons radio du même panneau : un seul peut être coché
            if (!checkPAYEE.Checked && !checkNONPAYEE.Checked)
            {
                MessageBox.Show("Veuillez indiquer si la facture est payée ou non payée.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                using (SqlConnection connect = new SqlConnection(DatabaseConfig.GetConnectionString()))
                {
                    int id_personne = Convert.ToInt32(comboBox1.SelectedItem);
                    connect.Open();
                    string query = "INSERT INTO Factures (date_facture, id_personne, statut,type,montant) VALUES (@date_facture, @id_personne, @statut,@type,@montant)";
                    using (SqlCommand command = new SqlCommand(query, connect))
                    {
                        command.Parameters.AddWithValue("@date_facture", dateTimePicker1.Value);
                        command.Parameters.AddWithValue("@id_personne", id_personne);
                        command.Parameters.AddWithValue("@statut", checkPAYEE.Checked ? "payée" : "non payée");
                        command.Parameters.AddWithValue("@type", "achat");
                        command.Parameters.AddWithValue("@montant", valeurMontant);
                    
                        command.ExecuteNonQuery();
                    }
                    LoadFactures();
                }
            }
            catch (Exception ex)
            {
                ErrorHandler.Show(ex, "Erreur lors de l'ajout de la facture.");
            }

        }

        private void buttonQuitter_Click(object sender, EventArgs e)
        {
            dateTimePicker1.Value = DateTime.Now;
            comboBox1.SelectedIndex = -1;
            checkNONPAYEE.Checked = false;
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

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
