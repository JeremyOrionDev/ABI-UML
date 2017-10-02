using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDAO
{
    public class MContratsCDIDAOEFStatic
    {
        public ContratCDI ContratCDI
        {
            get => default(ContratCDI);
            set
            {
            }
        }

        public static void instancieContratsCDI(Collaborateurs leCollaborateur)
        {
            if (DonneesDAO.DbContextCollaborateurs == null) DonneesDAO.DbContextCollaborateurs = new lesCollaborateursContainer();

            var query = from C in DonneesDAO.DbContextCollaborateurs.ContratsSet
                        where C.Collaborateurs.matricule == leCollaborateur.matricule
                        select C;

            ContratCDI leContrat;

            foreach (ContratCDI item in query)
            {
                leContrat = new ContratCDI(item.Libelle, item.Salaire, item.NumContrat, item.Fonction, item.Qualification, item.Statut, item.DateDebut,item.idContrat);
                leCollaborateur.Contrats.Add(leContrat);
                DonneesDAO.DbContextCollaborateurs.SaveChanges();

            }


        }
    }
}
