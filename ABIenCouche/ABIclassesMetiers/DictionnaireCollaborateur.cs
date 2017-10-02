using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using ABIenCouche;

namespace ABIenCouche
{
    public class DictionnaireCollaborateur
    {
        public static SortedDictionary<int, Collaborateur> listCollaborateur =new SortedDictionary<int, Collaborateur> ();
        private Collaborateur leColab;

        public Collaborateur LeColab
        {
            get
            {
                return leColab;
            }
            set
            {
          
                    leColab = value;
                
            }
        }
        /// <summary>
        /// Ajout du collaborateur unColab en collection
        /// </summary>
        /// <param name="unColab">le collaborateur a ajouter en collection</param>
        public static void Ajouter(Collaborateur unColab)
        {
    
            if (!listCollaborateur.ContainsKey(unColab.Matricule))
            {
                listCollaborateur.Add(unColab.Matricule, unColab);
                
            }
            else throw new Exception(" le collaborateur est déja dans la base");
        }
        /// <summary>
        /// fonction de suppression prenant en paramètre le collaborateur complet (objet)
        /// </summary>
        /// <param name="unColab">le collaborateur à supprimer</param>
        /// <returns></returns>
        public static String SupprimerCollab(Collaborateur unColab)
        {
            String nom = unColab.NomCollaborateur;
            String prenom = unColab.PrenomCollaborateur;
            Int32 matricul = unColab.Matricule;
            if (listCollaborateur.ContainsKey(unColab.Matricule))
            {
                listCollaborateur.Remove(unColab.Matricule);
                return "le collaborateur matricule: " + matricul + " Nom: " + nom + " prénom: " + prenom+"a bien été supprimé";
            }
            else return "le collaborateur selectionné n'existe pas dans la base, merci de vérifier votre saisie";
        }
        /// <summary>
        /// Fonction de suppresion d'un collaborateur à partir du matricule de celui-ci
        /// </summary>
        /// <param name="unMatricule">le matricule du collaborateur à supprimer</param>
        /// <returns></returns>
        public static String SupprimerCollab(Int32 unMatricule)
        {
            String nom = listCollaborateur[unMatricule].NomCollaborateur;
            String prenom = listCollaborateur[unMatricule].PrenomCollaborateur;
            Int32 matricul = unMatricule;
            if (listCollaborateur.ContainsKey(unMatricule))
            {
                listCollaborateur.Remove(unMatricule);
                return "le collaborateur de matricule: " + matricul + " Nom: " + nom + " prenom: " + prenom + " a bien été supprimé";
            }
            else return "le matricule selectionné ne correspond à aucun collaborateur, merci de vérifier votre saisie.";
        }
        /// <summary>
        /// Remplacement des données du collaborateur par des nouvelles
        /// </summary>
        /// <param name="leColab">le collaborateur à mettre à jour</param>
        public  static void RemplacerColab(Collaborateur leColab)
        {
            if (listCollaborateur.ContainsKey(leColab.Matricule))
            {
                listCollaborateur[leColab.Matricule] = leColab;
            }
            else throw new Exception("le collaborateur ne peut pas être remplacé car il n'existe pas, il faut le créer");
        }

