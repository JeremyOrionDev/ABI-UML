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

        public override String ToString()
        {
            return "le contrat numero: " + this.numContrat + "commençant le : " + DateDebutContrat;
        }

        public Contrat(String uneFonction,String uneQualif,Boolean unStatut, DateTime leDebut,String uneRue,String uneVille,String unCP)
        {
            this.RueContrat = uneRue;
            this.VilleContrat = uneVille;
            this.CodePostalContrat = unCP;
            this.DateDebutContrat = leDebut;
            this.LeStatut = unStatut;
            this.QualificationCollaborateur = uneQualif;
            this.FonctionCollaborateur = uneFonction;
            ListAvenant = new SortedDictionary<int, ABIenCouche.avenantContrat>();
        }
        private String rueContrat;
        private String villeContrat;
        private String codePostalContrat;
        private String qualificationCollaborateur;
        private String fonctionCollaborateur;
        private Boolean leStatut;
        private Int32 numContrat;
        private DateTime dateDebutContrat;

        public int NumContrat
        {
            get
            {
                return numContrat;
            }
            set
            {
                if (this.NumContrat != value)
                    this.numContrat = value;
            }
        }





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

        public string RueContrat
        {
            get
            {
                return rueContrat;
            }

            set
            {
                rueContrat = value;
            }
        }

        public string VilleContrat
        {
            get
            {
                return villeContrat;
            }

            set
            {
                villeContrat = value;
            }
        }

        public string CodePostalContrat
        {
            get
            {
                return codePostalContrat;
            }

            set
            {
                codePostalContrat = value;
            }
        }
    }
}
