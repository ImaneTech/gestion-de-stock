namespace Gestion_de_stock
{
    partial class VenteForm
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
            panel1 = new Panel();
            panel2 = new Panel();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            panel3 = new Panel();
            button3 = new Button();
            buttonConfirmer = new Button();
            panel4 = new Panel();
            button2 = new Button();
            button1 = new Button();
            textBox1 = new TextBox();
            comboBox2 = new ComboBox();
            comboBox1 = new ComboBox();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label1 = new Label();
            dataGridView2 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel3.SuspendLayout();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(panel2);
            panel1.Controls.Add(dataGridView1);
            panel1.Location = new Point(107, 528);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(826, 395);
            panel1.TabIndex = 1;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SlateBlue;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(0, 0);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(826, 64);
            panel2.TabIndex = 4;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(19, 12);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(275, 32);
            label2.TabIndex = 0;
            label2.Text = "Historique des ventes :";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 62);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(826, 333);
            dataGridView1.TabIndex = 3;
            // 
            // panel3
            // 
            panel3.BackColor = Color.Silver;
            panel3.Controls.Add(button3);
            panel3.Controls.Add(buttonConfirmer);
            panel3.Location = new Point(292, 413);
            panel3.Margin = new Padding(4);
            panel3.Name = "panel3";
            panel3.Size = new Size(459, 95);
            panel3.TabIndex = 8;
            // 
            // button3
            // 
            button3.BackColor = Color.SlateBlue;
            button3.FlatStyle = FlatStyle.Flat;
            button3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button3.Location = new Point(260, 24);
            button3.Margin = new Padding(4);
            button3.Name = "button3";
            button3.Size = new Size(123, 49);
            button3.TabIndex = 2;
            button3.Text = "Annuler";
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // buttonConfirmer
            // 
            buttonConfirmer.BackColor = Color.SlateBlue;
            buttonConfirmer.FlatStyle = FlatStyle.Flat;
            buttonConfirmer.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonConfirmer.Location = new Point(49, 24);
            buttonConfirmer.Margin = new Padding(4);
            buttonConfirmer.Name = "buttonConfirmer";
            buttonConfirmer.Size = new Size(148, 49);
            buttonConfirmer.TabIndex = 1;
            buttonConfirmer.Text = "Confirmer";
            buttonConfirmer.UseVisualStyleBackColor = false;
            buttonConfirmer.Click += button2_Click;
            // 
            // panel4
            // 
            panel4.BackColor = Color.Silver;
            panel4.Controls.Add(button2);
            panel4.Controls.Add(button1);
            panel4.Controls.Add(textBox1);
            panel4.Controls.Add(comboBox2);
            panel4.Controls.Add(comboBox1);
            panel4.Controls.Add(label5);
            panel4.Controls.Add(label4);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label1);
            panel4.Location = new Point(26, 32);
            panel4.Margin = new Padding(4);
            panel4.Name = "panel4";
            panel4.Size = new Size(502, 342);
            panel4.TabIndex = 9;
            // 
            // button2
            // 
            button2.BackColor = Color.SlateBlue;
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(336, 274);
            button2.Margin = new Padding(4);
            button2.Name = "button2";
            button2.Size = new Size(148, 49);
            button2.TabIndex = 16;
            button2.Text = "Effacer";
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click_1;
            // 
            // button1
            // 
            button1.BackColor = Color.SlateBlue;
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(180, 274);
            button1.Margin = new Padding(4);
            button1.Name = "button1";
            button1.Size = new Size(148, 49);
            button1.TabIndex = 15;
            button1.Text = "Ajouter";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(155, 214);
            textBox1.Margin = new Padding(4);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(252, 31);
            textBox1.TabIndex = 14;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(155, 152);
            comboBox2.Margin = new Padding(4);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(252, 33);
            comboBox2.TabIndex = 13;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(155, 89);
            comboBox1.Margin = new Padding(4);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(252, 33);
            comboBox1.TabIndex = 12;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(21, 215);
            label5.Margin = new Padding(4, 0, 4, 0);
            label5.Name = "label5";
            label5.Size = new Size(107, 30);
            label5.TabIndex = 11;
            label5.Text = "Quantite :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(21, 152);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(116, 30);
            label4.TabIndex = 10;
            label4.Text = "Produit ID:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(21, 89);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(99, 30);
            label3.TabIndex = 9;
            label3.Text = "Client ID:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(49, 11);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(223, 32);
            label1.TabIndex = 8;
            label1.Text = "Vente Formulaire :\r\n";
            // 
            // dataGridView2
            // 
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(536, 32);
            dataGridView2.Margin = new Padding(4);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.RowHeadersWidth = 51;
            dataGridView2.Size = new Size(501, 342);
            dataGridView2.TabIndex = 10;
            // 
            // VenteForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.GhostWhite;
            ClientSize = new Size(1066, 956);
            Controls.Add(dataGridView2);
            Controls.Add(panel4);
            Controls.Add(panel3);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
            Name = "VenteForm";
            Text = "VenteForm";
            Load += VenteForm_Load;
            panel1.ResumeLayout(false);
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel3.ResumeLayout(false);
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Panel panel1;
        private Panel panel2;
        private Label label2;
        private DataGridView dataGridView1;
        private Panel panel3;
        private Panel panel4;
        private Button button3;
        private Button buttonConfirmer;
        private TextBox textBox1;
        private ComboBox comboBox2;
        private ComboBox comboBox1;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label1;
        private DataGridView dataGridView2;
        private Button button1;
        private Button buttonViderPanier_Click;
        private Button button2;
    }
}