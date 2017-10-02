using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ABIenCouche
{
    /// <summary>
    /// Classe publique de contrats de type Interim dérivée de la classe Contrat
    /// </summary>
    [DataContract]
    public class contratInterim:Contrat
    {
        /// <summary>
        /// Dictionnaire d'avenants trié par leur numéros
        /// </summary>
        public SortedDictionary<Int32,avenantContrat> lesAvenant;
        /// <summary>
        /// Constructeur de la classe contrat intérim
        /// </summary>
        /// <param name="uneAgence">Agence d'intérim</param>
        /// <param name="unMotif">Motif du contrat</param>
        /// <param name="leSalaire">Salaire du collaborateur possédant le contrat</param>
        /// <param name="uneDateFin">Date de fin du Contrat</param>
        /// <param name="unNumContrat">Numéro de contrat</param>
        /// <param name="uneFonction">Fonction du collaborateur</param>
        /// <param name="uneQualif">Qualification du collaborateur</param>
        /// <param name="unLibelle">Libellé du contrat</param>
        /// <param name="unStatut">Statut cadre du collaborateur</param>
        /// <param name="leDebut">Date de début du contrat</param>
        public contratInterim(String uneAgence,String unMotif,Double leSalaire,DateTime uneDateFin, Int32 unNumContrat, String uneFonction, String uneQualif, String unLibelle, Boolean unStatut, DateTime leDebut) : base(unNumContrat, uneFonction, uneQualif, unLibelle, unStatut, leDebut)
        {
            this.Agence = uneAgence;
            this.Salaire = leSalaire;
            this.LaDateFin = uneDateFin;
            this.MotifContrat = unMotif;
            lesAvenant = new SortedDictionary<int, avenantContrat>();
        }
        /// <summary>
        /// Attribut privé du nom de l'agence d'interim
        /// </summary>
        private String agence;
        /// <summary>
        /// Attribut privé du salaire
        /// </summary>
        private Double salaire;
        /// <summary>
        /// Attribut privé de Date de fin du contrat
        /// </summary>
        private DateTime? laDateFin;
        /// <summary>
        /// Attribut privé du motif du contrat
        /// </summary>
        private String motifContrat;

        [DataMember]
        public string Agence
        {
            get
            {
                return agence;
            }
            private set
            {
                agence = value;
            }
        }
        [DataMember]
        public double Salaire
        {
            get
            {
                return salaire;
            }
            private set
            {
                salaire = value;
            }
        }
        [DataMember]
        public DateTime? LaDateFin
        {
            get
            {
                return laDateFin;
            }
            private set
            {
                laDateFin = value;
            }
        }
        [DataMember]
        public string MotifContrat
        {
            get
            {
                return motifContrat;
            }
            private set
            {
                motifContrat = value;
            }
        }
    }
}
