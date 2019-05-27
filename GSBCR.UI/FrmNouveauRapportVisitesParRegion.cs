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

namespace GSBCR.UI
{
    public partial class FrmNouveauRapportVisitesParRegion : Form
    {
        //private List<RAPPORT_VISITE> lesRapports = Manager.ChargerRapportRegionNonLus();
        // Charge  les rappors de la région non lus
        public FrmNouveauRapportVisitesParRegion(VAFFECTATION v)
        {
            InitializeComponent();
            //bsRapport.DataSource = Manager.ChargerRapportRegionNonLus(v.SEC_CODE);
            bsRapport.DataSource = Manager.ChargerRapportRegionNonLus(v.REG_CODE);
            cbxRapport.DataSource = bsRapport;
            cbxRapport.DisplayMember = "RAP_NUM";
            btnVoirLePraticien.Enabled = true;
        }
        // Bouton pour fermer le formulaire
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        // Affiche le rapport si un rapport est sélectionner
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
        // N'affiche pas les users controls au chargement du formulaire
        private void FrmNouveauRapportVisitesParRegion_Load(object sender, EventArgs e)
        {
            ucRapportsValides1.Visible = false;
            ucPraticien1.Visible = false;
        }
        // Bouton permettant l'affichage du praticien
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
