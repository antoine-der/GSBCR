namespace GSBCR.UCTEST
{
    partial class Form1
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.cbxMedoc = new System.Windows.Forms.ComboBox();
            this.bsMedoc = new System.Windows.Forms.BindingSource(this.components);
            this.ucMedicament1 = new GSBCR.UC.UcMedicament();
            this.quitter = new System.Windows.Forms.Button();
            this.cbxPraticien = new System.Windows.Forms.ComboBox();
            this.bsPraticien = new System.Windows.Forms.BindingSource(this.components);
            this.ucPraticien1 = new GSBCR.UC.UcPraticien();
            ((System.ComponentModel.ISupportInitialize)(this.bsMedoc)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPraticien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkRed;
            this.label1.Location = new System.Drawing.Point(92, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(461, 42);
            this.label1.TabIndex = 0;
            this.label1.Text = "Consultation médicament";
            // 
            // cbxMedoc
            // 
            this.cbxMedoc.DataSource = this.bsMedoc;
            this.cbxMedoc.FormattingEnabled = true;
            this.cbxMedoc.Location = new System.Drawing.Point(241, 67);
            this.cbxMedoc.Name = "cbxMedoc";
            this.cbxMedoc.Size = new System.Drawing.Size(121, 21);
            this.cbxMedoc.TabIndex = 1;
            this.cbxMedoc.SelectedIndexChanged += new System.EventHandler(this.cbxMedoc_SelectedIndexChanged);
            // 
            // bsMedoc
            // 
            this.bsMedoc.DataSource = typeof(GSBCR.BLL.Manager);
            this.bsMedoc.CurrentChanged += new System.EventHandler(this.bsMedoc_CurrentChanged);
            // 
            // ucMedicament1
            // 
            this.ucMedicament1.LeMedicament = null;
            this.ucMedicament1.Location = new System.Drawing.Point(99, 94);
            this.ucMedicament1.Name = "ucMedicament1";
            this.ucMedicament1.Size = new System.Drawing.Size(468, 486);
            this.ucMedicament1.TabIndex = 2;
            this.ucMedicament1.Load += new System.EventHandler(this.ucMedicament1_Load);
            // 
            // quitter
            // 
            this.quitter.BackColor = System.Drawing.Color.Red;
            this.quitter.ForeColor = System.Drawing.SystemColors.InfoText;
            this.quitter.Location = new System.Drawing.Point(446, 595);
            this.quitter.Name = "quitter";
            this.quitter.Size = new System.Drawing.Size(67, 27);
            this.quitter.TabIndex = 3;
            this.quitter.Text = "Quitter";
            this.quitter.UseVisualStyleBackColor = false;
            this.quitter.Click += new System.EventHandler(this.quitter_Click);
            // 
            // cbxPraticien
            // 
            this.cbxPraticien.DataSource = this.bsPraticien;
            this.cbxPraticien.FormattingEnabled = true;
            this.cbxPraticien.Location = new System.Drawing.Point(446, 67);
            this.cbxPraticien.Name = "cbxPraticien";
            this.cbxPraticien.Size = new System.Drawing.Size(121, 21);
            this.cbxPraticien.TabIndex = 4;
            this.cbxPraticien.SelectedIndexChanged += new System.EventHandler(this.cbxPraticien_SelectedIndexChanged);
            // 
            // bsPraticien
            // 
            this.bsPraticien.DataSource = typeof(GSBCR.BLL.Manager);
            // 
            // ucPraticien1
            // 
            this.ucPraticien1.LePraticien = null;
            this.ucPraticien1.Location = new System.Drawing.Point(99, 109);
            this.ucPraticien1.Name = "ucPraticien1";
            this.ucPraticien1.Size = new System.Drawing.Size(414, 460);
            this.ucPraticien1.TabIndex = 5;
            this.ucPraticien1.Load += new System.EventHandler(this.ucPraticien1_Load);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(829, 812);
            this.Controls.Add(this.ucPraticien1);
            this.Controls.Add(this.cbxPraticien);
            this.Controls.Add(this.quitter);
            this.Controls.Add(this.ucMedicament1);
            this.Controls.Add(this.cbxMedoc);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.bsMedoc)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsPraticien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private UC.UcMedicament ucMedicament1;
        private System.Windows.Forms.Button quitter;
        private System.Windows.Forms.BindingSource bsMedoc;
        private System.Windows.Forms.ComboBox cbxMedoc;
        private System.Windows.Forms.ComboBox cbxPraticien;
        private UC.UcPraticien ucPraticien1;
        private System.Windows.Forms.BindingSource bsPraticien;
    }
}

