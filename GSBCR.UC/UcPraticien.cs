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
    public partial class UcPraticien : UserControl
    {
        public UcPraticien()
        {
            InitializeComponent();
        }

        private PRATICIEN lePraticien = null;

        public PRATICIEN LePraticien
        {
            get
            {
                return lePraticien;
            }

            set
            {
                lePraticien = value;
                if (lePraticien != null)
                {
                    ucPraticien_actualiser();
                }
            }
        }

        private void ucPraticien_actualiser()
        {
            numBox.Text = Convert.ToString(lePraticien.PRA_NUM);
            nomBox.Text = lePraticien.PRA_NOM;
            prenomBox.Text = lePraticien.PRA_PRENOM;
            adresseBox.Text = lePraticien.PRA_ADRESSE;
            cpBox.Text = lePraticien.PRA_CP;
            villeBox.Text = lePraticien.PRA_VILLE;
            coeffBox.Text = Convert.ToString(lePraticien.PRA_COEFNOTORIETE);
            codeBox.Text = lePraticien.TYP_CODE;
        }

        private void UcPraticien_Load(object sender, EventArgs e)
        {
                      
        }
    }
}
