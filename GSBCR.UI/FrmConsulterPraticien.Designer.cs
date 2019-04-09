namespace GSBCR.UI
{
    partial class FrmConsulterPraticien
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsulterPraticien));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxPra1 = new System.Windows.Forms.ComboBox();
            this.bsPra1 = new System.Windows.Forms.BindingSource(this.components);
            this.bsRapport1 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_choisir_praticien = new System.Windows.Forms.Button();
            this.checkBox_afficher_rapport = new System.Windows.Forms.CheckBox();
            this.listBox_numRapport = new System.Windows.Forms.ListBox();
            this.btn_choisirRapport = new System.Windows.Forms.Button();
            this.btn_quitter = new System.Windows.Forms.Button();
            this.ucPraticien1 = new GSBCR.UC.UcPraticien();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPra1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapport1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(13, 13);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 119);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(378, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Praticien :";
            // 
            // cbxPra1
            // 
            this.cbxPra1.FormattingEnabled = true;
            this.cbxPra1.Location = new System.Drawing.Point(473, 49);
            this.cbxPra1.Name = "cbxPra1";
            this.cbxPra1.Size = new System.Drawing.Size(135, 21);
            this.cbxPra1.TabIndex = 2;
            // 
            // btn_choisir_praticien
            // 
            this.btn_choisir_praticien.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_choisir_praticien.Location = new System.Drawing.Point(643, 47);
            this.btn_choisir_praticien.Name = "btn_choisir_praticien";
            this.btn_choisir_praticien.Size = new System.Drawing.Size(96, 23);
            this.btn_choisir_praticien.TabIndex = 3;
            this.btn_choisir_praticien.Text = "Valider";
            this.btn_choisir_praticien.UseVisualStyleBackColor = false;
            this.btn_choisir_praticien.Click += new System.EventHandler(this.btn_choisir_praticien_Click);
            // 
            // checkBox_afficher_rapport
            // 
            this.checkBox_afficher_rapport.AutoSize = true;
            this.checkBox_afficher_rapport.Location = new System.Drawing.Point(508, 98);
            this.checkBox_afficher_rapport.Name = "checkBox_afficher_rapport";
            this.checkBox_afficher_rapport.Size = new System.Drawing.Size(140, 17);
            this.checkBox_afficher_rapport.TabIndex = 4;
            this.checkBox_afficher_rapport.Text = "Afficher rapport de visite";
            this.checkBox_afficher_rapport.UseVisualStyleBackColor = true;
            this.checkBox_afficher_rapport.CheckedChanged += new System.EventHandler(this.checkBox_afficher_rapport_CheckedChanged);
            // 
            // listBox_numRapport
            // 
            this.listBox_numRapport.DataSource = this.bsRapport1;
            this.listBox_numRapport.FormattingEnabled = true;
            this.listBox_numRapport.Location = new System.Drawing.Point(682, 212);
            this.listBox_numRapport.Name = "listBox_numRapport";
            this.listBox_numRapport.Size = new System.Drawing.Size(304, 186);
            this.listBox_numRapport.TabIndex = 22;
            // 
            // btn_choisirRapport
            // 
            this.btn_choisirRapport.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_choisirRapport.ForeColor = System.Drawing.Color.Black;
            this.btn_choisirRapport.Location = new System.Drawing.Point(781, 421);
            this.btn_choisirRapport.Name = "btn_choisirRapport";
            this.btn_choisirRapport.Size = new System.Drawing.Size(113, 34);
            this.btn_choisirRapport.TabIndex = 23;
            this.btn_choisirRapport.Text = "Sélectionner";
            this.btn_choisirRapport.UseVisualStyleBackColor = false;
            this.btn_choisirRapport.Click += new System.EventHandler(this.btn_choisirRapport_Click);
            // 
            // btn_quitter
            // 
            this.btn_quitter.BackColor = System.Drawing.Color.Tomato;
            this.btn_quitter.Location = new System.Drawing.Point(141, 500);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(81, 29);
            this.btn_quitter.TabIndex = 24;
            this.btn_quitter.Text = "Quitter";
            this.btn_quitter.UseVisualStyleBackColor = false;
            this.btn_quitter.Click += new System.EventHandler(this.btn_quitter_Click);
            // 
            // ucPraticien1
            // 
            this.ucPraticien1.LePraticien = null;
            this.ucPraticien1.Location = new System.Drawing.Point(24, 149);
            this.ucPraticien1.Name = "ucPraticien1";
            this.ucPraticien1.Size = new System.Drawing.Size(338, 315);
            this.ucPraticien1.TabIndex = 25;
            // 
            // FrmConsulterPraticien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1038, 613);
            this.Controls.Add(this.ucPraticien1);
            this.Controls.Add(this.btn_quitter);
            this.Controls.Add(this.btn_choisirRapport);
            this.Controls.Add(this.listBox_numRapport);
            this.Controls.Add(this.checkBox_afficher_rapport);
            this.Controls.Add(this.btn_choisir_praticien);
            this.Controls.Add(this.cbxPra1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmConsulterPraticien";
            this.Text = "FrmConsulterPraticien";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPra1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapport1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxPra1;
        private System.Windows.Forms.BindingSource bsPra1;
        private System.Windows.Forms.BindingSource bsRapport1;
        private System.Windows.Forms.Button btn_choisir_praticien;
        private System.Windows.Forms.CheckBox checkBox_afficher_rapport;
        private System.Windows.Forms.ListBox listBox_numRapport;
        private System.Windows.Forms.Button btn_choisirRapport;
        private System.Windows.Forms.Button btn_quitter;
        private UC.UcPraticien ucPraticien1;
    }
}