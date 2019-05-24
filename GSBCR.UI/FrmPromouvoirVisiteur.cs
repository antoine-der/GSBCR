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

        //Indique le matricule du visiteur selectionné
        string leMatricule = "";
        private List<string> lesNumVis;
        private List<string> lesNumDel;
        private string matricule;
        IDictionary<int, string> ListMatricule = new Dictionary<int, string>();
        IDictionary<string, string> ListNomPrenom = new Dictionary<string, string>();
        IDictionary<string, string> ListRegion = new Dictionary<string, string>();
        IDictionary<string, string> ListRole = new Dictionary<string, string>();
        List<VISITEUR> lv;
        public FrmPromouvoirVisiteur(string matricule)
        {
            this.matricule = matricule;
            InitializeComponent();
            listBox_matriculeDel.Enabled = false;
            listBox_matriculeDel.SelectionMode = SelectionMode.None;
            VAFFECTATION t = Manager.ChargerAffectationVisiteur(this.matricule);
            this.lv = Manager.chargerLesVisiteurs(t.REG_CODE);
            bsVisiteurs1.DataSource = lv;

            this.lesNumVis = new List<string>();
            this.lesNumDel = new List<string>();

            foreach (VISITEUR v in lv)
            {
                VAFFECTATION affectVisitActuel = Manager.ChargerAffectationVisiteur(v.VIS_MATRICULE);
                if (affectVisitActuel.TRA_ROLE == "Visiteur")
                {
                    lesNumVis.Add(v.VIS_NOM + " " + v.Vis_PRENOM);
                }

                if (affectVisitActuel.TRA_ROLE == "Délégué")
                {
                    lesNumDel.Add(v.VIS_NOM + " " + v.Vis_PRENOM);
                }
            }
            bsVisiteurs1.DataSource = lesNumVis;
            bsDelegues1.DataSource = lesNumDel;
            listBox_matriculeVis.DataSource = bsVisiteurs1;
            if (lesNumVis.Count() == 0)
            {
                btn_promotion.Enabled = false;
            }
        }

        private void btn_promotion_Click(object sender, EventArgs e)
        {            
            string m = this.ListMatricule[listBox_matriculeVis.SelectedIndex];
            string re = this.ListRegion[m];
            TRAVAILLER tra = new TRAVAILLER();
            tra.TRA_ROLE = "Délégué";
            tra.REG_CODE = re;
            tra.JJMMAA = DateTime.Now;
            tra.VIS_MATRICULE = m;
            Manager.promouvoirVisiteur(tra);
            MessageBox.Show("Le visiteur a bien été promu");
            this.Close();
        }

        private void btn_fermer_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void listBox_matriculeVis_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Indique l'index du visiteur selectionné
            int index = listBox_matriculeVis.SelectedIndex;
            leMatricule = "";
            int compteur = 0;
            foreach (VISITEUR v in lv)
            {
                                
                VAFFECTATION t = Manager.ChargerAffectationVisiteur(v.VIS_MATRICULE);
                if (t.TRA_ROLE == "Visiteur")
                {
                    this.ListMatricule[compteur] = v.VIS_MATRICULE;
                    this.ListNomPrenom[v.VIS_MATRICULE] = v.VIS_NOM + " " + v.Vis_PRENOM;
                    this.ListRegion[v.VIS_MATRICULE] = t.REG_CODE;
                    this.ListRole[v.VIS_MATRICULE] = t.TRA_ROLE;
                    compteur++;
                }
                                
            }

            if(ListMatricule.Count() != 0)
            {
                txt_nomPrenom.Text = listBox_matriculeVis.SelectedValue.ToString();
                leMatricule = this.ListMatricule[index];
                txt_matricule.Text = leMatricule;
                txt_region.Text = this.ListRegion[leMatricule];
                txt_role.Text = this.ListRole[leMatricule];
            }

        }

    }
}
