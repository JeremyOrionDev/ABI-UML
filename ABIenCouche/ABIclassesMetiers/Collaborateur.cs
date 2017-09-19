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
        private SortedDictionary<Int32, Contrat> lesContrats;
        private SortedDictionary<DateTime, Contrat> lesContratsTriDate;
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
        public Collaborateur(Int32 unMatricule,String uneCivilite,String situation, String unNom, String unPrenom, String uneRue, String uneVille, String unCP,String unTel)
        {
            Matricule = unMatricule;
            Civilite = uneCivilite;
            NomCollaborateur = unNom;
            PrenomCollaborateur = unPrenom;
            rueCollab = uneRue;
            villeCollab = uneVille;
            cpCollab = unCP;
            Telephone = unTel;
            SituationMaritale = situation;
            LesContrats = new SortedDictionary<Int32, Contrat>();
            LesContratsTriDate = new SortedDictionary<DateTime, Contrat>();
            
        }

        public override String ToString()
        {
            return "collaborateur matricule: " + this.Matricule + " nom: " + this.NomCollaborateur + " prenom: " + this.PrenomCollaborateur + " à l'adresse: " + this.RueCollab + " " + this.CpCollab + " " + this.VilleCollab;
        }




        /// <pdGenerated>default setter</pdGenerated>
        public void ajoutContrat(Contrat unContrat)
        {
            if(!LesContrats.ContainsKey(unContrat.NumContrat))
            {
                LesContrats.Add(unContrat.NumContrat, unContrat);
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
            if (LesContrats.ContainsKey(oldContrat.NumContrat))

                LesContrats.Remove(oldContrat.NumContrat);
        }

        /// <pdGenerated>default removeAll</pdGenerated>
        public void RemoveAllContrat()
        {
            if (LesContrats.Count != 0)
                LesContrats.Clear();
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
            set
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


        public SortedDictionary<int, Contrat> LesContrats
        {
            get
            {
                return lesContrats;
            }

            set
            {
                lesContrats = value;
            }
            
        }

        public SortedDictionary<DateTime, Contrat> LesContratsTriDate
        {
            get
            {
                return lesContratsTriDate;
            }

            set
            {
                lesContratsTriDate = value;
            }
        }
    }
}
