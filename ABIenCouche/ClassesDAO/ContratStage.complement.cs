using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesDAO
{
    public partial class ContratStage:Contrats
    {
        public ContratStage()
        {
        }

        public ContratStage(String uneEcole, String unMotif, DateTime uneDateDeFin, String laMission, String leTuteur, Int32 unNumContrat, String uneFonction, String uneQualif, String unLibelle, Boolean unStatut, DateTime leDebut) : base(unNumContrat, uneFonction, uneQualif, unLibelle, unStatut, leDebut)
        {
            this.Ecole = uneEcole;
            this.Motif = unMotif;
            this.DateFin = uneDateDeFin;
            this.Mission = laMission;
            this.Tuteur = leTuteur;
        }
    }
}
