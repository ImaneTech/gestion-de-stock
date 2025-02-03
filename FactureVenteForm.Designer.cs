namespace Gestion_de_stock
{
    partial class FactureVenteForm
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
            IDPERSONNE = new Label();
            DATEFACTURE = new Label();
            STATU = new Label();
            buttonAjouter = new Button();
            buttonQuitter = new Button();
            panel1 = new Panel();
            checkNONPAYEE = new RadioButton();
            checkPAYEE = new RadioButton();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            dataGridView1 = new DataGridView();
            label2 = new Label();
            panel2 = new Panel();
            label1 = new Label();
            montant = new TextBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // IDPERSONNE
            // 
            IDPERSONNE.AutoSize = true;
            IDPERSONNE.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IDPERSONNE.Location = new Point(54, 26);
            IDPERSONNE.Name = "IDPERSONNE";
            IDPERSONNE.Size = new Size(76, 23);
            IDPERSONNE.TabIndex = 1;
            IDPERSONNE.Text = "ID Client";
            IDPERSONNE.Click += IDPERSONNE_Click;
            // 
            // DATEFACTURE
            // 
            DATEFACTURE.AutoSize = true;
            DATEFACTURE.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DATEFACTURE.Location = new Point(54, 69);
            DATEFACTURE.Name = "DATEFACTURE";
            DATEFACTURE.Size = new Size(107, 23);
            DATEFACTURE.TabIndex = 3;
            DATEFACTURE.Text = "Date Facture";
            DATEFACTURE.Click += DATEFACTURE_Click;
            // 
            // STATU
            // 
            STATU.AutoSize = true;
            STATU.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            STATU.Location = new Point(54, 157);
            STATU.Name = "STATU";
            STATU.Size = new Size(56, 23);
            STATU.TabIndex = 4;
            STATU.Text = "Statut";
            STATU.Click += STATU_Click;
            // 
            // buttonAjouter
            // 
            buttonAjouter.BackColor = Color.SlateBlue;
            buttonAjouter.FlatStyle = FlatStyle.Flat;
            buttonAjouter.Font = new Font("Arial Rounded MT Bold", 10F);
            buttonAjouter.Location = new Point(538, 178);
            buttonAjouter.Name = "buttonAjouter";
            buttonAjouter.Size = new Size(118, 43);
            buttonAjouter.TabIndex = 10;
            buttonAjouter.Text = "Confirmer";
            buttonAjouter.UseVisualStyleBackColor = false;
            buttonAjouter.Click += buttonAjouter_Click;
            // 
            // buttonQuitter
            // 
            buttonQuitter.BackColor = Color.SlateBlue;
            buttonQuitter.FlatStyle = FlatStyle.Flat;
            buttonQuitter.Font = new Font("Arial Rounded MT Bold", 10F);
            buttonQuitter.Location = new Point(672, 178);
            buttonQuitter.Name = "buttonQuitter";
            buttonQuitter.Size = new Size(107, 43);
            buttonQuitter.TabIndex = 13;
            buttonQuitter.Text = "Effacer";
            buttonQuitter.UseVisualStyleBackColor = false;
            buttonQuitter.Click += buttonQuitter_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(montant);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(checkNONPAYEE);
            panel1.Controls.Add(checkPAYEE);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(buttonQuitter);
            panel1.Controls.Add(buttonAjouter);
            panel1.Controls.Add(STATU);
            panel1.Controls.Add(DATEFACTURE);
            panel1.Controls.Add(IDPERSONNE);
            panel1.Location = new Point(29, 46);
            panel1.Name = "panel1";
            panel1.Size = new Size(802, 238);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // checkNONPAYEE
            // 
            checkNONPAYEE.AutoSize = true;
            checkNONPAYEE.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkNONPAYEE.Location = new Point(323, 153);
            checkNONPAYEE.Margin = new Padding(2, 2, 2, 2);
            checkNONPAYEE.Name = "checkNONPAYEE";
            checkNONPAYEE.Size = new Size(113, 27);
            checkNONPAYEE.TabIndex = 16;
            checkNONPAYEE.TabStop = true;
            checkNONPAYEE.Text = "non payée";
            checkNONPAYEE.UseVisualStyleBackColor = true;
            // 
            // checkPAYEE
            // 
            checkPAYEE.AutoSize = true;
            checkPAYEE.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkPAYEE.Location = new Point(189, 153);
            checkPAYEE.Margin = new Padding(2, 2, 2, 2);
            checkPAYEE.Name = "checkPAYEE";
            checkPAYEE.Size = new Size(78, 27);
            checkPAYEE.TabIndex = 15;
            checkPAYEE.TabStop = true;
            checkPAYEE.Text = "payée";
            checkPAYEE.UseVisualStyleBackColor = true;
            checkPAYEE.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(189, 26);
            comboBox1.Margin = new Padding(2, 2, 2, 2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(247, 28);
            comboBox1.TabIndex = 14;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(189, 67);
            dateTimePicker1.Margin = new Padding(2, 2, 2, 2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(247, 27);
            dateTimePicker1.TabIndex = 14;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(29, 379);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(802, 286);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(308, 18);
            label2.Name = "label2";
            label2.Size = new Size(178, 23);
            label2.TabIndex = 0;
            label2.Text = "liste des factures";
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SlateBlue;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(29, 323);
            panel2.Name = "panel2";
            panel2.Size = new Size(802, 58);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(54, 113);
            label1.Name = "label1";
            label1.Size = new Size(66, 17);
            label1.TabIndex = 17;
            label1.Text = "Montant";
            label1.Click += label1_Click_1;
            // 
            // montant
            // 
            montant.Location = new Point(189, 113);
            montant.Name = "montant";
            montant.Size = new Size(247, 27);
            montant.TabIndex = 18;
            montant.TextChanged += montant_TextChanged;
            // 
            // FactureVenteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 765);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FactureVenteForm";
            Text = "FactureVenteForm";
            Load += FactureVenteForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label IDPERSONNE;
        private Label DATEFACTURE;
        private Label STATU;
        private Button buttonAjouter;
        private Button buttonQuitter;
        private Panel panel1;
        private DataGridView dataGridView1;
        private Label label2;
        private Panel panel2;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private RadioButton checkPAYEE;
        private RadioButton checkNONPAYEE;
        private TextBox montant;
        private Label label1;
    }
}