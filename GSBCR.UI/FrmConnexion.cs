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
    //FORMULAIRE DE CONNEXION
    public partial class FrmConnexion : Form
    {
        //Instantiation du visiteur
        VISITEUR vis = new VISITEUR();
        public FrmConnexion()
        {
            InitializeComponent();

        }

        private void lblTitre_Click(object sender, EventArgs e)
        {

        }

        private void FrmConnexion_Load(object sender, EventArgs e)
        {

        }

        //Click sur le bouton valider
        private void btn_valider_Click(object sender, EventArgs e)
        {
            string mat = txt_mat.Text;
            string mdp = txt_mdp.Text;
            try
            {
                vis = Manager.ChargerVisiteur(mat, mdp);
                //Si le mot de passe et / ou le matricule ne sont pas renseignés
                if (mat == "" || mdp == "" || mat != vis.VIS_MATRICULE || mdp != vis.vis_mdp)
                {
                    MessageBox.Show("Les identifiants ne sont pas tous remplis.");
                }
                //Sinon
                else
                {
                    this.Visible = false;
                    FrmMenuVisiteur fmv = new FrmMenuVisiteur(mat, mdp);
                    fmv.ShowDialog();
                }
            }
            //Si les identifiants sont incorrectes
            catch (Exception ex)
            {
                MessageBox.Show("Les identifiants sont incorrectes");
            }
            

        }

        //Click sur le bouton "Quitter", permet de fermer l'application
        private void btn_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
