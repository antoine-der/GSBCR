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
        /// Permet d'obtenir une liste de tous les visiteurs appartenant à une region passée en paramètre
        /// </summary>
        /// <param name="region">Region</param>
        /// <returns>VISITEUR</returns>
        public static List<VISITEUR> FindAllInReg(string region)
        {
            List<VISITEUR> vis = null;
            using (var context = new GSB_VisiteEntities())
            {
                //désactiver le chargement différé
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from v in context.VISITEUR
                          join vaff in context.VAFFECTATION on v.VIS_MATRICULE equals vaff.VIS_MATRICULE
                          join reg in context.REGION on vaff.REG_CODE equals reg.REG_CODE
                          where reg.REG_CODE == region
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
        /// <param name="region">region du visiteur</param>
        /// <param name="role">role du visiteur</param>
        public static void promouvoir(TRAVAILLER tra)
        {
            try
            {
                using (var context = new GSB_VisiteEntities())
                {
                    context.TRAVAILLER.Add(tra);
                    //sauvegarde du contexte
                    context.SaveChanges();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        /// <summary>
        /// Permet de modifier les infos perso du visiteur
        /// </summary>
        /// <param name="v">Infos du visiteur</param>
        public static void update(VISITEUR v)
        {
            using (var context = new GSB_VisiteEntities())
            {
                try
                {
                    //mise à jour de l'état du rapport 
                    context.Entry<VISITEUR>(v).State = System.Data.EntityState.Modified;
                    //sauvegarde du contexte
                    context.SaveChanges();
                }
                catch (Exception ex)
                {

                    throw ex;
                }

            }
        }
        /// <summary>
        /// Permet de modifier le mot de passe d'un visiteur
        /// </summary>
        /// <param name="v">Infos du visiteur</param>
        public static void MajMDP(VISITEUR v)
        {
            using (var context = new GSB_VisiteEntities())
            {
                try
                {
                    //mise à jour de l'état du rapport 
                    context.Entry<VISITEUR>(v).State = System.Data.EntityState.Modified;
                    //sauvegarde du contexte
                    context.SaveChanges();
                }
                catch (Exception ex)
                {

                    throw ex;
                }
            }
        }
        /// <summary>
        /// Permet de retrouver les infos d'un visiteur à partir de son login et mot de passe
        /// </summary>
        /// <param name="matricule">matricule Visiteur</param>
        /// <returns>VISITEUR</returns>
        public static List<VISITEUR> FindBySecteur(string respon, string secteurCode)
        {
            List<VISITEUR> vis = null;
            using (var context = new GSB_VisiteEntities())
            {
                //context.Configuration.LazyLoadingEnabled = false;
                var req = from v in context.VISITEUR
                          join vaff in context.VAFFECTATION on v.VIS_MATRICULE equals vaff.VIS_MATRICULE
                          join reg in context.REGION on vaff.REG_CODE equals reg.REG_CODE
                          where reg.SEC_CODE == secteurCode && v.VIS_MATRICULE != respon
                          select v;
                vis = req.ToList<VISITEUR>();
            }
            return vis;
        }
    }
}
