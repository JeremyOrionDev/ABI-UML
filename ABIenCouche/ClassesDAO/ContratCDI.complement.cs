using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDAO
{
    public partial class ContratCDI:Contrats
    {
        public ContratCDI(String unLibelle, Double unSalaire, Int32 unNumContrat, String uneFonction, String uneQualif, Boolean unStatut, DateTime leDebut) :
    base(unNumContrat, uneFonction, uneQualif, unLibelle, unStatut, leDebut)
        {

            this.Libelle = unLibelle;
            this.Salaire = unSalaire;

        }
    }
}
