namespace GSBCR.UI
{
    partial class FrmRapportsValides
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
            this.lblTitre = new System.Windows.Forms.Label();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.cbxRapport = new System.Windows.Forms.ComboBox();
            this.bsRapport = new System.Windows.Forms.BindingSource(this.components);
            this.ucRapportsValides1 = new GSBCR.UC.UcRapportsValides();
            this.ucPraticien1 = new GSBCR.UC.UcPraticien();
            this.btnVoirLePraticien = new System.Windows.Forms.Button();
            this.bsPraticien = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsRapport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPraticien)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.CausesValidation = false;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(281, 21);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(147, 20);
            this.lblTitre.TabIndex = 3;
            this.lblTitre.Text = "Rapports Validés";
            // 
            // btnQuitter
            // 
            this.btnQuitter.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.btnQuitter.Location = new System.Drawing.Point(386, 523);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 43;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(58, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Sélectionner un rapport :";
            // 
            // cbxRapport
            // 
            this.cbxRapport.DataSource = this.bsRapport;
            this.cbxRapport.FormattingEnabled = true;
            this.cbxRapport.Location = new System.Drawing.Point(180, 75);
            this.cbxRapport.Name = "cbxRapport";
            this.cbxRapport.Size = new System.Drawing.Size(121, 21);
            this.cbxRapport.TabIndex = 6;
            this.cbxRapport.SelectedIndexChanged += new System.EventHandler(this.cbxRapport_SelectedIndexChanged);
            // 
            // bsRapport
            // 
            this.bsRapport.DataSource = typeof(GSBCR.BLL.Manager);
            // 
            // ucRapportsValides1
            // 
            this.ucRapportsValides1.LeRapportVisite = null;
            this.ucRapportsValides1.Location = new System.Drawing.Point(38, 102);
            this.ucRapportsValides1.Name = "ucRapportsValides1";
            this.ucRapportsValides1.Size = new System.Drawing.Size(600, 395);
            this.ucRapportsValides1.TabIndex = 48;
            // 
            // ucPraticien1
            // 
            this.ucPraticien1.LePraticien = null;
            this.ucPraticien1.Location = new System.Drawing.Point(513, 211);
            this.ucPraticien1.Name = "ucPraticien1";
            this.ucPraticien1.Size = new System.Drawing.Size(245, 308);
            this.ucPraticien1.TabIndex = 49;
            // 
            // btnVoirLePraticien
            // 
            this.btnVoirLePraticien.Location = new System.Drawing.Point(327, 146);
            this.btnVoirLePraticien.Name = "btnVoirLePraticien";
            this.btnVoirLePraticien.Size = new System.Drawing.Size(101, 23);
            this.btnVoirLePraticien.TabIndex = 50;
            this.btnVoirLePraticien.Text = "Voir le praticien";
            this.btnVoirLePraticien.UseVisualStyleBackColor = true;
            this.btnVoirLePraticien.Click += new System.EventHandler(this.btnVoirLePraticien_Click);
            // 
            // bsPraticien
            // 
            this.bsPraticien.DataSource = typeof(GSBCR.BLL.Manager);
            // 
            // FrmRapportsValides
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 558);
            this.Controls.Add(this.btnVoirLePraticien);
            this.Controls.Add(this.ucPraticien1);
            this.Controls.Add(this.ucRapportsValides1);
            this.Controls.Add(this.cbxRapport);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblTitre);
            this.Name = "FrmRapportsValides";
            this.Text = "FrmRapportsValides";
            this.Load += new System.EventHandler(this.FrmRapportsValides_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsRapport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPraticien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbxRapport;
        private UC.UcRapportsValides ucRapportsValides1;
        private System.Windows.Forms.BindingSource bsRapport;
        private UC.UcPraticien ucPraticien1;
        private System.Windows.Forms.Button btnVoirLePraticien;
        private System.Windows.Forms.BindingSource bsPraticien;
    }
}