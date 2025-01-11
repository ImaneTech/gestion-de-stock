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
    public partial class FournisseurForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=SERVER_NAME;Initial Catalog=master;Integrated Security=True;Encrypt=False");
        public FournisseurForm()
        {
            InitializeComponent();
            ChargerFournisseur();
        }

        private void ChargerFournisseur()
        {
            try
            {
                using (connect)
                {
                    connect.Open();
                    string query = "SELECT * FROM Personne WHERE type = 'fournisseur'";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connect);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des Fournisseurs : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nom.Clear();
            Adresse.Clear();
            Tele.Clear();
            Email.Clear();
            Nom.Focus();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Nom.Text) || string.IsNullOrEmpty(Adresse.Text) || string.IsNullOrEmpty(Tele.Text) || string.IsNullOrEmpty(Email.Text))
            {
                MessageBox.Show("Veuillez remplir tous les champs.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            try
            {
                connect.Open();
                string query = "INSERT INTO Personne (nom, adresse, telephone, email, type) VALUES (@nom, @adresse, @telephone, @email, 'fournisseur')";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@nom", Nom.Text);
                    cmd.Parameters.AddWithValue("@adresse", Adresse.Text);
                    cmd.Parameters.AddWithValue("@telephone", Tele.Text);
                    cmd.Parameters.AddWithValue("@email", Email.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Fournisseur ajouté avec succès.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur: " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                connect.Close();
            }
        }
    }
}
