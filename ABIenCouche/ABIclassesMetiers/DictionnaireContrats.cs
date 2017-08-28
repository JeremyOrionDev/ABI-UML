using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABIenCouche
{
    class DictionnaireContrats
    {
        public SortedDictionary<Int32, Contrat> lesContrats;

        public  DictionnaireContrats()
        {
            lesContrats = new SortedDictionary<int, Contrat>();
        }

        /// <summary>
        /// Fonction ajout de contrat a un collaborateur
        /// </summary>
        /// <param name="leContrat"></param>
        public void AjoutContrat(Contrat leContrat)
        {
            if (!lesContrats.ContainsKey(leContrat.NumContrat))
            {
                lesContrats.Add(leContrat.NumContrat, leContrat);
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
            String libelle = leContrat.LibelleContrat;
            if (lesContrats.ContainsKey(numero))
            {
                lesContrats.Remove(numero);
                return "le contrat n° " + numero + " " + libelle + " a bien été supprimé.";
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
            String libelle = lesContrats[numero].LibelleContrat;
            if (lesContrats.ContainsKey(numero))
            {
                lesContrats.Remove(numero);
                return "le contrat n° " + numero + " " + libelle + " a bien été supprimé.";
            }
            else return "le contrat selectionné n'existe pas il ne peut donc pas être supprimé. Veuillez vérifier votre saisie";
        }

        /// <summary>
        /// fonction de remplacement de contrat
        /// </summary>
        /// <param name="unContrat">le contrat dont les données doivent être remplacées</param>
        public void RemplacerContrat(Contrat unContrat)
        {
            if (lesContrats.ContainsKey(unContrat.NumContrat))
            {
                lesContrats[unContrat.NumContrat] = unContrat;
            }
            else throw new Exception("le contrat correspondant au numéro entré n'existe pas, il ne peut pas être remplacé, merci de vérifier votre saisie");
        }

        /// <summary>
        /// fonction de récupération d'un contrat à partir de son numéro
        /// </summary>
        /// <param name="leNumero">le numéro du contrat à récupérer</param>
        /// <returns></returns>
        public Contrat retrouverContrat(Int32 leNumero)
        {
            if (lesContrats.ContainsKey(leNumero))
            {
                return lesContrats[leNumero];
            }
            else throw new Exception("le numéro renseigné ne correspond à aucun contrat pour le collaborateur selectionné, merci de vérifier votre saisie");
        }


    }
}
