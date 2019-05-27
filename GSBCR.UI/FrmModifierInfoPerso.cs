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
    //FORMULAIRE PERMETTANT DE MODIFIER SES INFORMATIONS PERSONNELLES
    public partial class FrmModifierInfoPerso : Form
    {
        private VISITEUR v;
        //Constructeur : affiche les informations du visiteur dans les cases du formulaire
        public FrmModifierInfoPerso(VISITEUR v)
        {
            InitializeComponent();
            this.v = v;
            txtAdresse.Text = v.VIS_ADRESSE;
            txtCp.Text = v.VIS_CP;
            txtVille.Text = v.VIS_VILLE;
         
                InitRapport();
            
        }
        private void InitRapport()
        {
            txtAdresse.Text = v.VIS_ADRESSE;
            txtCp.Text = v.VIS_CP;
            txtVille.Text = v.VIS_VILLE;
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }

        //Click sur le bouton "Annuler" : annule les modifications efféctuées
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.Close();
        }

        //Click sur le bouton "Valider" : valide les informations saisies si celles-ci sont correctes
        private void btnValider_Click(object sender, EventArgs e)
        {
            
            string s = txtVille.Text;
            //Si le code postal n'est pas valide : affiche un message d'erreur
            if (txtCp.Text.Length != 5 || s.Any(char.IsNumber))
            {
                MessageBox.Show("Il faut que le code postal soit composé de 5 caractères et que la ville comporte uniquement des lettres");
            }
            //Sinon s'il est valide : met à jour les informations
            else
            {
                v.VIS_ADRESSE = txtAdresse.Text;
                v.VIS_CP = txtCp.Text;
                v.VIS_VILLE = txtVille.Text;
                Manager.MajInfosPersos(this.v);
                MessageBox.Show("Vos informations personnelles ont bien été mis à jour !");
                this.Close();
            }
            

        }
    }
}
