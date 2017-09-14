using ABIenCouche;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ClassesDAO
{
    public class MContratStageDAOEFStatic
    {
        Collaborateur C;
        public static void instancieContratsStage(Collaborateur leCollaborateur)
        {
            if (DonneesDAO.DbContextCollaborateurs == null) DonneesDAO.DbContextCollaborateurs = new lesCollaborateursContainer();

            var query = from C in DonneesDAO.DbContextCollaborateurs.ContratsSet
                        where C.Collaborateurs.matricule == leCollaborateur.Matricule
                        select C;

            ContratStage leContratStageDAO;
            Collaborateurs leCollaborateurDAO = DonneesDAO.DbContextCollaborateurs.CollaborateursSet.Find(leCollaborateur.Matricule);

            foreach (ContratStage item in query)
            {
                leContratStageDAO = new ContratStage(item.Ecole,item.Motif,item.DateFin,item.Mission,item.Tuteur,item.NumContrat,item.Fonction,item.Qualification,item.Libelle,item.Statut,item.DateDebut);
                
                DonneesDAO.DbContextCollaborateurs.SaveChanges();

               
            }


        }
    }
}
