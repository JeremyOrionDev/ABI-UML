using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDAO
{
    public partial class ContratInterim:Contrats
    {

        public ContratInterim(String uneAgence, String unMotif, Double leSalaire, DateTime uneDateFin, Int32 unNumContrat, String uneFonction, String uneQualif, String unLibelle, Boolean unStatut, DateTime leDebut) : base(unNumContrat, uneFonction, uneQualif, unLibelle, unStatut, leDebut)
        {
            this.Agence = uneAgence;
            this.Salaire = leSalaire;
            this.DateFin = uneDateFin;
            this.Motif = unMotif;
        }
        public ContratInterim()
        {
        }
    }
}
