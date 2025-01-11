namespace Gestion_de_stock
{
    partial class ProduitForm
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
            button1 = new Button();
            button2 = new Button();
            button5 = new Button();
            button3 = new Button();
            button4 = new Button();
            panel2 = new Panel();
            txtPrix = new TextBox();
            label12 = new Label();
            label11 = new Label();
            txtDescription = new TextBox();
            QteMin = new Label();
            QteMax = new Label();
            txtQteMin = new TextBox();
            txtQteMax = new TextBox();
            txtQteStock = new TextBox();
            label10 = new Label();
            label8 = new Label();
            txtNom = new TextBox();
            label6 = new Label();
            txtId = new TextBox();
            label5 = new Label();
            label4 = new Label();
            panel3 = new Panel();
            label1 = new Label();
            panel5 = new Panel();
            label3 = new Label();
            panel6 = new Panel();
            dataGridView1 = new DataGridView();
            comboBox1 = new ComboBox();
            panel2.SuspendLayout();
            panel3.SuspendLayout();
            panel5.SuspendLayout();
            panel6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // button1
            // 
            button1.BackColor = Color.MediumPurple;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(671, 232);
            button1.Name = "button1";
            button1.Size = new Size(170, 59);
            button1.TabIndex = 0;
            button1.Text = "Ajouter";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.BackColor = Color.MediumPurple;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button2.Location = new Point(197, 346);
            button2.Name = "button2";
            button2.Size = new Size(194, 59);
            button2.TabIndex = 1;
            button2.Text = "Supprimer";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button5
            // 
            button5.BackColor = Color.MediumPurple;
            button5.FlatStyle = FlatStyle.Flat;
            button5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button5.Location = new Point(584, 346);
            button5.Name = "button5";
            button5.Size = new Size(194, 59);
            button5.TabIndex = 9;
            button5.Text = "Chercher";
            button5.UseVisualStyleBackColor = false;
            button5.Click += button5_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.MediumPurple;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button3.Location = new Point(855, 232);
            button3.Name = "button3";
            button3.Size = new Size(176, 59);
            button3.TabIndex = 3;
            button3.Text = "Effacer";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.MediumPurple;
            button4.FlatStyle = FlatStyle.Flat;
            button4.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button4.Location = new Point(397, 346);
            button4.Name = "button4";
            button4.Size = new Size(181, 59);
            button4.TabIndex = 2;
            button4.Text = "Mettre à jour";
            button4.UseVisualStyleBackColor = false;
            button4.Click += button4_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(192, 192, 255);
            panel2.Controls.Add(comboBox1);
            panel2.Controls.Add(txtPrix);
            panel2.Controls.Add(label12);
            panel2.Controls.Add(button3);
            panel2.Controls.Add(label11);
            panel2.Controls.Add(txtDescription);
            panel2.Controls.Add(QteMin);
            panel2.Controls.Add(button1);
            panel2.Controls.Add(QteMax);
            panel2.Controls.Add(txtQteMin);
            panel2.Controls.Add(txtQteMax);
            panel2.Controls.Add(txtQteStock);
            panel2.Controls.Add(label10);
            panel2.Controls.Add(label8);
            panel2.Controls.Add(txtNom);
            panel2.Controls.Add(label6);
            panel2.Controls.Add(txtId);
            panel2.Controls.Add(label5);
            panel2.Controls.Add(label4);
            panel2.Location = new Point(12, 39);
            panel2.Name = "panel2";
            panel2.Size = new Size(1042, 301);
            panel2.TabIndex = 3;
            panel2.Paint += panel2_Paint;
            // 
            // txtPrix
            // 
            txtPrix.Location = new Point(165, 178);
            txtPrix.Name = "txtPrix";
            txtPrix.Size = new Size(246, 31);
            txtPrix.TabIndex = 18;
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label12.Location = new Point(27, 181);
            label12.Name = "label12";
            label12.Size = new Size(59, 28);
            label12.TabIndex = 17;
            label12.Text = "Prix";
            label12.Click += label12_Click;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(509, 178);
            label11.Name = "label11";
            label11.Size = new Size(147, 28);
            label11.TabIndex = 16;
            label11.Text = "Description";
            label11.Click += label11_Click;
            // 
            // txtDescription
            // 
            txtDescription.Location = new Point(783, 181);
            txtDescription.Name = "txtDescription";
            txtDescription.Size = new Size(246, 31);
            txtDescription.TabIndex = 15;
            // 
            // QteMin
            // 
            QteMin.AutoSize = true;
            QteMin.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            QteMin.Location = new Point(439, 141);
            QteMin.Name = "QteMin";
            QteMin.Size = new Size(321, 28);
            QteMin.TabIndex = 14;
            QteMin.Text = "quantite de stock minimale";
            QteMin.Click += label9_Click_1;
            // 
            // QteMax
            // 
            QteMax.AutoSize = true;
            QteMax.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            QteMax.Location = new Point(439, 104);
            QteMax.Name = "QteMax";
            QteMax.Size = new Size(327, 28);
            QteMax.TabIndex = 13;
            QteMax.Text = "quantite de stock maximale";
            QteMax.Click += label7_Click;
            // 
            // txtQteMin
            // 
            txtQteMin.Location = new Point(783, 141);
            txtQteMin.Name = "txtQteMin";
            txtQteMin.Size = new Size(248, 31);
            txtQteMin.TabIndex = 12;
            // 
            // txtQteMax
            // 
            txtQteMax.Location = new Point(783, 101);
            txtQteMax.Name = "txtQteMax";
            txtQteMax.Size = new Size(246, 31);
            txtQteMax.TabIndex = 10;
            // 
            // txtQteStock
            // 
            txtQteStock.Location = new Point(783, 64);
            txtQteStock.Name = "txtQteStock";
            txtQteStock.Size = new Size(246, 31);
            txtQteStock.TabIndex = 8;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label10.Location = new Point(509, 67);
            label10.Name = "label10";
            label10.Size = new Size(210, 28);
            label10.TabIndex = 7;
            label10.Text = "quantite de stock";
            label10.Click += label10_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(18, 141);
            label8.Name = "label8";
            label8.Size = new Size(127, 28);
            label8.TabIndex = 5;
            label8.Text = "Categorie";
            // 
            // txtNom
            // 
            txtNom.Location = new Point(165, 101);
            txtNom.Name = "txtNom";
            txtNom.Size = new Size(246, 31);
            txtNom.TabIndex = 4;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(18, 104);
            label6.Name = "label6";
            label6.Size = new Size(65, 28);
            label6.TabIndex = 3;
            label6.Text = "Nom";
            label6.Click += label6_Click;
            // 
            // txtId
            // 
            txtId.Location = new Point(165, 64);
            txtId.Name = "txtId";
            txtId.Size = new Size(246, 31);
            txtId.TabIndex = 2;
            txtId.TextChanged += textBox1_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(18, 67);
            label5.Name = "label5";
            label5.Size = new Size(38, 28);
            label5.TabIndex = 1;
            label5.Text = "ID";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(0, 0);
            label4.Name = "label4";
            label4.Size = new Size(59, 25);
            label4.TabIndex = 0;
            label4.Text = "label4";
            // 
            // panel3
            // 
            panel3.BackColor = Color.SlateBlue;
            panel3.Controls.Add(label1);
            panel3.Location = new Point(12, 39);
            panel3.Name = "panel3";
            panel3.Size = new Size(1039, 51);
            panel3.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(18, 13);
            label1.Name = "label1";
            label1.Size = new Size(135, 28);
            label1.TabIndex = 0;
            label1.Text = "Proprietes";
            label1.Click += label1_Click;
            // 
            // panel5
            // 
            panel5.BackColor = Color.SlateBlue;
            panel5.Controls.Add(label3);
            panel5.Location = new Point(9, 421);
            panel5.Name = "panel5";
            panel5.Size = new Size(1042, 50);
            panel5.TabIndex = 4;
            panel5.Paint += panel5_Paint;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(18, 13);
            label3.Name = "label3";
            label3.Size = new Size(215, 28);
            label3.TabIndex = 0;
            label3.Text = "Liste de Produits:";
            label3.Click += label3_Click;
            // 
            // panel6
            // 
            panel6.BackColor = Color.FromArgb(192, 192, 255);
            panel6.Controls.Add(dataGridView1);
            panel6.Location = new Point(9, 421);
            panel6.Name = "panel6";
            panel6.Size = new Size(1042, 502);
            panel6.TabIndex = 5;
            panel6.Paint += panel6_Paint;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 47);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 62;
            dataGridView1.Size = new Size(1039, 455);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Smartphones", "", "Ordinateurs", "", "Téléviseurs", "", "Accessoires", "", "Périphériques", "", "Tablettes", "", "Montres Connectées", "", "Imprimantes", "", "Stockage", "", "Audio", "", "Sécurité", "", "Consoles", "", "Réseaux", "", "Composants" });
            comboBox1.Location = new Point(165, 136);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(246, 33);
            comboBox1.TabIndex = 19;
            // 
            // ProduitForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Ivory;
            ClientSize = new Size(1066, 947);
            Controls.Add(button5);
            Controls.Add(panel5);
            Controls.Add(panel6);
            Controls.Add(button4);
            Controls.Add(panel3);
            Controls.Add(button2);
            Controls.Add(panel2);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProduitForm";
            Text = "ProduitForm";
            Load += ProduitForm_Load;
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            panel6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Button button1;
        private Button button2;
        private Button button3;
        private Button button4;
        private Panel panel2;
        private Panel panel3;
        private Label label1;
        private Panel panel5;
        private Label label3;
        private Panel panel6;
        private DataGridView dataGridView1;
        private TextBox txtNom;
        private Label label6;
        private TextBox txtId;
        private Label label5;
        private Label label4;
        private Label label8;
        private Button button5;
        private TextBox txtQteMin;
        private TextBox txtQteMax;
        private TextBox txtQteStock;
        private Label label10;
        private Label QteMin;
        private Label QteMax;
        private Label label11;
        private TextBox txtDescription;
        private TextBox txtPrix;
        private Label label12;
        private ComboBox comboBox1;
    }
}