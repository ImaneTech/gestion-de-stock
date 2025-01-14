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
            buttonQuitter = new Button();
            buttonModifier = new Button();
            buttonSupprimer = new Button();
            buttonAjouter = new Button();
            checkNONPAYEE = new CheckBox();
            checkPAYEE = new CheckBox();
            textDATE = new TextBox();
            textPERSONNE = new TextBox();
            textFACTURE = new TextBox();
            STATUS = new Label();
            DATEFACTURE = new Label();
            IDPERSONNE = new Label();
            IDFACTURE = new Label();
            label1 = new Label();
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
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(buttonQuitter);
            panel1.Controls.Add(buttonModifier);
            panel1.Controls.Add(buttonSupprimer);
            panel1.Controls.Add(buttonAjouter);
            panel1.Controls.Add(checkNONPAYEE);
            panel1.Controls.Add(checkPAYEE);
            panel1.Controls.Add(textDATE);
            panel1.Controls.Add(textPERSONNE);
            panel1.Controls.Add(textFACTURE);
            panel1.Controls.Add(STATUS);
            panel1.Controls.Add(DATEFACTURE);
            panel1.Controls.Add(IDPERSONNE);
            panel1.Controls.Add(IDFACTURE);
            panel1.Location = new Point(1, 58);
            panel1.Name = "panel1";
            panel1.Size = new Size(798, 189);
            panel1.TabIndex = 0;
            panel1.Paint += panel1_Paint;
            // 
            // buttonQuitter
            // 
            buttonQuitter.BackColor = SystemColors.AppWorkspace;
            buttonQuitter.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonQuitter.Location = new Point(620, 132);
            buttonQuitter.Name = "buttonQuitter";
            buttonQuitter.Size = new Size(94, 46);
            buttonQuitter.TabIndex = 12;
            buttonQuitter.Text = "Quitter";
            buttonQuitter.UseVisualStyleBackColor = false;
            buttonQuitter.Click += buttonQuitter_Click;
            // 
            // buttonModifier
            // 
            buttonModifier.BackColor = SystemColors.AppWorkspace;
            buttonModifier.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonModifier.Location = new Point(450, 132);
            buttonModifier.Name = "buttonModifier";
            buttonModifier.Size = new Size(94, 46);
            buttonModifier.TabIndex = 11;
            buttonModifier.Text = "Modifier";
            buttonModifier.UseVisualStyleBackColor = false;
            buttonModifier.Click += buttonModifier_Click;
            // 
            // buttonSupprimer
            // 
            buttonSupprimer.BackColor = SystemColors.AppWorkspace;
            buttonSupprimer.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonSupprimer.Location = new Point(267, 132);
            buttonSupprimer.Name = "buttonSupprimer";
            buttonSupprimer.Size = new Size(112, 46);
            buttonSupprimer.TabIndex = 10;
            buttonSupprimer.Text = "Supprimer";
            buttonSupprimer.UseVisualStyleBackColor = false;
            buttonSupprimer.Click += buttonSupprimer_Click;
            // 
            // buttonAjouter
            // 
            buttonAjouter.BackColor = SystemColors.ControlDark;
            buttonAjouter.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            buttonAjouter.ForeColor = SystemColors.ActiveCaptionText;
            buttonAjouter.Location = new Point(95, 132);
            buttonAjouter.Name = "buttonAjouter";
            buttonAjouter.Size = new Size(107, 46);
            buttonAjouter.TabIndex = 9;
            buttonAjouter.Text = "Ajouter";
            buttonAjouter.UseVisualStyleBackColor = false;
            buttonAjouter.Click += buttonAjouter_Click;
            // 
            // checkNONPAYEE
            // 
            checkNONPAYEE.AutoSize = true;
            checkNONPAYEE.Font = new Font("Sylfaen", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkNONPAYEE.Location = new Point(658, 88);
            checkNONPAYEE.Name = "checkNONPAYEE";
            checkNONPAYEE.Size = new Size(103, 23);
            checkNONPAYEE.TabIndex = 8;
            checkNONPAYEE.Text = "non payee";
            checkNONPAYEE.UseVisualStyleBackColor = true;
            checkNONPAYEE.CheckedChanged += checkNONPAYEE_CheckedChanged;
            // 
            // checkPAYEE
            // 
            checkPAYEE.AutoSize = true;
            checkPAYEE.Font = new Font("Sylfaen", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            checkPAYEE.Location = new Point(556, 88);
            checkPAYEE.Name = "checkPAYEE";
            checkPAYEE.Size = new Size(73, 23);
            checkPAYEE.TabIndex = 7;
            checkPAYEE.Text = "payee";
            checkPAYEE.UseVisualStyleBackColor = true;
            checkPAYEE.CheckedChanged += checkPAYEE_CheckedChanged;
            // 
            // textDATE
            // 
            textDATE.Location = new Point(604, 28);
            textDATE.Name = "textDATE";
            textDATE.Size = new Size(125, 27);
            textDATE.TabIndex = 6;
            textDATE.TextChanged += textDATE_TextChanged;
            // 
            // textPERSONNE
            // 
            textPERSONNE.Location = new Point(179, 86);
            textPERSONNE.Name = "textPERSONNE";
            textPERSONNE.Size = new Size(125, 27);
            textPERSONNE.TabIndex = 5;
            textPERSONNE.TextChanged += textPERSONNE_TextChanged;
            // 
            // textFACTURE
            // 
            textFACTURE.Location = new Point(179, 24);
            textFACTURE.Name = "textFACTURE";
            textFACTURE.Size = new Size(125, 27);
            textFACTURE.TabIndex = 4;
            textFACTURE.TextChanged += textFACTURE_TextChanged;
            // 
            // STATUS
            // 
            STATUS.AutoSize = true;
            STATUS.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            STATUS.Location = new Point(450, 86);
            STATUS.Name = "STATUS";
            STATUS.Size = new Size(67, 23);
            STATUS.TabIndex = 3;
            STATUS.Text = "STATUS";
            STATUS.Click += STATUS_Click;
            // 
            // DATEFACTURE
            // 
            DATEFACTURE.AutoSize = true;
            DATEFACTURE.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            DATEFACTURE.Location = new Point(439, 28);
            DATEFACTURE.Name = "DATEFACTURE";
            DATEFACTURE.Size = new Size(126, 23);
            DATEFACTURE.TabIndex = 2;
            DATEFACTURE.Text = "DATE FACTURE";
            DATEFACTURE.Click += DATEFACTURE_Click;
            // 
            // IDPERSONNE
            // 
            IDPERSONNE.AutoSize = true;
            IDPERSONNE.Font = new Font("Segoe UI Semibold", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            IDPERSONNE.Location = new Point(32, 86);
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
            IDFACTURE.Location = new Point(32, 28);
            IDFACTURE.Name = "IDFACTURE";
            IDFACTURE.Size = new Size(103, 23);
            IDFACTURE.TabIndex = 0;
            IDFACTURE.Text = "ID FACTURE";
            IDFACTURE.Click += IDFACTURE_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Rockwell Nova", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Navy;
            label1.Location = new Point(268, 9);
            label1.Name = "label1";
            label1.Size = new Size(309, 31);
            label1.TabIndex = 1;
            label1.Text = "LES FACTURES D'ACHAT";
            label1.Click += label1_Click;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Blue;
            panel2.Controls.Add(label2);
            panel2.Location = new Point(1, 277);
            panel2.Name = "panel2";
            panel2.Size = new Size(798, 58);
            panel2.TabIndex = 2;
            panel2.Paint += panel2_Paint;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Sitka Banner", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = SystemColors.ButtonHighlight;
            label2.Location = new Point(323, 10);
            label2.Name = "label2";
            label2.Size = new Size(158, 29);
            label2.TabIndex = 0;
            label2.Text = "Liste des Factures";
            // 
            // dataGridView1
            // 
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(1, 334);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(798, 220);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // FactureAchatForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 550);
            Controls.Add(dataGridView1);
            Controls.Add(panel2);
            Controls.Add(label1);
            Controls.Add(panel1);
            Name = "FactureAchatForm";
            Text = "FactureAchatForm";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox textFACTURE;
        private Label STATUS;
        private Label DATEFACTURE;
        private Label IDPERSONNE;
        private Label IDFACTURE;
        private CheckBox checkPAYEE;
        private TextBox textDATE;
        private TextBox textPERSONNE;
        private CheckBox checkNONPAYEE;
        private Button buttonAjouter;
        private Label label1;
        private Button buttonQuitter;
        private Button buttonModifier;
        private Button buttonSupprimer;
        private Panel panel2;
        private Label label2;
        private DataGridView dataGridView1;
    }
}