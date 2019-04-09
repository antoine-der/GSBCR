using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GSBCR.modele;

namespace GSBCR.UC
{
    public partial class UcRapportsValides : UserControl
    {
        public UcRapportsValides()
        {
            InitializeComponent();
        }
        private RAPPORT_VISITE leRapportVisite = null;


        public RAPPORT_VISITE LeRapportVisite
        {
            get
            {
                return leRapportVisite;
            }

            set
            {
                leRapportVisite = value;
                if (leRapportVisite != null)
                {
                    ucRapportVisite_actualiser();
                }
            }
        }

        private void ucRapportVisite_actualiser()
        {
            txtNumPrat.Text = Convert.ToString(leRapportVisite.RAP_NUM);
            txtDateVisite.Text = Convert.ToString(leRapportVisite.RAP_DATVISIT);
            txtMotifVisite.Text = leRapportVisite.RAP_MOTIF;
            txtAutreMotifVisite.Text = leRapportVisite.RAP_MOTIFAUTRE;
            txtEtat.Text = leRapportVisite.RAP_ETAT;
            txtCoefConfiance.Text = leRapportVisite.RAP_CONFIANCE;
            txtBilan.Text = leRapportVisite.RAP_BILAN;
            txtMed1.Text = leRapportVisite.RAP_MED1;
            txtMed2.Text = leRapportVisite.RAP_MED2;
        }

        private void UcRapportsValides_Load(object sender, EventArgs e)
        {
            txtBilan.Visible = false;
            txtCoefConfiance.Visible = false;
            labelBilan.Visible = false;
            labelCoeff.Visible = false;

        }

        private void btnDetailRapport_Click(object sender, EventArgs e)
        {
            txtBilan.Visible = true;
            txtCoefConfiance.Visible = true;
            labelBilan.Visible = true;
            labelCoeff.Visible = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            txtBilan.Visible = true;
            txtCoefConfiance.Visible = true;
            labelBilan.Visible = true;
            labelCoeff.Visible = true;

            if (checkBxDetail.Checked == false)
            {
                txtBilan.Visible = false;
                txtCoefConfiance.Visible = false;
                labelBilan.Visible = false;
                labelCoeff.Visible = false;
            }
        }
    }
}
