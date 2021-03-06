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
    /// <summary>
    /// Classe publique de Collaborateur
    /// </summary>
    public class Collaborateur
    {
        /// <summary>
        /// Dictionnaire des contrats associ� au collaborateur
        /// </summary>
        private SortedDictionary<Int32, Contrat> lesContrats;
        /// <summary>
        /// Dictionnaire de contrat bas� sur la date de Contrat afin de r�cup�rer le premier contrat(initial)
        /// </summary>
        private SortedDictionary<DateTime, Contrat> lesContratsTriDate;
        /// <summary>
        /// nom du collaborateur
        /// </summary>
        private String nomCollaborateur;
        /// <summary>
        /// pr�nom du collaborateur
        /// </summary>
        private String prenomCollaborateur;
        /// <summary>
        /// rue du collaborateur
        /// </summary>
        private String rueCollab;
        /// <summary>
        /// ville du collaborateur
        /// </summary>
        private String villeCollab;
        /// <summary>
        /// code postal de la ville du collaborateur
        /// </summary>
        private String cpCollab;
        /// <summary>
        /// matricule du collaborateur(ref)
        /// </summary>
        private Int32 matricule;
        /// <summary>
        /// Situation maritale du collaborateur
        /// </summary>
        private String situationMaritale;
        /// <summary>
        /// Etat civil du collaborateur
        /// </summary>
        private String civilite;
        /// <summary>
        /// Num�ro de t�l�phone du collaborateur
        /// </summary>
        private String telephone;
        /// <summary>
        /// Etat d'archivage du collaborateur
        /// </summary>
        private Boolean archive;
        /// <summary>
        /// Constructeur pour les collaborateur
        /// </summary>
        /// <param name="unNom">le nom du collaborateur</param>
        /// <param name="unPrenom">le prenom du collaborateur</param>
        /// <param name="unMatricule">le matricule du collaborateur</param>
        public Collaborateur(Int32 unMatricule,String uneCivilite,String situation, String unNom, String unPrenom, String uneRue, String uneVille, String unCP,String unTel,Boolean estArchive)
        {
            Archive = estArchive;
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
        /// <summary>
        /// M�thode surchage de la m�thode toString permettant de formatter la sortie
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            return "collaborateur matricule: " + this.Matricule + " nom: " + this.NomCollaborateur + " prenom: " + this.PrenomCollaborateur + " � l'adresse: " + this.RueCollab + " " + this.CpCollab + " " + this.VilleCollab;
        }




        /// <summary>
        /// M�thode d'ajout de contrat au dictionnaire du collaborateur
        /// </summary>
        /// <param name="unContrat"></param>
        public void ajoutContrat(Contrat unContrat)
        {
            if(!LesContrats.ContainsKey(unContrat.NumContrat))
            {
                LesContrats.Add(unContrat.NumContrat, unContrat);
            }
            else
            {
                throw new Exception("Le collaborateur " + this.nomCollaborateur + " poss�de d�ja le contrat: " + unContrat.NumContrat);
            }
   }



        /// <summary>
        /// M�thode de suppression de contrat du dictionnaire
        /// </summary>
        /// <param name="oldContrat"></param>
        public void supprimeContrat(Contrat oldContrat)
        {
            if (oldContrat == null)
                throw new Exception("le contrat entr� n'existe pas");
            if (LesContrats.ContainsKey(oldContrat.NumContrat))

                LesContrats.Remove(oldContrat.NumContrat);
        }

        /// <summary>
        /// m�thode de vidage du dictionnaire
        /// </summary>
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

        public bool Archive { get => archive; set => archive = value; }
    }
}
