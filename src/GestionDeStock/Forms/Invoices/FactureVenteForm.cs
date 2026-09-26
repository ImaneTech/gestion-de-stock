using System.Data;

namespace Gestion_de_stock
{

    public partial class FactureVenteForm : Form
    {

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
                DataTable clients = Db.Query("SELECT id FROM Personne where type='client'");
                comboBox1.Items.Clear();

                // Parcourir les résultats et ajouter les id à la ComboBox
                foreach (DataRow row in clients.Rows)
                {
                    comboBox1.Items.Add(row["id"].ToString()!);
                }
            }
            catch (Exception ex)
            {
                // Gestion des erreurs
                ErrorHandler.Show(ex, "Erreur lors du chargement des clients.");
            }
        }

        private void LoadFactures()
        {
            try
            {
                factureTable = Db.Query("SELECT * FROM Factures where type='vente'");
                dataGridView1.DataSource = factureTable;
            }
            catch (Exception ex)
            {
                ErrorHandler.Show(ex, "Erreur lors du chargement des factures.");
            }

        }

        private void buttonAjouter_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Veuillez sélectionner un client.", "Erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                int id_personne = Convert.ToInt32(comboBox1.SelectedItem);
                Db.Execute("INSERT INTO Factures (date_facture, id_personne, statut,type,montant) VALUES (@date_facture, @id_personne, @statut,@type,@montant)",
                    ("@date_facture", dateTimePicker1.Value),
                    ("@id_personne", id_personne),
                    ("@statut", checkPAYEE.Checked ? "payée" : "non payée"),
                    ("@type", "vente"),
                    ("@montant", valeurMontant));

                LoadFactures();
            }
            catch (Exception ex)
            {
                ErrorHandler.Show(ex, "Erreur lors de l'ajout de la facture.");
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

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void montant_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
