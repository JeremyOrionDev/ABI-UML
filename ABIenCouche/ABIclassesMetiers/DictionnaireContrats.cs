using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABIenCouche
{
    public class DictionnaireContrats
    {
        public SortedDictionary<Int32, Contrat> listContrats;

        public  DictionnaireContrats()
        {
            listContrats = new SortedDictionary<int, Contrat>();
        }

        /// <summary>
        /// Fonction ajout de contrat a un collaborateur
        /// </summary>
        /// <param name="leContrat"></param>
        public void AjoutContrat(Contrat leContrat)
        {
            if (!listContrats.ContainsKey(leContrat.NumContrat))
            {
                listContrats.Add(leContrat.NumContrat, leContrat);
            }
            else throw new Exception("le numéro de contrat existe deja pour ce collaborateur, merci d'en selectionner un autre");

        }

        /// <summary>
        /// Fonction de suppression du contrat
        /// </summary>
        /// <param name="leContrat">le contrat à supprimer</param>
        /// <returns></returns>
        public String SupprimerContrat(Contrat leContrat)
        {
            Int32 numero = leContrat.NumContrat;
           
            if (listContrats.ContainsKey(numero))
            {
                listContrats.Remove(numero);
                return "le contrat n° " + numero + " a bien été supprimé.";
            }
            else return "le contrat selectionné n'existe pas il ne peut donc pas être supprimé. Veuillez vérifier votre saisie";
        }

        /// <summary>
        /// surchage de la fonction de suppression du contrat grâce à son numéro
        /// </summary>
        /// <param name="numContrat">le numéro du contrat à supprimer</param>
        /// <returns></returns>
        public String SupprimerContrat(Int32 numContrat)
        {
            Int32 numero = numContrat;

            if (listContrats.ContainsKey(numero))
            {
                listContrats.Remove(numero);
                return "le contrat n° " + numero  + " a bien été supprimé.";
            }
            else return "le contrat selectionné n'existe pas il ne peut donc pas être supprimé. Veuillez vérifier votre saisie";
        }



        /// <summary>
        /// fonction de récupération d'un contrat à partir de son numéro
        /// </summary>
        /// <param name="leNumero">le numéro du contrat à récupérer</param>
        /// <returns></returns>
        public Contrat retrouverContrat(Int32 leNumero)
        {
            if (listContrats.ContainsKey(leNumero))
            {
                return listContrats[leNumero];
            }
            else throw new Exception("le numéro renseigné ne correspond à aucun contrat pour le collaborateur selectionné, merci de vérifier votre saisie");
        }


    }
}
