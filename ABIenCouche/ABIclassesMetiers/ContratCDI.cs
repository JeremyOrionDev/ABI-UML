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

        public ContratCDI( String unLibelle, Double unSalaire,String unePhoto, Int32 unNumContrat, String uneFonction, String uneQualif, Boolean unStatut, DateTime leDebut) :
            base( unNumContrat,uneFonction, uneQualif,unLibelle, unStatut, leDebut)
        {

            this.LibelleContrat = unLibelle;
            this.SalaireBrut = unSalaire;
            this.LaPhoto = unePhoto;
      
            lesAvenants = new SortedDictionary<int, ABIenCouche.avenantContrat>();
        }
        private double salaireBrut;
        private String laPhoto;



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

        public string LaPhoto
        {
            get
            {
                return laPhoto;
            }

            set
            {
                laPhoto = value;
            }
        }


    }
}
