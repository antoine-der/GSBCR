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
    public partial class FrmVoirVisiteurEquipe : Form
    {
        public FrmVoirVisiteurEquipe(VISITEUR v)
        {
            InitializeComponent();
            string matricule = v.VIS_MATRICULE;
            VAFFECTATION leprofil = Manager.ChargerAffectationVisiteur(matricule);

            if (leprofil.TRA_ROLE == "Délégué")
            {
                bsVisiteur.DataSource = Manager.ChargerVisiteurByRegion(leprofil.REG_CODE);
            }
            else if (leprofil.TRA_ROLE == "Responsable")
            {
                bsVisiteur.DataSource = Manager.ChargerVisiteurBySecteur(matricule, v.SEC_CODE);
            }

            
            List<RAPPORT_VISITE> lesRapports = Manager.ChargerRapportRegionLus(leprofil.REG_CODE);
            List<string> lesNumRap = new List<string>();
            foreach (RAPPORT_VISITE rv in lesRapports)
            {
                lesNumRap.Add(rv.RAP_NUM.ToString());
            }

            bsRapport.DataSource = lesNumRap;


            cbxMatricule.DataSource = bsVisiteur;
            cbxMatricule.DisplayMember = "VIS_MATRICULE";
        }

        private void cbxMatricule_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbxMatricule.SelectedIndex != -1)
            {
                VISITEUR v = (VISITEUR)cbxMatricule.SelectedItem;
                VAFFECTATION leprofil = Manager.ChargerAffectationVisiteur(v.VIS_MATRICULE);


                txtNom.Text = v.VIS_NOM;
                txtPrenom.Text = v.Vis_PRENOM;
                dtDateEmbauche.Value = v.VIS_DATEEMBAUCHE;
                dtAffectationRegion.Value = leprofil.JJMMAA;
                List<RAPPORT_VISITE> nbRapports = Manager.ChargerRapportRegionLus(leprofil.REG_CODE);
                txtNbRapports.Text = nbRapports.Count.ToString();

                txtNom.Visible = true;
                txtPrenom.Visible = true;
                dtAffectationRegion.Visible = true;
                txtNbRapports.Visible = true;
                dtDateEmbauche.Visible = true;
                labelNom.Visible = true;
                labelPrenom.Visible = true;
                labelDtEmbauche.Visible = true;
                labeldtAffectation.Visible = true;
                labelNbRapports.Visible = true;

                if (nbRapports.Count.ToString() == "0")
                {
                    btnRapportsConsultés.Visible = false;
                    lbxRapports.Visible = false;
                }
                else
                {
                    btnRapportsConsultés.Visible = true;
                    lbxRapports.Visible = true;
                }

            }
        }

        private void FrmVoirVisiteurEquipe_Load(object sender, EventArgs e)
        {

            lbxRapports.Visible = false;
            btnRapportsConsultés.Visible = false;     
            txtNom.Visible = false;
            txtPrenom.Visible = false;
            dtAffectationRegion.Visible = false;
            dtDateEmbauche.Visible = false;
            txtNbRapports.Visible = false;
            labelNom.Visible = false;
            labelPrenom.Visible = false;
            labelDtEmbauche.Visible = false;
            labeldtAffectation.Visible = false;
            labelNbRapports.Visible = false;
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnRapportsConsultés_Click(object sender, EventArgs e)
        {

        }
    }
}
