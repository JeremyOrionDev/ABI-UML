using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABIenCouche
{
    public  class avenantContrat
    {
        public avenantContrat(Int32 unNumero, String libelle,DateTime uneDate)
        {
            this.NumeroAvenant = unNumero;
            this.LibelleAvenant = libelle;
            this.DateAvenant = uneDate;

        }
        private Int32 numeroAvenant;
        private String libelleAvenant;
        private DateTime dateAvenant;

        public int NumeroAvenant
        {
            get
            {
                return numeroAvenant;
            }

            set
            {
                numeroAvenant = value;
            }
        }

        public string LibelleAvenant
        {
            get
            {
                return libelleAvenant;
            }

            set
            {
                libelleAvenant = value;
            }
        }

        public DateTime DateAvenant
        {
            get
            {
                return dateAvenant;
            }

            set
            {
                dateAvenant = value;
            }
        }
    }
}
