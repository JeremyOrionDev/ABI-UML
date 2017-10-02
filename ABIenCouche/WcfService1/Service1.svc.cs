using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ClassesDAO;

namespace WcfService1
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class Service1 : IService1
    {
        public string AddCollaborateur(Collaborateurs unCollaborateur)
        {
            if (DonneesDAO.DbContextCollaborateurs.Collaborateurs == null)
            {
                DonneesDAO.DbContextCollaborateurs = new lesCollaborateursContainer();
            }

            return MCollaborateurDAOEFStatic.ajoutCollaborateurDB(unCollaborateur);
        }

        public Collaborateurs AjoutCollaborateur(Collaborateurs leColab)
        {
            throw new NotImplementedException();
        }

        public bool DeleteCollaborateur(Collaborateurs unCollaborateur)
        {
            throw new NotImplementedException();
        }

        public IList<Collaborateurs> GetAllCollaborateurs(bool Archive)
        {
            return MCollaborateurDAOEFStatic.GetColabs(Archive);
        }

        public Collaborateurs GetCollaborateurs(int numColab)
        {
            return MCollaborateurDAOEFStatic.retrouverCollaborateur(numColab);
        }



        public string UpdateCollaborateur(Collaborateurs unCollaborateur)
        {
            throw new NotImplementedException();
        }
    }
}
