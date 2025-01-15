using Microsoft.Data.SqlClient;
using System.Data;
using System;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Diagnostics.Metrics;
using TestStack.White.UIItems.TreeItems;
namespace Gestion_de_stock
{
    public partial class LoginForm : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=DESKTOP-7P14TAD\SQLEXPRESS;Initial Catalog=tempdb ;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
        public LoginForm()
        {
            InitializeComponent();
        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(username.Text) || string.IsNullOrWhiteSpace(password.Text))
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    if (connect.State != ConnectionState.Open)
                    {
                        connect.Open();
                    }

                    // SQL query to check if user exists with the given username and password
                    string query = "SELECT COUNT(id) FROM users WHERE username = @username AND password = @password";
                    using (SqlCommand cmd = new SqlCommand(query, connect))
                    {
                        cmd.Parameters.AddWithValue("@username", username.Text.Trim());
                        cmd.Parameters.AddWithValue("@password", password.Text.Trim()); // This should be hashed in real applications

                        int count = (int)cmd.ExecuteScalar();

                        if (count == 1)
                        {
                            // Login successful
                            MainForm home = new MainForm();
                            home.Show();
                            this.Hide();
                        }
                        else
                        {
                            // Invalid credentials
                            MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Une erreur s'est produite: " + ex.Message, "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    if (connect.State == ConnectionState.Open)
                    {
                        connect.Close();
                    }
                }
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void signbtn_Click(object sender, EventArgs e)
        {
            SignUp SignUp = new SignUp();
            SignUp.Show();
            this.Hide();
        }

        // Afficher Le Password :
        private void showpsw_CheckedChanged(object sender, EventArgs e)
        {
            password.PasswordChar = showpsw.Checked ? '\0' : '*';
        }

        //Configuration de Hover sur Le Bouton Login :
        private void Button_MouseEnter(object sender, EventArgs e)
        {
            loginbtn.BackColor = Color.DarkSlateBlue; // Couleur hover 
        }
        private void Button_MouseLeave(object sender, EventArgs e)
        {
            loginbtn.BackColor = Color.SlateBlue; // Couleur Originale
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
