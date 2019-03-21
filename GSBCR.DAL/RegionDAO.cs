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
    public static class RegionDAO
    {
        public static REGION FindById(string code)
        {
            //A faire : rechercher une région par son nom
            REGION reg = null;
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from r in context.REGION.Include("leSecteur")
                          where r.REG_CODE == code
                          select r;
                reg = req.SingleOrDefault<REGION>();

            }
            return reg;
        }

        public static List<REGION> FindAll()
        {
            //A faire : charger toutes les régions
            List<REGION> reg = null;
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from r in context.REGION.Include("leSecteur")
                          select r;
                reg = req.ToList<REGION>();

            }
            return reg;
        }
    }
}
