namespace GSBCR.UI
{
    partial class FrmNouveauRapportVisitesParRegion
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
            this.ucPraticien1 = new GSBCR.UC.UcPraticien();
            this.ucRapportsValides1 = new GSBCR.UC.UcRapportsValides();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.cbxRapport = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.bsPraticien = new System.Windows.Forms.BindingSource(this.components);
            this.bsRapport = new System.Windows.Forms.BindingSource(this.components);
            this.btnVoirLePraticien = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bsPraticien)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapport)).BeginInit();
            this.SuspendLayout();
            // 
            // ucPraticien1
            // 
            this.ucPraticien1.LePraticien = null;
            this.ucPraticien1.Location = new System.Drawing.Point(545, 198);
            this.ucPraticien1.Name = "ucPraticien1";
            this.ucPraticien1.Size = new System.Drawing.Size(245, 308);
            this.ucPraticien1.TabIndex = 51;
            // 
            // ucRapportsValides1
            // 
            this.ucRapportsValides1.LeRapportVisite = null;
            this.ucRapportsValides1.Location = new System.Drawing.Point(70, 89);
            this.ucRapportsValides1.Name = "ucRapportsValides1";
            this.ucRapportsValides1.Size = new System.Drawing.Size(600, 395);
            this.ucRapportsValides1.TabIndex = 50;
            // 
            // btnQuitter
            // 
            this.btnQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuitter.Location = new System.Drawing.Point(395, 530);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 52;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // cbxRapport
            // 
            this.cbxRapport.FormattingEnabled = true;
            this.cbxRapport.Location = new System.Drawing.Point(213, 70);
            this.cbxRapport.Name = "cbxRapport";
            this.cbxRapport.Size = new System.Drawing.Size(121, 21);
            this.cbxRapport.TabIndex = 53;
            this.cbxRapport.SelectedIndexChanged += new System.EventHandler(this.cbxRapport_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(84, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 54;
            this.label2.Text = "Sélectionner un rapport :";
            // 
            // bsPraticien
            // 
            this.bsPraticien.DataSource = typeof(GSBCR.BLL.Manager);
            // 
            // bsRapport
            // 
            this.bsRapport.DataSource = typeof(GSBCR.BLL.Manager);
            // 
            // btnVoirLePraticien
            // 
            this.btnVoirLePraticien.Location = new System.Drawing.Point(665, 169);
            this.btnVoirLePraticien.Name = "btnVoirLePraticien";
            this.btnVoirLePraticien.Size = new System.Drawing.Size(101, 23);
            this.btnVoirLePraticien.TabIndex = 55;
            this.btnVoirLePraticien.Text = "Voir le praticien";
            this.btnVoirLePraticien.UseVisualStyleBackColor = true;
            this.btnVoirLePraticien.Click += new System.EventHandler(this.btnVoirLePraticien_Click);
            // 
            // FrmNouveauRapportVisitesParRegion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 595);
            this.Controls.Add(this.btnVoirLePraticien);
            this.Controls.Add(this.cbxRapport);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.ucPraticien1);
            this.Controls.Add(this.ucRapportsValides1);
            this.Name = "FrmNouveauRapportVisitesParRegion";
            this.Text = "FrmNouveauRapportVisitesParRegion";
            this.Load += new System.EventHandler(this.FrmNouveauRapportVisitesParRegion_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsPraticien)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private UC.UcPraticien ucPraticien1;
        private UC.UcRapportsValides ucRapportsValides1;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.ComboBox cbxRapport;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.BindingSource bsPraticien;
        private System.Windows.Forms.BindingSource bsRapport;
        private System.Windows.Forms.Button btnVoirLePraticien;
    }
}