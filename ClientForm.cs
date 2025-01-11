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
    public partial class ClientForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=SERVER_NAME;Initial Catalog=master;Integrated Security=True;Encrypt=False");
        public ClientForm()
        {
            InitializeComponent();
            ChargerClients();
        }
        private void ChargerClients()
        {
            try
            {
                using (connect)
                {
                    connect.Open();
                    string query = "SELECT * FROM Personne WHERE type = 'client'";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, connect);
                    DataTable dataTable = new DataTable();
                    dataAdapter.Fill(dataTable);
                    dataGridView1.DataSource = dataTable;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des Clients : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
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
                string query = "INSERT INTO Personne (nom, adresse, telephone, email, type) VALUES (@nom, @adresse, @telephone, @email, 'client')";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@nom", Nom.Text);
                    cmd.Parameters.AddWithValue("@adresse", Adresse.Text);
                    cmd.Parameters.AddWithValue("@telephone", Tele.Text);
                    cmd.Parameters.AddWithValue("@email", Email.Text);

                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Client ajoutée avec succès.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Nom.Clear();
            Adresse.Clear();
            Tele.Clear();
            Email.Clear();
            Nom.Focus();
        }
    }
}
