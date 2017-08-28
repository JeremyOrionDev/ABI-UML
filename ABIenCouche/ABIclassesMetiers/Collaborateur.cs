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
        private String nomCollaborateur;
        private String prenomCollaborateur;
        private String rueCollab;
        private String villeCollab;
        private String cpCollab;
        private Int32 matricule;
        private object photo;
        private String situationMaritale;

        public SortedDictionary<Int32,Contrat> lstContrat;
        public SortedDictionary<Int32, Collaborateur> lesColab;
        /// <summary>
        /// Constructeur pour les collaborateur
        /// </summary>
        /// <param name="unNom">le nom du collaborateur</param>
        /// <param name="unPrenom">le prenom du collaborateur</param>
        /// <param name="unMatricule">le matricule du collaborateur</param>
        public Collaborateur(Int32 unMatricule, String unNom, String unPrenom, String uneRue, String uneVille, String unCP)
        {
            this.NomCollaborateur = unNom;
            this.PrenomCollaborateur = unPrenom;
            this.Matricule = unMatricule;
            this.rueCollab = uneRue;
            this.villeCollab = uneVille;
            this.cpCollab = unCP;
            lstContrat = new SortedDictionary<Int32, Contrat>();
        }

        public override String ToString()
        {
            return "collaborateur matricule: " + this.Matricule + " nom: " + this.NomCollaborateur + " prenom: " + this.PrenomCollaborateur + " à l'adresse: " + this.RueCollab + " " + this.CpCollab + " " + this.VilleCollab;
        }




        /// <pdGenerated>default setter</pdGenerated>
        public void ajoutContrat(Contrat unContrat)
        {
            if(!lstContrat.ContainsKey(unContrat.NumContrat))
            {
                lstContrat.Add(unContrat.NumContrat, unContrat);
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
            if (lstContrat.ContainsKey(oldContrat.NumContrat))
                
                    lstContrat.Remove(oldContrat.NumContrat);
        }

        /// <pdGenerated>default removeAll</pdGenerated>
        public void RemoveAllContrat()
        {
            if (lstContrat.Count != 0)
                lstContrat.Clear();
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

        public DataTable ListCollab()
        {
            DataTable dt = new DataTable();
            DataRow DR;
            dt.Columns.Add(new DataColumn("Matricule", typeof(Int32)));
            dt.Columns.Add(new DataColumn("Nom", typeof(String)));
            dt.Columns.Add(new DataColumn("Prénom", typeof(String)));
            dt.Columns.Add(new DataColumn("Adresse", typeof(String)));

            foreach(KeyValuePair<Int32,Collaborateur> colab in lesColab)
            {
                DR = dt.NewRow();
                DR[0]=lesColab.Values.
            }
        }
    }
}
