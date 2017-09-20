using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDAO
{
    public partial class Collaborateurs
    {
        public Collaborateurs(Int32 unMatricule, String uneCivilite, String situation, String unNom, String unPrenom, String uneRue, String uneVille, String unCP, String unTel)
        {
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
    }
}
