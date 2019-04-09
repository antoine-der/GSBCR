namespace GSBCR.UI
{
    partial class FrmConsulterMedicament
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmConsulterMedicament));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_choisir_medicament = new System.Windows.Forms.Button();
            this.ucMedicament1 = new GSBCR.UC.UcMedicament();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxMed1 = new System.Windows.Forms.ComboBox();
            this.checkBox_afficher_rapport = new System.Windows.Forms.CheckBox();
            this.listBox_numRapport = new System.Windows.Forms.ListBox();
            this.btn_quitter = new System.Windows.Forms.Button();
            this.btn_choisirRapport = new System.Windows.Forms.Button();
            this.bsMed1 = new System.Windows.Forms.BindingSource(this.components);
            this.bsRapport1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMed1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapport1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(183, 121);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // btn_choisir_medicament
            // 
            this.btn_choisir_medicament.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_choisir_medicament.Location = new System.Drawing.Point(662, 50);
            this.btn_choisir_medicament.Name = "btn_choisir_medicament";
            this.btn_choisir_medicament.Size = new System.Drawing.Size(75, 23);
            this.btn_choisir_medicament.TabIndex = 1;
            this.btn_choisir_medicament.Text = "Valider";
            this.btn_choisir_medicament.UseVisualStyleBackColor = false;
            this.btn_choisir_medicament.Click += new System.EventHandler(this.btn_choisir_medicament_Click);
            // 
            // ucMedicament1
            // 
            this.ucMedicament1.LeMedicament = null;
            this.ucMedicament1.Location = new System.Drawing.Point(61, 139);
            this.ucMedicament1.Name = "ucMedicament1";
            this.ucMedicament1.Size = new System.Drawing.Size(374, 481);
            this.ucMedicament1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(364, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Medicament :";
            // 
            // cbxMed1
            // 
            this.cbxMed1.FormattingEnabled = true;
            this.cbxMed1.Location = new System.Drawing.Point(474, 52);
            this.cbxMed1.Name = "cbxMed1";
            this.cbxMed1.Size = new System.Drawing.Size(164, 21);
            this.cbxMed1.TabIndex = 4;
            // 
            // checkBox_afficher_rapport
            // 
            this.checkBox_afficher_rapport.AutoSize = true;
            this.checkBox_afficher_rapport.Location = new System.Drawing.Point(487, 104);
            this.checkBox_afficher_rapport.Name = "checkBox_afficher_rapport";
            this.checkBox_afficher_rapport.Size = new System.Drawing.Size(140, 17);
            this.checkBox_afficher_rapport.TabIndex = 5;
            this.checkBox_afficher_rapport.Text = "Afficher rapport de visite";
            this.checkBox_afficher_rapport.UseVisualStyleBackColor = true;
            this.checkBox_afficher_rapport.CheckedChanged += new System.EventHandler(this.checkBox_afficher_rapport_CheckedChanged);
            // 
            // listBox_numRapport
            // 
            this.listBox_numRapport.BackColor = System.Drawing.SystemColors.Window;
            this.listBox_numRapport.DataSource = this.bsRapport1;
            this.listBox_numRapport.FormattingEnabled = true;
            this.listBox_numRapport.Location = new System.Drawing.Point(662, 265);
            this.listBox_numRapport.Name = "listBox_numRapport";
            this.listBox_numRapport.Size = new System.Drawing.Size(298, 186);
            this.listBox_numRapport.TabIndex = 6;
            // 
            // btn_quitter
            // 
            this.btn_quitter.BackColor = System.Drawing.Color.Tomato;
            this.btn_quitter.Location = new System.Drawing.Point(122, 612);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(89, 30);
            this.btn_quitter.TabIndex = 7;
            this.btn_quitter.Text = "Quitter";
            this.btn_quitter.UseVisualStyleBackColor = false;
            this.btn_quitter.Click += new System.EventHandler(this.btn_quitter_Click);
            // 
            // btn_choisirRapport
            // 
            this.btn_choisirRapport.BackColor = System.Drawing.Color.MediumTurquoise;
            this.btn_choisirRapport.Location = new System.Drawing.Point(755, 480);
            this.btn_choisirRapport.Name = "btn_choisirRapport";
            this.btn_choisirRapport.Size = new System.Drawing.Size(96, 38);
            this.btn_choisirRapport.TabIndex = 8;
            this.btn_choisirRapport.Text = "Sélectionner";
            this.btn_choisirRapport.UseVisualStyleBackColor = false;
            this.btn_choisirRapport.Click += new System.EventHandler(this.btn_choisirRapport_Click);
            // 
            // FrmConsulterMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1036, 654);
            this.Controls.Add(this.btn_choisirRapport);
            this.Controls.Add(this.btn_quitter);
            this.Controls.Add(this.listBox_numRapport);
            this.Controls.Add(this.checkBox_afficher_rapport);
            this.Controls.Add(this.cbxMed1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ucMedicament1);
            this.Controls.Add(this.btn_choisir_medicament);
            this.Controls.Add(this.pictureBox1);
            this.Name = "FrmConsulterMedicament";
            this.Text = "FrmConsulterMedicament";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsMed1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapport1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_choisir_medicament;
        private UC.UcMedicament ucMedicament1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbxMed1;
        private System.Windows.Forms.CheckBox checkBox_afficher_rapport;
        private System.Windows.Forms.ListBox listBox_numRapport;
        private System.Windows.Forms.Button btn_quitter;
        private System.Windows.Forms.Button btn_choisirRapport;
        private System.Windows.Forms.BindingSource bsMed1;
        private System.Windows.Forms.BindingSource bsRapport1;
    }
}