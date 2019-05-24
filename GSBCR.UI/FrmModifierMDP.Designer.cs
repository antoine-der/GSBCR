namespace GSBCR.UI
{
    partial class FrmModifierMDP
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
            this.lblTitre = new System.Windows.Forms.Label();
            this.txt_mdp_actuel = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_mdp_new = new System.Windows.Forms.TextBox();
            this.txt_mdp_c_new = new System.Windows.Forms.TextBox();
            this.btn_valider = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTitre
            // 
            this.lblTitre.AutoSize = true;
            this.lblTitre.CausesValidation = false;
            this.lblTitre.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitre.Location = new System.Drawing.Point(136, 30);
            this.lblTitre.Name = "lblTitre";
            this.lblTitre.Size = new System.Drawing.Size(205, 20);
            this.lblTitre.TabIndex = 4;
            this.lblTitre.Text = "Modifier le mot de passe";
            // 
            // txt_mdp_actuel
            // 
            this.txt_mdp_actuel.Location = new System.Drawing.Point(254, 91);
            this.txt_mdp_actuel.Name = "txt_mdp_actuel";
            this.txt_mdp_actuel.PasswordChar = '*';
            this.txt_mdp_actuel.Size = new System.Drawing.Size(158, 20);
            this.txt_mdp_actuel.TabIndex = 5;
            this.txt_mdp_actuel.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(95, 94);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Mot de passe actuel:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(81, 143);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nouveau mot de passe:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(25, 191);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(176, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Confirmer le nouveau mot de passe:";
            // 
            // txt_mdp_new
            // 
            this.txt_mdp_new.Location = new System.Drawing.Point(254, 143);
            this.txt_mdp_new.Name = "txt_mdp_new";
            this.txt_mdp_new.PasswordChar = '*';
            this.txt_mdp_new.Size = new System.Drawing.Size(158, 20);
            this.txt_mdp_new.TabIndex = 9;
            this.txt_mdp_new.UseSystemPasswordChar = true;
            // 
            // txt_mdp_c_new
            // 
            this.txt_mdp_c_new.Location = new System.Drawing.Point(254, 191);
            this.txt_mdp_c_new.Name = "txt_mdp_c_new";
            this.txt_mdp_c_new.PasswordChar = '*';
            this.txt_mdp_c_new.Size = new System.Drawing.Size(158, 20);
            this.txt_mdp_c_new.TabIndex = 10;
            this.txt_mdp_c_new.UseSystemPasswordChar = true;
            // 
            // btn_valider
            // 
            this.btn_valider.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_valider.Location = new System.Drawing.Point(195, 251);
            this.btn_valider.Name = "btn_valider";
            this.btn_valider.Size = new System.Drawing.Size(89, 23);
            this.btn_valider.TabIndex = 11;
            this.btn_valider.Text = "Valider";
            this.btn_valider.UseVisualStyleBackColor = true;
            this.btn_valider.Click += new System.EventHandler(this.btn_valider_Click);
            // 
            // FrmModifierMDP
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 297);
            this.Controls.Add(this.btn_valider);
            this.Controls.Add(this.txt_mdp_c_new);
            this.Controls.Add(this.txt_mdp_new);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_mdp_actuel);
            this.Controls.Add(this.lblTitre);
            this.Name = "FrmModifierMDP";
            this.Text = "FrmModifierMDP";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitre;
        private System.Windows.Forms.TextBox txt_mdp_actuel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_mdp_new;
        private System.Windows.Forms.TextBox txt_mdp_c_new;
        private System.Windows.Forms.Button btn_valider;
    }
}