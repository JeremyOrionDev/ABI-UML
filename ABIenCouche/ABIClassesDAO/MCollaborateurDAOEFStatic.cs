using System;
using System.Collections.Generic;
using System.Linq;
using ABIenCouche;
using System.Data;
using System.Text;
using System.Threading.Tasks;

namespace ABIClassesDAO
{
    public class MCollaborateurDAOEFStatic
    {



        public static Collaborateur retrouverCollaborateurDAO(Int32 leMatricule)
        {
            if (DonneesDAO.DbContextCollaborateur == null) DonneesDAO.DbContextCollaborateur = new CollaborateursEntityContainer();

            var query = from C in DonneesDAO.DbContextCollaborateur.CollaborateursSet
                        where C.matricule == leMatricule
                        select C;
            Collaborateur unCollaborateur;

            foreach (Collaborateurs item in query)
            {
                unCollaborateur=new Collaborateur(item.matricule, item.Civilite,item.SituationMaritale, item.Nom, item.Prenom,item.Rue,
                     item.Ville, item.CodePostal,item.Augmentation, item.Telephone, item.Photo);
               
                return unCollaborateur;  
            }
            throw new Exception("le collaborateur n'existe pas");
        }

        public static DataTable dtCollabDAO(DictionnaireCollaborateur lesColab)
        {
            if (DonneesDAO.DbContextCollaborateur == null) DonneesDAO.DbContextCollaborateur = new CollaborateursEntityContainer();
            var query = from C in DonneesDAO.DbContextCollaborateur.CollaborateursSet
                        where C.matricule==lesColab.LeColab.Matricule
                        select C;
            DataTable dt = new DataTable();
            DataRow DR;
            dt.Columns.Add(new DataColumn("#", typeof(Int32)));
            dt.Columns.Add(new DataColumn("Civ", typeof(String)));
            dt.Columns.Add(new DataColumn("Nom", typeof(String)));
            dt.Columns.Add(new DataColumn("Prénom", typeof(String)));
            dt.Columns.Add(new DataColumn("Adresse", typeof(String)));
            dt.Columns.Add(new DataColumn("Telephone", typeof(String)));

            foreach ( Collaborateurs C in query)
            {
                
                DR = dt.NewRow();
                DR[0] = C.matricule;
                DR[1] = C.Civilite;
                DR[2] = C.Nom;
                DR[3] = C.Prenom;
                DR[4] = C.Rue + " " + C.CodePostal + " " + C.Ville;
                DR[5] = C.Telephone;
                dt.Rows.Add(DR);

            }
            return dt;
        }

        public static void instancieCollaborateurs(DictionnaireCollaborateur lesColab)
        {
            if (DonneesDAO.DbContextCollaborateur==null)
            {
                DonneesDAO.DbContextCollaborateur = new CollaborateursEntityContainer();
            }
        }
    }
}
