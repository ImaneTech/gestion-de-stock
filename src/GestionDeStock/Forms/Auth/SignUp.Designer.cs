namespace Gestion_de_stock
{
    partial class SignUp
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label2 = new Label();
            showpsw = new CheckBox();
            passwordlbl = new Label();
            usernamelbl = new Label();
            signupbtn = new Button();
            password = new TextBox();
            username = new TextBox();
            panel1 = new Panel();
            label1 = new Label();
            signinbtn = new Button();
            exit = new Label();
            maillbl = new Label();
            mail = new TextBox();
            pictureBox1 = new PictureBox();
            label3 = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.SlateBlue;
            label2.Location = new Point(663, 129);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(157, 38);
            label2.TabIndex = 15;
            label2.Text = "Inscription";
            // 
            // showpsw
            // 
            showpsw.AutoSize = true;
            showpsw.Location = new Point(756, 435);
            showpsw.Margin = new Padding(4, 4, 4, 4);
            showpsw.Name = "showpsw";
            showpsw.Size = new Size(230, 29);
            showpsw.TabIndex = 14;
            showpsw.Text = "Afficher le mot de passe";
            showpsw.UseVisualStyleBackColor = true;
            showpsw.CheckedChanged += showpsw_CheckedChanged;
            // 
            // passwordlbl
            // 
            passwordlbl.AutoSize = true;
            passwordlbl.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            passwordlbl.Location = new Point(549, 342);
            passwordlbl.Margin = new Padding(4, 0, 4, 0);
            passwordlbl.Name = "passwordlbl";
            passwordlbl.Size = new Size(149, 28);
            passwordlbl.TabIndex = 13;
            passwordlbl.Text = "Mot de Passe :\r\n";
            // 
            // usernamelbl
            // 
            usernamelbl.AutoSize = true;
            usernamelbl.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            usernamelbl.Location = new Point(548, 192);
            usernamelbl.Margin = new Padding(4, 0, 4, 0);
            usernamelbl.Name = "usernamelbl";
            usernamelbl.Size = new Size(185, 28);
            usernamelbl.TabIndex = 12;
            usernamelbl.Text = "Nom d'utilisateur:";
            // 
            // signupbtn
            // 
            signupbtn.BackColor = Color.SlateBlue;
            signupbtn.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signupbtn.ForeColor = SystemColors.Control;
            signupbtn.Location = new Point(792, 493);
            signupbtn.Margin = new Padding(4, 4, 4, 4);
            signupbtn.Name = "signupbtn";
            signupbtn.Size = new Size(195, 64);
            signupbtn.TabIndex = 11;
            signupbtn.Text = "s'inscrire";
            signupbtn.UseVisualStyleBackColor = false;
            signupbtn.Click += signupbtn_Click;
            signupbtn.MouseEnter += Button_MouseEnter;
            signupbtn.MouseLeave += Button_MouseLeave;
            // 
            // password
            // 
            password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.Location = new Point(549, 371);
            password.Margin = new Padding(4, 4, 4, 4);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(372, 39);
            password.TabIndex = 10;
            // 
            // username
            // 
            username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.Location = new Point(549, 221);
            username.Margin = new Padding(4, 4, 4, 4);
            username.Name = "username";
            username.Size = new Size(372, 39);
            username.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateBlue;
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(signinbtn);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 625);
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(105, 364);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(279, 45);
            label1.TabIndex = 2;
            label1.Text = "Gestion de Stock\r\n";
            // 
            // signinbtn
            // 
            signinbtn.BackColor = Color.Ivory;
            signinbtn.Font = new Font("Segoe UI", 11F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signinbtn.Location = new Point(281, 493);
            signinbtn.Margin = new Padding(4, 4, 4, 4);
            signinbtn.Name = "signinbtn";
            signinbtn.Size = new Size(195, 64);
            signinbtn.TabIndex = 0;
            signinbtn.Text = "se connecter";
            signinbtn.UseVisualStyleBackColor = false;
            signinbtn.Click += signinbtn_Click;
            signinbtn.MouseLeave += Button_MouseLeave;
            // 
            // exit
            // 
            exit.AutoSize = true;
            exit.BackColor = Color.SlateBlue;
            exit.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            exit.ForeColor = Color.Ivory;
            exit.Location = new Point(962, 11);
            exit.Margin = new Padding(4, 0, 4, 0);
            exit.Name = "exit";
            exit.Size = new Size(24, 25);
            exit.TabIndex = 16;
            exit.Text = "X\r\n";
            exit.Click += exit_Click;
            // 
            // maillbl
            // 
            maillbl.AutoSize = true;
            maillbl.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            maillbl.Location = new Point(549, 268);
            maillbl.Margin = new Padding(4, 0, 4, 0);
            maillbl.Name = "maillbl";
            maillbl.Size = new Size(69, 28);
            maillbl.TabIndex = 17;
            maillbl.Text = "Email:";
            // 
            // mail
            // 
            mail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mail.Location = new Point(549, 296);
            mail.Margin = new Padding(4, 4, 4, 4);
            mail.Name = "mail";
            mail.Size = new Size(372, 39);
            mail.TabIndex = 18;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = Properties.Resources.logo1;
            pictureBox1.BackgroundImageLayout = ImageLayout.Zoom;
            pictureBox1.Location = new Point(105, 55);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(288, 277);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(12, 514);
            label3.Name = "label3";
            label3.Size = new Size(235, 25);
            label3.TabIndex = 3;
            label3.Text = "Déjà inscrit ? Se connecter";
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(1000, 625);
            Controls.Add(mail);
            Controls.Add(maillbl);
            Controls.Add(exit);
            Controls.Add(label2);
            Controls.Add(showpsw);
            Controls.Add(passwordlbl);
            Controls.Add(usernamelbl);
            Controls.Add(signupbtn);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4, 4, 4, 4);
            Name = "SignUp";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "SignUp";
            Load += SignUp_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label2;
        private CheckBox showpsw;
        private Label passwordlbl;
        private Label usernamelbl;
        private Button signupbtn;
        private TextBox password;
        private TextBox username;
        private Panel panel1;
        private Label label1;
        private Button signinbtn;
        private Label exit;
        private Label maillbl;
        private TextBox mail;
        private PictureBox pictureBox1;
        private Label label3;
    }
}