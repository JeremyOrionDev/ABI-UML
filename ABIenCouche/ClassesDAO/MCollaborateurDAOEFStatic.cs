using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ABIenCouche;
using System.Data;
using System.Windows.Forms;

namespace ClassesDAO
{
    public class MCollaborateurDAOEFStatic
    {
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
                        select C;

            Collaborateur leCollaborateur;
            ABIenCouche.ContratCDD leCDD;
            ABIenCouche.ContratCDI leCDI;
            contratInterim unInterim;
            ABIenCouche.ContratStage leStage;
            foreach (Collaborateurs item in query)
            {
                leCollaborateur = new Collaborateur(item.matricule, item.Civilite, item.SituationMaritale,
                    item.Nom, item.Prenom, item.Rue, item.Ville, item.CodePostal, item.Telephone);
                if (DictionnaireCollaborateur.listCollaborateur.ContainsKey(leCollaborateur.Matricule))
                {
                    Int32 refColab = leCollaborateur.Matricule ;
                    DictionnaireCollaborateur.listCollaborateur.Values.ElementAt(refColab).NomCollaborateur = item.Nom;
                    DictionnaireCollaborateur.listCollaborateur.Values.ElementAt(refColab).PrenomCollaborateur = item.Prenom;
                    DictionnaireCollaborateur.listCollaborateur.Values.ElementAt(refColab).RueCollab = item.Rue;
                    DictionnaireCollaborateur.listCollaborateur.Values.ElementAt(refColab).VilleCollab = item.Ville;
                    DictionnaireCollaborateur.listCollaborateur.Values.ElementAt(refColab).CpCollab = item.CodePostal;
                    DictionnaireCollaborateur.listCollaborateur.Values.ElementAt(refColab).Civilite = item.Civilite;
                    DictionnaireCollaborateur.listCollaborateur.Values.ElementAt(refColab).SituationMaritale = item.SituationMaritale;
                    DictionnaireCollaborateur.listCollaborateur.Values.ElementAt(refColab).Telephone = item.Telephone;
                }
                else DictionnaireCollaborateur.listCollaborateur.Add(leCollaborateur.Matricule, leCollaborateur);


                    var query2 = from D in DonneesDAO.DbContextCollaborateurs.ContratsSet
                                 where D.Collaborateurs.matricule == item.matricule
                                 select D;
                    foreach (Contrats leContrat in query2)
                    {
                        if (leContrat is ContratCDD)
                        {
                            ContratCDD unCDD = (ContratCDD)leContrat;
                            leCDD = new ABIenCouche.ContratCDD(unCDD.Libelle, unCDD.DateFin, unCDD.Motif, unCDD.NumContrat, unCDD.Fonction, unCDD.Qualification, unCDD.Statut, unCDD.DateDebut);
                            leCollaborateur.ajoutContrat(leCDD);
                        }
                        else if (leContrat is ContratCDI)
                        {
                            ContratCDI unCDI = (ContratCDI)leContrat;
                            leCDI = new ABIenCouche.ContratCDI(unCDI.Libelle, unCDI.Salaire, unCDI.NumContrat, unCDI.Fonction, unCDI.Qualification, unCDI.Statut, unCDI.DateDebut);
                            leCollaborateur.ajoutContrat(leCDI);
                        }
                        else if (leContrat is ContratInterim)
                        {
                            ContratInterim lInterim = (ContratInterim)leContrat;
                            unInterim = new contratInterim(lInterim.Agence, lInterim.Motif, lInterim.Salaire, lInterim.DateFin, lInterim.NumContrat, lInterim.Fonction, lInterim.Qualification, lInterim.Libelle, lInterim.Statut, lInterim.DateDebut);
                            leCollaborateur.ajoutContrat(unInterim);
                        }
                        else if (leContrat is ContratStage)
                        {
                            ContratStage unStage = (ContratStage)leContrat;
                            leStage = new ABIenCouche.ContratStage(unStage.Ecole, unStage.Motif, unStage.DateFin, unStage.Mission, unStage.Tuteur, unStage.NumContrat, unStage.Fonction, unStage.Qualification, unStage.Libelle, unStage.Statut, unStage.DateDebut);
                            leCollaborateur.ajoutContrat(leStage);
                        }
                        var query3 = from A in DonneesDAO.DbContextCollaborateurs.AvenantSet
                                     where A.Contrats.Collaborateurs.matricule == leCollaborateur.Matricule
                                     select A;
                        foreach (Avenant unAvenant in query3)
                        {
                            avenantContrat avenantContrat = new avenantContrat(unAvenant.numeroAvenant, unAvenant.MotifAvenant, unAvenant.Date);
                            
                        }
                    }
            }

        }

        public static DataTable ListerAvenant(Contrat unContrat)
        {
            DataTable dt = new DataTable();
            DataRow DR;
            dt.Columns.Add(new DataColumn("#", typeof(Int32)));
            dt.Columns.Add(new DataColumn("Date", typeof(DateTime)));
            dt.Columns.Add(new DataColumn("Motif", typeof(String)));

            var query = from C in DonneesDAO.DbContextCollaborateurs.AvenantSet
                        where C.Contrats.NumContrat == unContrat.NumContrat
                        select C;
            foreach (Avenant item in query)
            {
                DR = dt.NewRow();
                DR[0] = item.numeroAvenant;
                DR[1] = item.Date;
                DR[2] = item.MotifAvenant;
                dt.Rows.Add(DR);
            }

            return dt;
        }

        public static DataTable ListerAugmentation(Collaborateur unColab)
        {
            DataTable dt = new DataTable();
            DataRow DR;
            dt.Columns.Add(new DataColumn("Date", typeof(DateTime)));
            dt.Columns.Add(new DataColumn("Valeur", typeof(Double)));

            var query = from C in DonneesDAO.DbContextCollaborateurs.AugmentationsSet
                        where C.Collaborateurs.matricule == unColab.Matricule
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
        public static DataTable listerContratCollaborateurDAO(Collaborateur unColab)
        {
            DataTable dt = new DataTable();
            DataRow DR;
            dt.Columns.Add(new DataColumn("#", typeof(Int32)));
            dt.Columns.Add(new DataColumn("Type", typeof(String)));
            dt.Columns.Add(new DataColumn("Libelle", typeof(String)));
            dt.Columns.Add(new DataColumn("Cadre", typeof(String)));
            dt.Columns.Add(new DataColumn("Fonction", typeof(String)));
            dt.Columns.Add(new DataColumn("Date début", typeof(DateTime)));

            var query = from C in DonneesDAO.DbContextCollaborateurs.ContratsSet
                        where C.Collaborateurs.matricule == unColab.Matricule
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
                dt.Rows.Add(DR);
           

            }

            return dt;
        }

        public static Collaborateurs retrouverCollaborateur(Int32 unNum)
        {
            if (DonneesDAO.DbContextCollaborateurs.CollaborateursSet.Find(unNum) != null)
            {
                return DonneesDAO.DbContextCollaborateurs.CollaborateursSet.Find(unNum);
            }
            else throw new Exception("erreur le Collaborateur n'existe pas");
        }

        public Boolean retrouverContrat(Collaborateurs unColab,Int32 numContrat)
        {
            if (unColab.Contrats.ElementAt(numContrat) != null)
            {
                return true;
            }
            else return false;
        }

    }
}
