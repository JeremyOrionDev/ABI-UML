using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABIenCouche
{
    class ContratCDI:Contrat
    {
        public SortedDictionary<Int32, avenantContrat> lesAvenants = new SortedDictionary<int, avenantContrat>();

        public ContratCDI(Int32 leNumContrat, String unLibelle, Double unSalaire,String unePhoto, String uneFonction, String uneQualif, Boolean unStatut, DateTime leDebut,String uneRue,String uneVille,String unCP) :
            base( uneFonction, uneQualif, unStatut, leDebut, uneRue, uneVille, unCP)
        {

            this.NumContrat = leNumContrat;
            this.LibelleContrat = unLibelle;
            this.SalaireBrut = unSalaire;
            this.LaPhoto = unePhoto;

            lesAvenants = new SortedDictionary<int, ABIenCouche.avenantContrat>();
        }
        private String libelleContrat;
        private double salaireBrut;
        private String laPhoto;

        public string LibelleContrat
        {
            get
            {
                return libelleContrat;
            }

            set
            {
                libelleContrat = value;
            }
        }

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
