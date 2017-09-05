using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABIenCouche
{
    public class DictionnaireCDD
    {
        /// <summary>
        /// dictionnaire statique privé de contrat CDD
        /// </summary>
        private static SortedDictionary<int, ContratCDD> lesCDD = new SortedDictionary<int, ContratCDD>();

        public ContratCDD ContratCDD
        {
            get
            {
                throw new System.NotImplementedException();
            }

            set
            {
            }
        }

        /// <summary>
        /// méthode publique d'ajout de contrat CDD
        /// </summary>
        /// <param name="unCDD"></param>
        public static void AjouterCDD(ContratCDD unCDD)
        {

            if (!lesCDD.ContainsKey(unCDD.NumContrat))
            {
                lesCDD.Add(unCDD.NumContrat, unCDD);

            }
            else throw new Exception(" le collaborateur est déja dans la base");
        }
        /// <summary>
        /// méthode publique de suppression de contrat CDD
        /// </summary>
        /// <param name="unCDD"></param>
        public static void  supprimerCDD(ContratCDD unCDD)
        {
            if (lesCDD.ContainsKey(unCDD.NumContrat))
            {
                lesCDD.Remove(unCDD.NumContrat);
            }
            else throw new Exception("le contrat CDD n'existe pas merci de vérifier le numéro saisi du contrat saisi");
        }
        /// <summary>
        /// methode publique de récupération de CDD
        /// </summary>
        /// <param name="numContrat"></param>
        /// <returns></returns>
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
