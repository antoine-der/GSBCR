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
    public partial class FrmConnexion : Form
    {
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

        private void btn_valider_Click(object sender, EventArgs e)
        {
            string mat = txt_mat.Text;
            string mdp = txt_mdp.Text;
            try
            {
                vis = Manager.ChargerVisiteur(mat, mdp);
                if (mat == "" || mdp == "" || mat != vis.VIS_MATRICULE || mdp != vis.vis_mdp)
                {
                    MessageBox.Show("Les identifiants ne sont pas tous remplis.");
                }
                else
                {
                    this.Visible = false;
                    FrmMenuVisiteur fmv = new FrmMenuVisiteur(mat, mdp);
                    fmv.ShowDialog();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Les identifiants sont incorrectes");
            }
            

        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
            Application.Exit();
        }
    }
}
