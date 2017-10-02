using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ClassesDAO;
using ABIenCouche;

namespace WcfService1
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class Service1 : IService1
    {
        public string AddCollaborateur(Collaborateurs leCollaborateur)
        {
            try
            {
                DonneesDAO.DbContextCollaborateurs.CollaborateursSet.Add(leCollaborateur);

                return "le collaborateur à été ajouté";



            }
            catch (Exception)
            {

                throw;
            }
        }

        public Collaborateurs GetCollaborateur(int numColab)
        {
            try
            {
                ////instancier le dbContext au besoin
                if (DonneesDAO.DbContextCollaborateurs == null) DonneesDAO.DbContextCollaborateurs = new lesCollaborateursContainer();
                //var query = from C in DonneesDAO.DbContextCollaborateurs.CollaborateursSet
                //            select C;
                //Collaborateurs D = null;
                //foreach (Collaborateurs item in query)
                //{
                //    if (item.matricule==numColab)
                //    {
                //        D = item;
                //    }
                //}
                //return D;
                Collaborateurs C = DonneesDAO.DbContextCollaborateurs.CollaborateursSet.Find(numColab);
                return C;
            }
            catch (Exception)
            {

                throw;
            }
           
        }

        public Contrats GetContrat(Collaborateurs leCollaborateur, Contrats leContrat)
        {
            throw new NotImplementedException();
        }
    }
}
