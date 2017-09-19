using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDAO
{
    public partial class Contrats
    {
        public Contrats(Int32 unNumContrat, String uneFonction, String uneQualif, String unLibelle, Boolean unStatut, DateTime leDebut)
        {

            this.DateDebut = leDebut;
            this.Statut = unStatut;
            this.Qualification = uneQualif;
            this.Libelle = unLibelle;
            this.NumContrat = unNumContrat;
            this.Fonction = uneFonction;
        }
        public Contrats() { }
    }
}
