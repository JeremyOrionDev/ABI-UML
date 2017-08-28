using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABIenCouche
{
    public class ContratCDD:Contrat
    {
        public ContratCDD(Int32 unNum,DateTime uneDateDebut,String unLibelle, String unMotif, DateTime uneDateFin ):base(unNum,uneDateDebut)
        {
            
            this.NumContrat = unNum;
            this.Libelle = unLibelle;
            this.dateFinContrat = uneDateFin;
            this.motifContrat = unMotif;
        }


        private DateTime dateFinContrat;
        private String libelle;
        private String fonction;
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

        public string Fonction
        {
            get
            {
                return fonction;
            }

            set
            {
                fonction = value;
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
