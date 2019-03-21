using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GSBCR.modele;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;

namespace GSBCR.DAL
{
    public static class FamilleDAO
    {
        public static FAMILLE FindById(string code)
        {
            //A faire : rechercher un médicament par son nom de dépot
            FAMILLE fam = null;
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from f in context.FAMILLE.Include("LesMedicaments")
                          where f.FAM_CODE == code
                          select f;
                fam = req.SingleOrDefault<FAMILLE>();

            }
            return fam;
        }

        public static List<FAMILLE> FindAll()
        {
            //A faire : charger toutes les familles de médicaments
            List<FAMILLE> fam = null;
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from f in context.FAMILLE.Include("LesMedicaments")
                          select f;
                fam = req.ToList<FAMILLE>();

            }
            return fam;
        }

    }
}
