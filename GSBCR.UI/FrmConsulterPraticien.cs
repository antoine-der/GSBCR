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
    public partial class FrmConsulterPraticien : Form
    {
        private string idVisiteur;
        public FrmConsulterPraticien(VISITEUR idV)
        {
            this.idVisiteur = idV.VIS_MATRICULE;
            InitializeComponent();
            List<PRATICIEN> lpra = Manager.ChargerPraticiens();
            bsPra1.DataSource = lpra;
            cbxPra1.DataSource = bsPra1;
            cbxPra1.DisplayMember = "PRA_NOM";
            cbxPra1.ValueMember = "PRA_NUM";
            this.hideElements();
            cbxPra1.SelectedIndex = -1;
        }

        private void btn_choisir_praticien_Click(object sender, EventArgs e)
        {
            if (cbxPra1.SelectedIndex != -1)
            {
                PRATICIEN p = (PRATICIEN)cbxPra1.SelectedItem;
                ucPraticien1.LePraticien = p;
                ucPraticien1.Visible = true;
                checkBox_afficher_rapport.Visible = true;

                List<RAPPORT_VISITE> lesRapports = Manager.ChargerRapportVisiteurAvecPraticien(this.idVisiteur, p.PRA_NUM.ToString());
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

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_choisirRapport_Click(object sender, EventArgs e)
        {
            int noRapport = Int32.Parse(listBox_numRapport.SelectedItem.ToString());
            FrmDetailRapportVisite formulaire = new FrmDetailRapportVisite(this.idVisiteur, noRapport);
            formulaire.ShowDialog();
        }

        //Fonction qui va cacher certains élements lors du chargement du formulaire
        private void hideElements()
        {
            ucPraticien1.Visible = false;
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
