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
    public partial class RapportForm : Form
    {
        //La connection : 
        private SqlConnection conn;
        private SqlCommand cmd;
        private SqlDataReader dr;
        public RapportForm()
        {
            InitializeComponent();
            GetRapports();
        }
       
        private void GetRapports()
        {
            try
            {
                //Connection :
                conn = new SqlConnection("Data Source=servername;Initial Catalog=GestionStock;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
                //Execution commande :
                conn.Open();
                cmd = conn.CreateCommand();
                cmd.CommandText = "SELECT CONVERT(VARCHAR(10), date, 120), recettes, depenses, benefices FROM Rapport_Mensuel";
                dr = cmd.ExecuteReader();
                //init Data GridView :
                dataGridView1.DataSource = null;
                dataGridView1.Columns.Clear();
                dataGridView1.ColumnCount = 4;
                dataGridView1.Columns[0].Name = "Mois";
                dataGridView1.Columns[1].Name = "Recettes (Dh)";
                dataGridView1.Columns[2].Name = "Depenses (Dh)";
                dataGridView1.Columns[3].Name = "Benefices (Dh)";
                //Ramplir le listview :
                while (dr.Read())
                {
                    dataGridView1.Rows.Add(dr[0].ToString(), dr[1].ToString(), dr[2].ToString(), dr[3].ToString());
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
        //Changer couleur des lignes :
        private void dataGridView1_rowColor(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            int index = e.RowIndex;
            double x = Convert.ToDouble(dataGridView1.Rows[index].Cells[3].Value);
            if (x < 0) // Couleur Rouge si benefice < 0
            {
                dataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.LightCoral;
            }
            else if(x == 0)// Couleur Jaune si benefice = 0
            {
                dataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.LightYellow;
            }
            else //couleur verte si benefice > 0
            {
                dataGridView1.Rows[index].DefaultCellStyle.BackColor = Color.LightGreen;
            }



        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        //List des rapports :
        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void RapportForm_Load(object sender, EventArgs e)
        {
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
