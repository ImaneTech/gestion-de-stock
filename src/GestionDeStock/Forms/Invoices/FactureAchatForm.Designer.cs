namespace Gestion_de_stock
{
    partial class FactureAchatForm
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
            montant = new TextBox();
            label1 = new Label();
            checkNONPAYEE = new RadioButton();
            comboBox1 = new ComboBox();
            checkPAYEE = new RadioButton();
            dateTimePicker1 = new DateTimePicker();
            buttonQuitter = new Button();
            buttonAjouter = new Button();
            STATUS = new Label();
            DATEFACTURE = new Label();
            IDPERSONNE = new Label();
            panel2 = new Panel();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Silver;
            panel1.Controls.Add(montant);
            panel1.Controls.Add(label1);
            panel1.Controls.Add(checkNONPAYEE);
            panel1.Controls.Add(comboBox1);
            panel1.Controls.Add(checkPAYEE);
            panel1.Controls.Add(dateTimePicker1);
            panel1.Controls.Add(buttonQuitter);
            panel1.Controls.Add(buttonAjouter);
            panel1.Controls.Add(STATUS);
            panel1.Controls.Add(DATEFACTURE);
            panel1.Controls.Add(IDPERSONNE);
            panel1.Location = new Point(35, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(786, 238);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // montant
            // 
            montant.Location = new Point(165, 129);
            montant.Name = "montant";
            montant.Size = new Size(241, 27);
            montant.TabIndex = 20;
            montant.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(39, 134);
            label1.Name = "label1";
            label1.Size = new Size(66, 17);
            label1.TabIndex = 19;
            label1.Text = "Montant";
            label1.Click += label1_Click_1;
            // 
            // checkNONPAYEE
            // 
            checkNONPAYEE.AutoSize = true;
            checkNONPAYEE.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkNONPAYEE.Location = new Point(284, 169);
            checkNONPAYEE.Margin = new Padding(2);
            checkNONPAYEE.Name = "checkNONPAYEE";
            checkNONPAYEE.Size = new Size(113, 27);
            checkNONPAYEE.TabIndex = 18;
            checkNONPAYEE.TabStop = true;
            checkNONPAYEE.Text = "non payée";
            checkNONPAYEE.UseVisualStyleBackColor = true;
            checkNONPAYEE.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(165, 38);
            comboBox1.Margin = new Padding(2);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(241, 28);
            comboBox1.TabIndex = 14;
            // 
            // checkPAYEE
            // 
            checkPAYEE.AutoSize = true;
            checkPAYEE.Font = new Font("Segoe UI", 10F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkPAYEE.Location = new Point(156, 165);
            checkPAYEE.Margin = new Padding(2);
            checkPAYEE.Name = "checkPAYEE";
            checkPAYEE.Size = new Size(78, 27);
            checkPAYEE.TabIndex = 17;
            checkPAYEE.TabStop = true;
            checkPAYEE.Text = "payée";
            checkPAYEE.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(165, 83);
            dateTimePicker1.Margin = new Padding(2);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(241, 27);
            dateTimePicker1.TabIndex = 13;
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // buttonQuitter
            // 
            buttonQuitter.BackColor = Color.SlateBlue;
            buttonQuitter.FlatStyle = FlatStyle.Flat;
            buttonQuitter.Font = new Font("Arial Rounded MT Bold", 9F);
            buttonQuitter.Location = new Point(666, 175);
            buttonQuitter.Name = "buttonQuitter";
            buttonQuitter.Size = new Size(94, 46);
            buttonQuitter.TabIndex = 12;
            buttonQuitter.Text = "Effacer";
            buttonQuitter.UseVisualStyleBackColor = false;
            buttonQuitter.Click += buttonQuitter_Click;
            // 
            // buttonAjouter
            // 
            buttonAjouter.BackColor = Color.SlateBlue;
            buttonAjouter.FlatStyle = FlatStyle.Flat;
            buttonAjouter.Font = new Font("Arial Rounded MT Bold", 9F);
            buttonAjouter.ForeColor = SystemColors.ActiveCaptionText;
            buttonAjouter.Location = new Point(534, 175);
            buttonAjouter.Name = "buttonAjouter";
            buttonAjouter.Size = new Size(107, 46);
            buttonAjouter.TabIndex = 9;
            buttonAjouter.Text = "Confirmer";
            buttonAjouter.UseVisualStyleBackColor = false;
            buttonAjouter.Click += buttonAjouter_Click;
            // 
            // STATUS
            // 
            STATUS.AutoSize = true;
            STATUS.Font = new Font("Arial Rounded MT Bold", 9F);
            STATUS.Location = new Point(38, 175);
            STATUS.Name = "STATUS";
            STATUS.Size = new Size(51, 17);
            STATUS.TabIndex = 3;
            STATUS.Text = "Statut";
            STATUS.Click += STATUS_Click;
            // 
            // DATEFACTURE
            // 
            DATEFACTURE.AutoSize = true;
            DATEFACTURE.Font = new Font("Arial Rounded MT Bold", 9F);
            DATEFACTURE.Location = new Point(38, 84);
            DATEFACTURE.Name = "DATEFACTURE";
            DATEFACTURE.Size = new Size(103, 17);
            DATEFACTURE.TabIndex = 2;
            DATEFACTURE.Text = "Date Facture";
            DATEFACTURE.Click += DATEFACTURE_Click;
            // 
            // IDPERSONNE
            // 
            IDPERSONNE.AutoSize = true;
            IDPERSONNE.Font = new Font("Arial Rounded MT Bold", 9F);
            IDPERSONNE.Location = new Point(38, 49);
            IDPERSONNE.Name = "IDPERSONNE";
            IDPERSONNE.Size = new Size(107, 17);
            IDPERSONNE.TabIndex = 1;
            IDPERSONNE.Text = "ID Fornisseur";
            IDPERSONNE.Click += IDPERSONNE_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.SlateBlue;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(23, 334);
            panel2.Name = "panel2";
            panel2.Size = new Size(798, 58);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Arial Rounded MT Bold", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ActiveCaptionText;
            label2.Location = new Point(305, 19);
            label2.Name = "label2";
            label2.Size = new Size(190, 23);
            label2.TabIndex = 0;
            label2.Text = "Liste des Factures";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(23, 392);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(798, 270);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FactureAchatForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(853, 765);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FactureAchatForm";
            Text = "FactureAchatForm";
            Load += FactureAchatForm_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Label STATUS;
        private Label DATEFACTURE;
        private Label IDPERSONNE;
        private Button buttonAjouter;
        private Button buttonQuitter;
        private Panel panel2;
        private Label label2;
        private DataGridView dataGridView1;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private RadioButton checkNONPAYEE;
        private RadioButton checkPAYEE;
        private Label label1;
        private TextBox montant;
    }
}