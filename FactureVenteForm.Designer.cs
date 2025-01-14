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
            label1 = new Label();
            IDPERSONNE = new Label();
            IDFACTURE = new Label();
            DATEFACTURE = new Label();
            panel1 = new Panel();
            buttonQuitter = new Button();
            buttonModifier = new Button();
            buttonSupprimer = new Button();
            buttonAjouter = new Button();
            textIDPERSONNE = new TextBox();
            textDATE = new TextBox();
            textIDFACTURE = new TextBox();
            checkPAYEE = new CheckBox();
            checkNONPAYEE = new CheckBox();
            STATU = new Label();
            panel2 = new Panel();
            label2 = new Label();
            dataGridView1 = new DataGridView();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("SimSun", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(0, 0, 192);
            label1.Location = new Point(266, 20);
            label1.Name = "label1";
            label1.Size = new Size(283, 23);
            label1.TabIndex = 0;
            label1.Text = "LES FACTURES DE VENTE";
            label1.Click += label1_Click;
            // 
            // IDPERSONNE
            // 
            IDPERSONNE.AutoSize = true;
            IDPERSONNE.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IDPERSONNE.Location = new Point(28, 89);
            IDPERSONNE.Name = "IDPERSONNE";
            IDPERSONNE.Size = new Size(119, 23);
            IDPERSONNE.TabIndex = 1;
            IDPERSONNE.Text = "ID PERSONNE";
            IDPERSONNE.Click += IDPERSONNE_Click;
            // 
            // IDFACTURE
            // 
            IDFACTURE.AutoSize = true;
            IDFACTURE.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IDFACTURE.Location = new Point(28, 20);
            IDFACTURE.Name = "IDFACTURE";
            IDFACTURE.Size = new Size(103, 23);
            IDFACTURE.TabIndex = 2;
            IDFACTURE.Text = "ID FACTURE";
            IDFACTURE.Click += label3_Click;
            // 
            // DATEFACTURE
            // 
            DATEFACTURE.AutoSize = true;
            DATEFACTURE.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DATEFACTURE.Location = new Point(483, 23);
            DATEFACTURE.Name = "DATEFACTURE";
            DATEFACTURE.Size = new Size(126, 23);
            DATEFACTURE.TabIndex = 3;
            DATEFACTURE.Text = "DATE FACTURE";
            DATEFACTURE.Click += DATEFACTURE_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(buttonQuitter);
            panel1.Controls.Add(buttonModifier);
            panel1.Controls.Add(buttonSupprimer);
            panel1.Controls.Add(buttonAjouter);
            panel1.Controls.Add(textIDPERSONNE);
            panel1.Controls.Add(textDATE);
            panel1.Controls.Add(textIDFACTURE);
            panel1.Controls.Add(checkPAYEE);
            panel1.Controls.Add(checkNONPAYEE);
            panel1.Controls.Add(STATU);
            panel1.Controls.Add(IDFACTURE);
            panel1.Controls.Add(DATEFACTURE);
            panel1.Controls.Add(IDPERSONNE);
            panel1.Location = new Point(2, 62);
            panel1.Name = "panel1";
            panel1.Size = new Size(796, 197);
            panel1.TabIndex = 4;
            panel1.Paint += panel1_Paint;
            // 
            // buttonQuitter
            // 
            buttonQuitter.BackColor = SystemColors.ControlDarkDark;
            buttonQuitter.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonQuitter.Location = new Point(556, 144);
            buttonQuitter.Name = "buttonQuitter";
            buttonQuitter.Size = new Size(94, 43);
            buttonQuitter.TabIndex = 13;
            buttonQuitter.Text = "Quitter";
            buttonQuitter.UseVisualStyleBackColor = false;
            buttonQuitter.Click += buttonQuitter_Click;
            // 
            // buttonModifier
            // 
            buttonModifier.BackColor = SystemColors.ControlDarkDark;
            buttonModifier.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            buttonModifier.Location = new Point(373, 144);
            buttonModifier.Name = "buttonModifier";
            buttonModifier.Size = new Size(94, 43);
            buttonModifier.TabIndex = 12;
            buttonModifier.Text = "Modifier";
            buttonModifier.UseVisualStyleBackColor = false;
            buttonModifier.Click += buttonModifier_Click;
            // 
            // buttonSupprimer
            // 
            buttonSupprimer.BackColor = SystemColors.ControlDarkDark;
            buttonSupprimer.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSupprimer.Location = new Point(210, 144);
            buttonSupprimer.Name = "buttonSupprimer";
            buttonSupprimer.Size = new Size(113, 43);
            buttonSupprimer.TabIndex = 11;
            buttonSupprimer.Text = "Supprimer";
            buttonSupprimer.UseVisualStyleBackColor = false;
            buttonSupprimer.Click += button2_Click;
            // 
            // buttonAjouter
            // 
            buttonAjouter.BackColor = SystemColors.ControlDarkDark;
            buttonAjouter.Font = new Font("Segoe UI Semibold", 10.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAjouter.Location = new Point(53, 144);
            buttonAjouter.Name = "buttonAjouter";
            buttonAjouter.Size = new Size(94, 43);
            buttonAjouter.TabIndex = 10;
            buttonAjouter.Text = "Ajouter";
            buttonAjouter.UseVisualStyleBackColor = false;
            buttonAjouter.Click += buttonAjouter_Click;
            // 
            // textIDPERSONNE
            // 
            textIDPERSONNE.Location = new Point(163, 89);
            textIDPERSONNE.Name = "textIDPERSONNE";
            textIDPERSONNE.Size = new Size(125, 27);
            textIDPERSONNE.TabIndex = 9;
            textIDPERSONNE.TextChanged += textIDPERSONNE_TextChanged;
            // 
            // textDATE
            // 
            textDATE.Location = new Point(615, 20);
            textDATE.Name = "textDATE";
            textDATE.Size = new Size(125, 27);
            textDATE.TabIndex = 8;
            textDATE.TextChanged += textBox2_TextChanged;
            // 
            // textIDFACTURE
            // 
            textIDFACTURE.Location = new Point(163, 19);
            textIDFACTURE.Name = "textIDFACTURE";
            textIDFACTURE.Size = new Size(125, 27);
            textIDFACTURE.TabIndex = 7;
            textIDFACTURE.TextChanged += textIDFACTURE_TextChanged;
            // 
            // checkPAYEE
            // 
            checkPAYEE.AutoSize = true;
            checkPAYEE.Font = new Font("Sylfaen", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkPAYEE.Location = new Point(577, 93);
            checkPAYEE.Name = "checkPAYEE";
            checkPAYEE.Size = new Size(73, 23);
            checkPAYEE.TabIndex = 6;
            checkPAYEE.Text = "payee";
            checkPAYEE.UseVisualStyleBackColor = true;
            checkPAYEE.CheckedChanged += checkPAYEE_CheckedChanged;
            // 
            // checkNONPAYEE
            // 
            checkNONPAYEE.AutoSize = true;
            checkNONPAYEE.Font = new Font("Sylfaen", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkNONPAYEE.Location = new Point(656, 93);
            checkNONPAYEE.Name = "checkNONPAYEE";
            checkNONPAYEE.Size = new Size(103, 23);
            checkNONPAYEE.TabIndex = 5;
            checkNONPAYEE.Text = "non payee";
            checkNONPAYEE.UseVisualStyleBackColor = true;
            checkNONPAYEE.CheckedChanged += checkNONPAYEE_CheckedChanged;
            // 
            // STATU
            // 
            STATU.AutoSize = true;
            STATU.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            STATU.Location = new Point(494, 93);
            STATU.Name = "STATU";
            STATU.Size = new Size(67, 23);
            STATU.TabIndex = 4;
            STATU.Text = "STATUS";
            STATU.Click += STATU_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(0, 0, 192);
            panel2.Controls.Add(label2);
            panel2.Location = new Point(-4, 265);
            panel2.Name = "panel2";
            panel2.Size = new Size(810, 58);
            panel2.TabIndex = 5;
            panel2.Paint += panel2_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Times New Roman", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonFace;
            label2.Location = new Point(308, 18);
            label2.Name = "label2";
            label2.Size = new Size(152, 23);
            label2.TabIndex = 0;
            label2.Text = "liste des factures";
            label2.Click += label2_Click;
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(-4, 321);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(802, 196);
            dataGridView1.TabIndex = 6;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FactureVenteForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 514);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Controls.Add(label1);
            Name = "FactureVenteForm";
            Text = "FactureVenteForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label IDPERSONNE;
        private Label IDFACTURE;
        private Label DATEFACTURE;
        private Panel panel1;
        private Label STATU;
        private TextBox textDATE;
        private TextBox textIDFACTURE;
        private CheckBox checkPAYEE;
        private CheckBox checkNONPAYEE;
        private TextBox textIDPERSONNE;
        private Panel panel2;
        private Label label2;
        private Button buttonQuitter;
        private Button buttonModifier;
        private Button buttonSupprimer;
        private Button buttonAjouter;
        private DataGridView dataGridView1;
    }
}