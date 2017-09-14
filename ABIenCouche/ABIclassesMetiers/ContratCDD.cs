using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABIenCouche
{
    public class ContratCDD:Contrat
    {
        
        public ContratCDD(String unLibelle,DateTime uneDateFin,String unMotif, Int32 unNumContrat, String uneFonction,
            String uneQualif,Boolean unStatut,DateTime leDebut ) :base(unNumContrat,uneFonction, uneQualif,unLibelle, unStatut, leDebut)
        {
            
     
            this.dateFinContrat = uneDateFin;
            this.motifContrat = unMotif;
        
        }
        public static Contrat retrouverCDD(Collaborateur unColab, Int32 numContrat)
        {
            if (unColab.LesContrats.ContainsKey(numContrat))
            {
                return unColab.LesContrats[numContrat];
            }
            else throw new Exception("le collaborateur ne possede pas de contrats");
        }

        private DateTime dateFinContrat;
        private String libelle;
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
