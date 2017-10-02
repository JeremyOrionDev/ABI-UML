using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;

namespace ABIenCouche
{
    /// <summary>
    /// Classe publique de contrat de type CDI
    /// </summary>
    [DataContract]
    public class ContratCDI:Contrat
    {
        /// <summary>
        /// 
        /// </summary>
        public SortedDictionary<Int32, avenantContrat> lesAvenants = new SortedDictionary<int, avenantContrat>();

        public ContratCDI( String unLibelle, Double unSalaire, Int32 unNumContrat, String uneFonction, String uneQualif, Boolean unStatut, DateTime leDebut) :
            base( unNumContrat,uneFonction, uneQualif,unLibelle, unStatut, leDebut)
        {

            LibelleContrat = unLibelle;
            this.SalaireBrut = unSalaire;
      
            lesAvenants = new SortedDictionary<int, ABIenCouche.avenantContrat>();
        }
        private double salaireBrut;


        [DataMember]
        public double SalaireBrut
        {
            get
            {
                return salaireBrut;
            }
            private set
            {
                salaireBrut = value;
            }
        }



    }
}
