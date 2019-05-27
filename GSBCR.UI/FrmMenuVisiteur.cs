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
    //FORMULAIRE AFFICHANT LES CHOIX POSSIBLES (LES CHOIX DIFFERENT SELON LES RÔLES)
    public partial class FrmMenuVisiteur : Form
    {
        private VISITEUR leVisiteur;
        private VAFFECTATION leProfil;
        public FrmMenuVisiteur(string mat, string mdp)
        {
            InitializeComponent();
            //Le visiteur est passé en paramètre par le menu de connexion
            leVisiteur = Manager.ChargerVisiteur(mat, mdp);
            try
            {
                leProfil = Manager.ChargerAffectationVisiteur(leVisiteur.VIS_MATRICULE);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.GetBaseException().Message);
            }
            
        }

        //Fonction qui permet d'afficher les options disponibles selon le rôle de l'utilisateur
        private void FrmMenuVisiteur_Load(object sender, EventArgs e)
        {
            label2.Text = leProfil.TRA_ROLE + " " + leVisiteur.Vis_PRENOM + " " + leVisiteur.VIS_NOM;
            label3.Text = "Region : " + leProfil.REG_CODE;
            //S'il s'agit d'un visiteur
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
            //Sinon s'il s'agit d'un délégué
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
            //Sinon s'il s'agit d'un responsable
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

        //Click sur le bouton "Nouveau rapport de visite" : ouvre le formulaire de création d'un nouveau rapport de visite
        private void btnNouveau_Click(object sender, EventArgs e)
        {
            RAPPORT_VISITE r = new RAPPORT_VISITE();
            r.RAP_MATRICULE = leVisiteur.VIS_MATRICULE;
            FrmSaisir f = new FrmSaisir(r, true, 0);
            f.ShowDialog();
        }

        //Click sur le bouton "Quitter" : ferme le formulaire et quitte l'application
        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        //Click sur le bouton "Modifier Mot de passe" : ouvre le formulaire de modification du mot de passe
        private void btn_modifierMDP_Click(object sender, EventArgs e)
        {
            FrmModifierMDP fmdp = new FrmModifierMDP(leVisiteur);
            fmdp.ShowDialog();
        }

        //Click sur le bouton "Consulter Rapports validés" : ouvre le formulaire de consultation des rapports à l'état validé
        private void btnRapportValidés_Click(object sender, EventArgs e)
        {
            VISITEUR v = new VISITEUR();
            v.VIS_MATRICULE = leVisiteur.VIS_MATRICULE;
            FrmRapportsValides frv = new FrmRapportsValides(v);
            frv.ShowDialog();
        }

        //Click sur le bouton "Consulter médicament" : ouvre le formulaire de consultation d'un médicament
        private void btn_consulter_medicament_Click(object sender, EventArgs e)
        {
            VISITEUR v = new VISITEUR();
            v.VIS_MATRICULE = leVisiteur.VIS_MATRICULE;
            FrmConsulterMedicament fcm = new FrmConsulterMedicament(v);
            fcm.ShowDialog();
        }

        //Click sur le bouton "Consulter praticien" : ouvre le formulaire de consultation d'un praticien
        private void btn_consult_praticien_Click(object sender, EventArgs e)
        {
            VISITEUR v = new VISITEUR();
            v.VIS_MATRICULE = leVisiteur.VIS_MATRICULE;
            FrmConsulterPraticien fcp = new FrmConsulterPraticien(v);
            fcp.ShowDialog();
        }

        //Click sur le bouton "Modifier rapport visite" : ouvre le formulaire de modification d'un rapport de visite
        private void btnmModifierRapport_Click(object sender, EventArgs e)
        {
            RAPPORT_VISITE r = new RAPPORT_VISITE();
            r.RAP_MATRICULE = leVisiteur.VIS_MATRICULE;
            FrmSaisir f = new FrmSaisir(r, true, 1);
            f.ShowDialog();
        }

        ////Click sur le bouton "Promouvoir un visiteur" : ouvre le formulaire de promotion d'un visiteur
        private void button1_Click(object sender, EventArgs e)
        {
            FrmPromouvoirVisiteur f = new FrmPromouvoirVisiteur(leProfil.VIS_MATRICULE);
            f.ShowDialog();
        }

        //Click sur le bouton "Modifier Informations personnelles" : ouvre le formulaire de modifications des informations personnelles
        private void btnModifierInfoPerso_Click(object sender, EventArgs e)
        {
            
            FrmModifierInfoPerso f = new FrmModifierInfoPerso(this.leVisiteur);
            f.ShowDialog();
        }

        //Click sur le bouton "Consulter Nouveau rapport Region" : ouvre le formulaire de consultation des nouveaux rapports de la région de l'utilisateur
        private void btnNouveauRapportRegion_Click(object sender, EventArgs e)
        {
            VAFFECTATION vaff = new VAFFECTATION();
            vaff = leProfil;
            FrmNouveauRapportVisitesParRegion f = new FrmNouveauRapportVisitesParRegion(vaff);
            f.ShowDialog();
        }

        //Click sur le bouton "Se déconnecter" : deconnecte l'utilisateur et redémarre l'application (renvoi au formulaire de connexion)
        private void btn_deconnexion_Click(object sender, EventArgs e)
        {
            Application.Restart();
        }

        //Click sur le bouton "Consulter Visiteur de son équipe" : ouvre le formulaire de consultations des visiteurs de l'équipe de l'utilisateur connecté
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
