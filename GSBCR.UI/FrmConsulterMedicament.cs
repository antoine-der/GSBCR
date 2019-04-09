using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSBCR.BLL;
using GSBCR.modele;

namespace GSBCR.UI
{    
    public partial class FrmConsulterMedicament : Form
    {
        private string idVisiteur;
        public FrmConsulterMedicament(string idV)
        {
            this.idVisiteur = idV;
            InitializeComponent();
            List<MEDICAMENT> lmed = Manager.ChargerMedicaments();
            bsMed1.DataSource = lmed;
            cbxMed1.DataSource = bsMed1;
            cbxMed1.DisplayMember = "MED_NOMCOMMERCIAL";
            cbxMed1.ValueMember = "MED_DEPOTLEGAL";
            this.hideElements();
            cbxMed1.SelectedIndex = -1;
        }

        private void btn_choisirRapport_Click(object sender, EventArgs e)
        {
            int noRapport = Int32.Parse(listBox_numRapport.SelectedItem.ToString());
            FrmDetailRapportVisite formulaire = new FrmDetailRapportVisite(this.idVisiteur, noRapport);
            formulaire.ShowDialog();
        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_choisir_medicament_Click(object sender, EventArgs e)
        {
            if (cbxMed1.SelectedIndex != -1)
            {
                MEDICAMENT m = (MEDICAMENT)cbxMed1.SelectedItem;
                ucMedicament1.LeMedicament = m;
                ucMedicament1.Visible = true;
                checkBox_afficher_rapport.Visible = true;

                List<RAPPORT_VISITE> lesRapports = Manager.ChargerRapportVisiteurAvecMedicament(this.idVisiteur, m.MED_DEPOTLEGAL);
                List<string> lesNumRap = new List<string>();
                foreach (RAPPORT_VISITE rv in lesRapports)
                {
                    lesNumRap.Add(rv.RAP_NUM.ToString());
                }

                if (lesNumRap.Count() == 0)
                {
                    btn_choisirRapport.Enabled = false;
                }
                else
                {
                    btn_choisirRapport.Enabled = true;
                }

                bsRapport1.DataSource = lesNumRap;
            }
        }

        //Fonction qui va cacher certains élements lors du chargement du formulaire
        private void hideElements()
        {
            ucMedicament1.Visible = false;
            listBox_numRapport.Visible = false;
            checkBox_afficher_rapport.Visible = false;
            btn_choisirRapport.Visible = false;
        }

        private void checkBox_afficher_rapport_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_afficher_rapport.Checked)
            {
                listBox_numRapport.Visible = true;
                btn_choisirRapport.Visible = true;
            }
            else
            {
                listBox_numRapport.Visible = false;
                btn_choisirRapport.Visible = false;
            }
        }


    }
}