        public static bool estPresent(Int32 matricule)
        {
            if (listCollaborateur.ContainsKey(matricule))
            {
                return true;
            }
            else return false;
        }
        /// <summary>
        /// Fonction de récupération d'un collaborateur à partir de son matricule
        /// </summary>
        /// <param name="unMatricule">le numéro de matricule du collaborateur à retrouver</param>
        /// <returns></returns>
        public static Collaborateur retrouverCollaborateur(Int32 unMatricule)
        {
            if (listCollaborateur.ContainsKey(unMatricule))
            {
                return listCollaborateur[unMatricule];
            }
            else throw new Exception("le matricule renseigné ne correspond à aucun collaborateur, merci de vérifier votre saisie");
        }
        /// <summary>
        /// Retourne une DataTable contenant tous kles collaborateurs archivés
        /// </summary>
        /// <returns></returns>
        public static DataTable listArchive()
        {
            DataTable dt = new DataTable();
            DataRow DR;
            dt.Columns.Add(new DataColumn("#", typeof(Int32)));
            dt.Columns.Add(new DataColumn("Civ", typeof(String)));
            dt.Columns.Add(new DataColumn("Nom", typeof(String)));
            dt.Columns.Add(new DataColumn("Prénom", typeof(String)));
            dt.Columns.Add(new DataColumn("Adresse", typeof(String)));
            dt.Columns.Add(new DataColumn("Telephone", typeof(String)));
            dt.Columns.Add(new DataColumn("Archive", typeof(Boolean)));
            foreach (KeyValuePair<Int32, Collaborateur> colab in listCollaborateur)
            {
                if (colab.Value.Archive)
                {
                    DR = dt.NewRow();
                    DR[0] = colab.Value.Matricule;
                    DR[1] = colab.Value.Civilite;
                    DR[2] = colab.Value.NomCollaborateur;
                    DR[3] = colab.Value.PrenomCollaborateur;
                    DR[4] = colab.Value.RueCollab + " " + colab.Value.CpCollab + " " + colab.Value.VilleCollab;
                    DR[5] = colab.Value.Telephone;
                    DR[6] = colab.Value.Archive;
                    dt.Rows.Add(DR);
                }

            }
            return dt;
        }
        /// <summary>
        /// Méthode retournant la liste des collaborateurs en DataTable pour remplir la DataGrid
        /// </summary>
        /// <returns></returns>
        public static DataTable ListCollab()
        {
           
            DataTable dt = new DataTable();
            DataRow DR;
            dt.Columns.Add(new DataColumn("#", typeof(Int32)));
            dt.Columns.Add(new DataColumn("Civ", typeof(String)));
            dt.Columns.Add(new DataColumn("Nom", typeof(String)));
            dt.Columns.Add(new DataColumn("Prénom", typeof(String)));
            dt.Columns.Add(new DataColumn("Adresse", typeof(String)));
            dt.Columns.Add(new DataColumn("Telephone", typeof(String)));
            
            foreach (KeyValuePair<Int32, Collaborateur> colab in listCollaborateur)
            {
                if (!colab.Value.Archive)
                {
                    DR = dt.NewRow();
                    DR[0] = colab.Value.Matricule;
                    DR[1] = colab.Value.Civilite;
                    DR[2] = colab.Value.NomCollaborateur;
                    DR[3] = colab.Value.PrenomCollaborateur;
                    DR[4] = colab.Value.RueCollab+" "+colab.Value.CpCollab+" "+colab.Value.VilleCollab;
                    DR[5] = colab.Value.Telephone;
                    dt.Rows.Add(DR);
                }

            }
            return dt;
        }
        /// <summary>
        /// Méthode retournant les contrats d'un collaborateur sous forme de DataTable pour remplir la dgContrats
        /// </summary>
        /// <param name="unCollaborateur"></param>
        /// <returns></returns>
        public static DataTable ListContrats(Collaborateur unCollaborateur)
        {
            
            DataTable dt = new DataTable();
            DataRow DR;
            dt.Columns.Add(new DataColumn("#", typeof(Int32)));
            dt.Columns.Add(new DataColumn("type", typeof(String)));
            dt.Columns.Add(new DataColumn("statut", typeof(String)));
            dt.Columns.Add(new DataColumn("qualification", typeof(String)));
            dt.Columns.Add(new DataColumn("fonction", typeof(String)));
            dt.Columns.Add(new DataColumn("avenant", typeof(Int32)));


            foreach (KeyValuePair<Int32,Contrat> leContrat in unCollaborateur.LesContrats)
            {
                
                DR = dt.NewRow();
                DR[0] = leContrat.Value.NumContrat;
                if (leContrat.Value is ContratCDD)
                {
                    DR[1] = "CDD";
                    ContratCDD leCDD = (ContratCDD)leContrat.Value;
                    DR[5] = leCDD.ListAvenant.Count();
                }
                else if (leContrat.Value is ContratCDI)
                {
                    DR[1] = "CDI";
                    ContratCDI leCDD = (ContratCDI)leContrat.Value;
                    DR[5] = leCDD.lesAvenants.Count();
                }
                else if (leContrat.Value is contratInterim)
                {
                    DR[1] = "interim";
                    contratInterim leCDD = (contratInterim)leContrat.Value;
                    DR[5] = leCDD.lesAvenant.Count();
                }
                else
                {
                    DR[1] = "stage";
                    ContratStage leStage = (ContratStage)leContrat.Value;
                    DR[5] = leStage.lesAvenant.Count();
                }
                if (leContrat.Value.LeStatut == true)
                {
                    DR[2] = "cadre";
                }
                else DR[2] = "non cadre";
                DR[3] = leContrat.Value.QualificationCollaborateur;
                DR[4] = leContrat.Value.FonctionCollaborateur;
                dt.Rows.Add(DR);
            }
            return dt;
        }

        public static Int32 nbCollab()
        {
            return listCollaborateur.Count();
        }
    }
}

