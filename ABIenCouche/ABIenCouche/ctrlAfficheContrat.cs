﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABIenCouche
{
    class ctrlAfficheContrat
    {
        private Contrat leContrat;
        private ContratCDD leCDD;
        private ContratCDI leCDI;
        private contratInterim lInterim;
        private frmAfficheContrat leForm;

        private void btnValider_Click(object sender,EventArgs e)
        {
            leForm.Close();
        }
        public ctrlAfficheContrat(Contrat unContrat)
        {
            this.leContrat = unContrat;
            
            if (unContrat is ContratCDI)
            {
                leCDI = (ContratCDI)unContrat;
                leForm.btnValiderContrat.Click += new EventHandler(btnValider_Click);
                leForm.txBxNumeroContrat.Text = leCDI.NumContrat.ToString();
                leForm.cBxTypeContrat.SelectedItem = "CDI";
                if (leCDI.LeStatut == true)
                {
                    leForm.rbtCadreOui.Checked = true;
                }
                else leForm.rbtCadreNon.Checked = true;
                leForm.panelMotif.Visible = false;
                leForm.panelDate.Visible = false;
                leForm.panelAgence.Visible = false;
                leForm.panelEcole.Visible = false;
                leForm.tBxFonctionContrat.Text = leCDI.FonctionCollaborateur;
                leForm.tBxQualification.Text = leCDI.QualificationCollaborateur;
                leForm.choixDateDebutContrat.Text = leCDI.DateDebutContrat.ToString();
                leForm.pictureBoxPhotoContrat.ImageLocation = leCDI.LaPhoto;
                leForm.tBxSalaire.Text = leCDI.SalaireBrut.ToString();
            }
            else
            {
                if (unContrat is ContratCDD)
                {
                    leForm = new frmAfficheContrat(unContrat);
                    leForm.btnValiderContrat.Click += new EventHandler(btnValider_Click);
                    leForm.panelAgence.Visible = false;
                    leForm.panelEcole.Visible = false;
                    leCDD = (ContratCDD)unContrat;
                    leForm.txBxNumeroContrat.Text = leCDD.NumContrat.ToString();
                    leForm.tBxMotifContrat.Text = leCDD.MotifContrat;
                    leForm.cBxTypeContrat.SelectedItem = "CDD";
                    if (leCDD.LeStatut == true)
                    {
                        leForm.rbtCadreOui.Checked = true;
                    }
                    else leForm.rbtCadreNon.Checked = true;
                    leForm.tBxFonctionContrat.Text = leCDD.FonctionCollaborateur;
                    leForm.tBxQualification.Text = leCDD.QualificationCollaborateur;                    
                    leForm.choixDateDebutContrat.Value= leCDD.DateDebutContrat;
                    leForm.ChoixDateFinContrat.Value = leCDD.DateFinContrat;
                    leForm.btnAnnuler.Visible = false;
                    leForm.btnValiderContrat.Text = "Fermer";
                }
                else if (unContrat is contratInterim )
                {
                    lInterim = (contratInterim)unContrat;
                    leForm.btnValiderContrat.Click += new EventHandler(btnValider_Click);
                    leForm.txBxNumeroContrat.Text = lInterim.NumContrat.ToString();
                    leForm.tBxMotifContrat.Text = lInterim.MotifContrat;
                    leForm.cBxTypeContrat.SelectedItem = "CDD";
                    if (lInterim.LeStatut == true)
                    {
                        leForm.rbtCadreOui.Checked = true;
                    }
                    else leForm.rbtCadreNon.Checked = true;
                    leForm.panelEcole.Visible = false;
                    leForm.tBxFonctionContrat.Text = lInterim.FonctionCollaborateur;
                    leForm.tBxQualification.Text = lInterim.QualificationCollaborateur;
                    leForm.choixDateDebutContrat.Text = lInterim.DateDebutContrat.ToString();
                    leForm.ChoixDateFinContrat.Text = lInterim.LaDateFin.ToString();

                }
                {

                }
            } 
            leForm.ShowDialog();
      
        }


    }
}