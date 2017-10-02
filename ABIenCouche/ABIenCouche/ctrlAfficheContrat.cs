using ClassesDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABIenCouche
{
    /// <summary>
    /// Classe du controleur d'affichage du contrat
    /// </summary>
    class ctrlAfficheContrat
    {
        /// <summary>
        /// Attribut privé référençant le contrat du collaborateur à afficher
        /// </summary>
        private Contrats leContrat;
        /// <summary>
        /// Attribut privé de la Classe DAO du contrat de type CDD pour accès au attributs du CDD
        /// </summary>
        private ClassesDAO.ContratCDD leCDD;
        /// <summary>
        /// Attribut privé de la ClasseDAO de contrat de type CDI pour accès aux attribut de la classe ContratCDI
        /// </summary>
        private ClassesDAO.ContratCDI leCDI;
        /// <summary>
        /// Attribut privé de type ClasseDAO Contrat interim pour accès aux attribut de cette classe
        /// </summary>
        private ContratInterim lInterim;
        /// <summary>
        /// Attribut privé de type classeDAO contrat stage pour accès aux attributs de cette classe
        /// </summary>
        private ClassesDAO.ContratStage leStage;
        /// <summary>
        /// Attribut privé de type formAfficheContrat pour l'ouverture du form
        /// </summary>
        private frmAfficheContrat leForm;
        private frmAvenant nouvelAvenant;
        /// <summary>
        /// Méthode privé appellée au clic sur le bouton valider
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValider_Click(object sender,EventArgs e)
        {
            leForm.Close();
        }
        /// <summary>
        /// Constructeur de la classe Controleur d'affichage du contrat mettant en forme le formulaire d'affichage du contrat et entrant les données depuis la BDD dans les champs adéquats
        /// </summary>
        /// <param name="unContrat">Contrat à afficher</param>
        public ctrlAfficheContrat(Contrats unContrat)
        {
            leForm = new frmAfficheContrat(unContrat);
            this.leContrat = unContrat;
            leForm.btnValiderContrat.Text = "&Fermer";
            leForm.btnAjoutAvenant.Click += new EventHandler(btnAjoutAvenant_Click);
            leForm.btnAnnuler.Visible = false;
            leForm.cBxTypeContrat.Items.AddRange(new String[] { "CDI", "CDD", "INTERIM","STAGE" });
                leForm.panelAvenant.Visible = true;
            leForm.tBxFonctionContrat.Enabled = false;
            leForm.tBxQualification.Enabled = false;
            leForm.choixDateDebutContrat.Enabled = false;
            leForm.ChoixDateFinContrat.Enabled = false;
            leForm.tBxAgence.Enabled = false;
            leForm.tBxSalaire.Enabled = false;
            leForm.tBxLibelle.Enabled = false;
            leForm.cBxTypeContrat.Enabled = false;
            leForm.tBxEcole.Enabled = false;
            leForm.gBxCadre.Enabled = false;
            leForm.tBxMotifContrat.Enabled = false;
            if (unContrat is ClassesDAO.ContratCDI)
            {
                leCDI = (ClassesDAO.ContratCDI)unContrat;
                leForm.btnValiderContrat.Click += new EventHandler(btnValider_Click);
                leForm.txBxNumeroContrat.Text = leCDI.NumContrat.ToString();
                leForm.cBxTypeContrat.SelectedItem = "CDI";
                if (leCDI.Statut == true)
                {
                    leForm.rbtCadreOui.Checked = true;
                }
                else leForm.rbtCadreNon.Checked = true;
                leForm.panelMotif.Visible = false;
                leForm.panelDate.Visible = false;
                leForm.panelAgence.Visible = false;
                leForm.panelEcole.Visible = false;
                leForm.tBxFonctionContrat.Text = leCDI.Fonction;
                leForm.tBxQualification.Text = leCDI.Qualification;
                leForm.choixDateDebutContrat.Text = leCDI.DateDebut.ToString();
                leForm.tBxSalaire.Text = leCDI.Salaire.ToString();
                leForm.tBxLibelle.Text = leCDI.Libelle;
            }
            else
            {
                if (unContrat is ClassesDAO.ContratCDD)
                {
                    //leForm = new frmAfficheContrat(unContrat);
                    leCDD = (ClassesDAO.ContratCDD)unContrat;
                    leForm.btnValiderContrat.Click += new EventHandler(btnValider_Click);
                    leForm.panelAgence.Visible = false;
                    leForm.panelEcole.Visible = false;
                    leForm.tBxLibelle.Text = leCDD.Libelle;
                    leForm.tBxSalaire.Text = leCDD.Salaire.ToString();
                    leForm.txBxNumeroContrat.Text = leCDD.NumContrat.ToString();
                    leForm.tBxMotifContrat.Text = leCDD.Motif;
                    leForm.cBxTypeContrat.SelectedItem = "CDD";
                    if (leCDD.Statut == true)
                    {
                        leForm.rbtCadreOui.Checked = true;
                    }
                    else leForm.rbtCadreNon.Checked = true;
                    leForm.tBxFonctionContrat.Text = leCDD.Fonction;
                    leForm.tBxQualification.Text = leCDD.Qualification;
                    leForm.choixDateDebutContrat.Value= leCDD.DateDebut;
                    leForm.ChoixDateFinContrat.Value = leCDD.DateFin;
                    leForm.btnValiderContrat.Text = "Fermer";
                }
                else if (unContrat is ContratInterim)
                {
                    lInterim = (ContratInterim)unContrat;
                    leForm.btnValiderContrat.Click += new EventHandler(btnValider_Click);
                    leForm.txBxNumeroContrat.Text = lInterim.NumContrat.ToString();
                    leForm.tBxMotifContrat.Text = lInterim.Motif;
                    leForm.cBxTypeContrat.SelectedItem = "INTERIM";
                    if (lInterim.Statut == true)
                    {
                        leForm.rbtCadreOui.Checked = true;
                    }
                    else leForm.rbtCadreNon.Checked = true;
                    leForm.panelEcole.Visible = false;
                    leForm.tBxFonctionContrat.Text = lInterim.Fonction;
                    leForm.tBxQualification.Text = lInterim.Qualification;
                    leForm.choixDateDebutContrat.Text = lInterim.DateFin.ToString();
                    leForm.ChoixDateFinContrat.Text = lInterim.DateFin.ToString();
                    leForm.tBxAgence.Text = lInterim.Agence;
                    leForm.tBxSalaire.Text = lInterim.Salaire.ToString();
                    leForm.tBxLibelle.Text = lInterim.Libelle;

                    
                }
                else if (unContrat is ClassesDAO.ContratStage)
                {
                    leStage = (ClassesDAO.ContratStage)unContrat;
                    leForm.panelEcole.Visible = true;
                    leForm.panelAgence.Visible = false;
                    leForm.panelSalaire.Visible = false;
                    leForm.tBxEcole.Text = leStage.Ecole;
                    leForm.tBxFonctionContrat.Text = leStage.Fonction;
                    leForm.tBxQualification.Text = leStage.Qualification;
                    leForm.choixDateDebutContrat.Text = leStage.DateFin.ToString();
                    leForm.ChoixDateFinContrat.Text = leStage.DateFin.ToString();
                    leForm.tBxLibelle.Text = leStage.Libelle;
                    leForm.txBxNumeroContrat.Text = leStage.NumContrat.ToString();
                    leForm.cBxTypeContrat.SelectedItem = "STAGE";
                    leForm.tBxMotifContrat.Text = leStage.Motif;
                    leForm.btnValiderContrat.Click += new EventHandler(btnValider_Click);

                }
                leForm.dgAvenant.DataSource = MCollaborateurDAOEFStatic.ListerAvenant(unContrat);
                leForm.dgAvenant.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                leForm.dgAvenant.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
                leForm.dgAvenant.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
                leForm.dgAvenant.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            //formAfficheColab.dgCollabo.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;

            } 
            leForm.Show();
      
        }
        /// <summary>
        /// Méthode appelée lors de l'ajout d'un avenant au contrat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjoutAvenant_Click(object sender, EventArgs e)
        {
            nouvelAvenant= new frmAvenant(leContrat);
            nouvelAvenant.txBxIdAvenant.Enabled = false;
            nouvelAvenant.btnValiderAvenant.Click += new EventHandler(btnValiderAvenant_click);
            if (leContrat.Avenant.Count != 0)
            {
                nouvelAvenant.txBxIdAvenant.Text = leContrat.Avenant.Count.ToString();
            }
            else nouvelAvenant.txBxIdAvenant.Text = "1";
            if (nouvelAvenant.ShowDialog()==DialogResult.OK)
            {
                ClassesDAO.Avenant lavenant = new Avenant((DonneesDAO.DbContextCollaborateurs.AvenantSet.Count() + 1), nouvelAvenant.dateAvenant.Value, nouvelAvenant.txBxMotifAvenant.Text,Convert.ToInt32( nouvelAvenant.txBxIdAvenant.Text));
                leContrat.Avenant.Add(lavenant);
                DonneesDAO.DbContextCollaborateurs.SaveChanges();
                nouvelAvenant.Close();
                leForm.dgAvenant.DataSource = MCollaborateurDAOEFStatic.ListerAvenant(leContrat);
                leForm.dgAvenant.Refresh();
            }
        }
        /// <summary>
        /// Méthode appelée au clic sur le bouton de validation de l'avenant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValiderAvenant_click(object sender, EventArgs e)
        {
            nouvelAvenant.DialogResult = DialogResult.OK;
        }
    }
}
