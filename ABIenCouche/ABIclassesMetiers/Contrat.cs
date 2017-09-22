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

namespace ABIenCouche
{
    /// <summary>
    /// Classe Abstraite de contrat de base dont les contrats(CDI,CDD,Stage et interim) d�rivent
    /// </summary>
    public abstract class Contrat
    {
        /// <summary>
        /// override de la m�thode toString
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            return "le contrat "+NumContrat+" libell�:"+libelleContrat;
        }
        /// <summary>
        /// Constructeur de contrat
        /// </summary>
        /// <param name="unNumContrat">Num�ro du contrat</param>
        /// <param name="uneFonction">Fonction du collaborateur</param>
        /// <param name="uneQualif">Qualification</param>
        /// <param name="unLibelle">Libell� complet du contrat</param>
        /// <param name="unStatut">Statut cadre ou non</param>
        /// <param name="leDebut">Date de d�but du contrat</param>
        public Contrat(Int32 unNumContrat,String uneFonction,String uneQualif,String unLibelle,Boolean unStatut, DateTime leDebut)
        {

            this.DateDebutContrat = leDebut;
            this.LeStatut = unStatut;
            this.QualificationCollaborateur = uneQualif;
            this.LibelleContrat = unLibelle;
            this.NumContrat = unNumContrat;
            this.FonctionCollaborateur = uneFonction;
            
        }
        /// <summary>
        /// M�thode de la classe m�tier de restitution de contrat pour un collaborateur et un num�ro de contrat
        /// </summary>
        /// <param name="unColab">ref au collaborateur dont on demande le contrat</param>
        /// <param name="numContrat">ref du contrat demand�</param>
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
        /// num�ro du contrat
        /// </summary>
        private Int32 numContrat;
        /// <summary>
        /// Date de d�but du contrat
        /// </summary>
        private DateTime dateDebutContrat;
        /// <summary>
        /// Libell� complet du contrat
        /// </summary>
        private String libelleContrat;






        public DateTime DateDebutContrat
        {
            get
            {
                return dateDebutContrat;
            }
            set
            {
                if (this.dateDebutContrat != value)
                    this.dateDebutContrat = value;
            }
        }

        public string QualificationCollaborateur
        {
            get
            {
                return qualificationCollaborateur;
            }

            set
            {
                qualificationCollaborateur = value;
            }
        }

        public string FonctionCollaborateur
        {
            get
            {
                return fonctionCollaborateur;
            }

            set
            {
                fonctionCollaborateur = value;
            }
        }

        public bool LeStatut
        {
            get
            {
                return leStatut;
            }

            set
            {
                leStatut = value;
            }
        }

       
        public string LibelleContrat
        {
            get
            {
                return libelleContrat;
            }

            set
            {
                libelleContrat = value;
            }
        }

        public int NumContrat
        {
            get
            {
                return numContrat;
            }

            set
            {
                numContrat = value;
            }
        }
    }
}
