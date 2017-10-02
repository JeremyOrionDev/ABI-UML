using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ABIenCouche;
using ClassesDAO;

namespace ABIService
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

        public Collaborateur GetCollaborateur(int numColab)
        {
            throw new NotImplementedException();
        }

        public Contrat GetContrat(Collaborateur leCollaborateur, Contrat leContrat)
        {
            throw new NotImplementedException();
        }
    }
}
