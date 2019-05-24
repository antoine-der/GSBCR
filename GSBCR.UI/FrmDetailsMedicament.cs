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
    public partial class FrmDetailsMedicament : Form
    {
        public FrmDetailsMedicament(string depotLegal)
        {
            InitializeComponent();
            MEDICAMENT med = Manager.ChargerLeMedicament(depotLegal);
            ucMedicament1.LeMedicament = med;
        }

        private void btn_quitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
