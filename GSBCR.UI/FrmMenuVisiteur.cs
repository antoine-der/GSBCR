﻿using System;
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
            if (leProfil.TRA_ROLE == "Visiteur" || leProfil.TRA_ROLE == "Délégué")
            {
                btnNouveau.Visible = true;
            }
        }

        private void btnNouveau_Click(object sender, EventArgs e)
        {
            RAPPORT_VISITE r = new RAPPORT_VISITE();
            r.RAP_MATRICULE = leVisiteur.VIS_MATRICULE;
            FrmSaisir f = new FrmSaisir(r, true);
            f.ShowDialog();
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }

        private void btn_modifierMDP_Click(object sender, EventArgs e)
        {
            FrmModifierMDP fmdp = new FrmModifierMDP();
            fmdp.ShowDialog();
        }
    }
}
