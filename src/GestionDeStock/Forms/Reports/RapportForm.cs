using Microsoft.Data.SqlClient;
using System.Data;

namespace Gestion_de_stock
{
    public partial class RapportForm : Form
    {
        private SqlCommand cmd;

        public RapportForm()
        {
            InitializeComponent();
            AjouterRapportMensuel(); // Ajoute un rapport pour le mois précédent si non existant
            GetRapports(); // Affiche les rapports existants
            dataGridView1.Refresh();
            dataGridView1.RowPrePaint += dataGridView1_RowPrePaint;

        }

        /// Récupère et affiche les rapports mensuels dans le DataGridView.

        private void GetRapports()
        {
            try
            {
                dataGridView1.DataSource = Db.Query("SELECT mois_annee AS Mois, recettes AS [Recettes (Dh)], depenses AS [Dépenses (Dh)], benefices AS [Bénéfices (Dh)] FROM Rapport_Mensuel");
            }
            catch (Exception ex)
            {
                ErrorHandler.Show(ex, "Erreur lors du chargement des rapports.");
            }
        }


        /// Génère et stocke le rapport du mois précédent si non existant.

        private void AjouterRapportMensuel()
        {
            try
            {
                GenererRapportsMensuels();
            }
            catch (Exception ex)
            {
                ErrorHandler.Show(ex, "Erreur lors de la génération des rapports.");
            }
        }

        private void GenererRapportsMensuels()
        {
            using (SqlConnection connect = new SqlConnection(DatabaseConfig.GetConnectionString()))
            {
                connect.Open();

                // Récupérer la première et la dernière date de facture
                cmd = new SqlCommand("SELECT MIN(date_facture), MAX(date_facture) FROM Factures", connect);
                SqlDataReader dr = cmd.ExecuteReader();

                DateTime minDate = DateTime.MinValue;
                DateTime maxDate = DateTime.MinValue;

                // MIN/MAX renvoient NULL lorsque la table Factures est vide
                if (dr.Read() && dr[0] != DBNull.Value && dr[1] != DBNull.Value)
                {
                    minDate = Convert.ToDateTime(dr[0]);
                    maxDate = Convert.ToDateTime(dr[1]);
                }
                dr.Close();

                if (minDate == DateTime.MinValue || maxDate == DateTime.MinValue)
                {
                    MessageBox.Show("Aucune facture trouvée !");
                    return;
                }

                // Définir le premier mois à analyser
                DateTime moisCourant = new DateTime(minDate.Year, minDate.Month, 1);
                DateTime dernierMois = new DateTime(maxDate.Year, maxDate.Month, 1);

                decimal totalCumulatifRecettes = 0;
                decimal totalCumulatifDepenses = 0;

                while (moisCourant <= dernierMois)
                {
                    // Format du mois et de l'année en "YYYY-MM"
                    string moisAnnee = moisCourant.ToString("yyyy-MM");

                    DateTime moisDebut = moisCourant;
                    DateTime moisFin = moisCourant.AddMonths(1).AddDays(-1);

                    // Calcul des dépenses cumulatives (achats payés jusqu'à ce mois)
                    cmd = new SqlCommand(@"SELECT COALESCE(SUM(montant), 0) 
                                   FROM Factures 
                                   WHERE type = 'achat' AND statut = 'payée' 
                                   AND date_facture <= @moisFin", connect);
                    cmd.Parameters.AddWithValue("@moisFin", moisFin);
                    totalCumulatifDepenses = Convert.ToDecimal(cmd.ExecuteScalar());

                    // Calcul des recettes cumulatives (ventes payées jusqu'à ce mois)
                    cmd = new SqlCommand(@"SELECT COALESCE(SUM(montant), 0) 
                                   FROM Factures 
                                   WHERE type = 'vente' AND statut = 'payée' 
                                   AND date_facture <= @moisFin", connect);
                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@moisFin", moisFin);
                    totalCumulatifRecettes = Convert.ToDecimal(cmd.ExecuteScalar());

                    // Insérer ou mettre à jour le rapport mensuel avec le mois et l'année formatés
                    cmd = new SqlCommand(@"MERGE INTO Rapport_Mensuel AS target
                                   USING (SELECT @moisAnnee AS mois_annee, @recettes AS recettes, @depenses AS depenses) AS source
                                   ON target.mois_annee = source.mois_annee
                                   WHEN MATCHED THEN 
                                       UPDATE SET target.recettes = source.recettes, target.depenses = source.depenses
                                   WHEN NOT MATCHED THEN 
                                       INSERT (mois_annee, recettes, depenses) VALUES (source.mois_annee, source.recettes, source.depenses);", connect);

                    cmd.Parameters.Clear();
                    cmd.Parameters.AddWithValue("@moisAnnee", moisAnnee);
                    cmd.Parameters.AddWithValue("@recettes", totalCumulatifRecettes);
                    cmd.Parameters.AddWithValue("@depenses", totalCumulatifDepenses);
                    cmd.ExecuteNonQuery();

                    // Passer au mois suivant
                    moisCourant = moisCourant.AddMonths(1);
                }
            }
        }



        /// Change la couleur des lignes en fonction des bénéfices.

        private void dataGridView1_RowPrePaint(object sender, DataGridViewRowPrePaintEventArgs e)
        {
            if (e.RowIndex < 0) return;

            object cellValue = dataGridView1.Rows[e.RowIndex].Cells[3].Value; // Colonne 3

            double benefice;

            // Vérifier que la valeur n'est ni null ni vide et qu'on peut la convertir en double
            if (cellValue != null && double.TryParse(cellValue.ToString(), out benefice))
            {
                if (benefice < 0)
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightCoral; // Rouge
                else if (benefice == 0)
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightYellow; // Jaune
                else
                    dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.LightGreen; // Vert
            }
            else
            {
                // Si la valeur est invalide, on garde la couleur par défaut
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void RapportForm_Load(object sender, EventArgs e)
        {

        }
    }
}
