using ABIenCouche;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassesDAO
{
    public class MContratsCDDDAOEFStatic
    {
        public static void instancieContratsCDD(Collaborateurs leCollaborateur)
        {
            if (DonneesDAO.DbContextCollaborateurs == null) DonneesDAO.DbContextCollaborateurs = new lesCollaborateursContainer();

            var query = from C in DonneesDAO.DbContextCollaborateurs.ContratsSet
                        where C.Collaborateurs.matricule == leCollaborateur.matricule
                        select C;

            ContratCDD leContrat;
            Collaborateur monColab = DictionnaireCollaborateur.retrouverCollaborateur(leCollaborateur.matricule);
            
            foreach (ContratCDD item in query)
            {
                leContrat = new ContratCDD(item.Libelle,item.DateFin,item.Motif,item.NumContrat, item.Fonction, item.Qualification, item.Statut, item.DateDebut);
                leCollaborateur.Contrats.Add(leContrat);
                DonneesDAO.DbContextCollaborateurs.SaveChanges();
                          }

        }
    }
}
