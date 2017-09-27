using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDAO
{
    /// <summary>
    /// Classe partielle de Collaborateurs pour la classe DAO
    /// </summary>
    public partial class Collaborateurs
    {
        /// <summary>
        /// Constructeur complet de collaborateur avec tous ses paramètres
        /// </summary>
        /// <param name="unMatricule">ref au matricule du collaborateur</param>
        /// <param name="uneCivilite">Civilité du collaborateur</param>
        /// <param name="situation">Situation maritale du collaborateur</param>
        /// <param name="unNom">Nom du collaborateur</param>
        /// <param name="unPrenom">Prénom du collaborateur</param>
        /// <param name="uneRue">rRue du collaborateur</param>
        /// <param name="uneVille">Ville du collaborateur</param>
        /// <param name="unCP">Code postal du collaborateur</param>
        /// <param name="unTel">Téléphone du collaborateur</param>
        /// <param name="isArchiv">Etat d'archivage du collaborateur</param>
        public Collaborateurs(Int32 unMatricule, String uneCivilite, String situation, String unNom, String unPrenom, String uneRue, String uneVille, String unCP, String unTel,Boolean isArchiv)
        {
            Archive = isArchiv;
            matricule = unMatricule;
            Civilite = uneCivilite;
            SituationMaritale = situation;
            Nom = unNom;
            Prenom = unPrenom;
            Rue = uneRue;
            CodePostal = unCP;
            Ville = uneVille;
            Telephone = unTel;
            SortedDictionary<Int32,Contrats> lesContrats = new SortedDictionary<Int32, Contrats>();

        }
        public Collaborateurs() { }

        public Contrats Contrats1
        {
            get => default(Contrats);
            set
            {
            }
        }
    }
}
