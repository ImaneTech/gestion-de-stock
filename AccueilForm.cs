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
    public partial class AccueilForm : Form
    {
        private readonly string connectionString = @"Data Source=DESKTOP-7P14TAD\SQLEXPRESS;Initial Catalog=master;Integrated Security=True;Encrypt=True;Trust Server Certificate=True";
        public AccueilForm()
        {
            InitializeComponent();
            ChargerStatistiques();
        }

        private void ChargerStatistiques()
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(connectionString))
                {
                    connect.Open();

                    //la valeur totale du stock
                    string queryValeurStock = "SELECT SUM(prix_unitaire * qte_stock) FROM Produit";
                    using (SqlCommand cmdValeurStock = new SqlCommand(queryValeurStock, connect))
                    {
                        object result = cmdValeurStock.ExecuteScalar();
                        decimal valeurStock = result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                        label2.Text = valeurStock.ToString();

                    }

                    // le nombre de factures d'achat payees
                    string queryFacturesPayees = "SELECT COUNT(*) FROM Factures WHERE statut = 'payée'";
                    using (SqlCommand cmdFacturesPayees = new SqlCommand(queryFacturesPayees, connect))
                    {
                        int nombreFacturesPayees = Convert.ToInt32(cmdFacturesPayees.ExecuteScalar());
                        label3.Text = nombreFacturesPayees.ToString();
                    }

                    // le nombre de produits en rupture de stock
                    string queryProduitsRupture = "SELECT COUNT(*) FROM Produit WHERE qte_stock < qte_stock_min";
                    using (SqlCommand cmdProduitsRupture = new SqlCommand(queryProduitsRupture, connect))
                    {
                        int nombreProduitsRupture = Convert.ToInt32(cmdProduitsRupture.ExecuteScalar());
                        label5.Text = nombreProduitsRupture.ToString();

                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des statistiques : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }
    }
}



