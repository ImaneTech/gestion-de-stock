
namespace Gestion_de_stock
{
    partial class HomePage
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
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HomePage));
            panel1 = new Panel();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            sidebartimer = new System.Windows.Forms.Timer(components);
            sidebar = new Panel();
            button6 = new Button();
            panel14 = new Panel();
            button17 = new Button();
            button16 = new Button();
            button18 = new Button();
            panel13 = new Panel();
            panel12 = new Panel();
            button15 = new Button();
            button7 = new Button();
            panel10 = new Panel();
            button14 = new Button();
            button13 = new Button();
            button4 = new Button();
            panel3 = new Panel();
            button12 = new Button();
            button11 = new Button();
            button5 = new Button();
            menuButton = new Button();
            panel1.SuspendLayout();
            sidebar.SuspendLayout();
            panel14.SuspendLayout();
            panel13.SuspendLayout();
            panel12.SuspendLayout();
            panel10.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Right;
            panel1.Location = new Point(995, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(120, 927);
            panel1.TabIndex = 0;
            // 
            // button3
            // 
            button3.BackColor = Color.SlateBlue;
            button3.BackgroundImage = Properties.Resources.maximize;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.SlateBlue;
            button3.Location = new Point(47, 4);
            button3.Name = "button3";
            button3.Size = new Size(30, 30);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.SlateBlue;
            button2.BackgroundImage = Properties.Resources.minimize_sign;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.SlateBlue;
            button2.Location = new Point(11, 4);
            button2.Name = "button2";
            button2.Size = new Size(30, 30);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.SlateBlue;
            button1.BackgroundImage = Properties.Resources.exit;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.SlateBlue;
            button1.Location = new Point(83, 4);
            button1.Name = "button1";
            button1.Size = new Size(30, 30);
            button1.TabIndex = 0;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // sidebartimer
            // 
            sidebartimer.Interval = 5;
            sidebartimer.Tick += button4_Click;
            // 
            // sidebar
            // 
            sidebar.BackColor = Color.SlateBlue;
            sidebar.Controls.Add(button6);
            sidebar.Controls.Add(panel14);
            sidebar.Controls.Add(button18);
            sidebar.Controls.Add(panel13);
            sidebar.Controls.Add(button7);
            sidebar.Controls.Add(panel10);
            sidebar.Controls.Add(button4);
            sidebar.Controls.Add(panel3);
            sidebar.Controls.Add(button5);
            sidebar.Controls.Add(menuButton);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 0);
            sidebar.MaximumSize = new Size(300, 1100);
            sidebar.MinimumSize = new Size(62, 450);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(300, 927);
            sidebar.TabIndex = 2;
            sidebar.Paint += sidebar_Paint_1;
            // 
            // button6
            // 
            button6.AutoSize = true;
            button6.BackColor = Color.DarkSlateBlue;
            button6.BackgroundImageLayout = ImageLayout.Zoom;
            button6.Dock = DockStyle.Top;
            button6.FlatAppearance.BorderSize = 0;
            button6.FlatStyle = FlatStyle.Flat;
            button6.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button6.Image = (Image)resources.GetObject("button6.Image");
            button6.ImageAlign = ContentAlignment.MiddleLeft;
            button6.Location = new Point(0, 850);
            button6.Margin = new Padding(0);
            button6.Name = "button6";
            button6.RightToLeft = RightToLeft.No;
            button6.Size = new Size(300, 75);
            button6.TabIndex = 16;
            button6.Text = "Reports";
            button6.UseVisualStyleBackColor = false;
            // 
            // panel14
            // 
            panel14.Controls.Add(button17);
            panel14.Controls.Add(button16);
            panel14.Dock = DockStyle.Top;
            panel14.Location = new Point(0, 711);
            panel14.Name = "panel14";
            panel14.Size = new Size(300, 139);
            panel14.TabIndex = 14;
            // 
            // button17
            // 
            button17.BackColor = Color.MediumPurple;
            button17.BackgroundImageLayout = ImageLayout.Zoom;
            button17.Dock = DockStyle.Top;
            button17.FlatAppearance.BorderSize = 0;
            button17.FlatStyle = FlatStyle.Flat;
            button17.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button17.Image = (Image)resources.GetObject("button17.Image");
            button17.ImageAlign = ContentAlignment.MiddleLeft;
            button17.Location = new Point(0, 69);
            button17.Name = "button17";
            button17.Padding = new Padding(7, 14, 14, 14);
            button17.RightToLeft = RightToLeft.No;
            button17.Size = new Size(300, 70);
            button17.TabIndex = 13;
            button17.Text = "Ventes";
            button17.UseVisualStyleBackColor = false;
            button17.Click += button17_Click;
            // 
            // button16
            // 
            button16.BackColor = Color.MediumPurple;
            button16.BackgroundImageLayout = ImageLayout.Zoom;
            button16.Dock = DockStyle.Top;
            button16.FlatAppearance.BorderSize = 0;
            button16.FlatStyle = FlatStyle.Flat;
            button16.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button16.Image = (Image)resources.GetObject("button16.Image");
            button16.ImageAlign = ContentAlignment.MiddleLeft;
            button16.Location = new Point(0, 0);
            button16.Margin = new Padding(0);
            button16.Name = "button16";
            button16.Padding = new Padding(7, 14, 14, 14);
            button16.RightToLeft = RightToLeft.No;
            button16.Size = new Size(300, 69);
            button16.TabIndex = 0;
            button16.Text = " Commandes";
            button16.UseVisualStyleBackColor = false;
            // 
            // button18
            // 
            button18.AutoSize = true;
            button18.BackColor = Color.DarkSlateBlue;
            button18.BackgroundImageLayout = ImageLayout.Zoom;
            button18.Dock = DockStyle.Top;
            button18.FlatAppearance.BorderSize = 0;
            button18.FlatStyle = FlatStyle.Flat;
            button18.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button18.Image = (Image)resources.GetObject("button18.Image");
            button18.ImageAlign = ContentAlignment.MiddleLeft;
            button18.Location = new Point(0, 636);
            button18.Margin = new Padding(0);
            button18.Name = "button18";
            button18.RightToLeft = RightToLeft.No;
            button18.Size = new Size(300, 75);
            button18.TabIndex = 15;
            button18.Text = "Orders";
            button18.UseVisualStyleBackColor = false;
            button18.Click += button18_Click;
            // 
            // panel13
            // 
            panel13.Controls.Add(panel12);
            panel13.Dock = DockStyle.Top;
            panel13.Location = new Point(0, 573);
            panel13.Margin = new Padding(0);
            panel13.Name = "panel13";
            panel13.Size = new Size(300, 63);
            panel13.TabIndex = 14;
            // 
            // panel12
            // 
            panel12.Controls.Add(button15);
            panel12.Location = new Point(0, 0);
            panel12.Margin = new Padding(0);
            panel12.Name = "panel12";
            panel12.Size = new Size(300, 61);
            panel12.TabIndex = 12;
            // 
            // button15
            // 
            button15.BackColor = Color.MediumPurple;
            button15.BackgroundImageLayout = ImageLayout.Zoom;
            button15.Dock = DockStyle.Top;
            button15.FlatAppearance.BorderSize = 0;
            button15.FlatStyle = FlatStyle.Flat;
            button15.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button15.Image = (Image)resources.GetObject("button15.Image");
            button15.ImageAlign = ContentAlignment.MiddleLeft;
            button15.Location = new Point(0, 0);
            button15.Margin = new Padding(0);
            button15.Name = "button15";
            button15.Padding = new Padding(7, 14, 14, 14);
            button15.RightToLeft = RightToLeft.No;
            button15.Size = new Size(300, 63);
            button15.TabIndex = 0;
            button15.Text = "Produits";
            button15.UseVisualStyleBackColor = false;
            button15.Click += button15_Click;
            // 
            // button7
            // 
            button7.AutoSize = true;
            button7.BackColor = Color.DarkSlateBlue;
            button7.BackgroundImageLayout = ImageLayout.Zoom;
            button7.Dock = DockStyle.Top;
            button7.FlatAppearance.BorderSize = 0;
            button7.FlatStyle = FlatStyle.Flat;
            button7.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(0, 498);
            button7.Margin = new Padding(0);
            button7.Name = "button7";
            button7.RightToLeft = RightToLeft.No;
            button7.Size = new Size(300, 75);
            button7.TabIndex = 0;
            button7.Text = "Stock";
            button7.UseVisualStyleBackColor = false;
            button7.Click += button7_Click;
            // 
            // panel10
            // 
            panel10.Controls.Add(button14);
            panel10.Controls.Add(button13);
            panel10.Dock = DockStyle.Top;
            panel10.Location = new Point(0, 350);
            panel10.Name = "panel10";
            panel10.Size = new Size(300, 148);
            panel10.TabIndex = 2;
            // 
            // button14
            // 
            button14.BackColor = Color.MediumPurple;
            button14.BackgroundImageLayout = ImageLayout.Zoom;
            button14.Dock = DockStyle.Top;
            button14.FlatAppearance.BorderSize = 0;
            button14.FlatStyle = FlatStyle.Flat;
            button14.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button14.Image = (Image)resources.GetObject("button14.Image");
            button14.ImageAlign = ContentAlignment.MiddleLeft;
            button14.Location = new Point(0, 79);
            button14.Name = "button14";
            button14.Padding = new Padding(7, 14, 14, 14);
            button14.RightToLeft = RightToLeft.No;
            button14.Size = new Size(300, 66);
            button14.TabIndex = 0;
            button14.Text = " Fornisseurs\r\n";
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.MediumPurple;
            button13.BackgroundImageLayout = ImageLayout.Zoom;
            button13.Dock = DockStyle.Top;
            button13.FlatAppearance.BorderSize = 0;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button13.Image = (Image)resources.GetObject("button13.Image");
            button13.ImageAlign = ContentAlignment.MiddleLeft;
            button13.Location = new Point(0, 0);
            button13.Name = "button13";
            button13.Padding = new Padding(7, 14, 14, 14);
            button13.RightToLeft = RightToLeft.No;
            button13.Size = new Size(300, 79);
            button13.TabIndex = 0;
            button13.Text = "Clients";
            button13.UseVisualStyleBackColor = false;
            button13.Click += button13_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.DarkSlateBlue;
            button4.BackgroundImageLayout = ImageLayout.Zoom;
            button4.Dock = DockStyle.Top;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial Rounded MT Bold", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 269);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.RightToLeft = RightToLeft.No;
            button4.Size = new Size(300, 81);
            button4.TabIndex = 0;
            button4.Text = "  Accounts\r\n";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // panel3
            // 
            panel3.Controls.Add(button12);
            panel3.Controls.Add(button11);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 149);
            panel3.Name = "panel3";
            panel3.Size = new Size(300, 120);
            panel3.TabIndex = 1;
            // 
            // button12
            // 
            button12.BackColor = Color.MediumPurple;
            button12.BackgroundImageLayout = ImageLayout.Zoom;
            button12.Dock = DockStyle.Top;
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button12.Image = (Image)resources.GetObject("button12.Image");
            button12.ImageAlign = ContentAlignment.MiddleLeft;
            button12.Location = new Point(0, 59);
            button12.Name = "button12";
            button12.Padding = new Padding(7, 14, 14, 14);
            button12.RightToLeft = RightToLeft.No;
            button12.Size = new Size(300, 61);
            button12.TabIndex = 0;
            button12.Text = "   Modifications\r\n";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button11
            // 
            button11.BackColor = Color.MediumPurple;
            button11.BackgroundImageLayout = ImageLayout.Zoom;
            button11.Dock = DockStyle.Top;
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Arial Rounded MT Bold", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button11.Image = (Image)resources.GetObject("button11.Image");
            button11.ImageAlign = ContentAlignment.MiddleLeft;
            button11.Location = new Point(0, 0);
            button11.Name = "button11";
            button11.Padding = new Padding(7, 14, 14, 14);
            button11.RightToLeft = RightToLeft.No;
            button11.Size = new Size(300, 59);
            button11.TabIndex = 0;
            button11.Text = "Alertes";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click_1;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkSlateBlue;
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.Dock = DockStyle.Top;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(0, 76);
            button5.Name = "button5";
            button5.Padding = new Padding(7, 14, 14, 14);
            button5.RightToLeft = RightToLeft.No;
            button5.Size = new Size(300, 73);
            button5.TabIndex = 0;
            button5.Text = "Home";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // menuButton
            // 
            menuButton.BackColor = Color.DarkSlateBlue;
            menuButton.BackgroundImageLayout = ImageLayout.Zoom;
            menuButton.Dock = DockStyle.Top;
            menuButton.FlatAppearance.BorderSize = 0;
            menuButton.FlatStyle = FlatStyle.Flat;
            menuButton.Font = new Font("Arial Rounded MT Bold", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuButton.Image = (Image)resources.GetObject("menuButton.Image");
            menuButton.ImageAlign = ContentAlignment.MiddleLeft;
            menuButton.Location = new Point(0, 0);
            menuButton.MaximumSize = new Size(300, 76);
            menuButton.Name = "menuButton";
            menuButton.Padding = new Padding(7, 14, 14, 14);
            menuButton.RightToLeft = RightToLeft.No;
            menuButton.Size = new Size(300, 76);
            menuButton.TabIndex = 0;
            menuButton.Text = "Menu";
            menuButton.UseVisualStyleBackColor = false;
            menuButton.Click += menuButton_Click;
            // 
            // HomePage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.Ivory;
            ClientSize = new Size(1115, 927);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "HomePage";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += HomePage_Load;
            panel1.ResumeLayout(false);
            sidebar.ResumeLayout(false);
            sidebar.PerformLayout();
            panel14.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel12.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panel3.ResumeLayout(false);
            ResumeLayout(false);
        }



        #endregion

        private Panel panel1;
        private Button button1;
        private Button button2;
        private Button button3;
        private System.Windows.Forms.Timer sidebartimer;
        private Panel sidebar;
        private Button menuButton;
        private Button button5;
        private Button button7;
        private Button button11;
        private Button button12;
        private Button button4;
        private Button button16;
        private Panel panel12;
        private Button button15;
        private Panel panel3;
        private Panel panel10;
        private Button button14;
        private Button button13;
        private Panel panel13;
        private Button button17;
        private Button button18;
        private Panel panel14;
        private Button button6;
    }
}