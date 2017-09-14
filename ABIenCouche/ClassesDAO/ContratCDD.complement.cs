using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDAO
{
    public partial class ContratCDD:Contrats
    {
        public ContratCDD(String unLibelle, DateTime uneDateFin, String unMotif, Int32 unNumContrat, String uneFonction,
    String uneQualif, Boolean unStatut, DateTime leDebut) : base(unNumContrat, uneFonction, uneQualif, unLibelle, unStatut, leDebut)
        {


            this.DateFin = uneDateFin;
            this.Motif = unMotif;

        }
    }
}
