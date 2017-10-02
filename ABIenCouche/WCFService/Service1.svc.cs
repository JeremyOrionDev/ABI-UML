using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using ABIenCouche;
using ClassesDAO;

namespace WCFService
{
    // REMARQUE : vous pouvez utiliser la commande Renommer du menu Refactoriser pour changer le nom de classe "Service1" dans le code, le fichier svc et le fichier de configuration.
    // REMARQUE : pour lancer le client test WCF afin de tester ce service, sélectionnez Service1.svc ou Service1.svc.cs dans l'Explorateur de solutions et démarrez le débogage.
    public class Service1 : IService1
    {
        public string AddCollaborateur(Collaborateur unCollaborateur)
        {
            Collaborateur C = unCollaborateur;
            if (!DictionnaireCollaborateur.estPresent(unCollaborateur.Matricule))
            {

                try
                {
                    MCollaborateurDAOEFStatic.ajoutCollaborateur(C);
                    return "le collaborateur a bien été ajouté";
                }
                catch (Exception)
                {

                    throw;
                }
            }
            else
            {
                Collaborateur D = DictionnaireCollaborateur.retrouverCollaborateur(unCollaborateur.Matricule);
                throw new AddressAlreadyInUseException("le collaborateur matricule " + unCollaborateur.Matricule + " existe déja " + "\r il apaprtient au collaborateur " + D.NomCollaborateur + " " + D.PrenomCollaborateur);
            }
        }

        public Collaborateurs AjoutCollaborateurDB(Collaborateurs leColab)
        {
            throw new NotImplementedException();
        }

        public string DeleteCollaborateur(int unMatricule)
        {
            try
            {
                Collaborateur C = MCollaborateurDAOEFStatic.retrouverCollaborateur(unMatricule);
                C.Archive = true;
                DonneesDAO.DbContextCollaborateurs.SaveChanges();
                return "le collaborateur " + C.NomCollaborateur + " " + C.PrenomCollaborateur + " a été archivé";
            }
            catch (Exception)
            {

                throw;
            }

        }

        public IList<Collaborateurs> GetAllCollaborateurs(bool Archive)
        {
            return MCollaborateurDAOEFStatic.GetColabs(Archive);
        }

        public Collaborateur GetCollaborateur(string numColab)
        {
            int I = int.Parse(numColab);
            return MCollaborateurDAOEFStatic.retrouverCollaborateur(I);
        }

        public Contrats GetContrat(Collaborateurs unCollaborateur,int unNum)
        {
            Collaborateurs C = unCollaborateur;
            List<Contrats> laListe = new List<Contrats>();
            foreach (Contrats item in C.Contrats)
            {
                if (item.idContrat == unNum)
                {
                    laListe.Add(item);
                }
                else throw new Exception("erreur ");
            }
                if (laListe.Count == 1)
                {
                    return laListe.FirstOrDefault();
                }
                else throw new Exception("erreur");
        }

        public IList<Contrat> ListeContrat(Collaborateur unCollaborateur)
        {
            Collaborateur C = MCollaborateurDAOEFStatic.retrouverCollaborateur(unCollaborateur.Matricule);
            if (DonneesDAO.DbContextCollaborateurs.Collaborateurs == null)
            {
                DonneesDAO.DbContextCollaborateurs = new lesCollaborateursContainer();
            }
            return MCollaborateurDAOEFStatic.ContratToList(C);
        }

        public IList<Contrats> getAllContrats()
        {
            if (DonneesDAO.DbContextCollaborateurs==null)
            {
                DonneesDAO.DbContextCollaborateurs = new lesCollaborateursContainer();
            }

            return MCollaborateurDAOEFStatic.tousLesContrats();
        }

        public string UpdateCollaborateur(Collaborateurs unCollaborateur)
        {
            throw new NotImplementedException();
        }

        Collaborateur IService1.AjoutCollaborateur(Collaborateurs leColab)
        {
            throw new NotImplementedException();
        }

        IList<Collaborateur> IService1.GetAllCollaborateurs(bool Archive)
        {
            throw new NotImplementedException();
        }

        public string AddCollaborateur(Collaborateurs unCollaborateur)
        {
            throw new NotImplementedException();
        }

        public string UpdateCollaborateur(Collaborateur unCollaborateur)
        {
            throw new NotImplementedException();
        }

        public Contrat GetContrat(Collaborateur unCollaborateur, int unNum)
        {
            throw new NotImplementedException();
        }

        IList<Contrat> IService1.getAllContrats()
        {
            throw new NotImplementedException();
        }
    }
}
