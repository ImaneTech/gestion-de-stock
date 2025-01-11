namespace Gestion_de_stock
{
    partial class LoginForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            username = new TextBox();
            password = new TextBox();
            loginbtn = new Button();
            signbtn = new Button();
            panel1 = new Panel();
            label1 = new Label();
            pictureBox1 = new PictureBox();
            usernamelbl = new Label();
            passwordlbl = new Label();
            showpsw = new CheckBox();
            label2 = new Label();
            exit = new Label();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // username
            // 
            username.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            username.Location = new Point(549, 272);
            username.Margin = new Padding(4);
            username.Name = "username";
            username.Size = new Size(372, 39);
            username.TabIndex = 1;
            // 
            // password
            // 
            password.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            password.Location = new Point(549, 365);
            password.Margin = new Padding(4);
            password.Name = "password";
            password.PasswordChar = '*';
            password.Size = new Size(372, 39);
            password.TabIndex = 2;
            password.TextChanged += textBox2_TextChanged;
            // 
            // loginbtn
            // 
            loginbtn.BackColor = Color.SlateBlue;
            loginbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            loginbtn.ForeColor = SystemColors.Control;
            loginbtn.Location = new Point(549, 484);
            loginbtn.Margin = new Padding(4);
            loginbtn.Name = "loginbtn";
            loginbtn.Size = new Size(195, 64);
            loginbtn.TabIndex = 3;
            loginbtn.Text = "LOG IN\r\n";
            loginbtn.UseVisualStyleBackColor = false;
            loginbtn.Click += button1_Click;
            loginbtn.MouseEnter += Button_MouseEnter;
            loginbtn.MouseLeave += Button_MouseLeave;
            // 
            // signbtn
            // 
            signbtn.BackColor = Color.Ivory;
            signbtn.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            signbtn.Location = new Point(159, 484);
            signbtn.Margin = new Padding(4);
            signbtn.Name = "signbtn";
            signbtn.Size = new Size(195, 64);
            signbtn.TabIndex = 0;
            signbtn.Text = "SIGN UP\r\n";
            signbtn.UseVisualStyleBackColor = false;
            signbtn.Click += signbtn_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(pictureBox1);
            panel1.Controls.Add(signbtn);
            panel1.ForeColor = Color.Black;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(500, 625);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(109, 345);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(279, 45);
            label1.TabIndex = 2;
            label1.Text = "Gestion de Stock\r\n";
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.device;
            pictureBox1.Location = new Point(188, 175);
            pictureBox1.Margin = new Padding(4);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(125, 125);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // usernamelbl
            // 
            usernamelbl.AutoSize = true;
            usernamelbl.Location = new Point(549, 244);
            usernamelbl.Margin = new Padding(4, 0, 4, 0);
            usernamelbl.Name = "usernamelbl";
            usernamelbl.Size = new Size(113, 25);
            usernamelbl.TabIndex = 4;
            usernamelbl.Text = "USERNAME :";
            // 
            // passwordlbl
            // 
            passwordlbl.AutoSize = true;
            passwordlbl.Location = new Point(548, 336);
            passwordlbl.Margin = new Padding(4, 0, 4, 0);
            passwordlbl.Name = "passwordlbl";
            passwordlbl.Size = new Size(117, 25);
            passwordlbl.TabIndex = 5;
            passwordlbl.Text = "PASSWORD :\r\n";
            // 
            // showpsw
            // 
            showpsw.AutoSize = true;
            showpsw.Location = new Point(756, 429);
            showpsw.Margin = new Padding(4);
            showpsw.Name = "showpsw";
            showpsw.Size = new Size(162, 29);
            showpsw.TabIndex = 6;
            showpsw.Text = "Show Password";
            showpsw.UseVisualStyleBackColor = true;
            showpsw.CheckedChanged += showpsw_CheckedChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(548, 156);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(214, 38);
            label2.TabIndex = 7;
            label2.Text = "Login  Account";
           // label2.Click += label2_Click;
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
            exit.TabIndex = 8;
            exit.Text = "X\r\n";
            exit.Click += exit_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(1000, 625);
            Controls.Add(exit);
            Controls.Add(label2);
            Controls.Add(showpsw);
            Controls.Add(passwordlbl);
            Controls.Add(usernamelbl);
            Controls.Add(loginbtn);
            Controls.Add(password);
            Controls.Add(username);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "LoginForm";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private TextBox username;
        private TextBox password;
        private Button loginbtn;
        private Button signbtn;
        private Panel panel1;
        private PictureBox pictureBox1;
        private Label usernamelbl;
        private Label passwordlbl;
        private Label label1;
        private CheckBox showpsw;
        private Label label2;
        private Label exit;
    }
}
