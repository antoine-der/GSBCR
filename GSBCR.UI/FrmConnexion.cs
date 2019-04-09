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
        private VISITEUR vis;
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
            vis = Manager.ChargerVisiteur(mat, mdp);
            if (string.IsNullOrWhiteSpace(txt_mat.Text) || string.IsNullOrWhiteSpace(txt_mdp.Text))
            {
                MessageBox.Show("Les identifiants sont nulls ou incorrectes");
            }
            else
            {
                this.Visible = false;
                FrmMenuVisiteur fmv = new FrmMenuVisiteur(mat, mdp);
                fmv.ShowDialog();

            }

        }
    }
}
