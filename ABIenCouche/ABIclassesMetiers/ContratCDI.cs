using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABIenCouche
{
    public class ContratCDI:Contrat
    {
        public SortedDictionary<Int32, avenantContrat> lesAvenants = new SortedDictionary<int, avenantContrat>();

        public ContratCDI( String unLibelle, Double unSalaire, Int32 unNumContrat, String uneFonction, String uneQualif, Boolean unStatut, DateTime leDebut) :
            base( unNumContrat,uneFonction, uneQualif,unLibelle, unStatut, leDebut)
        {

            this.LibelleContrat = unLibelle;
            this.SalaireBrut = unSalaire;
      
            lesAvenants = new SortedDictionary<int, ABIenCouche.avenantContrat>();
        }
        private double salaireBrut;



        public double SalaireBrut
        {
            get
            {
                return salaireBrut;
            }

            set
            {
                salaireBrut = value;
            }
        }



    }
}
