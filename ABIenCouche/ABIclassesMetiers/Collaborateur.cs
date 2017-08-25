/***********************************************************************
 * Module:  Collaborateur.cs
 * Author:  CDI14
 * Purpose: Definition of the Class Collaborateur
 ***********************************************************************/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;

namespace ABIenCouche
{

    public class Collaborateur
    {
        /// <summary>
        /// Constructeur pour les collaborateur
        /// </summary>
        /// <param name="unNom">le nom du collaborateur</param>
        /// <param name="unPrenom">le prenom du collaborateur</param>
        /// <param name="unMatricule">le matricule du collaborateur</param>
        public Collaborateur(Int32 unMatricule, String unNom, String unPrenom)
        {
            this.NomCollaborateur = unNom;
            this.PrenomCollaborateur = unPrenom;
            this.Matricule = unMatricule;
        }

        public override String ToString()
        {
            return "collaborateur matricule: " + this.Matricule + " nom: " + this.NomCollaborateur + " prenom: " + this.PrenomCollaborateur;
        }




        /// <pdGenerated>default setter</pdGenerated>
        public void newContrat(Contrat unContrat)
        {
            if (unContrat.)
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

        private string nomCollaborateur;
        private string prenomCollaborateur;
        private Int32 matricule;
        private object photo;
        private String situationMaritale;

        public string NomCollaborateur
        {
            get
            {
                return nomCollaborateur;
            }
            set
            {
                if (this.nomCollaborateur != value)
                    this.nomCollaborateur = value;
            }
        }

        public string PrenomCollaborateur
        {
            get
            {
                return prenomCollaborateur;
            }
            set
            {
                if (this.prenomCollaborateur != value)
                    this.prenomCollaborateur = value;
            }
        }

        public int Matricule
        {
            get
            {
                return matricule;
            }
            set
            {
                if (this.matricule != value)
                    this.matricule = value;
            }
        }

        public object Photo
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

        public String SituationMaritale
        {
            get
            {
                return situationMaritale;
            }
            set
            {
                if (this.situationMaritale != value)
                    this.situationMaritale = value;
            }
        }

    }
}
