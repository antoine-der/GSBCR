using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GSBCR.modele;
using GSBCR.BLL;

namespace GSBCR.UI
{
    public partial class FrmMenuVisiteur : Form
    {
        private VISITEUR leVisiteur;
        private VAFFECTATION leProfil;
        public FrmMenuVisiteur(string mat, string mdp)
        {
            InitializeComponent();
            //le visiteur doit être passé en paramètre par le menu de connexion
            //Ici initialiser le visiteur en dur
            //visiteur
            leVisiteur = Manager.ChargerVisiteur(mat, mdp);
            
            //délégue
            //leVisiteur = Manager.ChargerVisiteur("r58", "0CC56730");
            try
            {
                leProfil = Manager.ChargerAffectationVisiteur(leVisiteur.VIS_MATRICULE);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);
            }
            
        }

        private void FrmMenuVisiteur_Load(object sender, EventArgs e)
        {
            label2.Text = leProfil.TRA_ROLE + " " + leVisiteur.Vis_PRENOM + " " + leVisiteur.VIS_NOM;
            label3.Text = "Region : " + leProfil.REG_CODE;
            if (leProfil.TRA_ROLE == "Visiteur")
            {
                btn_consult_praticien.Visible = true;
                btn_consulter_medicament.Visible = true;
                btnModifierInfoPerso.Visible = true;
                btn_modifierMDP.Visible = true;
                btnNouveau.Visible = true;
                btnmModifierRapport.Visible = true;
                btnRapportValidés.Visible = true;
            }
            else if (leProfil.TRA_ROLE == "Délégué")
            {
                btn_consult_praticien.Visible = true;
                btn_consulter_medicament.Visible = true;
                btnModifierInfoPerso.Visible = true;
                btn_modifierMDP.Visible = true;
                btnNouveau.Visible = true;
                btnmModifierRapport.Visible = true;
                btnRapportValidés.Visible = true;
                btnNouveauRapportRegion.Visible = true;
                btnVoirVisiteurEquipe.Visible = true;
            }
            else if (leProfil.TRA_ROLE == "Responsable")
            {
                btn_consult_praticien.Visible = true;
                btn_consulter_medicament.Visible = true;
                btnModifierInfoPerso.Visible = true;
                btn_modifierMDP.Visible = true;
                btnVoirVisiteurEquipe.Visible = true;
                btn_promotion.Visible = true;
            }
            
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            RAPPORT_VISITE r = new RAPPORT_VISITE();
            r.RAP_MATRICULE = leVisiteur.VIS_MATRICULE;
            FrmSaisir f = new FrmSaisir(r, true, 0);
            f.ShowDialog();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btn_modifierMDP_Click(object sender, EventArgs e)
        {
            FrmModifierMDP fmdp = new FrmModifierMDP(leVisiteur);
            fmdp.ShowDialog();
        }

        private void btnRapportValidés_Click(object sender, EventArgs e)
        {
            VISITEUR v = new VISITEUR();
            v.VIS_MATRICULE = leVisiteur.VIS_MATRICULE;
            FrmRapportsValides frv = new FrmRapportsValides(v);
            frv.ShowDialog();
        }

        private void btn_consulter_medicament_Click(object sender, EventArgs e)
        {
            VISITEUR v = new VISITEUR();
            v.VIS_MATRICULE = leVisiteur.VIS_MATRICULE;
            FrmConsulterMedicament fcm = new FrmConsulterMedicament(v);
            fcm.ShowDialog();
        }

        private void btn_consult_praticien_Click(object sender, EventArgs e)
        {
            VISITEUR v = new VISITEUR();
            v.VIS_MATRICULE = leVisiteur.VIS_MATRICULE;
            FrmConsulterPraticien fcp = new FrmConsulterPraticien(v);
            fcp.ShowDialog();
        }

        private void btnmModifierRapport_Click(object sender, EventArgs e)
        {
            RAPPORT_VISITE r = new RAPPORT_VISITE();
            r.RAP_MATRICULE = leVisiteur.VIS_MATRICULE;
            FrmSaisir f = new FrmSaisir(r, true, 1);
            f.ShowDialog();
        }

        //Promouvoir un visiteur
        private void button1_Click(object sender, EventArgs e)
        {
            FrmPromouvoirVisiteur f = new FrmPromouvoirVisiteur(leProfil.VIS_MATRICULE);
            f.ShowDialog();
        }

        private void btnModifierInfoPerso_Click(object sender, EventArgs e)
        {
            
            FrmModifierInfoPerso f = new FrmModifierInfoPerso(this.leVisiteur);
            f.ShowDialog();
        }

        private void btnNouveauRapportRegion_Click(object sender, EventArgs e)
        {
            FrmNouveauRapportVisitesParRegion f = new FrmNouveauRapportVisitesParRegion();
            f.ShowDialog();
        }

        /*private void button1_Click(object sender, EventArgs e)
        {
            
        }*/

        private void btn_deconnexion_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        private void btnVoirVisiteurEquipe_Click(object sender, EventArgs e)
        {
            VISITEUR v = new VISITEUR();
            v.VIS_MATRICULE = leVisiteur.VIS_MATRICULE;
            v.SEC_CODE = leVisiteur.SEC_CODE;
            FrmVoirVisiteurEquipe fvve = new FrmVoirVisiteurEquipe(v);
            fvve.ShowDialog();
        }
    }
}
