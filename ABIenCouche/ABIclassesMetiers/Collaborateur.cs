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
using System.Runtime.Serialization;

namespace ABIenCouche
{
    /// <summary>
    /// Classe publique de Collaborateur
    /// </summary>
    [Serializable]
    [DataContract]
    public class Collaborateur
    {
        /// <summary>
        /// Dictionnaire des contrats associé au collaborateur
        /// </summary>
        private SortedDictionary<Int32, Contrat> lesContrats;
        /// <summary>
        /// Dictionnaire de contrat basé sur la date de Contrat afin de récupérer le premier contrat(initial)
        /// </summary>
        private SortedDictionary<DateTime, Contrat> lesContratsTriDate;
        /// <summary>
        /// nom du collaborateur
        /// </summary>
        private String nomCollaborateur;
        /// <summary>
        /// prénom du collaborateur
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
        /// Numéro de téléphone du collaborateur
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
        /// Méthode surchage de la méthode toString permettant de formatter la sortie
        /// </summary>
        /// <returns></returns>
        public override String ToString()
        {
            return "collaborateur matricule: " + this.Matricule + " nom: " + this.NomCollaborateur + " prenom: " + this.PrenomCollaborateur + " à l'adresse: " + this.RueCollab + " " + this.CpCollab + " " + this.VilleCollab;
        }




        /// <summary>
        /// Méthode d'ajout de contrat au dictionnaire du collaborateur
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
                throw new Exception("Le collaborateur " + this.nomCollaborateur + " possède déja le contrat: " + unContrat.NumContrat);
            }
   }



        /// <summary>
        /// Méthode de suppression de contrat du dictionnaire
        /// </summary>
        /// <param name="oldContrat"></param>
        public void supprimeContrat(Contrat oldContrat)
        {
            if (oldContrat == null)
                throw new Exception("le contrat entré n'existe pas");
            if (LesContrats.ContainsKey(oldContrat.NumContrat))

                LesContrats.Remove(oldContrat.NumContrat);
        }

        /// <summary>
        /// méthode de vidage du dictionnaire
        /// </summary>
        public void RemoveAllContrat()
        {
            if (LesContrats.Count != 0)
                LesContrats.Clear();
        }

        [DataMember]
        public string NomCollaborateur
        {
            get
            {
                return nomCollaborateur;
            }
            private set
            {
                if (this.nomCollaborateur != value)
                    this.nomCollaborateur = value;
            }
        }
        [DataMember]
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
        [DataMember]
        public int Matricule
        {
            get
            {
                return matricule;
            }
            private set
            {
                if (this.matricule != value)
                    this.matricule = value;
            }
        }


        [DataMember]
        public String SituationMaritale
        {
            get
            {
                return situationMaritale;
            }
            private set
            {
                if (this.situationMaritale != value)
                    this.situationMaritale = value;
            }
        }
        [DataMember]
        public string RueCollab
        {
            get
            {
                return rueCollab;
            }
            private set
            {
                rueCollab = value;
            }
        }
        [DataMember]
        public string VilleCollab
        {
            get
            {
                return villeCollab;
            }
            private set
            {
                villeCollab = value;
            }
        }
        [DataMember]
        public string CpCollab
        {
            get
            {
                return cpCollab;
            }
            private set
            {
                cpCollab = value;
            }
        }

        [DataMember]
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
        [DataMember]
        public string Telephone
        {
            get
            {
                return telephone;
            }
            private set
            {
                telephone = value;
            }
        }

        [DataMember]
        public SortedDictionary<int, Contrat> LesContrats
        {
            get
            {
                return lesContrats;
            }
            private set
            {
                lesContrats = value;
            }
            
        }
        [DataMember]
        public SortedDictionary<DateTime, Contrat> LesContratsTriDate
        {
            get
            {
                return lesContratsTriDate;
            }
            private set
            {
                lesContratsTriDate = value;
            }
        }
        [DataMember]
        public bool Archive { get => archive;private set => archive = value; }
    }
}
