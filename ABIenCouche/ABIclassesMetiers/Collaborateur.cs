/***********************************************************************
 * Module:  Collaborateur.cs
 * Author:  Jeremy ORION
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
        public SortedDictionary<Int32, Contrat> lesContrats ;

        private String nomCollaborateur;
        private String prenomCollaborateur;
        private String rueCollab;
        private String villeCollab;
        private String cpCollab;
        private Int32 matricule;
        private Int32 augmentation;
        private String situationMaritale;
        private String civilite;
        private String telephone;
   
        /// <summary>
        /// Constructeur pour les collaborateur
        /// </summary>
        /// <param name="unNom">le nom du collaborateur</param>
        /// <param name="unPrenom">le prenom du collaborateur</param>
        /// <param name="unMatricule">le matricule du collaborateur</param>
        public Collaborateur(Int32 unMatricule,String uneCivilite, String unNom, String unPrenom, String uneRue, String uneVille, String unCP,Int32 uneAugmentation,String unTel)
        {
            this.NomCollaborateur = unNom;
            this.PrenomCollaborateur = unPrenom;
            this.Matricule = unMatricule;
            this.rueCollab = uneRue;
            this.villeCollab = uneVille;
            this.cpCollab = unCP;
            this.Augmentation = uneAugmentation;
            this.Civilite = uneCivilite;
            this.Telephone = unTel;
            lesContrats = new SortedDictionary<Int32, Contrat>();

            
        }

        public override String ToString()
        {
            return "collaborateur matricule: " + this.Matricule + " nom: " + this.NomCollaborateur + " prenom: " + this.PrenomCollaborateur + " à l'adresse: " + this.RueCollab + " " + this.CpCollab + " " + this.VilleCollab;
        }




        /// <pdGenerated>default setter</pdGenerated>
        public void ajoutContrat(Contrat unContrat)
        {
            if(!lesContrats.ContainsKey(unContrat.NumContrat))
            {
                lesContrats.Add(unContrat.NumContrat, unContrat);
            }
            else
            {
                throw new Exception("Le collaborateur " + this.nomCollaborateur + " possède déja le contrat: " + unContrat.NumContrat);
            }
   }



        /// <pdGenerated>default Remove</pdGenerated>
        public void supprimeContrat(Contrat oldContrat)
        {
            if (oldContrat == null)
                throw new Exception("le contrat entré n'existe pas");
            if (lesContrats.ContainsKey(oldContrat.NumContrat))

                lesContrats.Remove(oldContrat.NumContrat);
        }

        /// <pdGenerated>default removeAll</pdGenerated>
        public void RemoveAllContrat()
        {
            if (lesContrats.Count != 0)
                lesContrats.Clear();
        }


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

        public String Photo
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

        public string RueCollab
        {
            get
            {
                return rueCollab;
            }

            set
            {
                rueCollab = value;
            }
        }

        public string VilleCollab
        {
            get
            {
                return villeCollab;
            }

            set
            {
                villeCollab = value;
            }
        }

        public string CpCollab
        {
            get
            {
                return cpCollab;
            }

            set
            {
                cpCollab = value;
            }
        }

        public int Augmentation
        {
            get
            {
                return augmentation;
            }

            set
            {
                augmentation = value;
            }
        }

        public String Civilite
        {
            get
            {
                return civilite;
            }
            private set
            {
                civilite = value;
            }
        }

        public string Telephone
        {
            get
            {
                return telephone;
            }

            set
            {
                telephone = value;
            }
        }
    }
}
