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
                //la valeur totale du stock
                object? result = Db.Scalar("SELECT SUM(prix_unitaire * qte_stock) FROM Produit");
                decimal valeurStock = result != null && result != DBNull.Value ? Convert.ToDecimal(result) : 0;
                label2.Text = valeurStock.ToString();

                // le nombre de factures d'achat payees
                label3.Text = Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM Factures WHERE statut = 'payée'")).ToString();

                // le nombre de produits en rupture de stock
                label5.Text = Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM Produit WHERE qte_stock < qte_stock_min")).ToString();

                //Nombre de clients :
                label7.Text = Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM personne where type='client'")).ToString();

                //Nombre de fournisseurs :
                label10.Text = Convert.ToInt32(Db.Scalar("SELECT COUNT(*) FROM personne where type='fournisseur'")).ToString();
            }
            // Gestion des erreurs
            catch (Exception ex)
            {
                ErrorHandler.Show(ex, "Erreur lors du chargement des statistiques.");
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
                ErrorHandler.Show(ex, "Erreur lors de la récupération des alertes.");
            }
        }
        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox3_Click(object sender, EventArgs e)
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
