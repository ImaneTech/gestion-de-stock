using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_de_stock
{
    public partial class VenteForm : Form
    {
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataReader dr;
        public VenteForm()
        {
            InitializeComponent();
            GetVente();
        }


        private void GetVente()
        {

            try
            {
                //Connection :
                conn = new SqlConnection("Data Source=servername;Initial Catalog=GestionStock;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
                //Execution commande :
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT lo.id_Operation, lo.id_produit, p.nom, lo.quantite, lo.prix_total " +
                                  "FROM LigneOperation lo " +
                                  "JOIN Operation o ON lo.id_Operation = o.id_Operation " +
                                  "JOIN Produit p ON lo.id_produit = p.id " +
                                  "WHERE o.type = 'vente'";
                dr = cmd.ExecuteReader();
                //init Data GridView :
                dataGridView1.DataSource = null;
                dataGridView1.Columns.Clear();
                dataGridView1.ColumnCount = 5;
                dataGridView1.Columns[0].Name = "Id Operation";
                dataGridView1.Columns[1].Name = "Id Produit";
                dataGridView1.Columns[2].Name = "Produit";
                dataGridView1.Columns[3].Name = "Quantite";
                dataGridView1.Columns[4].Name = "Total Prix(Dh)";
                //Ramplir le listview :
                while (dr.Read())
                {
                    dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString(), dr[4].ToString());
                }
                //Fermeture de la connection :
                dr.Close();
                conn.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void VenteForm_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
