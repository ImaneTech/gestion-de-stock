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
    public partial class HomePage : Form
    {
        bool sidebarExpanded;

        public HomePage()
        {
            InitializeComponent();
            customizeDesign();
            menuButton.Tag = "Menu";
            button5.Tag = "Home";
            button4.Tag = "Accounts";
            button7.Tag = "Stock";
            button18.Tag = "Orders";
            button6.Tag = "Reports";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

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

        private void button2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void HomePage_Load(object sender, EventArgs e)
        {

        }



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

            panel3.Visible = false;
            panel10.Visible = false;
            panel14.Visible = false;
            panel13.Visible = false;
            panel12.Visible = false;

        }
        private void hideSubMenu()
        {
            if (panel3.Visible == true)
            {
                panel3.Visible = false;
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
            if (panel12.Visible == true)
            {
                panel12.Visible = false;
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
            showSubMenu(panel3);
        }
        private void button4_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panel10);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            showSubMenu(panel12);
        }
        private void button8_Click(object sender, EventArgs e)
        {
            showSubMenu(panel13);
        }


        private void button18_Click(object sender, EventArgs e)
        {
            showSubMenu(panel14);
        }


        private void button13_Click(object sender, EventArgs e)
        {
            //diriger vers la page ...
            hideSubMenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            //diriger vers la page ...
            hideSubMenu();
        }

        private void button17_Click(object sender, EventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            //diriger vers la page ...
            hideSubMenu();
        }
    }
}