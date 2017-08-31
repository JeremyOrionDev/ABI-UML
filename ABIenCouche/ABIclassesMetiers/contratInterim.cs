using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABIenCouche
{
    class contratInterim:Contrat
    {
        public contratInterim(Int32 uneRef,String uneAgence,Double leSalaire, String uneFonction, String uneQualif, Boolean unStatut, DateTime leDebut, String uneRue, String uneVille, String unCP) : base(uneFonction, uneQualif, unStatut, leDebut, uneRue, uneVille, unCP)
        {
            this.RefContrat = uneRef;
            this.Agence = uneAgence;
            this.Salaire = leSalaire;
        }
        private Int32 refContrat;
        private String agence;
        private Double salaire;

        public int RefContrat
        {
            get
            {
                return refContrat;
            }

            set
            {
                refContrat = value;
            }
        }

        public string Agence
        {
            get
            {
                return agence;
            }

            set
            {
                agence = value;
            }
        }

        public double Salaire
        {
            get
            {
                return salaire;
            }

            set
            {
                salaire = value;
            }
        }
    }
}
