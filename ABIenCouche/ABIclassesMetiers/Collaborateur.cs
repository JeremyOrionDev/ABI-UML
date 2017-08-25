/***********************************************************************
 * Module:  Collaborateur.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Collaborateur
 ***********************************************************************/

using System;

public class Collaborateur
{
   public Collaborateur(String nomCollaborateur, String prenomCollaborateur, int matricule)
   {
      // TODO: implement
   }
   
   public String ToString(String nomCollaborateur, String prenomCollaborateur, int matricule, String situation)
   {
      // TODO: implement
      return null;
   }

   public System.Collections.ArrayList contrat;
   
   /// <pdGenerated>default getter</pdGenerated>
   public System.Collections.ArrayList GetContrat()
   {
      if (contrat == null)
         contrat = new System.Collections.ArrayList();
      return contrat;
   }
   
   /// <pdGenerated>default setter</pdGenerated>
   public void SetContrat(System.Collections.ArrayList newContrat)
   {
      RemoveAllContrat();
      foreach (Contrat oContrat in newContrat)
         AddContrat(oContrat);
   }
   
   /// <pdGenerated>default Add</pdGenerated>
   public void AddContrat(Contrat newContrat)
   {
      if (newContrat == null)
         return;
      if (this.contrat == null)
         this.contrat = new System.Collections.ArrayList();
      if (!this.contrat.Contains(newContrat))
         this.contrat.Add(newContrat);
   }
   
   /// <pdGenerated>default Remove</pdGenerated>
   public void RemoveContrat(Contrat oldContrat)
   {
      if (oldContrat == null)
         return;
      if (this.contrat != null)
         if (this.contrat.Contains(oldContrat))
            this.contrat.Remove(oldContrat);
   }
   
   /// <pdGenerated>default removeAll</pdGenerated>
   public void RemoveAllContrat()
   {
      if (contrat != null)
         contrat.Clear();
   }

   private string NomCollaborateur;
   private string PrenomCollaborateur;
   private int Matricule;
   private object Photo;
   private String SituationMaritale;

   public string _NomCollaborateur
   {
      get
      {
         return NomCollaborateur;
      }
      set
      {
         if (this.NomCollaborateur != value)
            this.NomCollaborateur = value;
      }
   }
   
   public string _PrenomCollaborateur
   {
      get
      {
         return PrenomCollaborateur;
      }
      set
      {
         if (this.PrenomCollaborateur != value)
            this.PrenomCollaborateur = value;
      }
   }
   
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
   
   public object _Photo
   {
      get
      {
         return Photo;
      }
      set
      {
         if (this.Photo != value)
            this.Photo = value;
      }
   }
   
   public String _SituationMaritale
   {
      get
      {
         return SituationMaritale;
      }
      set
      {
         if (this.SituationMaritale != value)
            this.SituationMaritale = value;
      }
   }

}