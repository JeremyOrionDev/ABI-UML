/***********************************************************************
 * Module:  Contrat.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Contrat
 ***********************************************************************/

using System;

namespace ABIenCouche
{

    public abstract class Contrat
    {
        
        public override String ToString()
        {
            return "le contrat numero: " + this.numContrat + "commençant le : " + DateDebutContrat;
        }

        public Contrat(Int32 leNumContrat, DateTime leDebut)
        {
            this.numContrat = leNumContrat;
            this.DateDebutContrat = leDebut;

          
        }



        //public bool Equals(Contrat con1, Contrat con2)
        //{
        //    if (con1.numContrat == con2.numContrat && con1.idCollaborateur == con2.idCollaborateur)
        //    {
        //        return true;
        //    }
        //    else
        //        return false;
        //}
        private Int32 numContrat;
        private DateTime dateDebutContrat;

        public int NumContrat
        {
            get
            {
                return numContrat;
            }
            set
            {
                if (this.NumContrat != value)
                    this.numContrat = value;
            }
        }





        public DateTime DateDebutContrat
        {
            get
            {
                return dateDebutContrat;
            }
            set
            {
                if (this.dateDebutContrat != value)
                    this.dateDebutContrat = value;
            }
        }
        

    }
}
