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
    public static class TypePraticienDAO
    {
        public static TYPE_PRATICIEN FindById(string code)
        {
            //A faire : rechercher un type praticien par son code
            TYPE_PRATICIEN type_pra = null;
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from tp in context.TYPE_PRATICIEN
                          where tp.TYP_CODE == code
                          select tp;
                type_pra = req.SingleOrDefault<TYPE_PRATICIEN>();

            }
            return type_pra;
        }

        public static List<TYPE_PRATICIEN> FindAll()
        {
            //A faire : charger tous les types praticiens
            List<TYPE_PRATICIEN> type_prat = null;
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from tp in context.TYPE_PRATICIEN
                          select tp;
                type_prat = req.ToList<TYPE_PRATICIEN>();

            }
            return type_prat;
        }

    }
}
