using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;

namespace ClassesDAO
{
    public class MCollaborateurDAOEFStatic
    {
        public Collaborateurs Collaborateurs
        {
            get => default(Collaborateurs);
            set
            {
            }
        }

        /// <summary>
        /// instancie les objets MCollaborateurs spécialisés correspondants aux entités du dbSet
        /// </summary>
        /// <param name="lesColab">la réf de la collection de collaborateurs</param>
        public static void instancieCollaborateurs()
        {
            
            //instancier le dbContext au besoin
            if (DonneesDAO.DbContextCollaborateurs == null) DonneesDAO.DbContextCollaborateurs = new lesCollaborateursContainer();

            //requête Linq pour lire la BDD
            var query = from C in DonneesDAO.DbContextCollaborateurs.CollaborateursSet
                        where C.Archive == false
                        select C;

            Collaborateurs leCollaborateur;
            ContratCDD leCDD;
            ContratCDI leCDI;
            SortedDictionary<int, Collaborateurs> lesColab = new SortedDictionary<int, Collaborateurs>();
            ContratInterim unInterim;
            ContratStage leStage;
            foreach (Collaborateurs item in query)
            {
                leCollaborateur = new Collaborateurs(item.matricule, item.Civilite, item.SituationMaritale,
                    item.Nom, item.Prenom, item.Rue, item.Ville, item.CodePostal, item.Telephone,item.Archive);
               


                    var query2 = from D in DonneesDAO.DbContextCollaborateurs.ContratsSet
                                 where D.Collaborateurs.matricule == item.matricule
                                 select D;
                    foreach (Contrats leContrat in query2)
                    {
                        if (leContrat is ContratCDD)
                        {
                            ContratCDD unCDD = (ContratCDD)leContrat;
                            leCDD = new ContratCDD(unCDD.Libelle, unCDD.DateFin, unCDD.Motif, unCDD.NumContrat, unCDD.Fonction, unCDD.Qualification, unCDD.Statut, unCDD.DateDebut);
                            leCollaborateur.Contrats.Add(leCDD);
                        }
                        else if (leContrat is ContratCDI)
                        {
                            ContratCDI unCDI = (ContratCDI)leContrat;
                            leCDI = new ContratCDI(unCDI.Libelle, unCDI.Salaire, unCDI.NumContrat, unCDI.Fonction, unCDI.Qualification, unCDI.Statut, unCDI.DateDebut);
                            leCollaborateur.Contrats.Add(leCDI);
                        }
                        else if (leContrat is ContratInterim)
                        {
                            ContratInterim lInterim = (ContratInterim)leContrat;
                            unInterim = new ContratInterim(lInterim.Agence, lInterim.Motif, lInterim.Salaire, lInterim.DateFin, lInterim.NumContrat, lInterim.Fonction, lInterim.Qualification, lInterim.Libelle, lInterim.Statut, lInterim.DateDebut);
                            leCollaborateur.Contrats.Add(unInterim);
                        }
                        else if (leContrat is ContratStage)
                        {
                            ContratStage unStage = (ContratStage)leContrat;
                            leStage = new ContratStage(unStage.Ecole, unStage.Motif, unStage.DateFin, unStage.Mission, unStage.Tuteur, unStage.NumContrat, unStage.Fonction, unStage.Qualification, unStage.Libelle, unStage.Statut, unStage.DateDebut);
                            leCollaborateur.Contrats.Add(leStage);
                        }
                        var query3 = from A in DonneesDAO.DbContextCollaborateurs.AvenantSet
                                     where A.Contrats.Collaborateurs.matricule == leCollaborateur.matricule
                                     select A;
                        foreach (Avenant unAvenant in query3)
                        {
                            Avenant avenantContrat = new Avenant(unAvenant.idAvenant,unAvenant.Date,unAvenant.MotifAvenant,unAvenant.numeroAvenant);
                            
                        }
                    }
            }

        }
        /// <summary>
        /// méthode publique statique générant la DataTable des avenant du contrat
        /// </summary>
        /// <param name="unContrat"></param>
        /// <returns></returns>
        public static DataTable ListerAvenant(Contrats unContrat)
        {
            DataTable dt = new DataTable();
            DataRow DR;
            dt.Columns.Add(new DataColumn("#", typeof(Int32)));
            dt.Columns.Add(new DataColumn("Date", typeof(DateTime)));
            dt.Columns.Add(new DataColumn("Motif", typeof(String)));

            var t = DonneesDAO.DbContextCollaborateurs.ContratsSet.Include("AvenantSet").Where(c => c.NumContrat == unContrat.NumContrat).Select(c => c.Avenant);


            var query = from c in DonneesDAO.DbContextCollaborateurs.AvenantSet
                        where c.Contrats.idContrat==unContrat.idContrat
                        select c;


            foreach (ClassesDAO.Avenant item in query)
            {
                DR = dt.NewRow();
                DR[0] = item.numeroAvenant;
                DR[1] = item.Date;
                DR[2] = item.MotifAvenant;
                dt.Rows.Add(DR);
            }

            return dt;
        }
        /// <summary>
        /// méthode publique statique générant la DataTable des augmentations du collaborateur
        /// </summary>
        /// <param name="unColab"></param>
        /// <returns></returns>
        public static DataTable ListerAugmentation(Collaborateurs unColab)
        {
            DataTable dt = new DataTable();
            DataRow DR;
            dt.Columns.Add(new DataColumn("Date", typeof(DateTime)));
            dt.Columns.Add(new DataColumn("Valeur", typeof(Double)));

            var query = from C in DonneesDAO.DbContextCollaborateurs.AugmentationsSet
                        where C.Collaborateurs.matricule == unColab.matricule
                        select C;
            foreach (Augmentations item in query)
            {
                DR = dt.NewRow();
                DR[0] = item.Date;
                DR[1] = item.Valeur;
                dt.Rows.Add(DR);
            }

            return dt;
        }
        /// <summary>
        /// méthode publique statique générant une DataTable de collaborateurs
        /// </summary>
        /// <param name="unColab"></param>
        /// <returns></returns>
        public static DataTable listerContratCollaborateurDAO(Collaborateurs unColab)
        {
            DataTable dt = new DataTable();
            DataRow DR;
            dt.Columns.Add(new DataColumn("#", typeof(Int32)));
            dt.Columns.Add(new DataColumn("Type", typeof(String)));
            dt.Columns.Add(new DataColumn("Libelle", typeof(String)));
            dt.Columns.Add(new DataColumn("Cadre", typeof(String)));
            dt.Columns.Add(new DataColumn("Fonction", typeof(String)));
            dt.Columns.Add(new DataColumn("Date début", typeof(DateTime)));
            dt.Columns.Add(new DataColumn("id", typeof(Int32)));

            var query = from C in DonneesDAO.DbContextCollaborateurs.ContratsSet
                        where C.Collaborateurs.matricule == unColab.matricule
                        select C;

            foreach (Contrats item in query)
            {
                DR = dt.NewRow();
                DR[0] = item.NumContrat;
                if (item is ContratCDD)
                {
                    DR[1] = "CDD";
                }
                else if (item is ContratCDI)
                {
                    DR[1] = "CDI";
                }
                else if (item is ContratInterim)
                {
                    DR[1] = "Interim";
                }
                else if (item is ContratStage)
                {
                    DR[1] = "Stage";
                }
                DR[2] = item.Libelle;
                DR[3] = item.Statut;
                DR[4] = item.Fonction;
                DR[5] = item.DateDebut;
                DR[6] = item.idContrat;
                dt.Rows.Add(DR);
           

            }

            return dt;
        }
        /// <summary>
        /// méthode publique statique pour retrouver un collaborateur à partir de son matricule
        /// </summary>
        /// <param name="unNum"></param>
        /// <returns></returns>
        public static Collaborateurs retrouverCollaborateur(Int32 unNum)
        {
            if (DonneesDAO.DbContextCollaborateurs.CollaborateursSet.Find(unNum) != null)
            {
                return DonneesDAO.DbContextCollaborateurs.CollaborateursSet.Find(unNum);
            }
            else throw new Exception("erreur le Collaborateur n'existe pas");
        }



    }
}
