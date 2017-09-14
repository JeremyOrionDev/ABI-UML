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

            foreach (Collaborateurs item in query)
            {
                leCollaborateur = new Collaborateur(item.matricule, item.Civilite, item.SituationMaritale, item.Nom, item.Prenom, item.Rue, item.Ville, item.CodePostal, item.Augmentation, item.Telephone, item.Photo);
                if (DictionnaireCollaborateur.listCollaborateur.ContainsKey(leCollaborateur.Matricule))
                {
                    Int32 refColab = leCollaborateur.Matricule - 1;
                    DictionnaireCollaborateur.listCollaborateur.Values.ElementAt(refColab).NomCollaborateur = item.Nom;
                    DictionnaireCollaborateur.listCollaborateur.Values.ElementAt(refColab).PrenomCollaborateur = item.Prenom;
                    DictionnaireCollaborateur.listCollaborateur.Values.ElementAt(refColab).RueCollab = item.Rue;
                    DictionnaireCollaborateur.listCollaborateur.Values.ElementAt(refColab).VilleCollab = item.Ville;
                    DictionnaireCollaborateur.listCollaborateur.Values.ElementAt(refColab).CpCollab = item.CodePostal;
                    DictionnaireCollaborateur.listCollaborateur.Values.ElementAt(refColab).Civilite = item.Civilite;
                    DictionnaireCollaborateur.listCollaborateur.Values.ElementAt(refColab).SituationMaritale = item.SituationMaritale;
                    DictionnaireCollaborateur.listCollaborateur.Values.ElementAt(refColab).Augmentation = item.Augmentation;
                    DictionnaireCollaborateur.listCollaborateur.Values.ElementAt(refColab).Telephone = item.Telephone;
                    DictionnaireCollaborateur.listCollaborateur.Values.ElementAt(refColab).LaPhoto = item.Photo;
                }
                else DictionnaireCollaborateur.listCollaborateur.Add(leCollaborateur.Matricule,leCollaborateur);
            }
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

    }
}
