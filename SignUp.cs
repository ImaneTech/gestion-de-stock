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
    public partial class SignUp : Form
    {
        public SignUp()
        {
            InitializeComponent();
        }

        private void SignUp_Load(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void signinbtn_Click(object sender, EventArgs e)
        {
            LoginForm LoginForm = new LoginForm();
            LoginForm.Show();
            this.Hide();
        }

        private void showpsw_CheckedChanged(object sender, EventArgs e)
        {
            password.PasswordChar = showpsw.Checked ? '\0' : '*';
        }

        //Configuration de Hover sur Le Bouton Login :
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            signupbtn.BackColor = Color.DarkSlateBlue; // Couleur hover 
        }
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            signupbtn.BackColor = Color.SlateBlue; // Couleur Originale
        }

        private void signupbtn_Click(object sender, EventArgs e)
        {

        }
    }
}
