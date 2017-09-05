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

    public abstract class Contrat
    {
        public SortedDictionary<Int32, avenantContrat> ListAvenant;
        private Collaborateur leCollaborateur;
        private Contrat leContrat;
        public override String ToString()
        {
            return "le contrat ";
        }

        public Contrat(Int32 unNumContrat,String uneFonction,String uneQualif,String unLibelle,Boolean unStatut, DateTime leDebut)
        {

            this.DateDebutContrat = leDebut;
            this.LeStatut = unStatut;
            this.QualificationCollaborateur = uneQualif;
            this.LibelleContrat = unLibelle;
            this.NumContrat = unNumContrat;
            this.FonctionCollaborateur = uneFonction;
            ListAvenant = new SortedDictionary<int, ABIenCouche.avenantContrat>();
        }
        public static Contrat retrouverContrat(Collaborateur unColab, Int32 numContrat)
        {
            if (unColab.lesContrats.ContainsKey(numContrat))
            {
                return unColab.lesContrats[numContrat];
            }
            else throw new Exception("le collaborateur ne possede pas de contrats");
        }
        private String qualificationCollaborateur;
        private String fonctionCollaborateur;
        private Boolean leStatut;
        private Int32 numContrat;
        private DateTime dateDebutContrat;
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
