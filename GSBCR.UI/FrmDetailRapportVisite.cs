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
    //FORMULAIRE AFFICHANT LES DETAILS D'UN RAPPORT DE VISITE
    public partial class FrmDetailRapportVisite : Form
    {
        //Le formulaire prend en paramètre le matricule du visiteur (m) ainsi que le numero du rapport (n)
        public FrmDetailRapportVisite(string m, int n)
        {
            InitializeComponent();
            RAPPORT_VISITE r = Manager.ChargerRapportVisite(m, n);
            txt_matricule.Text = r.RAP_MATRICULE;
            txt_numero.Text = r.RAP_NUM.ToString();
            txt_matriculePraticien.Text = r.RAP_PRANUM.ToString();
            txt_date.Text = r.RAP_DATE.ToString();
            txt_dateVisite.Text = r.RAP_DATVISIT.ToString();
            txt_etat.Text = r.RAP_ETAT;
            txt_confiance.Text = r.RAP_CONFIANCE;
            txt_bilan.Text = r.RAP_BILAN;
        }

        private void FrmDetailRapportVisite_Load(object sender, EventArgs e)
        {

        }

        //Click sur le bouton "Quitter" : ferme le formulaire
        private void btn_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
