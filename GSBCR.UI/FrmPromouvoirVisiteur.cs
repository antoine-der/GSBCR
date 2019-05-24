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
    public partial class FrmPromouvoirVisiteur : Form
    {
        //NOTE : NON FONCTIONNEL --> LA LISTE DE VISITEURS NE CHARGE PAS
        private List<string> lesNumVis;
        private List<string> lesIdVis;
        private string matricule;
        public FrmPromouvoirVisiteur(string matricule)
        {
            this.matricule = matricule;
            InitializeComponent();
            VAFFECTATION t = Manager.ChargerAffectationVisiteur(this.matricule);
            string secteur = Manager.getSecteur(t.REG_CODE);
            List<VISITEUR> lv = Manager.chargerLesVisiteurs(secteur);
            bsVisiteurs1.DataSource = lv;

            this.lesNumVis = new List<string>();
            this.lesIdVis = new List<string>();
            
            foreach (VISITEUR v in lv)
            {                
                /*if(v.LeSecteur.ToString() == "")
                {

                }*/
                lesNumVis.Add(v.VIS_NOM + " " + v.Vis_PRENOM);
                lesIdVis.Add(v.VIS_MATRICULE);
            }
            bsVisiteurs1.DataSource = lesNumVis;
            listBox_matriculeVis.DataSource = bsVisiteurs1;
            if(lesNumVis.Count() == 0)
            {
                btn_promotion.Enabled = false;
            }
        }

        private void btn_promotion_Click(object sender, EventArgs e)
        {

        }

        private void btn_fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox_matriculeVis_SelectedIndexChanged(object sender, EventArgs e)
        {
            txt_nomPrenom.Text = listBox_matriculeVis.SelectedValue.ToString();
            int index = listBox_matriculeVis.SelectedIndex;
            txt_matricule.Text = lesIdVis[index];
            VAFFECTATION vaff = Manager.ChargerAffectationVisiteur(lesIdVis[index]);
            txt_region.Text = vaff.REG_CODE;
            txt_role.Text = vaff.TRA_ROLE;
            if(txt_role.Text != "Visiteur")
            {
                btn_promotion.Enabled = false;
            }
            else
            {
                btn_promotion.Enabled = true;
            }
        }
    }
}
