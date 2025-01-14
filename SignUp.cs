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
    public partial class SignUp : Form
    {
        SqlConnection connect = new SqlConnection(@"Data Source=server ;Initial Catalog=master;Integrated Security=True;Encrypt=True;Trust Server Certificate=True");
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
            if (string.IsNullOrWhiteSpace(username.Text) || string.IsNullOrWhiteSpace(password.Text) || string.IsNullOrWhiteSpace(mail.Text))
            {
                MessageBox.Show("Tous les champs doivent être remplis.", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (connect.State != ConnectionState.Open)
                {
                    try
                    {
                        connect.Open();

                        // Check if user already exists
                        string selectUsername = "SELECT COUNT(id) FROM users WHERE username = @user";
                        using (SqlCommand checkUser = new SqlCommand(selectUsername, connect))
                        {
                            checkUser.Parameters.AddWithValue("@user", username.Text.Trim());
                            int count = (int)checkUser.ExecuteScalar();

                            if (count >= 1)
                            {
                                MessageBox.Show(username.Text.Trim() + " est déjà pris.", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                            }
                            else
                            {
                                // Corrected the SQL insert statement syntax
                                string insertData = "INSERT INTO users (username, mail, password) VALUES (@username, @mail, @password)";
                                using (SqlCommand cmd = new SqlCommand(insertData, connect))
                                {
                                    cmd.Parameters.AddWithValue("@username", username.Text.Trim());
                                    cmd.Parameters.AddWithValue("@mail", mail.Text.Trim());
                                    // Password should be hashed before storing
                                    cmd.Parameters.AddWithValue("@password", password.Text.Trim()); // Hash this in real applications

                                    cmd.ExecuteNonQuery();

                                    MessageBox.Show("Inscription réussie avec succès.", "Message d'information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                    LoginForm loginForm = new LoginForm(); // Replace with actual login form initialization
                                    loginForm.Show();
                                    this.Hide();
                                }
                            }
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Une erreur s'est produite: " + ex.Message, "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        connect.Close();
                    }
                }
            }
        }

    }
}
