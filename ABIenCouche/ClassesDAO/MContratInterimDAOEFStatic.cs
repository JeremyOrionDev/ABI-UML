using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDAO
{
    public class MContratInterimDAOEFStatic
    {
        public static void instancieContratsInterim(Collaborateurs leCollaborateur)
        {
            if (DonneesDAO.DbContextCollaborateurs == null) DonneesDAO.DbContextCollaborateurs = new lesCollaborateursContainer();

            var query = from C in DonneesDAO.DbContextCollaborateurs.ContratsSet
                        where C.Collaborateurs.matricule == leCollaborateur.matricule
                        select C;

            ContratInterim leContrat;

            foreach (ContratInterim item in query)
            {
                leContrat = new ContratInterim(item.Agence,item.Motif,item.Salaire,item.DateFin,item.NumContrat,item.Fonction,item.Qualification,item.Libelle,item.Statut,item.DateDebut);
                leCollaborateur.Contrats.Add(leContrat);
                DonneesDAO.DbContextCollaborateurs.SaveChanges();

            }


        }
    }
}
