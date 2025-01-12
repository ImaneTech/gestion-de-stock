namespace Gestion_de_stock
{
    partial class FournisseurForm
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
            panel2 = new Panel();
            dataGridView1 = new DataGridView();
            panel5 = new Panel();
            button5 = new Button();
            button4 = new Button();
            button3 = new Button();
            panel4 = new Panel();
            label6 = new Label();
            panel1 = new Panel();
            button2 = new Button();
            button1 = new Button();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            Email = new TextBox();
            Tele = new TextBox();
            Adresse = new TextBox();
            Nom = new TextBox();
            panel3 = new Panel();
            label5 = new Label();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel5.SuspendLayout();
            panel4.SuspendLayout();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel2
            // 
            panel2.Controls.Add(dataGridView1);
            panel2.Controls.Add(panel5);
            panel2.Controls.Add(panel4);
            panel2.Location = new Point(389, 137);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(664, 658);
            panel2.TabIndex = 3;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 49);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(664, 470);
            dataGridView1.TabIndex = 2;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // panel5
            // 
            panel5.BackColor = Color.SlateGray;
            panel5.Controls.Add(button5);
            panel5.Controls.Add(button4);
            panel5.Controls.Add(button3);
            panel5.Location = new Point(0, 518);
            panel5.Margin = new Padding(4);
            panel5.Name = "panel5";
            panel5.Size = new Size(664, 140);
            panel5.TabIndex = 1;
            // 
            // button5
            // 
            button5.BackColor = Color.Silver;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button5.Location = new Point(462, 48);
            button5.Margin = new Padding(4);
            button5.Name = "button5";
            button5.Size = new Size(125, 56);
            button5.TabIndex = 2;
            button5.Text = "Chercher";
            button5.UseVisualStyleBackColor = false;
            // 
            // button4
            // 
            button4.BackColor = Color.Silver;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button4.Location = new Point(229, 48);
            button4.Margin = new Padding(4);
            button4.Name = "button4";
            button4.Size = new Size(191, 56);
            button4.TabIndex = 1;
            button4.Text = "Mettre à Jour";
            button4.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.Silver;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI", 7.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(68, 48);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(125, 56);
            button3.TabIndex = 0;
            button3.Text = "Supprimer";
            button3.UseVisualStyleBackColor = false;
            // 
            // panel4
            // 
            panel4.BackColor = Color.SlateGray;
            panel4.Controls.Add(label6);
            panel4.Location = new Point(0, 0);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(664, 51);
            panel4.TabIndex = 0;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.Location = new Point(14, 10);
            label6.Margin = new Padding(4, 0, 4, 0);
            label6.Name = "label6";
            label6.Size = new Size(139, 30);
            label6.TabIndex = 0;
            label6.Text = "Fournisseur :";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(button2);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(label4);
            panel1.Controls.Add(label3);
            panel1.Controls.Add(label2);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(Email);
            panel1.Controls.Add(Tele);
            panel1.Controls.Add(Adresse);
            panel1.Controls.Add(Nom);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(20, 137);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(350, 658);
            panel1.TabIndex = 2;
            // 
            // button2
            // 
            button2.BackColor = Color.Silver;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(192, 545);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(125, 56);
            button2.TabIndex = 10;
            button2.Text = "Effacer";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button1
            // 
            button1.BackColor = Color.Silver;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(40, 545);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(125, 56);
            button1.TabIndex = 9;
            button1.Text = "Ajouter";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(44, 422);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(74, 30);
            label4.TabIndex = 8;
            label4.Text = "Email :";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(44, 312);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(119, 30);
            label3.TabIndex = 7;
            label3.Text = "Téléphone :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(40, 209);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(97, 30);
            label2.TabIndex = 6;
            label2.Text = "Adresse :";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(40, 100);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(70, 30);
            label1.TabIndex = 5;
            label1.Text = "Nom :";
            // 
            // Email
            // 
            Email.Location = new Point(40, 465);
            Email.Margin = new Padding(4);
            Email.Multiline = true;
            Email.Name = "Email";
            Email.Size = new Size(280, 43);
            Email.TabIndex = 4;
            // 
            // Tele
            // 
            Tele.Location = new Point(44, 359);
            Tele.Margin = new Padding(4);
            Tele.Multiline = true;
            Tele.Name = "Tele";
            Tele.Size = new Size(276, 43);
            Tele.TabIndex = 3;
            // 
            // Adresse
            // 
            Adresse.Location = new Point(44, 254);
            Adresse.Margin = new Padding(4);
            Adresse.Multiline = true;
            Adresse.Name = "Adresse";
            Adresse.Size = new Size(276, 43);
            Adresse.TabIndex = 2;
            // 
            // Nom
            // 
            Nom.BackColor = SystemColors.Window;
            Nom.Location = new Point(40, 144);
            Nom.Margin = new Padding(4);
            Nom.Multiline = true;
            Nom.Name = "Nom";
            Nom.Size = new Size(276, 43);
            Nom.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BackColor = Color.SlateGray;
            panel3.Controls.Add(label5);
            panel3.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel3.Location = new Point(0, 0);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(350, 51);
            panel3.TabIndex = 0;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(15, 10);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(153, 30);
            label5.TabIndex = 0;
            label5.Text = "Informations :";
            // 
            // FournisseurForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 947);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "FournisseurForm";
            Text = "FournisseurForm";
            Load += FournisseurForm_Load;
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel5.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel2;
        private DataGridView dataGridView1;
        private Panel panel5;
        private Button button5;
        private Button button4;
        private Button button3;
        private Panel panel4;
        private Label label6;
        private Panel panel1;
        private Button button2;
        private Button button1;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox Email;
        private TextBox Tele;
        private TextBox Adresse;
        private TextBox Nom;
        private Panel panel3;
        private Label label5;
    }
}