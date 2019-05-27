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
    //FORMULAIRE AFFICHANT LES DETAILS D'UN MEDICAMENT
    public partial class FrmDetailsMedicament : Form
    {
        //Le formulaire prend en paramètre le depot legal du medicament dont il est question
        public FrmDetailsMedicament(string depotLegal)
        {
            InitializeComponent();
            MEDICAMENT med = Manager.ChargerLeMedicament(depotLegal);
            ucMedicament1.LeMedicament = med;
        }

        //Click sur le bouton "Quitter" : ferme le formulaire
        private void btn_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
