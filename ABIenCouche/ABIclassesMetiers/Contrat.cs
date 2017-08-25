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
            if(this.typeContrat=="CDI")
            {
                return ("Ceci est le contrat numero: " + this.numContrat +" c'est un CDI débutant le " + this.dateDebut);
            }
            else
            {
                if (this.typeContrat =="stage")
                {
                    return ("ce contrat est un stage pour le motif: " + this.motifCDD + " avec l'école: " + this.ecoleStage + "commençant le: " + this.dateDebut + "finissant le: " + this.dateFin);
                }
                if (this.typeContrat =="CDD")
                {
                    return ("ce contrat est un CDD pour le motif: " + this.motifCDD + " pour un salaire de " + this.salaire + "€ débutant le " + this.dateDebut + " finissant le: " + this.dateFin);
                }
                
            }
        }

        public Contrat(Int32 leNumContrat, Int32 unCollaborateur, Int32 leSalaire, String leType,  DateTime leDebut)
        {
            this.numContrat = leNumContrat;
            this.idCollaborateur = unCollaborateur;
            this.Salaire = leSalaire;
            this.typeContrat = leType;
            this.DateDebut = leDebut;
          
        }
        public Contrat(Int32 leNumContrat,Int32 unCollaborateur, Int32 leSalaire, String? leMotif,String leType, String? unEcole, DateTime leDebut, DateTime? laFin)
        {
            this.numContrat = leNumContrat;
            this.idCollaborateur = unCollaborateur;
            this.Salaire = leSalaire;
            this.motifFin = leMotif;
            this.typeContrat = leType;
            this.ecoleStage = unEcole;
            this.DateDebut = leDebut;
            this.DateFin = laFin;
        }

        public override Int32 GetHashCode()
        {
            // TODO: implement
            return this.idCollaborateur;
        }

        public bool Equals(Contrat con1, Contrat con2)
        {
            if (con1.numContrat == con2.numContrat && con1.idCollaborateur == con2.idCollaborateur)
            {
                return true;
            }
            else
                return false;
        }
        private Int32 numContrat;
        private Int32 idCollaborateur;
        private String typeContrat;
        private double salaire;
        private String qualif;
        private DateTime dateDebut;
        private DateTime? dateFin;
        private String? nomAgence;
        private String? motifFin;
        private String? motifCDD;
        private String? ecoleStage;
        private Int32 augmentation;

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

        public double Salaire
        {
            get
            {
                return salaire;
            }
            set
            {
                if (this.salaire != value)
                    this.salaire = value;
            }
        }

        public String Qualif
        {
            get
            {
                return qualif;
            }
            set
            {
                if (this.qualif != value)
                    this.qualif = value;
            }
        }

        public DateTime DateDebut
        {
            get
            {
                return dateDebut;
            }
            set
            {
                if (this.dateDebut != value)
                    this.dateDebut = value;
            }
        }

        public String? NomAgence
        {
            get
            {
                return nomAgence;
            }
            set
            {
               
                    this.nomAgence = value;
            }
        }

        public String? MotifFin
        {
            get
            {
                return motifFin;
            }
            set
            {
                
                    this.motifFin = value;
            }
        }

        public DateTime? DateFin
        {
            get
            {
                return dateFin;
            }
            set
            {
                if (this.dateFin != value)
                    this.dateFin = value;
            }
        }

        public String? EcoleStage
        {
            get
            {
                return ecoleStage;
            }
            set
            {
                
                    this.ecoleStage = value;
            }
        }

        public Int32 Augmentation
        {
            get
            {
                return augmentation;
            }
            set
            {
                if (this.augmentation != value)
                    this.augmentation = value;
            }
        }

        public string TypeContrat
        {
            get
            {
                return typeContrat;
            }

            set
            {
                typeContrat = value;
            }
        }

        public int IdCollaborateur
        {
            get
            {
                return idCollaborateur;
            }

            set
            {
                idCollaborateur = value;
            }
        }
    }
}
