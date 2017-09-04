using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABIenCouche
{
    public class DictionnaireCDD
    {
        private static SortedDictionary<int, ContratCDD> lesCDD = new SortedDictionary<int, ContratCDD>();
        public static void AjouterCDD(ContratCDD unCDD)
        {

            if (!lesCDD.ContainsKey(unCDD.NumContrat))
            {
                lesCDD.Add(unCDD.NumContrat, unCDD);

            }
            else throw new Exception(" le collaborateur est déja dans la base");
        }
        public static ContratCDD retrouverCDD(Int32 numContrat)
        {
            if (lesCDD.ContainsKey(numContrat))
            {
                return lesCDD[numContrat];
            }
            else throw new Exception("le numero de contrat n'est pas référencé");
        }
    }


}
