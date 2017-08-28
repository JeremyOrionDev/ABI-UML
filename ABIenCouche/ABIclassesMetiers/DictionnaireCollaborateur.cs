using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace ABIenCouche
{
    public class DictionnaireCollaborateur
    {
        public  SortedDictionary<int, Collaborateur> SDCollaborateur;
        /// <summary>
        /// Initialisation de la collection de collaborateurs
        /// </summary>
        public DictionnaireCollaborateur()
        {
            SDCollaborateur = new SortedDictionary<int, Collaborateur>();
        }
        /// <summary>
        /// Ajout du collaborateur unColab en collection
        /// </summary>
        /// <param name="unColab">le collaborateur a ajouter en collection</param>
        public void AJouter(Collaborateur unColab)
        {
            if (!SDCollaborateur.ContainsKey(unColab.Matricule))
            {
                SDCollaborateur.Add(unColab.Matricule, unColab);
            }
            else throw new Exception(" le collaborateur est déja dans la base");
        }
        /// <summary>
        /// fonction de suppression prenant en paramètre le collaborateur complet (objet)
        /// </summary>
        /// <param name="unColab">le collaborateur à supprimer</param>
        /// <returns></returns>
        public String SupprimerCollab(Collaborateur unColab)
        {
            String nom = unColab.NomCollaborateur;
            String prenom = unColab.PrenomCollaborateur;
            Int32 matricul = unColab.Matricule;
            if (SDCollaborateur.ContainsKey(unColab.Matricule))
            {
                SDCollaborateur.Remove(unColab.Matricule);
                return "le collaborateur matricule: " + matricul + " Nom: " + nom + " prénom: " + prenom+"a bien été supprimé";
            }
            else return "le collaborateur selectionné n'existe pas dans la base, merci de vérifier votre saisie";
        }
        /// <summary>
        /// Fonction de suppresion d'un collaborateur à partir du matricule de celui-ci
        /// </summary>
        /// <param name="unMatricule">le matricule du collaborateur à supprimer</param>
        /// <returns></returns>
        public String SupprimerCollab(Int32 unMatricule)
        {
            String nom = SDCollaborateur[unMatricule].NomCollaborateur;
            String prenom = SDCollaborateur[unMatricule].PrenomCollaborateur;
            Int32 matricul = unMatricule;
            if (SDCollaborateur.ContainsKey(unMatricule))
            {
                SDCollaborateur.Remove(unMatricule);
                return "le collaborateur de matricule: " + matricul + " Nom: " + nom + " prenom: " + prenom + " a bien été supprimé";
            }
            else return "le matricule selectionné ne correspond à aucun collaborateur, merci de vérifier votre saisie.";
        }
        /// <summary>
        /// Remplacement des données du collaborateur par des nouvelles
        /// </summary>
        /// <param name="leColab">le collaborateur à mettre à jour</param>
        public void RemplacerColab(Collaborateur leColab)
        {
            if (SDCollaborateur.ContainsKey(leColab.Matricule))
            {
                SDCollaborateur[leColab.Matricule] = leColab;
            }
            else throw new Exception("le collaborateur ne peut pas être remplacé car il n'existe pas, il faut le créer");
        }

        /// <summary>
        /// Fonction de récupération d'un collaborateur à partir de son matricule
        /// </summary>
        /// <param name="unMatricule">le numéro de matricule du collaborateur à retrouver</param>
        /// <returns></returns>
        public Collaborateur retrouverCollaborateur(Int32 unMatricule)
        {
            if (SDCollaborateur.ContainsKey(unMatricule))
            {
                return SDCollaborateur[unMatricule];
            }
            else throw new Exception("le matricule renseigné ne correspond à aucun collaborateur, merci de vérifier votre saisie");
        }

        public DataTable ListCollab()
        {
            DataTable dt = new DataTable();
            DataRow DR;
            dt.Columns.Add(new DataColumn("Matricule", typeof(Int32)));
            dt.Columns.Add(new DataColumn("Nom", typeof(String)));
            dt.Columns.Add(new DataColumn("Prénom", typeof(String)));
            dt.Columns.Add(new DataColumn("Adresse", typeof(String)));

            foreach (KeyValuePair<Int32, Collaborateur> colab in SDCollaborateur)
            {
                DR = dt.NewRow();
                DR[0] = colab.Value.Matricule;
                DR[1] = colab.Value.NomCollaborateur;
                DR[2] = colab.Value.PrenomCollaborateur;
                DR[3] = colab.Value.RueCollab+" "+colab.Value.CpCollab+" "+colab.Value.VilleCollab;
                dt.Rows.Add(DR);

            }
            return dt;
        }
    }
}
