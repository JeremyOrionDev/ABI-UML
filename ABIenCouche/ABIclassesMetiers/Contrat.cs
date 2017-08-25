/***********************************************************************
 * Module:  Contrat.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Contrat
 ***********************************************************************/

using System;

public abstract class Contrat
{
   public String ToString()
   {
      // TODO: implement
      return [matricule, salaire,contrat];
   }
   
   public Contrat(int matricule, int salaire, String motif, String ecole, DateTime duree)
   {
      // TODO: implement
   }
   
   public Int32 GetHashCode()
   {
      // TODO: implement
      return null;
   }
   
   public bool Equals()
   {
      // TODO: implement
      return false;
   }

   private int Matricule;
   private double Salaire;
   private String Qualif;
   private DateTime DateDebut;
   private String NomAgence;
   private String MotifFin;
   private DateTime DateFin;
   private String EcoleStage;
   private Int32 Augmentation;

   public int _Matricule
   {
      get
      {
         return Matricule;
      }
      set
      {
         if (this.Matricule != value)
            this.Matricule = value;
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

}