using Microsoft.Data.SqlClient;
using System.Data;
using System.Security.Cryptography;
using System.Text;
namespace Gestion_de_stock
{
    public partial class LoginForm : Form
    {
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
                    if (Authentifier(username.Text.Trim(), password.Text))
                    {
                        // Login successful
                        MainForm home = new MainForm();
                        home.Show();
                        this.Hide();
                    }
                }
                catch (Exception ex)
                {
                    ErrorHandler.Show(ex, "Une erreur s'est produite lors de la connexion.");
                }

            }
        }

        private const int MaxTentatives = 5;
        private const int MinutesVerrouillage = 5;

        /// Vérifie les identifiants, gère le verrouillage du compte et ouvre la session.
        /// Affiche lui-même le message en cas d'échec.
        private bool Authentifier(string nomUtilisateur, string motDePasse)
        {
            using (SqlConnection connect = new SqlConnection(DatabaseConfig.GetConnectionString()))
            {
                connect.Open();

                int id;
                string role;
                string? motDePasseAncien;
                byte[]? hash, sel;
                bool verrouille;

                string query = @"SELECT id, role, password, password_hash, password_salt,
                                        CASE WHEN lockout_until > SYSUTCDATETIME() THEN 1 ELSE 0 END AS verrouille
                                 FROM users WHERE username = @username";
                using (SqlCommand cmd = new SqlCommand(query, connect))
                {
                    cmd.Parameters.AddWithValue("@username", nomUtilisateur);
                    using (SqlDataReader reader = cmd.ExecuteReader())
                    {
                        if (!reader.Read())
                        {
                            // Même coût qu'une vraie vérification, pour ne pas révéler quels comptes existent
                            PasswordHasher.HashPassword(motDePasse);
                            AfficherIdentifiantsIncorrects();
                            return false;
                        }
                        id = reader.GetInt32(0);
                        role = reader.GetString(1);
                        motDePasseAncien = reader.IsDBNull(2) ? null : reader.GetString(2);
                        hash = reader.IsDBNull(3) ? null : (byte[])reader[3];
                        sel = reader.IsDBNull(4) ? null : (byte[])reader[4];
                        verrouille = reader.GetInt32(5) == 1;
                    }
                }

                if (verrouille)
                {
                    MessageBox.Show($"Ce compte est temporairement verrouillé après {MaxTentatives} tentatives échouées. Réessayez dans {MinutesVerrouillage} minutes.", "Compte verrouillé", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return false;
                }

                bool valide;
                bool migrerAncienMotDePasse = false;
                if (hash != null && sel != null)
                {
                    valide = PasswordHasher.Verify(motDePasse, hash, sel);
                }
                else
                {
                    // Ancien compte avec mot de passe en clair (enregistré après Trim) : migré vers PBKDF2 à la première connexion réussie
                    valide = motDePasseAncien != null && CryptographicOperations.FixedTimeEquals(
                        Encoding.UTF8.GetBytes(motDePasse.Trim()), Encoding.UTF8.GetBytes(motDePasseAncien));
                    migrerAncienMotDePasse = valide;
                }

                if (!valide)
                {
                    // Le compteur repart à zéro quand le compte est verrouillé
                    string echec = @"UPDATE users SET
                                        lockout_until = CASE WHEN failed_attempts + 1 >= @max THEN DATEADD(MINUTE, @minutes, SYSUTCDATETIME()) ELSE lockout_until END,
                                        failed_attempts = CASE WHEN failed_attempts + 1 >= @max THEN 0 ELSE failed_attempts + 1 END
                                     WHERE id = @id";
                    using (SqlCommand cmd = new SqlCommand(echec, connect))
                    {
                        cmd.Parameters.AddWithValue("@max", MaxTentatives);
                        cmd.Parameters.AddWithValue("@minutes", MinutesVerrouillage);
                        cmd.Parameters.AddWithValue("@id", id);
                        cmd.ExecuteNonQuery();
                    }
                    AfficherIdentifiantsIncorrects();
                    return false;
                }

                string succes = "UPDATE users SET failed_attempts = 0, lockout_until = NULL WHERE id = @id";
                if (migrerAncienMotDePasse)
                    succes = "UPDATE users SET failed_attempts = 0, lockout_until = NULL, password_hash = @hash, password_salt = @salt, password = NULL WHERE id = @id";

                using (SqlCommand cmd = new SqlCommand(succes, connect))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    if (migrerAncienMotDePasse)
                    {
                        var (nouveauHash, nouveauSel) = PasswordHasher.HashPassword(motDePasseAncien!);
                        cmd.Parameters.Add("@hash", SqlDbType.VarBinary, PasswordHasher.HashSize).Value = nouveauHash;
                        cmd.Parameters.Add("@salt", SqlDbType.VarBinary, PasswordHasher.SaltSize).Value = nouveauSel;
                    }
                    cmd.ExecuteNonQuery();
                }

                Session.Start(id, nomUtilisateur, role);
                return true;
            }
        }

        private static void AfficherIdentifiantsIncorrects()
        {
            MessageBox.Show("Nom d'utilisateur ou mot de passe incorrect.", "Message d'erreur", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
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
