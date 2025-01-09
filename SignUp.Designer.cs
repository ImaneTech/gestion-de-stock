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
            pictureBox1 = new PictureBox();
            signinbtn = new Button();
            exit = new Label();
            maillbl = new Label();
            mail = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(438, 102);
            label2.Name = "label2";
            label2.Size = new Size(183, 31);
            label2.TabIndex = 15;
            label2.Text = "Create  Account";
            // 
            // showpsw
            // 
            showpsw.AutoSize = true;
            showpsw.Location = new Point(605, 348);
            showpsw.Name = "showpsw";
            showpsw.Size = new Size(132, 24);
            showpsw.TabIndex = 14;
            showpsw.Text = "Show Password";
            showpsw.UseVisualStyleBackColor = true;
            showpsw.CheckedChanged += showpsw_CheckedChanged;
            // 
            // passwordlbl
            // 
            passwordlbl.AutoSize = true;
            passwordlbl.Location = new Point(439, 274);
            passwordlbl.Name = "passwordlbl";
            passwordlbl.Size = new Size(94, 20);
            passwordlbl.TabIndex = 13;
            passwordlbl.Text = "PASSWORD :\r\n";
            // 
            // usernamelbl
            // 
            usernamelbl.AutoSize = true;
            usernamelbl.Location = new Point(438, 154);
            usernamelbl.Name = "usernamelbl";
            usernamelbl.Size = new Size(93, 20);
            usernamelbl.TabIndex = 12;
            usernamelbl.Text = "USERNAME :";
            // 
            // signupbtn
            // 
            signupbtn.BackColor = Color.SlateBlue;
            signupbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signupbtn.ForeColor = SystemColors.Control;
            signupbtn.Location = new Point(438, 387);
            signupbtn.Name = "signupbtn";
            signupbtn.Size = new Size(156, 51);
            signupbtn.TabIndex = 11;
            signupbtn.Text = "SIGN UP";
            signupbtn.UseVisualStyleBackColor = false;
            signupbtn.Click += signupbtn_Click;
            signupbtn.MouseEnter += Button_MouseEnter;
            signupbtn.MouseLeave += Button_MouseLeave;
            // 
            // password
            // 
            password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.Location = new Point(439, 297);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(298, 34);
            password.TabIndex = 10;
            // 
            // username
            // 
            username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.Location = new Point(439, 177);
            username.Name = "username";
            username.Size = new Size(298, 34);
            username.TabIndex = 9;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(signinbtn);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(400, 500);
            panel1.TabIndex = 8;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(87, 276);
            label1.Name = "label1";
            label1.Size = new Size(237, 38);
            label1.TabIndex = 2;
            label1.Text = "Gestion de Stock\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.device;
            pictureBox1.Location = new Point(150, 140);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(100, 100);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // signinbtn
            // 
            signinbtn.BackColor = Color.Ivory;
            signinbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signinbtn.Location = new Point(127, 387);
            signinbtn.Name = "signinbtn";
            signinbtn.Size = new Size(156, 51);
            signinbtn.TabIndex = 0;
            signinbtn.Text = "SIGN IN\r\n";
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
            exit.Location = new Point(770, 9);
            exit.Name = "exit";
            exit.Size = new Size(19, 20);
            exit.TabIndex = 16;
            exit.Text = "X\r\n";
            exit.Click += exit_Click;
            // 
            // maillbl
            // 
            maillbl.AutoSize = true;
            maillbl.Location = new Point(439, 214);
            maillbl.Name = "maillbl";
            maillbl.Size = new Size(50, 20);
            maillbl.TabIndex = 17;
            maillbl.Text = "MAIL :";
            // 
            // mail
            // 
            mail.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            mail.Location = new Point(439, 237);
            mail.Name = "mail";
            mail.Size = new Size(298, 34);
            mail.TabIndex = 18;
            // 
            // SignUp
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(800, 500);
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
        private PictureBox pictureBox1;
        private Button signinbtn;
        private Label exit;
        private Label maillbl;
        private TextBox mail;
    }
}