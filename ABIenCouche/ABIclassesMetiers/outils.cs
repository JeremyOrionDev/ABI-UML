using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABIenCouche
{
    class outils
    {
        public static String typeContrat(Contrat unContrat)
        {
            if (unContrat is ContratCDD)
            {
                return "CDD";
            }
            else if (unContrat is ContratCDI)
            {
                return "CDI";
            }
            else if (unContrat is contratInterim)
            {
                return "INTERIM";
            }
            else if (unContrat is ContratStage)
            {
                return "STAGE";
            }
            else return "le contrat n'existe pas";
        }
    }
}
