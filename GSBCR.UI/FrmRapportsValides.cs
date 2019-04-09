using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSBCR.modele;
using GSBCR.BLL;
using GSBCR.UC;

namespace GSBCR.UI
{
    public partial class FrmRapportsValides : Form
    {
        RAPPORT_VISITE r;
        public FrmRapportsValides(VISITEUR v)
        {
            InitializeComponent();
            bsRapport.DataSource = Manager.ChargerRapportVisiteurFinis(v.VIS_MATRICULE);
            cbxRapport.DataSource = bsRapport;
            cbxRapport.DisplayMember = "RAP_NUM";
                       
        }

        private void cbxRapport_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cbxRapport.SelectedIndex != -1)
            {
                RAPPORT_VISITE r = (RAPPORT_VISITE)cbxRapport.SelectedItem;
                ucRapportsValides1.LeRapportVisite = r;
                ucRapportsValides1.Visible = true;
            }

            if (ucRapportsValides1.Visible == false)
            {
                btnVoirLePraticien.Enabled = false;
            }

        }
        
        private void FrmRapportsValides_Load(object sender, EventArgs e)
        {
            ucRapportsValides1.Visible = false;
            ucPraticien1.Visible = false;
            
        }

        private void btnVoirLePraticien_Click(object sender, EventArgs e)
        {
            Int16 mat = Int16.Parse(ucRapportsValides1.txtNumPrat.Text.ToString());
            PRATICIEN p = Manager.ChargerLePraticien(mat);

            if (p == null)
            {
                string msg = "Il n'y a pas de Praticien";
                MessageBox.Show(msg);
            }
            ucPraticien1.LePraticien = p;
            ucPraticien1.Visible = true;
        }
    }
    
}

