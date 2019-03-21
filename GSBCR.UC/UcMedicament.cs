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
    public partial class UcMedicament : UserControl
    {
        public UcMedicament()
        {
            InitializeComponent();
        }

        private void UcMedicament_Load(object sender, EventArgs e)
        {

        }

        private MEDICAMENT leMedicament = null;

        public MEDICAMENT LeMedicament
        {
            get
            {
                return leMedicament;
            }

            set
            {
                leMedicament = value;
                if (leMedicament != null)
                {
                    ucMedicament_actualiser();
                }
            }
        }

        private void ucMedicament_actualiser()
        {
            depotLegalBx.Text = leMedicament.MED_DEPOTLEGAL;
            nomCommercialBx.Text = leMedicament.MED_NOMCOMMERCIAL;
            idFamilleBx.Text = leMedicament.FAM_CODE;
            textFamilleBx.Text = leMedicament.LaFamille.FAM_LIBELLE;
            compositionTextBox.Text = leMedicament.MED_COMPOSITION;
            contreIndicationsTextBox.Text = leMedicament.MED_CONTREINDIC;
            effetsTextBox.Text = leMedicament.MED_EFFETS;
            prixEchantillonBx.Text = leMedicament.MED_PRIXECHANTILLON.ToString();
        }
    }
}
