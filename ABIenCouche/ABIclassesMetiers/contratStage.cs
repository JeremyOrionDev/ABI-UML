using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ABIenCouche
{
    /// <summary>
    /// Classe publique De contrats de type stage hérite de la classe contrat
    /// </summary>
    [DataContract]
    public class ContratStage:Contrat
    {
        /// <summary>
        /// Dictionnaire des avenant du contrat trié par le numéro 
        /// </summary>
        public SortedDictionary<Int32, avenantContrat> lesAvenant;
        /// <summary>
        /// Constructeur de la classe
        /// </summary>
        /// <param name="uneEcole">école du stagiaire</param>
        /// <param name="unMotif">Motif amenant a la création du contrat</param>
        /// <param name="uneDateDeFin">Date de fin du contrat</param>
        /// <param name="laMission">Mission attribuée au stagiaire</param>
        /// <param name="leMaitre">Maitre de stage du stagiaire</param>
        /// <param name="unNumContrat">Numéro du contrat</param>
        /// <param name="uneFonction">Fonction du stagiaire</param>
        /// <param name="uneQualif">Qualification du stagiaire</param>
        /// <param name="unLibelle">Libellé du contrat du stagiaire</param>
        /// <param name="unStatut">Statut cadre ou non cadre</param>
        /// <param name="leDebut">Date de début du contrat</param>
        public ContratStage(String uneEcole,String unMotif,DateTime uneDateDeFin ,String laMission, String leMaitre,Int32 unNumContrat, String uneFonction, String uneQualif,String unLibelle, Boolean unStatut, DateTime leDebut) : base(unNumContrat,uneFonction, uneQualif, unLibelle, unStatut, leDebut)
        {
            this.Ecole = uneEcole;
            this.Motif = unMotif;
            this.DateDeFin = uneDateDeFin;
            this.UneMission = laMission;
            this.UnMaitre = leMaitre;
            lesAvenant = new SortedDictionary<int, avenantContrat>();
        }
        /// <summary>
        /// Attribut privé du nom de l'école du stagiaire
        /// </summary>
        private String ecole;
        /// <summary>
        /// attribut privé du motif amenant à la création du contrat
        /// </summary>
        private String motif;
        /// <summary>
        /// Attribut privé de la date de fin du contrat
        /// </summary>
        private DateTime dateDeFin;
        /// <summary>
        /// Attribut privé de la mission attribuée au stagiaire
        /// </summary>
        private String uneMission;
        /// <summary>
        /// Attribut privé référençant le maitre de stage du stagiaire
        /// </summary>
        private String unMaitre;
        [DataMember]
        public string Ecole
        {
            get
            {
                return ecole;
            }
            private set
            {
                ecole = value;
            }
        }
        [DataMember]
        public string Motif
        {
            get
            {
                return motif;
            }
            private set
            {
                motif = value;
            }
        }
        [DataMember]
        public DateTime DateDeFin
        {
            get
            {
                return dateDeFin;
            }
            private set
            {
                dateDeFin = value;
            }
        }
        [DataMember]
        public string UneMission
        {
            get
            {
                return uneMission;
            }
            private set
            {
                uneMission = value;
            }
        }
        [DataMember]
        public string UnMaitre
        {
            get
            {
                return unMaitre;
            }
            private set
            {
                unMaitre = value;
            }
        }
    }
}
