using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ABIenCouche
{
    /// <summary>
    /// Classe des avenant associés au contrat
    /// </summary>
    [Serializable]
    [DataContract]
    public  class avenantContrat
    {
        /// <summary>
        /// constructeur d'un avenant de contrat
        /// </summary>
        /// <param name="unNumero">numero de l'avenant du contrat</param>
        /// <param name="libelle">Libellé pour l'avenant</param>
        /// <param name="uneDate">Date à laquelle l'avenant à été signé</param>
        public avenantContrat(Int32 unNumero, String libelle,DateTime uneDate)
        {
            this.NumeroAvenant = unNumero;
            this.LibelleAvenant = libelle;
            this.DateAvenant = uneDate;

        }
        /// <summary>
        /// référence privé contenant le numero de contrat en Int
        /// </summary>
        private Int32 numeroAvenant;
        /// <summary>
        /// le libellé de l'avenant en STring
        /// </summary>
        private String libelleAvenant;
        /// <summary>
        /// Date de l'avenant
        /// </summary>
        private DateTime dateAvenant;
        /// <summary>
        /// méthode get-set du numéro
        /// </summary>
        [DataMember]
        public int NumeroAvenant
        {
            get
            {
                return numeroAvenant;
            }
            private set
            {
                numeroAvenant = value;
            }
        }
        /// <summary>
        /// méthode get-set du libellé
        /// </summary>
        [DataMember]
        public string LibelleAvenant
        {
            get
            {
                return libelleAvenant;
            }
            private set
            {
                libelleAvenant = value;
            }
        }
        /// <summary>
        /// méthode get-set pour la date de l'avenant
        /// </summary>
        [DataMember]
        public DateTime DateAvenant
        {
            get
            {
                return dateAvenant;
            }
            private set
            {
                dateAvenant = value;
            }
        }
    }
}
