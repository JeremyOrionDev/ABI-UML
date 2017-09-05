using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABIenCouche
{
    public class DictionnaireCDI
    {
        //private ContratCDI leCDI;

        internal static SortedDictionary<Int32, ContratCDI> lesCDI = new SortedDictionary<int, ContratCDI>();
        /// <summary>
        /// getteur pour les CDI
        /// </summary>
        public SortedDictionary<int, ContratCDI> LesCDI
        {
            get
            {
                return lesCDI;
            }

            
        }
        /// <summary>
        /// methode publique d'ajout de contrat CDI
        /// </summary>
        /// <param name="unCDI"></param>
        public static void ajouterCDI(ContratCDI unCDI)
        {
            if (!lesCDI.ContainsKey(unCDI.NumContrat))
            {
                lesCDI.Add(unCDI.NumContrat, unCDI);
            }
            else throw new Exception("un CDI existe deja avec ce numero de contrat, merci de vérifier votre saisie");
        }
        /// <summary>
        /// methode public de suppression de contrat CDI
        /// </summary>
        /// <param name="unCDI"></param>
        public static void supprimerCDI(ContratCDI unCDI)
        {
            if (lesCDI.ContainsKey(unCDI.NumContrat))
            {
                lesCDI.Remove(unCDI.NumContrat);
            }
            else throw new Exception("le CDI n'existe pas dans la base de donnée merci de vérifier votre saisie");
        }
        /// <summary>
        /// methode de récupération de CDI
        /// </summary>
        /// <param name="unCDI"></param>
        /// <returns></returns>
        public static ContratCDI retrouverCDI(ContratCDI unCDI)
        {
            if (lesCDI.ContainsKey(unCDI.NumContrat))
            {
                return lesCDI[unCDI.NumContrat];
            }
            else throw new Exception("le contrat demandé n'existe pas merci de vérifier le numero saisi");
        }
    }
}
