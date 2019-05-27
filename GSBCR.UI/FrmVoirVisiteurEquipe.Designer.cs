namespace GSBCR.UI
{
    partial class FrmVoirVisiteurEquipe
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
            this.labelPrenom = new System.Windows.Forms.Label();
            this.labelNom = new System.Windows.Forms.Label();
            this.dtDateEmbauche = new System.Windows.Forms.DateTimePicker();
            this.labelDtEmbauche = new System.Windows.Forms.Label();
            this.labelMat = new System.Windows.Forms.Label();
            this.dtAffectationRegion = new System.Windows.Forms.DateTimePicker();
            this.labeldtAffectation = new System.Windows.Forms.Label();
            this.txtPrenom = new System.Windows.Forms.TextBox();
            this.txtNom = new System.Windows.Forms.TextBox();
            this.txtNbRapports = new System.Windows.Forms.TextBox();
            this.labelNbRapports = new System.Windows.Forms.Label();
            this.cbxMatricule = new System.Windows.Forms.ComboBox();
            this.close = new System.Windows.Forms.Button();
            this.bsVisiteur = new System.Windows.Forms.BindingSource(this.components);
            this.btnRapportsConsultés = new System.Windows.Forms.Button();
            this.lbxRapports = new System.Windows.Forms.ListBox();
            this.bsRapport = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapport)).BeginInit();
            this.SuspendLayout();
            // 
            // labelPrenom
            // 
            this.labelPrenom.AutoSize = true;
            this.labelPrenom.Location = new System.Drawing.Point(15, 68);
            this.labelPrenom.Name = "labelPrenom";
            this.labelPrenom.Size = new System.Drawing.Size(43, 13);
            this.labelPrenom.TabIndex = 32;
            this.labelPrenom.Text = "Prénom";
            // 
            // labelNom
            // 
            this.labelNom.AutoSize = true;
            this.labelNom.Location = new System.Drawing.Point(15, 46);
            this.labelNom.Name = "labelNom";
            this.labelNom.Size = new System.Drawing.Size(29, 13);
            this.labelNom.TabIndex = 29;
            this.labelNom.Text = "Nom";
            // 
            // dtDateEmbauche
            // 
            this.dtDateEmbauche.Location = new System.Drawing.Point(137, 92);
            this.dtDateEmbauche.Name = "dtDateEmbauche";
            this.dtDateEmbauche.Size = new System.Drawing.Size(200, 20);
            this.dtDateEmbauche.TabIndex = 28;
            // 
            // labelDtEmbauche
            // 
            this.labelDtEmbauche.AutoSize = true;
            this.labelDtEmbauche.Location = new System.Drawing.Point(15, 98);
            this.labelDtEmbauche.Name = "labelDtEmbauche";
            this.labelDtEmbauche.Size = new System.Drawing.Size(82, 13);
            this.labelDtEmbauche.TabIndex = 27;
            this.labelDtEmbauche.Text = "date Embauche";
            // 
            // labelMat
            // 
            this.labelMat.AutoSize = true;
            this.labelMat.Location = new System.Drawing.Point(15, 15);
            this.labelMat.Name = "labelMat";
            this.labelMat.Size = new System.Drawing.Size(50, 13);
            this.labelMat.TabIndex = 25;
            this.labelMat.Text = "Matricule";
            // 
            // dtAffectationRegion
            // 
            this.dtAffectationRegion.Location = new System.Drawing.Point(137, 118);
            this.dtAffectationRegion.Name = "dtAffectationRegion";
            this.dtAffectationRegion.Size = new System.Drawing.Size(200, 20);
            this.dtAffectationRegion.TabIndex = 43;
            // 
            // labeldtAffectation
            // 
            this.labeldtAffectation.AutoSize = true;
            this.labeldtAffectation.Location = new System.Drawing.Point(15, 124);
            this.labeldtAffectation.Name = "labeldtAffectation";
            this.labeldtAffectation.Size = new System.Drawing.Size(113, 13);
            this.labeldtAffectation.TabIndex = 42;
            this.labeldtAffectation.Text = "date affectation région";
            // 
            // txtPrenom
            // 
            this.txtPrenom.Location = new System.Drawing.Point(137, 64);
            this.txtPrenom.Name = "txtPrenom";
            this.txtPrenom.Size = new System.Drawing.Size(100, 20);
            this.txtPrenom.TabIndex = 44;
            this.txtPrenom.TabStop = false;
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(137, 38);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(100, 20);
            this.txtNom.TabIndex = 45;
            this.txtNom.TabStop = false;
            // 
            // txtNbRapports
            // 
            this.txtNbRapports.Location = new System.Drawing.Point(137, 144);
            this.txtNbRapports.Name = "txtNbRapports";
            this.txtNbRapports.Size = new System.Drawing.Size(100, 20);
            this.txtNbRapports.TabIndex = 47;
            this.txtNbRapports.TabStop = false;
            // 
            // labelNbRapports
            // 
            this.labelNbRapports.AutoSize = true;
            this.labelNbRapports.Location = new System.Drawing.Point(15, 148);
            this.labelNbRapports.Name = "labelNbRapports";
            this.labelNbRapports.Size = new System.Drawing.Size(100, 13);
            this.labelNbRapports.TabIndex = 46;
            this.labelNbRapports.Text = "Nombre de rapports";
            // 
            // cbxMatricule
            // 
            this.cbxMatricule.FormattingEnabled = true;
            this.cbxMatricule.Location = new System.Drawing.Point(137, 11);
            this.cbxMatricule.Name = "cbxMatricule";
            this.cbxMatricule.Size = new System.Drawing.Size(121, 21);
            this.cbxMatricule.TabIndex = 48;
            this.cbxMatricule.SelectedIndexChanged += new System.EventHandler(this.cbxMatricule_SelectedIndexChanged);
            // 
            // close
            // 
            this.close.Location = new System.Drawing.Point(327, 272);
            this.close.Name = "close";
            this.close.Size = new System.Drawing.Size(75, 23);
            this.close.TabIndex = 49;
            this.close.Text = "Quitter";
            this.close.UseVisualStyleBackColor = true;
            this.close.Click += new System.EventHandler(this.close_Click);
            // 
            // bsVisiteur
            // 
            this.bsVisiteur.DataSource = typeof(GSBCR.BLL.Manager);
            // 
            // btnRapportsConsultés
            // 
            this.btnRapportsConsultés.Location = new System.Drawing.Point(528, 217);
            this.btnRapportsConsultés.Name = "btnRapportsConsultés";
            this.btnRapportsConsultés.Size = new System.Drawing.Size(107, 23);
            this.btnRapportsConsultés.TabIndex = 50;
            this.btnRapportsConsultés.Text = "Consulter rapports";
            this.btnRapportsConsultés.UseVisualStyleBackColor = true;
            this.btnRapportsConsultés.Click += new System.EventHandler(this.btnRapportsConsultés_Click);
            // 
            // lbxRapports
            // 
            this.lbxRapports.DataSource = this.bsRapport;
            this.lbxRapports.FormattingEnabled = true;
            this.lbxRapports.Location = new System.Drawing.Point(468, 92);
            this.lbxRapports.Name = "lbxRapports";
            this.lbxRapports.Size = new System.Drawing.Size(220, 108);
            this.lbxRapports.TabIndex = 51;
            // 
            // bsRapport
            // 
            this.bsRapport.DataSource = typeof(GSBCR.BLL.Manager);
            // 
            // FrmVoirVisiteurEquipe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 323);
            this.Controls.Add(this.lbxRapports);
            this.Controls.Add(this.btnRapportsConsultés);
            this.Controls.Add(this.close);
            this.Controls.Add(this.cbxMatricule);
            this.Controls.Add(this.txtNbRapports);
            this.Controls.Add(this.labelNbRapports);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.txtPrenom);
            this.Controls.Add(this.dtAffectationRegion);
            this.Controls.Add(this.labeldtAffectation);
            this.Controls.Add(this.labelPrenom);
            this.Controls.Add(this.labelNom);
            this.Controls.Add(this.dtDateEmbauche);
            this.Controls.Add(this.labelDtEmbauche);
            this.Controls.Add(this.labelMat);
            this.Name = "FrmVoirVisiteurEquipe";
            this.Text = "FrmVoirVisiteurEquipe";
            this.Load += new System.EventHandler(this.FrmVoirVisiteurEquipe_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteur)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsRapport)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelPrenom;
        private System.Windows.Forms.Label labelNom;
        private System.Windows.Forms.DateTimePicker dtDateEmbauche;
        private System.Windows.Forms.Label labelDtEmbauche;
        private System.Windows.Forms.Label labelMat;
        private System.Windows.Forms.DateTimePicker dtAffectationRegion;
        private System.Windows.Forms.Label labeldtAffectation;
        private System.Windows.Forms.TextBox txtPrenom;
        private System.Windows.Forms.TextBox txtNom;
        private System.Windows.Forms.TextBox txtNbRapports;
        private System.Windows.Forms.Label labelNbRapports;
        private System.Windows.Forms.ComboBox cbxMatricule;
        private System.Windows.Forms.BindingSource bsVisiteur;
        private System.Windows.Forms.Button close;
        private System.Windows.Forms.Button btnRapportsConsultés;
        private System.Windows.Forms.ListBox lbxRapports;
        private System.Windows.Forms.BindingSource bsRapport;
    }
}