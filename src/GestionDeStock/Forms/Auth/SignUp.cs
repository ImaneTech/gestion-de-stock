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
            else if (!PasswordPolicy.IsValid(password.Text))
            {
                MessageBox.Show(PasswordPolicy.Description, "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    using (SqlConnection connect = new SqlConnection(DatabaseConfig.GetConnectionString()))
                    {
                        connect.Open();
                        using (SqlTransaction transaction = connect.BeginTransaction())
                        {
                            // Verrou sur la table users : deux inscriptions simultanées ne peuvent pas devenir admin toutes les deux
                            int nombreComptes;
                            using (SqlCommand countUsers = new SqlCommand("SELECT COUNT(id) FROM users WITH (UPDLOCK, HOLDLOCK)", connect, transaction))
                            {
                                nombreComptes = (int)countUsers.ExecuteScalar();
                            }

                            // Check if user already exists
                            string selectUsername = "SELECT COUNT(id) FROM users WHERE username = @user";
                            using (SqlCommand checkUser = new SqlCommand(selectUsername, connect, transaction))
                            {
                                checkUser.Parameters.AddWithValue("@user", username.Text.Trim());
                                int count = (int)checkUser.ExecuteScalar();

                                if (count >= 1)
                                {
                                    transaction.Rollback();
                                    MessageBox.Show(username.Text.Trim() + " est déjà pris.", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                    return;
                                }
                            }

                            // Le premier compte créé est administrateur
                            string role = nombreComptes == 0 ? Session.RoleAdmin : Session.RoleUser;
                            var (hash, salt) = PasswordHasher.HashPassword(password.Text);

                            string insertData = "INSERT INTO users (username, mail, password_hash, password_salt, role) VALUES (@username, @mail, @hash, @salt, @role)";
                            using (SqlCommand cmd = new SqlCommand(insertData, connect, transaction))
                            {
                                cmd.Parameters.AddWithValue("@username", username.Text.Trim());
                                cmd.Parameters.AddWithValue("@mail", mail.Text.Trim());
                                cmd.Parameters.Add("@hash", SqlDbType.VarBinary, PasswordHasher.HashSize).Value = hash;
                                cmd.Parameters.Add("@salt", SqlDbType.VarBinary, PasswordHasher.SaltSize).Value = salt;
                                cmd.Parameters.AddWithValue("@role", role);
                                cmd.ExecuteNonQuery();
                            }

                            transaction.Commit();
                        }
                    }

                    MessageBox.Show("Inscription réussie avec succès.", "Message d'information", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    LoginForm loginForm = new LoginForm();
                    loginForm.Show();
                    this.Hide();
                }
                catch (Exception ex)
                {
                    ErrorHandler.Show(ex, "Une erreur s'est produite lors de l'inscription.");
                }
            }
        }

    }
}
