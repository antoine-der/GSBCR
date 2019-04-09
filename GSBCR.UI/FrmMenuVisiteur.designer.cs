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
            this.btnNouveau.Location = new System.Drawing.Point(154, 101);
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
            this.btnRapportValidés.Location = new System.Drawing.Point(154, 207);
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
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(154, 333);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(200, 23);
            this.btnQuitter.TabIndex = 6;
            this.btnQuitter.Text = "Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            this.btnQuitter.Click += new System.EventHandler(this.btnQuitter_Click);
            // 
            // btn_modifierMDP
            // 
            this.btn_modifierMDP.Location = new System.Drawing.Point(154, 292);
            this.btn_modifierMDP.Name = "btn_modifierMDP";
            this.btn_modifierMDP.Size = new System.Drawing.Size(200, 23);
            this.btn_modifierMDP.TabIndex = 7;
            this.btn_modifierMDP.Text = "Modifier Mot de Passe";
            this.btn_modifierMDP.UseVisualStyleBackColor = true;
            this.btn_modifierMDP.Click += new System.EventHandler(this.btn_modifierMDP_Click);
            // 
            // btn_consult_praticien
            // 
            this.btn_consult_praticien.Location = new System.Drawing.Point(154, 139);
            this.btn_consult_praticien.Name = "btn_consult_praticien";
            this.btn_consult_praticien.Size = new System.Drawing.Size(200, 23);
            this.btn_consult_praticien.TabIndex = 8;
            this.btn_consult_praticien.Text = "Consulter Praticien";
            this.btn_consult_praticien.UseVisualStyleBackColor = true;
            this.btn_consult_praticien.Click += new System.EventHandler(this.btn_consult_praticien_Click);
            // 
            // btn_consulter_medicament
            // 
            this.btn_consulter_medicament.Location = new System.Drawing.Point(154, 182);
            this.btn_consulter_medicament.Name = "btn_consulter_medicament";
            this.btn_consulter_medicament.Size = new System.Drawing.Size(200, 23);
            this.btn_consulter_medicament.TabIndex = 9;
            this.btn_consulter_medicament.Text = "Consulter médicament";
            this.btn_consulter_medicament.UseVisualStyleBackColor = true;
            this.btn_consulter_medicament.Click += new System.EventHandler(this.btn_consulter_medicament_Click);
            // 
            // FrmMenuVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 411);
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
    }
}