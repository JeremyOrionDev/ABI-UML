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
        Collaborateur unCollaborateur = new Collaborateur(1,"nom","prenom");
        public override String ToString()
        {
            // TODO: implement
            return "le contrat numero: " + numContrat + " du collaborateur: " +unCollaborateur.Matricule+" dont le salaire est: "+ Salaire+"€ type de contrat: "+typeContrat];
        }

        public Contrat(Int32 leNumContrat,Int32 unCollaborateur, Int32 leSalaire, String leMotif,String leType, String unEcole, DateTime leDebut, DateTime? laFin)
        {
            this.numContrat = leNumContrat;
            this.idCollaborateur = unCollaborateur;
            this.Salaire = leSalaire;
            this.MotifFin = leMotif;
            this.typeContrat = leType;
            this.EcoleStage = unEcole;
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
        private double Salaire;
        private String Qualif;
        private DateTime DateDebut;
        private DateTime? DateFin;
        private String NomAgence;
        private String MotifFin;
        private String EcoleStage;
        private Int32 Augmentation;

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

        public double _Salaire
        {
            get
            {
                return Salaire;
            }
            set
            {
                if (this.Salaire != value)
                    this.Salaire = value;
            }
        }

        public String _Qualif
        {
            get
            {
                return Qualif;
            }
            set
            {
                if (this.Qualif != value)
                    this.Qualif = value;
            }
        }

        public DateTime _DateDebut
        {
            get
            {
                return DateDebut;
            }
            set
            {
                if (this.DateDebut != value)
                    this.DateDebut = value;
            }
        }

        public String _NomAgence
        {
            get
            {
                return NomAgence;
            }
            set
            {
                if (this.NomAgence != value)
                    this.NomAgence = value;
            }
        }

        public String _Motif
        {
            get
            {
                return MotifFin;
            }
            set
            {
                if (this.MotifFin != value)
                    this.MotifFin = value;
            }
        }

        public DateTime _DateFin
        {
            get
            {
                return DateFin;
            }
            set
            {
                if (this.DateFin != value)
                    this.DateFin = value;
            }
        }

        public String _EcoleStage
        {
            get
            {
                return EcoleStage;
            }
            set
            {
                if (this.EcoleStage != value)
                    this.EcoleStage = value;
            }
        }

        public Int32 _Augmentation
        {
            get
            {
                return Augmentation;
            }
            set
            {
                if (this.Augmentation != value)
                    this.Augmentation = value;
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
