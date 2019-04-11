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
    public static class VisiteurDAO
    {
        /// <summary>
        /// Permet de retrouver les infos d'un visiteur à partir de son login et mot de passe
        /// </summary>
        /// <param name="matricule">matricule Visiteur</param>
        /// <returns>VISITEUR</returns>
        public static VISITEUR FindById(string matricule)
        {
            VISITEUR vis = null;
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from v in context.VISITEUR
                          where v.VIS_MATRICULE == matricule
                          select v; 
                vis = req.SingleOrDefault<VISITEUR>();
            }
            return vis;
        }




        /// <summary>
        /// Permet d'obtenir le secteur avec le matricule d'un visiteur
        
        /// </summary>
        /// <param name="region">code region</param>
        /// <returns>VISITEUR</returns>
        public static string getSecteur(string region)
        {
            string sec = null;
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from v in context.REGION
                          where v.REG_CODE == region
                          select v.SEC_CODE;
                sec = req.ToString();
            }
            return sec;
        }

        /// <summary>
        /// Permet d'obtenir une liste de tous les visiteurs appartenant à un secteur passé en paramètre
        /// </summary>
        /// <param name="matricule">matricule Visiteur</param>
        /// <returns>VISITEUR</returns>
        public static List<VISITEUR> FindAllInSec(string secteur)
        {
            List<VISITEUR> vis = null;
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from v in context.VISITEUR
                          join vaff in context.VAFFECTATION on v.VIS_MATRICULE equals vaff.VIS_MATRICULE
                          join reg in context.REGION on vaff.REG_CODE equals reg.REG_CODE
                          where reg.SEC_CODE == secteur
                          select v;
                vis = req.ToList<VISITEUR>();
            }
            return vis;
        }



        /// <summary>
        /// Permet d'obtenir une liste de tous les visiteurs
        /// </summary>
        /// <returns>VISITEUR</returns>
        public static List<VISITEUR> FindAll()
        {
            List<VISITEUR> vis = null;
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from v in context.VISITEUR
                          select v;
                vis = req.ToList<VISITEUR>();
            }
            return vis;
        }

        /// <summary>
        /// Permet de mettre un visiteur, délégué de région
        /// </summary>
        /// <param name="matricule">matricule Visiteur</param>
        /*public static void promouvoir(string matricule)
        {
            VISITEUR vis = null;
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = "insert into TRAVAILLER(VIS_MATRICULE, JJMMAA, REG_CODE, TRA_ROLE) values(" + matricule + ", now(), )";
                vis = req.SingleOrDefault<VISITEUR>();
            }
            return vis;
        }*/

    }
}
