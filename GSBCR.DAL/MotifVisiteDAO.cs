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
    public static class MotifVisiteDAO
    {
        public static MOTIF_VISITE FindById(string nom)
        {
            //A faire : rechercher un motif visite par son nom
            MOTIF_VISITE motif = null;
            using (var context = new GSB_VisiteEntities())
            {
                var req = from m in context.MOTIF_VISITE.Include("LesRapports")
                          where m.MOT_LIBEL == nom
                          select m;
                motif = req.SingleOrDefault<MOTIF_VISITE>();
            }
            return motif;
        }

        public static List<MOTIF_VISITE> FindAll()
        {
            //A faire : charger tous les motifs visite
            List<MOTIF_VISITE> motif = null;
            using (var context = new GSB_VisiteEntities())
            {
                var req = from m in context.MOTIF_VISITE.Include("LesRapports")
                          select m;
                motif = req.ToList<MOTIF_VISITE>();
            }
            return motif;
        }
    }
}
