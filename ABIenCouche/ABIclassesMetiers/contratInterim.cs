using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABIenCouche
{
    public class contratInterim:Contrat
    {
        public contratInterim(String uneAgence,String unMotif,Double leSalaire,DateTime uneDateFin, Int32 unNumContrat, String uneFonction, String uneQualif, String unLibelle, Boolean unStatut, DateTime leDebut) : base(unNumContrat, uneFonction, uneQualif, unLibelle, unStatut, leDebut)
        {
            this.Agence = uneAgence;
            this.Salaire = leSalaire;
            this.LaDateFin = uneDateFin;
            this.MotifContrat = unMotif;
        }

        private String agence;
        private Double salaire;
        private DateTime? laDateFin;
        private String motifContrat;


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

        public DateTime? LaDateFin
        {
            get
            {
                return laDateFin;
            }

            set
            {
                laDateFin = value;
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
