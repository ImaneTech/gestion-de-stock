
namespace Gestion_de_stock
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            panel1 = new Panel();
            label1 = new Label();
            button3 = new Button();
            button2 = new Button();
            button1 = new Button();
            sidebartimer = new System.Windows.Forms.Timer(components);
            sidebar = new Panel();
            button10 = new Button();
            panel2 = new Panel();
            button11 = new Button();
            button12 = new Button();
            button9 = new Button();
            button8 = new Button();
            panel14 = new Panel();
            button17 = new Button();
            button16 = new Button();
            button18 = new Button();
            panel13 = new Panel();
            button15 = new Button();
            button7 = new Button();
            panel10 = new Panel();
            button14 = new Button();
            button13 = new Button();
            button4 = new Button();
            button5 = new Button();
            menuButton = new Button();
            panelchildForm = new Panel();
            label2 = new Label();
            pictureBox1 = new PictureBox();
            panel1.SuspendLayout();
            sidebar.SuspendLayout();
            panel2.SuspendLayout();
            panel14.SuspendLayout();
            panel13.SuspendLayout();
            panel10.SuspendLayout();
            panelchildForm.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.SlateBlue;
            panel1.Controls.Add(label1);
            panel1.Controls.Add(button3);
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Dock = DockStyle.Top;
            panel1.Location = new Point(0, 0);
            panel1.Margin = new Padding(2);
            panel1.Name = "panel1";
            panel1.Size = new Size(1093, 42);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(10, 7);
            label1.Margin = new Padding(2, 0, 2, 0);
            label1.Name = "label1";
            label1.Size = new Size(414, 29);
            label1.TabIndex = 0;
            label1.Text = "ELECTROSTORE - Gestion de Stock";
            // 
            // button3
            // 
            button3.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button3.BackColor = Color.SlateBlue;
            button3.BackgroundImage = Properties.Resources.maximize;
            button3.BackgroundImageLayout = ImageLayout.Stretch;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.SlateBlue;
            button3.Location = new Point(1030, 10);
            button3.Margin = new Padding(2);
            button3.Name = "button3";
            button3.Size = new Size(24, 24);
            button3.TabIndex = 2;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button2
            // 
            button2.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button2.BackColor = Color.SlateBlue;
            button2.BackgroundImage = Properties.Resources.minimize_sign;
            button2.BackgroundImageLayout = ImageLayout.Stretch;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.SlateBlue;
            button2.Location = new Point(1002, 10);
            button2.Margin = new Padding(2);
            button2.Name = "button2";
            button2.Size = new Size(24, 24);
            button2.TabIndex = 1;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            button1.BackColor = Color.SlateBlue;
            button1.BackgroundImage = Properties.Resources.exit;
            button1.BackgroundImageLayout = ImageLayout.Stretch;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.SlateBlue;
            button1.Location = new Point(1059, 10);
            button1.Margin = new Padding(2);
            button1.Name = "button1";
            button1.Size = new Size(24, 24);
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
            sidebar.Controls.Add(button10);
            sidebar.Controls.Add(panel2);
            sidebar.Controls.Add(button9);
            sidebar.Controls.Add(button8);
            sidebar.Controls.Add(panel14);
            sidebar.Controls.Add(button18);
            sidebar.Controls.Add(panel13);
            sidebar.Controls.Add(button7);
            sidebar.Controls.Add(panel10);
            sidebar.Controls.Add(button4);
            sidebar.Controls.Add(button5);
            sidebar.Controls.Add(menuButton);
            sidebar.Dock = DockStyle.Left;
            sidebar.Location = new Point(0, 42);
            sidebar.Margin = new Padding(2);
            sidebar.MaximumSize = new Size(240, 880);
            sidebar.MinimumSize = new Size(50, 360);
            sidebar.Name = "sidebar";
            sidebar.Size = new Size(240, 765);
            sidebar.TabIndex = 2;
            sidebar.Paint += sidebar_Paint_1;
            // 
            // button10
            // 
            button10.AutoSize = true;
            button10.BackColor = Color.DarkSlateBlue;
            button10.BackgroundImageLayout = ImageLayout.Zoom;
            button10.Dock = DockStyle.Top;
            button10.FlatAppearance.BorderSize = 0;
            button10.FlatStyle = FlatStyle.Flat;
            button10.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button10.Image = (Image)resources.GetObject("button10.Image");
            button10.ImageAlign = ContentAlignment.MiddleLeft;
            button10.Location = new Point(0, 688);
            button10.Margin = new Padding(0);
            button10.Name = "button10";
            button10.RightToLeft = RightToLeft.No;
            button10.Size = new Size(240, 60);
            button10.TabIndex = 19;
            button10.Text = "Rapports";
            button10.UseVisualStyleBackColor = false;
            button10.Click += button10_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(button11);
            panel2.Controls.Add(button12);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 594);
            panel2.Margin = new Padding(2);
            panel2.Name = "panel2";
            panel2.Size = new Size(240, 94);
            panel2.TabIndex = 18;
            // 
            // button11
            // 
            button11.BackColor = Color.SlateBlue;
            button11.BackgroundImageLayout = ImageLayout.Zoom;
            button11.Dock = DockStyle.Top;
            button11.FlatAppearance.BorderSize = 0;
            button11.FlatStyle = FlatStyle.Flat;
            button11.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button11.Image = (Image)resources.GetObject("button11.Image");
            button11.ImageAlign = ContentAlignment.MiddleLeft;
            button11.Location = new Point(0, 46);
            button11.Margin = new Padding(2);
            button11.Name = "button11";
            button11.Padding = new Padding(6, 11, 11, 11);
            button11.RightToLeft = RightToLeft.No;
            button11.Size = new Size(240, 47);
            button11.TabIndex = 0;
            button11.Text = "Factures d'achat";
            button11.UseVisualStyleBackColor = false;
            button11.Click += button11_Click_1;
            // 
            // button12
            // 
            button12.BackColor = Color.SlateBlue;
            button12.BackgroundImageLayout = ImageLayout.Zoom;
            button12.Dock = DockStyle.Top;
            button12.FlatAppearance.BorderSize = 0;
            button12.FlatStyle = FlatStyle.Flat;
            button12.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button12.Image = (Image)resources.GetObject("button12.Image");
            button12.ImageAlign = ContentAlignment.MiddleLeft;
            button12.Location = new Point(0, 0);
            button12.Margin = new Padding(2);
            button12.Name = "button12";
            button12.Padding = new Padding(6, 11, 11, 11);
            button12.RightToLeft = RightToLeft.No;
            button12.Size = new Size(240, 46);
            button12.TabIndex = 0;
            button12.Text = " Factures de vente";
            button12.UseVisualStyleBackColor = false;
            button12.Click += button12_Click;
            // 
            // button9
            // 
            button9.AutoSize = true;
            button9.BackColor = Color.DarkSlateBlue;
            button9.BackgroundImageLayout = ImageLayout.Zoom;
            button9.Dock = DockStyle.Top;
            button9.FlatAppearance.BorderSize = 0;
            button9.FlatStyle = FlatStyle.Flat;
            button9.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button9.Image = (Image)resources.GetObject("button9.Image");
            button9.ImageAlign = ContentAlignment.MiddleLeft;
            button9.Location = new Point(0, 534);
            button9.Margin = new Padding(0);
            button9.Name = "button9";
            button9.RightToLeft = RightToLeft.No;
            button9.Size = new Size(240, 60);
            button9.TabIndex = 17;
            button9.Text = "Factures";
            button9.UseVisualStyleBackColor = false;
            button9.Click += button9_Click;
            // 
            // button8
            // 
            button8.AutoSize = true;
            button8.BackColor = Color.DarkSlateBlue;
            button8.BackgroundImageLayout = ImageLayout.Zoom;
            button8.Dock = DockStyle.Bottom;
            button8.FlatAppearance.BorderSize = 0;
            button8.FlatStyle = FlatStyle.Flat;
            button8.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button8.Image = (Image)resources.GetObject("button8.Image");
            button8.ImageAlign = ContentAlignment.MiddleLeft;
            button8.Location = new Point(0, 705);
            button8.Margin = new Padding(0);
            button8.Name = "button8";
            button8.RightToLeft = RightToLeft.No;
            button8.Size = new Size(240, 60);
            button8.TabIndex = 17;
            button8.Text = "Deconexion";
            button8.UseVisualStyleBackColor = false;
            button8.Click += button8_Click_1;
            // 
            // panel14
            // 
            panel14.Controls.Add(button17);
            panel14.Controls.Add(button16);
            panel14.Dock = DockStyle.Top;
            panel14.Location = new Point(0, 437);
            panel14.Margin = new Padding(2);
            panel14.Name = "panel14";
            panel14.Size = new Size(240, 97);
            panel14.TabIndex = 14;
            panel14.Paint += panel14_Paint;
            // 
            // button17
            // 
            button17.BackColor = Color.SlateBlue;
            button17.BackgroundImageLayout = ImageLayout.Zoom;
            button17.Dock = DockStyle.Top;
            button17.FlatAppearance.BorderSize = 0;
            button17.FlatStyle = FlatStyle.Flat;
            button17.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button17.Image = (Image)resources.GetObject("button17.Image");
            button17.ImageAlign = ContentAlignment.MiddleLeft;
            button17.Location = new Point(0, 49);
            button17.Margin = new Padding(2);
            button17.Name = "button17";
            button17.Padding = new Padding(6, 11, 11, 11);
            button17.RightToLeft = RightToLeft.No;
            button17.Size = new Size(240, 50);
            button17.TabIndex = 13;
            button17.Text = "Achat";
            button17.UseVisualStyleBackColor = false;
            button17.Click += button17_Click;
            // 
            // button16
            // 
            button16.BackColor = Color.SlateBlue;
            button16.BackgroundImageLayout = ImageLayout.Zoom;
            button16.Dock = DockStyle.Top;
            button16.FlatAppearance.BorderSize = 0;
            button16.FlatStyle = FlatStyle.Flat;
            button16.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button16.Image = (Image)resources.GetObject("button16.Image");
            button16.ImageAlign = ContentAlignment.MiddleLeft;
            button16.Location = new Point(0, 0);
            button16.Margin = new Padding(0);
            button16.Name = "button16";
            button16.Padding = new Padding(6, 11, 11, 11);
            button16.RightToLeft = RightToLeft.No;
            button16.Size = new Size(240, 49);
            button16.TabIndex = 0;
            button16.Text = "Vente";
            button16.UseVisualStyleBackColor = false;
            button16.Click += button16_Click;
            // 
            // button18
            // 
            button18.AutoSize = true;
            button18.BackColor = Color.DarkSlateBlue;
            button18.BackgroundImageLayout = ImageLayout.Zoom;
            button18.Dock = DockStyle.Top;
            button18.FlatAppearance.BorderSize = 0;
            button18.FlatStyle = FlatStyle.Flat;
            button18.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button18.Image = (Image)resources.GetObject("button18.Image");
            button18.ImageAlign = ContentAlignment.MiddleLeft;
            button18.Location = new Point(0, 379);
            button18.Margin = new Padding(0);
            button18.Name = "button18";
            button18.RightToLeft = RightToLeft.No;
            button18.Size = new Size(240, 58);
            button18.TabIndex = 15;
            button18.Text = "Transactions";
            button18.UseVisualStyleBackColor = false;
            button18.Click += button18_Click;
            // 
            // panel13
            // 
            panel13.Controls.Add(button15);
            panel13.Dock = DockStyle.Top;
            panel13.Location = new Point(0, 329);
            panel13.Margin = new Padding(0);
            panel13.Name = "panel13";
            panel13.Size = new Size(240, 50);
            panel13.TabIndex = 14;
            // 
            // button15
            // 
            button15.BackColor = Color.SlateBlue;
            button15.BackgroundImageLayout = ImageLayout.Zoom;
            button15.Dock = DockStyle.Top;
            button15.FlatAppearance.BorderSize = 0;
            button15.FlatStyle = FlatStyle.Flat;
            button15.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button15.Image = (Image)resources.GetObject("button15.Image");
            button15.ImageAlign = ContentAlignment.MiddleLeft;
            button15.Location = new Point(0, 0);
            button15.Margin = new Padding(0);
            button15.Name = "button15";
            button15.Padding = new Padding(6, 11, 11, 11);
            button15.RightToLeft = RightToLeft.No;
            button15.Size = new Size(240, 50);
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
            button7.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button7.Image = (Image)resources.GetObject("button7.Image");
            button7.ImageAlign = ContentAlignment.MiddleLeft;
            button7.Location = new Point(0, 280);
            button7.Margin = new Padding(0);
            button7.Name = "button7";
            button7.RightToLeft = RightToLeft.No;
            button7.Size = new Size(240, 49);
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
            panel10.Location = new Point(0, 162);
            panel10.Margin = new Padding(2);
            panel10.Name = "panel10";
            panel10.Size = new Size(240, 118);
            panel10.TabIndex = 2;
            // 
            // button14
            // 
            button14.BackColor = Color.SlateBlue;
            button14.BackgroundImageLayout = ImageLayout.Zoom;
            button14.Dock = DockStyle.Top;
            button14.FlatAppearance.BorderSize = 0;
            button14.FlatStyle = FlatStyle.Flat;
            button14.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button14.Image = (Image)resources.GetObject("button14.Image");
            button14.ImageAlign = ContentAlignment.MiddleLeft;
            button14.Location = new Point(0, 58);
            button14.Margin = new Padding(2);
            button14.Name = "button14";
            button14.Padding = new Padding(6, 11, 11, 11);
            button14.RightToLeft = RightToLeft.No;
            button14.Size = new Size(240, 58);
            button14.TabIndex = 0;
            button14.Text = " Fornisseurs\r\n";
            button14.UseVisualStyleBackColor = false;
            button14.Click += button14_Click;
            // 
            // button13
            // 
            button13.BackColor = Color.SlateBlue;
            button13.BackgroundImageLayout = ImageLayout.Zoom;
            button13.Dock = DockStyle.Top;
            button13.FlatAppearance.BorderSize = 0;
            button13.FlatStyle = FlatStyle.Flat;
            button13.Font = new Font("Microsoft Sans Serif", 11F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button13.Image = (Image)resources.GetObject("button13.Image");
            button13.ImageAlign = ContentAlignment.MiddleLeft;
            button13.Location = new Point(0, 0);
            button13.Margin = new Padding(2);
            button13.Name = "button13";
            button13.Padding = new Padding(6, 11, 11, 11);
            button13.RightToLeft = RightToLeft.No;
            button13.Size = new Size(240, 58);
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
            button4.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Image = (Image)resources.GetObject("button4.Image");
            button4.ImageAlign = ContentAlignment.MiddleLeft;
            button4.Location = new Point(0, 110);
            button4.Margin = new Padding(0);
            button4.Name = "button4";
            button4.RightToLeft = RightToLeft.No;
            button4.Size = new Size(240, 52);
            button4.TabIndex = 0;
            button4.Text = "Comptes";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click_1;
            // 
            // button5
            // 
            button5.BackColor = Color.DarkSlateBlue;
            button5.BackgroundImageLayout = ImageLayout.Zoom;
            button5.Dock = DockStyle.Top;
            button5.FlatAppearance.BorderSize = 0;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Image = (Image)resources.GetObject("button5.Image");
            button5.ImageAlign = ContentAlignment.MiddleLeft;
            button5.Location = new Point(0, 56);
            button5.Margin = new Padding(2);
            button5.Name = "button5";
            button5.Padding = new Padding(6, 11, 11, 11);
            button5.RightToLeft = RightToLeft.No;
            button5.Size = new Size(240, 54);
            button5.TabIndex = 0;
            button5.Text = "Accueil";
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
            menuButton.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Point, 0);
            menuButton.Image = (Image)resources.GetObject("menuButton.Image");
            menuButton.ImageAlign = ContentAlignment.MiddleLeft;
            menuButton.Location = new Point(0, 0);
            menuButton.Margin = new Padding(2);
            menuButton.MaximumSize = new Size(240, 61);
            menuButton.Name = "menuButton";
            menuButton.Padding = new Padding(6, 11, 11, 11);
            menuButton.RightToLeft = RightToLeft.No;
            menuButton.Size = new Size(240, 56);
            menuButton.TabIndex = 0;
            menuButton.Text = "Menu";
            menuButton.UseVisualStyleBackColor = false;
            menuButton.Click += menuButton_Click;
            // 
            // panelchildForm
            // 
            panelchildForm.BackColor = Color.FromArgb(192, 192, 255);
            panelchildForm.BackgroundImageLayout = ImageLayout.Center;
            panelchildForm.Controls.Add(label2);
            panelchildForm.Controls.Add(pictureBox1);
            panelchildForm.Dock = DockStyle.Fill;
            panelchildForm.Location = new Point(240, 42);
            panelchildForm.Margin = new Padding(2);
            panelchildForm.Name = "panelchildForm";
            panelchildForm.Size = new Size(853, 765);
            panelchildForm.TabIndex = 3;
            panelchildForm.Paint += panel2_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Microsoft Sans Serif", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(50, 90);
            label2.Margin = new Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new Size(511, 36);
            label2.TabIndex = 1;
            label2.Text = "Bienvenue ! Bonne journée de travail.";
            label2.Click += label2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(82, 140);
            pictureBox1.Margin = new Padding(2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(703, 568);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            AutoScroll = true;
            AutoSize = true;
            BackColor = Color.Ivory;
            ClientSize = new Size(1093, 807);
            Controls.Add(panelchildForm);
            Controls.Add(sidebar);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(2);
            Name = "MainForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += HomePage_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            sidebar.ResumeLayout(false);
            sidebar.PerformLayout();
            panel2.ResumeLayout(false);
            panel14.ResumeLayout(false);
            panel13.ResumeLayout(false);
            panel10.ResumeLayout(false);
            panelchildForm.ResumeLayout(false);
            panelchildForm.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private Button button4;
        private Button button16;
        private Panel panel10;
        private Button button14;
        private Button button13;
        private Button button17;
        private Button button18;
        private Panel panel14;
        private Panel panel13;
        private Button button15;
        private Button button8;
        private Panel panelchildForm;
        private Label label1;
        private Button button9;
        private Button button10;
        private Panel panel2;
        private Button button11;
        private Button button12;
        private PictureBox pictureBox1;
        private Label label2;
    }
}