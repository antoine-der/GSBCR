using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace GSBCR.UI
{
    static class Program
    {
        /// <summary>
        /// Point d'entrée principal de l'application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            /* TEST */
             Application.Run(new FrmMenuVisiteur());
             //Application.Run(new FrmConsulterPraticien("a131"));
             //Application.Run(new FrmDetailRapportVisite("a131", 3));
             //Application.Run(new FrmConsulterMedicament("a131"));            
        }
    }
}
