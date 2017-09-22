using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABIenCouche
{
    /// <summary>
    /// Classe de contrat de type CDD
    /// </summary>
    public class ContratCDD:Contrat
    {
        /// <summary>
        /// Dictionnaire d'avenant aux contrat trié sur la réf
        /// </summary>
        public SortedDictionary<Int32, avenantContrat> ListAvenant;
        /// <summary>
        /// Constructeur de la classe contratCDD1
        /// </summary>
        /// <param name="unLibelle">Libellé complet du contrat CDD </param>
        /// <param name="uneDateFin">Date de fin du contrat</param>
        /// <param name="unMotif">Motif du contrat</param>
        /// <param name="unNumContrat">numéro du contrat</param>
        /// <param name="uneFonction">Fonctiondu conllaborateur</param>
        /// <param name="uneQualif">Qualification du collaborateur</param>
        /// <param name="unStatut">Etat du statut cadre</param>
        /// <param name="leDebut">Date de début du contrat </param>
        public ContratCDD(String unLibelle,DateTime uneDateFin,String unMotif, Int32 unNumContrat, String uneFonction,
            String uneQualif,Boolean unStatut,DateTime leDebut ) :base(unNumContrat,uneFonction, uneQualif,unLibelle, unStatut, leDebut)
        {
            this.dateFinContrat = uneDateFin;
            this.motifContrat = unMotif;
            ListAvenant = new SortedDictionary<int, ABIenCouche.avenantContrat>();
        }

        /// <summary>
        /// Méthode statique de récupération de contrat CDD pour le collaborateur entré en paramètre et dont le numéro est entré en paramètre
        /// </summary>
        /// <param name="unColab">Collaborateur pour lequel on cherche le contrat</param>
        /// <param name="numContrat">Numéro du contrat recherché</param>
        /// <returns></returns>
        public static Contrat retrouverCDD(Collaborateur unColab, Int32 numContrat)
        {
            if (unColab.LesContrats.ContainsKey(numContrat))
            {
                return unColab.LesContrats[numContrat];
            }
            else throw new Exception("le collaborateur ne possede pas de contrats");
        }
        /// <summary>
        /// Date de fin du contrat
        /// </summary>
        private DateTime dateFinContrat;
        /// <summary>
        /// libellé du contrat
        /// </summary>
        private String libelle;
        /// <summary>
        /// motif de création du contrat
        /// </summary>
        private String motifContrat;

        public DateTime DateFinContrat
        {
            get
            {
                return dateFinContrat;
            }

            set
            {
                dateFinContrat = value;
            }
        }

        public string Libelle
        {
            get
            {
                return libelle;
            }

            set
            {
                libelle = value;
            }
        }



        public string MotifContrat
        {
            get
            {
                return motifContrat;
            }

            set
            {
                motifContrat = value;
            }
        }


    }
}
