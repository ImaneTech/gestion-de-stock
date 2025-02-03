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
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // IDPERSONNE
            // 
            IDPERSONNE.AutoSize = true;
            IDPERSONNE.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IDPERSONNE.Location = new Point(67, 33);
            IDPERSONNE.Margin = new Padding(4, 0, 4, 0);
            IDPERSONNE.Name = "IDPERSONNE";
            IDPERSONNE.Size = new Size(94, 30);
            IDPERSONNE.TabIndex = 1;
            IDPERSONNE.Text = "ID Client";
            IDPERSONNE.Click += IDPERSONNE_Click;
            // 
            // DATEFACTURE
            // 
            DATEFACTURE.AutoSize = true;
            DATEFACTURE.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DATEFACTURE.Location = new Point(67, 86);
            DATEFACTURE.Margin = new Padding(4, 0, 4, 0);
            DATEFACTURE.Name = "DATEFACTURE";
            DATEFACTURE.Size = new Size(134, 30);
            DATEFACTURE.TabIndex = 3;
            DATEFACTURE.Text = "Date Facture";
            DATEFACTURE.Click += DATEFACTURE_Click;
            // 
            // STATU
            // 
            STATU.AutoSize = true;
            STATU.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            STATU.Location = new Point(67, 139);
            STATU.Margin = new Padding(4, 0, 4, 0);
            STATU.Name = "STATU";
            STATU.Size = new Size(70, 30);
            STATU.TabIndex = 4;
            STATU.Text = "Statut";
            STATU.Click += STATU_Click;
            // 
            // buttonAjouter
            // 
            buttonAjouter.BackColor = Color.SlateBlue;
            buttonAjouter.FlatStyle = FlatStyle.Flat;
            buttonAjouter.Font = new Font("Arial Rounded MT Bold", 10F);
            buttonAjouter.Location = new Point(673, 222);
            buttonAjouter.Margin = new Padding(4);
            buttonAjouter.Name = "buttonAjouter";
            buttonAjouter.Size = new Size(147, 54);
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
            buttonQuitter.Location = new Point(840, 222);
            buttonQuitter.Margin = new Padding(4);
            buttonQuitter.Name = "buttonQuitter";
            buttonQuitter.Size = new Size(134, 54);
            buttonQuitter.TabIndex = 13;
            buttonQuitter.Text = "Effacer";
            buttonQuitter.UseVisualStyleBackColor = false;
            buttonQuitter.Click += buttonQuitter_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(checkNONPAYEE);
            panel1.Controls.Add(checkPAYEE);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(buttonQuitter);
            panel1.Controls.Add(buttonAjouter);
            panel1.Controls.Add(STATU);
            panel1.Controls.Add(DATEFACTURE);
            panel1.Controls.Add(IDPERSONNE);
            panel1.Location = new Point(36, 58);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(1002, 297);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // checkNONPAYEE
            // 
            checkNONPAYEE.AutoSize = true;
            checkNONPAYEE.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkNONPAYEE.Location = new Point(409, 139);
            checkNONPAYEE.Name = "checkNONPAYEE";
            checkNONPAYEE.Size = new Size(135, 32);
            checkNONPAYEE.TabIndex = 16;
            checkNONPAYEE.TabStop = true;
            checkNONPAYEE.Text = "non payée";
            checkNONPAYEE.UseVisualStyleBackColor = true;
            // 
            // checkPAYEE
            // 
            checkPAYEE.AutoSize = true;
            checkPAYEE.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkPAYEE.Location = new Point(236, 137);
            checkPAYEE.Name = "checkPAYEE";
            checkPAYEE.Size = new Size(93, 32);
            checkPAYEE.TabIndex = 15;
            checkPAYEE.TabStop = true;
            checkPAYEE.Text = "payée";
            checkPAYEE.UseVisualStyleBackColor = true;
            checkPAYEE.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(236, 33);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(308, 33);
            comboBox1.TabIndex = 14;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(236, 84);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(308, 31);
            dateTimePicker1.TabIndex = 14;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(36, 474);
            dataGridView1.Margin = new Padding(4);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(1002, 357);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(385, 22);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(211, 28);
            label2.TabIndex = 0;
            label2.Text = "liste des factures";
            label2.Click += label2_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SlateBlue;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(36, 404);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(1002, 72);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // FactureVenteForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1066, 956);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Margin = new Padding(4);
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
    }
}