using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABIenCouche
{
    public class ContratCDD:Contrat
    {
        
        public ContratCDD(Int32 unNum,String unLibelle,DateTime uneDateFin,String unMotif,String uneFonction,String uneQualif,Boolean unStatut,DateTime leDebut,String uneRue,String uneVille,String unCP ) :base(uneFonction, uneQualif, unStatut, leDebut, uneRue, uneVille, unCP)
        {
            
            this.NumContrat = unNum;
            this.Libelle = unLibelle;
            this.dateFinContrat = uneDateFin;
            this.motifContrat = unMotif;
        
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
