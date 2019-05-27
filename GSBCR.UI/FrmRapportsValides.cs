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
        // Charge les rapports finis des visiteurs
        public FrmRapportsValides(VISITEUR v)
        {
            InitializeComponent();
            btnVoirLePraticien.Visible = false;
            bsRapport.DataSource = Manager.ChargerRapportVisiteurFinis(v.VIS_MATRICULE);
            cbxRapport.DataSource = bsRapport;
            cbxRapport.DisplayMember = "RAP_NUM";
                       
        }
        // affiche les rapports finis des visiteurs, affiche les users controls si un rapport est sélectionner
        private void cbxRapport_SelectedIndexChanged(object sender, EventArgs e)
        {

            ucPraticien1.Visible = false;            
            if (cbxRapport.SelectedIndex != -1)
            {                
                RAPPORT_VISITE r = (RAPPORT_VISITE)cbxRapport.SelectedItem;
                ucRapportsValides1.LeRapportVisite = r;
                ucRapportsValides1.Visible = true;
                btnVoirLePraticien.Visible = true;
            }

            if (ucRapportsValides1.Visible == false)
            {
                btnVoirLePraticien.Enabled = false;
            }

        }
        // N'affiche pas les user control au chargement du formulaire
        private void FrmRapportsValides_Load(object sender, EventArgs e)
        {
            ucRapportsValides1.Visible = false;
            ucPraticien1.Visible = false;
            
        }
        // Charge le praticien
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

