namespace Gestion_de_stock
{
    partial class AccueilForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AccueilForm));
            panel1 = new Panel();
            panel5 = new Panel();
            pictureBox3 = new PictureBox();
            label5 = new Label();
            label6 = new Label();
            panel4 = new Panel();
            pictureBox2 = new PictureBox();
            label3 = new Label();
            label4 = new Label();
            panel3 = new Panel();
            pictureBox1 = new PictureBox();
            label2 = new Label();
            label1 = new Label();
            panel2 = new Panel();
            panel1.SuspendLayout();
            panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 192, 255);
            panel1.Controls.Add(panel5);
            panel1.Controls.Add(panel4);
            panel1.Controls.Add(panel3);
            panel1.Location = new Point(12, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(1038, 229);
            panel1.TabIndex = 0;
            // 
            // panel5
            // 
            panel5.BackColor = Color.SlateBlue;
            panel5.Controls.Add(pictureBox3);
            panel5.Controls.Add(label5);
            panel5.Controls.Add(label6);
            panel5.Location = new Point(710, 25);
            panel5.Name = "panel5";
            panel5.Size = new Size(301, 184);
            panel5.TabIndex = 2;
            // 
            // pictureBox3
            // 
            pictureBox3.BackgroundImage = (Image)resources.GetObject("pictureBox3.BackgroundImage");
            pictureBox3.BackgroundImageLayout = ImageLayout.Center;
            pictureBox3.Location = new Point(3, 20);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(128, 101);
            pictureBox3.TabIndex = 2;
            pictureBox3.TabStop = false;
            pictureBox3.Click += pictureBox3_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(137, 40);
            label5.Name = "label5";
            label5.Size = new Size(22, 23);
            label5.TabIndex = 1;
            label5.Text = "0";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(85, 137);
            label6.Name = "label6";
            label6.Size = new Size(200, 23);
            label6.TabIndex = 0;
            label6.Text = "Produits en rupture";
            // 
            // panel4
            // 
            panel4.BackColor = Color.SlateBlue;
            panel4.Controls.Add(pictureBox2);
            panel4.Controls.Add(label3);
            panel4.Controls.Add(label4);
            panel4.Location = new Point(357, 22);
            panel4.Name = "panel4";
            panel4.Size = new Size(324, 187);
            panel4.TabIndex = 1;
            // 
            // pictureBox2
            // 
            pictureBox2.BackgroundImage = (Image)resources.GetObject("pictureBox2.BackgroundImage");
            pictureBox2.BackgroundImageLayout = ImageLayout.Center;
            pictureBox2.Location = new Point(3, 23);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(119, 101);
            pictureBox2.TabIndex = 2;
            pictureBox2.TabStop = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(128, 43);
            label3.Name = "label3";
            label3.Size = new Size(22, 23);
            label3.TabIndex = 1;
            label3.Text = "0";
            label3.Click += label3_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(60, 140);
            label4.Name = "label4";
            label4.Size = new Size(251, 23);
            label4.TabIndex = 0;
            label4.Text = "Factures d'achat payées";
            // 
            // panel3
            // 
            panel3.BackColor = Color.SlateBlue;
            panel3.Controls.Add(pictureBox1);
            panel3.Controls.Add(label2);
            panel3.Controls.Add(label1);
            panel3.Location = new Point(18, 22);
            panel3.Name = "panel3";
            panel3.Size = new Size(309, 187);
            panel3.TabIndex = 0;
            // 
            // pictureBox1
            // 
            pictureBox1.BackgroundImage = (Image)resources.GetObject("pictureBox1.BackgroundImage");
            pictureBox1.BackgroundImageLayout = ImageLayout.Center;
            pictureBox1.Location = new Point(3, 23);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(117, 101);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(126, 43);
            label2.Name = "label2";
            label2.Size = new Size(22, 23);
            label2.TabIndex = 1;
            label2.Text = "0";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Arial Rounded MT Bold", 10F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(60, 140);
            label1.Name = "label1";
            label1.Size = new Size(227, 23);
            label1.TabIndex = 0;
            label1.Text = "Valeur totale du stock ";
            // 
            // panel2
            // 
            panel2.Location = new Point(12, 258);
            panel2.Name = "panel2";
            panel2.Size = new Size(1038, 418);
            panel2.TabIndex = 1;
            // 
            // AcceuilForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1062, 688);
            Controls.Add(panel2);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AcceuilForm";
            Text = "Form1";
            panel1.ResumeLayout(false);
            panel5.ResumeLayout(false);
            panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            panel4.ResumeLayout(false);
            panel4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel3;
        private Panel panel2;
        private Label label1;
        private PictureBox pictureBox1;
        private Label label2;
        private Panel panel5;
        private PictureBox pictureBox3;
        private Label label5;
        private Label label6;
        private Panel panel4;
        private PictureBox pictureBox2;
        private Label label3;
        private Label label4;
    }
}