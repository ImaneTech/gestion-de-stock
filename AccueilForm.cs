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
        public AccueilForm()
        {
            InitializeComponent();
            ChargerStatistiques();
            AfficherAlertes();
        }


        //  Statistiques 
        private void ChargerStatistiques()
        {
            try
            {
                using (SqlConnection connect = new SqlConnection(DatabaseConfig.GetConnectionString()))
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
                    //Nombre de clients :
                    string queryClient = "SELECT COUNT(*) FROM personne where type='client'";
                    using (SqlCommand cmdClient = new SqlCommand(queryClient, connect))
                    {
                        int nombreClient = Convert.ToInt32(cmdClient.ExecuteScalar());
                        label7.Text = nombreClient.ToString();

                    }
                    //Nombre de fournisseurs :
                    string queryFournisseur = "SELECT COUNT(*) FROM personne where type='fournisseur'";
                    using (SqlCommand cmdFournisseur = new SqlCommand(queryFournisseur, connect))
                    {
                        int nombreFournisseur = Convert.ToInt32(cmdFournisseur.ExecuteScalar());
                        label10.Text = nombreFournisseur.ToString();
                    }

                }
            }
            // Gestion des erreurs
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors du chargement des statistiques : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        // Alertes  
        private void AfficherAlertes()
        {
            flowLayoutPanel1.Controls.Clear();
            try
            {
                using (SqlConnection connect = new SqlConnection(DatabaseConfig.GetConnectionString()))
                {
                    connect.Open();
                    //Extraire les produits en rupture de stock (qte_stock < qte_stock_min)
                    string queryAlertes = @"SELECT nom, qte_stock, qte_stock_min FROM Produit WHERE qte_stock < qte_stock_min;";

                    using (SqlCommand cmdAlertes = new SqlCommand(queryAlertes, connect))
                    {
                        using (SqlDataReader reader = cmdAlertes.ExecuteReader())
                        {
                            if (!reader.HasRows)
                            {
                                //Aucune Alerte
                                Label lblAucuneAlerte = new Label();
                                lblAucuneAlerte.Text = "Liste vide";
                                lblAucuneAlerte.Font = new Font("Arial Rounded MT Bold", 20, FontStyle.Bold);
                                lblAucuneAlerte.ForeColor = Color.DarkGray;
                                lblAucuneAlerte.AutoSize = true;
                                // Ajouter le Label au FlowLayoutPanel
                                flowLayoutPanel1.Controls.Add(lblAucuneAlerte);
                            }
                            else
                            {
                                // Afficher chaque alerte dans un panel
                                while (reader.Read())
                                {
                                    string nomProduit = reader["nom"].ToString();
                                    int qteStock = Convert.ToInt32(reader["qte_stock"]);
                                    int qteStockMin = Convert.ToInt32(reader["qte_stock_min"]);

                                    // Creer un panel pour chaque alerte
                                    Panel panelAlerte = new Panel();
                                    panelAlerte.BackColor = Color.LightPink;
                                    panelAlerte.BorderStyle = BorderStyle.None;
                                    panelAlerte.Size = new Size(flowLayoutPanel1.Width, 50);

                                    // Ajouter le message d'alerte dans un label
                                    Label lblAlerte = new Label();
                                    lblAlerte.Text = $"Attention : Le stock de {nomProduit} est en dessous du seuil minimum {qteStockMin}.Stock actuel = {qteStock}";
                                    lblAlerte.Font = new Font("Arial Rounded MT Bold", 10, FontStyle.Regular);
                                    lblAlerte.ForeColor = Color.Black;
                                    lblAlerte.AutoSize = false;
                                    lblAlerte.Size = new Size(panelAlerte.Width, 40);
                                    lblAlerte.Location = new Point(10, 10);

                                    // Ajouter le label au panel
                                    panelAlerte.Controls.Add(lblAlerte);

                                    // Ajouter le panel au FlowLayoutPanel
                                    flowLayoutPanel1.Controls.Add(panelAlerte);
                                }
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erreur lors de la récupération des alertes : " + ex.Message, "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {




        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AccueilForm_Load(object sender, EventArgs e)
        {

        }
    }
}



