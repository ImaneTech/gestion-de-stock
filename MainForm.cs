using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using TestStack.White.UIItems.WindowStripControls;

namespace Gestion_de_stock
{
    public partial class MainForm : Form
    {
        bool sidebarExpanded;

        public MainForm()
        {
            InitializeComponent();
            customizeDesign();
            menuButton.Tag = "Menu";
            button5.Tag = "Accueil";
            button4.Tag = "Comptes";
            button7.Tag = "Stock";
            button10.Tag = "Rapports";
            button8.Tag = "Deconnexion";
            button9.Tag = "Factures";
            button18.Tag = "Transactions";

        }
        // ******************** exit button
        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // ******************** maximize button
        private void button3_Click(object sender, EventArgs e)
        {

            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }
        //******************** minimize button
        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        //******************** minimiser le sidebar

        private void button4_Click(object sender, EventArgs e)
        {
            if (sidebarExpanded)
            {
                sidebar.Width -= 10;
                if (sidebar.Width == sidebar.MinimumSize.Width)
                {
                    sidebarExpanded = false;
                    sidebartimer.Stop();
                    foreach (Control control in sidebar.Controls)
                    {
                        if (control is Button)
                        {
                            Button btn = (Button)control;
                            btn.Text = "";
                        }
                    }
                }
            }
            else
            {
                sidebar.Width += 10;
                if (sidebar.Width == sidebar.MaximumSize.Width)
                {
                    sidebarExpanded = true;
                    sidebartimer.Stop();
                    foreach (Control control in sidebar.Controls)
                    {
                        if (control is Button)
                        {
                            Button btn = (Button)control;
                            btn.Text = btn.Tag?.ToString();
                        }
                    }
                }
            }
        }
        private void menuButton_Click(object sender, EventArgs e)
        {
            sidebartimer.Start();
        }

        private void sidebar_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void button11_Click_1(object sender, EventArgs e)
        {
            //diriger vers la page ...
            hideSubMenu();
        }

        private void customizeDesign()
        {

            panel2.Visible = false;
            panel10.Visible = false;
            panel14.Visible = false;
            panel13.Visible = false;


        }
        private void hideSubMenu()
        {
            if (panel2.Visible == true)
            {
                panel2.Visible = false;
            }
            if (panel10.Visible == true)
            {
                panel10.Visible = false;
            }
            if (panel14.Visible == true)
            {
                panel14.Visible = false;
            }
            if (panel13.Visible == true)
            {
                panel13.Visible = false;
            }


        }
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }

        private void button12_Click(object sender, EventArgs e)
        {
            //diriger vers la page ...
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {

        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panel10);
        }

        private void button7_Click(object sender, EventArgs e)
        {

            showSubMenu(panel13);
        }
        private void button8_Click(object sender, EventArgs e)
        {

        }
        private void button9_Click(object sender, EventArgs e)
        {
            showSubMenu(panel2);
        }


        private void button18_Click(object sender, EventArgs e)
        {
            showSubMenu(panel14);
        }


        private void button13_Click(object sender, EventArgs e)
        {
            //diriger vers la page ...
            hideSubMenu();

            openChildForm(new ClientForm());
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //diriger vers la page ...
            hideSubMenu();
            openChildForm(new FournisseurForm());
        }
        private void button10_Click(object sender, EventArgs e)
        {

        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            hideSubMenu();

            openChildForm(new ProduitForm());



        }

        private void panel14_Paint(object sender, PaintEventArgs e)
        {

        }
        private void RedirigerVersPageConnexion()
        {
            // Fermer le formulaire actuel
            this.Hide();

            // Ouvrir la page de connexion
            LoginForm loginPage = new LoginForm();
            loginPage.Show();
        }
        private void button8_Click_1(object sender, EventArgs e)
        {
            // confirmation
            DialogResult result = MessageBox.Show("Êtes-vous sûr de vouloir vous déconnecter ?", "Déconnexion", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            // Si l'utilisateur confirme par OUI
            if (result == DialogResult.Yes)
            {
                // Rediriger vers la page de connexion
                RedirigerVersPageConnexion();

            }
        }
        private Form acrtiveForm = null;
        private void openChildForm(Form childForm)
        {
            if (acrtiveForm != null)
            {
                acrtiveForm.Close();
            }
            acrtiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelchildForm.Controls.Add(childForm);
            panelchildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {


        }
        private void HomePage_Load(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        
    }
}
    