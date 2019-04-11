namespace GSBCR.UI
{
    partial class FrmMenuVisiteur
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
            this.label1 = new System.Windows.Forms.Label();
            this.btnNouveau = new System.Windows.Forms.Button();
            this.btnRapportValidés = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnmModifierRapport = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.btn_modifierMDP = new System.Windows.Forms.Button();
            this.btn_consult_praticien = new System.Windows.Forms.Button();
            this.btn_consulter_medicament = new System.Windows.Forms.Button();
            this.btnModifierInfoPerso = new System.Windows.Forms.Button();
            this.btnNouveauRapportRegion = new System.Windows.Forms.Button();
            this.btn_deconnexion = new System.Windows.Forms.Button();
            this.btn_promotion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(78, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(373, 33);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestion rapports de visite";
            // 
            // btnNouveau
            // 
            this.btnNouveau.Location = new System.Drawing.Point(154, 205);
            this.btnNouveau.Name = "btnNouveau";
            this.btnNouveau.Size = new System.Drawing.Size(200, 23);
            this.btnNouveau.TabIndex = 2;
            this.btnNouveau.Text = "Nouveau rapport de visite";
            this.btnNouveau.UseVisualStyleBackColor = true;
            this.btnNouveau.Visible = false;
            this.btnNouveau.Click += new System.EventHandler(this.btnNouveau_Click);
            // 
            // btnRapportValidés
            // 
            this.btnRapportValidés.Location = new System.Drawing.Point(154, 263);
            this.btnRapportValidés.Name = "btnRapportValidés";
            this.btnRapportValidés.Size = new System.Drawing.Size(200, 23);
            this.btnRapportValidés.TabIndex = 7;
            this.btnRapportValidés.Text = "Consulter Rapport validés";
            this.btnRapportValidés.UseVisualStyleBackColor = true;
            this.btnRapportValidés.Click += new System.EventHandler(this.btnRapportValidés_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "label2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(444, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "label3";
            // 
            // btnmModifierRapport
            // 
            this.btnmModifierRapport.Location = new System.Drawing.Point(154, 234);
            this.btnmModifierRapport.Name = "btnmModifierRapport";
            this.btnmModifierRapport.Size = new System.Drawing.Size(200, 23);
            this.btnmModifierRapport.TabIndex = 0;
            this.btnmModifierRapport.Text = "Modifier rapport visite";
            this.btnmModifierRapport.Click += new System.EventHandler(this.btnmModifierRapport_Click);
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(154, 367);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(200, 23);
            this.btnQuitter.TabIndex = 6;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btn_modifierMDP
            // 
            this.btn_modifierMDP.Location = new System.Drawing.Point(154, 164);
            this.btn_modifierMDP.Name = "btn_modifierMDP";
            this.btn_modifierMDP.Size = new System.Drawing.Size(200, 23);
            this.btn_modifierMDP.TabIndex = 7;
            this.btn_modifierMDP.Text = "Modifier Mot de Passe";
            this.btn_modifierMDP.UseVisualStyleBackColor = true;
            this.btn_modifierMDP.Click += new System.EventHandler(this.btn_modifierMDP_Click);
            // 
            // btn_consult_praticien
            // 
            this.btn_consult_praticien.Location = new System.Drawing.Point(154, 106);
            this.btn_consult_praticien.Name = "btn_consult_praticien";
            this.btn_consult_praticien.Size = new System.Drawing.Size(200, 23);
            this.btn_consult_praticien.TabIndex = 8;
            this.btn_consult_praticien.Text = "Consulter Praticien";
            this.btn_consult_praticien.UseVisualStyleBackColor = true;
            this.btn_consult_praticien.Click += new System.EventHandler(this.btn_consult_praticien_Click);
            // 
            // btn_consulter_medicament
            // 
            this.btn_consulter_medicament.Location = new System.Drawing.Point(154, 135);
            this.btn_consulter_medicament.Name = "btn_consulter_medicament";
            this.btn_consulter_medicament.Size = new System.Drawing.Size(200, 23);
            this.btn_consulter_medicament.TabIndex = 9;
            this.btn_consulter_medicament.Text = "Consulter médicament";
            this.btn_consulter_medicament.UseVisualStyleBackColor = true;
            this.btn_consulter_medicament.Click += new System.EventHandler(this.btn_consulter_medicament_Click);
            // 
            // btnModifierInfoPerso
            // 
            this.btnModifierInfoPerso.Location = new System.Drawing.Point(154, 344);
            this.btnModifierInfoPerso.Name = "btnModifierInfoPerso";
            this.btnModifierInfoPerso.Size = new System.Drawing.Size(200, 23);
            this.btnModifierInfoPerso.TabIndex = 10;
            this.btnModifierInfoPerso.Text = "Modifier Informations persosonelles";
            this.btnModifierInfoPerso.UseVisualStyleBackColor = true;
            this.btnModifierInfoPerso.Click += new System.EventHandler(this.btnModifierInfoPerso_Click);
            // 
            // btnNouveauRapportRegion
            // 
            this.btnNouveauRapportRegion.Location = new System.Drawing.Point(154, 385);
            this.btnNouveauRapportRegion.Name = "btnNouveauRapportRegion";
            this.btnNouveauRapportRegion.Size = new System.Drawing.Size(200, 23);
            this.btnNouveauRapportRegion.TabIndex = 11;
            this.btnNouveauRapportRegion.Text = "Consulter Nouveau rapport Region";
            this.btnNouveauRapportRegion.UseVisualStyleBackColor = true;
            this.btnNouveauRapportRegion.Click += new System.EventHandler(this.btnNouveauRapportRegion_Click);
            // 
            // btn_deconnexion
            // 
            this.btn_deconnexion.Location = new System.Drawing.Point(154, 338);
            this.btn_deconnexion.Name = "btn_deconnexion";
            this.btn_deconnexion.Size = new System.Drawing.Size(200, 23);
            this.btn_deconnexion.TabIndex = 10;
            this.btn_deconnexion.Text = "Se déconnecter";
            this.btn_deconnexion.UseVisualStyleBackColor = true;
            this.btn_deconnexion.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_promotion
            // 
            this.btn_promotion.Location = new System.Drawing.Point(154, 295);
            this.btn_promotion.Name = "btn_promotion";
            this.btn_promotion.Size = new System.Drawing.Size(200, 22);
            this.btn_promotion.TabIndex = 10;
            this.btn_promotion.Text = "Promouvoir un visiteur";
            this.btn_promotion.UseVisualStyleBackColor = true;
            this.btn_promotion.Click += new System.EventHandler(this.button1_Click);
            // 
            // FrmMenuVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 479);
            this.Controls.Add(this.btnNouveauRapportRegion);
            this.Controls.Add(this.btnModifierInfoPerso);
            this.ClientSize = new System.Drawing.Size(527, 411);
            this.Controls.Add(this.btn_deconnexion);
            this.Controls.Add(this.btn_promotion);
            this.Controls.Add(this.btnmModifierRapport);
            this.Controls.Add(this.btn_consulter_medicament);
            this.Controls.Add(this.btn_consult_praticien);
            this.Controls.Add(this.btn_modifierMDP);
            this.Controls.Add(this.btnRapportValidés);
            this.Controls.Add(this.btnQuitter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnNouveau);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmMenuVisiteur";
            this.Text = "FrmMenuVisiteur";
            this.Load += new System.EventHandler(this.FrmMenuVisiteur_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnNouveau;
        private System.Windows.Forms.Button btnQuitter;
        private System.Windows.Forms.Button btnRapportValidés;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnmModifierRapport;
        private System.Windows.Forms.Button btn_modifierMDP;
        private System.Windows.Forms.Button btn_consult_praticien;
        private System.Windows.Forms.Button btn_consulter_medicament;
        private System.Windows.Forms.Button btnModifierInfoPerso;
        private System.Windows.Forms.Button btnNouveauRapportRegion;
        private System.Windows.Forms.Button btn_deconnexion;
        private System.Windows.Forms.Button btn_promotion;
    }
}