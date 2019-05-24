namespace GSBCR.UI
{
    partial class FrmDetailsMedicament
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
            this.btn_quitter = new System.Windows.Forms.Button();
            this.ucMedicament1 = new GSBCR.UC.UcMedicament();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.MediumTurquoise;
            this.label1.Location = new System.Drawing.Point(67, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(258, 33);
            this.label1.TabIndex = 1;
            this.label1.Text = "Détail medicament";
            // 
            // btn_quitter
            // 
            this.btn_quitter.BackColor = System.Drawing.Color.Transparent;
            this.btn_quitter.Location = new System.Drawing.Point(161, 523);
            this.btn_quitter.Name = "btn_quitter";
            this.btn_quitter.Size = new System.Drawing.Size(93, 33);
            this.btn_quitter.TabIndex = 18;
            this.btn_quitter.Text = "Quitter";
            this.btn_quitter.UseVisualStyleBackColor = false;
            this.btn_quitter.Click += new System.EventHandler(this.btn_quitter_Click);
            // 
            // ucMedicament1
            // 
            this.ucMedicament1.LeMedicament = null;
            this.ucMedicament1.Location = new System.Drawing.Point(-3, 96);
            this.ucMedicament1.Name = "ucMedicament1";
            this.ucMedicament1.Size = new System.Drawing.Size(430, 421);
            this.ucMedicament1.TabIndex = 19;
            // 
            // FrmDetailsMedicament
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(439, 631);
            this.Controls.Add(this.ucMedicament1);
            this.Controls.Add(this.btn_quitter);
            this.Controls.Add(this.label1);
            this.Name = "FrmDetailsMedicament";
            this.Text = "FrmDetailsMedicament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_quitter;
        private UC.UcMedicament ucMedicament1;
    }
}