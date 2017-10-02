/***********************************************************************
 * Module:  Contrat.cs
 * Author:  Jeremy ORION
 * Purpose: Definition of the Class Contrat
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ABIenCouche
{
    /// <summary>
    /// Classe Abstraite de contrat de base dont les contrats(CDI,CDD,Stage et interim) dérivent
    /// </summary>
    [Serializable]
    [DataContract]
    [KnownType(typeof(ContratCDI))]
    [KnownType(typeof(ContratCDD))]
    [KnownType(typeof(ContratStage))]
    [KnownType(typeof(contratInterim))]
    public abstract class Contrat
    {
        /// <summary>
        /// override de la méthode toString
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            return "le contrat "+NumContrat+" libellé:"+libelleContrat;
        }
        /// <summary>
        /// Constructeur de contrat
        /// </summary>
        /// <param name="unNumContrat">Numéro du contrat</param>
        /// <param name="uneFonction">Fonction du collaborateur</param>
        /// <param name="uneQualif">Qualification</param>
        /// <param name="unLibelle">Libellé complet du contrat</param>
        /// <param name="unStatut">Statut cadre ou non</param>
        /// <param name="leDebut">Date de début du contrat</param>
        public Contrat(Int32 unNumContrat, String uneFonction, String uneQualif, String unLibelle, Boolean unStatut, DateTime leDebut,int unId)
        {

            this.dateDebutContrat = leDebut;
            this.leStatut = unStatut;
            this.qualificationCollaborateur = uneQualif;
            this.libelleContrat = unLibelle;
            this.NumContrat = unNumContrat;
            this.fonctionCollaborateur = uneFonction;
            this.IdContrat = unId;
        }
        /// <summary>
        /// Méthode de la classe métier de restitution de contrat pour un collaborateur et un numéro de contrat
        /// </summary>
        /// <param name="unColab">ref au collaborateur dont on demande le contrat</param>
        /// <param name="numContrat">ref du contrat demandé</param>
        /// <returns></returns>
        public static Contrat retrouverContrat(Collaborateur unColab, Int32 numContrat)
        {
            if (unColab.LesContrats.ContainsKey(numContrat))
            {
                return unColab.LesContrats[numContrat];
            }
            else throw new Exception("le collaborateur ne possede pas de contrats");
        }
        /// <summary>
        /// qualification du collaborateur
        /// </summary>
        private String qualificationCollaborateur;
        /// <summary>
        /// fonction du collaborateur
        /// </summary>
        private String fonctionCollaborateur;
        /// <summary>
        /// Etat du statut cadre
        /// </summary>
        private Boolean leStatut;
        /// <summary>
        /// numéro du contrat
        /// </summary>
        private Int32 numContrat;
        /// <summary>
        /// Date de début du contrat
        /// </summary>
        private DateTime dateDebutContrat;

        private int idContrat;
        /// <summary>
        /// Libellé complet du contrat
        /// </summary>
        private String libelleContrat;
        [DataMember]
        public DateTime DateDebutContrat
        {
            get
            {
                return dateDebutContrat;
            }
            private set
            {
                if (this.dateDebutContrat != value)
                    this.dateDebutContrat = value;
            }
        }
        [DataMember]
        public string QualificationCollaborateur
        {
            get
            {
                return qualificationCollaborateur;
            }
            private set
            {
                qualificationCollaborateur = value;
            }
        }
        [DataMember]
        public string FonctionCollaborateur
        {
            get
            {
                return fonctionCollaborateur;
            }
            private set
            {
                fonctionCollaborateur = value;
            }
        }
        [DataMember]
        public bool LeStatut
        {
            get
            {
                return leStatut;
            }
            private set
            {
                leStatut = value;
            }
        }

       [DataMember]
        public string LibelleContrat
        {
            get
            {
                return libelleContrat;
            }
            internal set
            {
                this.libelleContrat = value;
            }
        }
        [DataMember]
        public int NumContrat
        {
            get
            {
                return numContrat;
            }
            private set
            {
                numContrat = value;
            }
        }

        public int IdContrat { get => idContrat; set => idContrat = value; }
    }
}
