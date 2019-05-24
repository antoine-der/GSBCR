namespace GSBCR.UI
{
    partial class FrmPromouvoirVisiteur
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
            this.listBox_matriculeVis = new System.Windows.Forms.ListBox();
            this.bsVisiteurs1 = new System.Windows.Forms.BindingSource(this.components);
            this.btn_promotion = new System.Windows.Forms.Button();
            this.btn_fermer = new System.Windows.Forms.Button();
            this.txt_matricule = new System.Windows.Forms.TextBox();
            this.txt_nomPrenom = new System.Windows.Forms.TextBox();
            this.txt_region = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_role = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listBox_matriculeDel = new System.Windows.Forms.ListBox();
            this.bsDelegues1 = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteurs1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDelegues1)).BeginInit();
            this.SuspendLayout();
            // 
            // listBox_matriculeVis
            // 
            this.listBox_matriculeVis.DataSource = this.bsVisiteurs1;
            this.listBox_matriculeVis.FormattingEnabled = true;
            this.listBox_matriculeVis.Location = new System.Drawing.Point(12, 59);
            this.listBox_matriculeVis.Name = "listBox_matriculeVis";
            this.listBox_matriculeVis.Size = new System.Drawing.Size(323, 277);
            this.listBox_matriculeVis.TabIndex = 0;
            this.listBox_matriculeVis.SelectedIndexChanged += new System.EventHandler(this.listBox_matriculeVis_SelectedIndexChanged);
            // 
            // btn_promotion
            // 
            this.btn_promotion.BackColor = System.Drawing.Color.Transparent;
            this.btn_promotion.Location = new System.Drawing.Point(365, 150);
            this.btn_promotion.Name = "btn_promotion";
            this.btn_promotion.Size = new System.Drawing.Size(118, 26);
            this.btn_promotion.TabIndex = 1;
            this.btn_promotion.Text = "Promouvoir -->";
            this.btn_promotion.UseVisualStyleBackColor = false;
            this.btn_promotion.Click += new System.EventHandler(this.btn_promotion_Click);
            // 
            // btn_fermer
            // 
            this.btn_fermer.BackColor = System.Drawing.Color.Transparent;
            this.btn_fermer.Location = new System.Drawing.Point(12, 497);
            this.btn_fermer.Name = "btn_fermer";
            this.btn_fermer.Size = new System.Drawing.Size(75, 23);
            this.btn_fermer.TabIndex = 2;
            this.btn_fermer.Text = "Fermer";
            this.btn_fermer.UseVisualStyleBackColor = false;
            this.btn_fermer.Click += new System.EventHandler(this.btn_fermer_Click);
            // 
            // txt_matricule
            // 
            this.txt_matricule.Location = new System.Drawing.Point(87, 370);
            this.txt_matricule.Name = "txt_matricule";
            this.txt_matricule.Size = new System.Drawing.Size(60, 20);
            this.txt_matricule.TabIndex = 3;
            // 
            // txt_nomPrenom
            // 
            this.txt_nomPrenom.Location = new System.Drawing.Point(178, 370);
            this.txt_nomPrenom.Name = "txt_nomPrenom";
            this.txt_nomPrenom.Size = new System.Drawing.Size(157, 20);
            this.txt_nomPrenom.TabIndex = 4;
            // 
            // txt_region
            // 
            this.txt_region.Location = new System.Drawing.Point(87, 425);
            this.txt_region.Name = "txt_region";
            this.txt_region.Size = new System.Drawing.Size(60, 20);
            this.txt_region.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 373);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Visiteur :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 428);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Région :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(175, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Rôle :";
            // 
            // txt_role
            // 
            this.txt_role.Location = new System.Drawing.Point(216, 425);
            this.txt_role.Name = "txt_role";
            this.txt_role.Size = new System.Drawing.Size(119, 20);
            this.txt_role.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(87, 23);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 18);
            this.label4.TabIndex = 11;
            this.label4.Text = "Visiteurs";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(612, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(78, 18);
            this.label5.TabIndex = 12;
            this.label5.Text = "Délégués";
            // 
            // listBox_matriculeDel
            // 
            this.listBox_matriculeDel.DataSource = this.bsDelegues1;
            this.listBox_matriculeDel.FormattingEnabled = true;
            this.listBox_matriculeDel.Location = new System.Drawing.Point(531, 69);
            this.listBox_matriculeDel.Name = "listBox_matriculeDel";
            this.listBox_matriculeDel.Size = new System.Drawing.Size(221, 264);
            this.listBox_matriculeDel.TabIndex = 13;
            // 
            // FrmPromouvoirVisiteur
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 544);
            this.Controls.Add(this.listBox_matriculeDel);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_role);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_region);
            this.Controls.Add(this.txt_nomPrenom);
            this.Controls.Add(this.txt_matricule);
            this.Controls.Add(this.btn_fermer);
            this.Controls.Add(this.btn_promotion);
            this.Controls.Add(this.listBox_matriculeVis);
            this.Name = "FrmPromouvoirVisiteur";
            this.Text = "FrmPromouvoirVisiteur";
            ((System.ComponentModel.ISupportInitialize)(this.bsVisiteurs1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsDelegues1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox listBox_matriculeVis;
        private System.Windows.Forms.Button btn_promotion;
        private System.Windows.Forms.Button btn_fermer;
        private System.Windows.Forms.BindingSource bsVisiteurs1;
        private System.Windows.Forms.TextBox txt_matricule;
        private System.Windows.Forms.TextBox txt_nomPrenom;
        private System.Windows.Forms.TextBox txt_region;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txt_role;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListBox listBox_matriculeDel;
        private System.Windows.Forms.BindingSource bsDelegues1;
    }
}