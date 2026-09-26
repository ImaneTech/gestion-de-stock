using System.Data;

namespace Gestion_de_stock
{
    public partial class FactureAchatForm : Form
    {
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
                foreach (DataRow row in Db.Query("SELECT id FROM Personne WHERE type = 'fournisseur'").Rows)
                {
                    comboBox1.Items.Add(row["id"].ToString()!);
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
                factureTable = Db.Query("SELECT * FROM Factures where type='achat'");
                dataGridView1.DataSource = factureTable;
            }
            catch (Exception ex)
            {
                ErrorHandler.Show(ex, "Erreur lors du chargement des factures.");
            }
        }

        private void DATEFACTURE_Click(object sender, EventArgs e)
        {

        }

        private void IDPERSONNE_Click(object sender, EventArgs e)
        {

        }

        private void STATUS_Click(object sender, EventArgs e)
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
                int id_personne = Convert.ToInt32(comboBox1.SelectedItem);
                Db.Execute("INSERT INTO Factures (date_facture, id_personne, statut,type,montant) VALUES (@date_facture, @id_personne, @statut,@type,@montant)",
                    ("@date_facture", dateTimePicker1.Value),
                    ("@id_personne", id_personne),
                    ("@statut", checkPAYEE.Checked ? "payée" : "non payée"),
                    ("@type", "achat"),
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
