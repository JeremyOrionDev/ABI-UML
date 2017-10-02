using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ClassesDAO;


namespace ABIenCouche
{
    /// <summary>
    /// Classe du contrôleur de création de contrat
    /// </summary>
    class ctrlNouveauContrat
    {

        /// <summary>
        /// ref au collaborateur à qui ajouter le collaborateur
        /// </summary>
        private Collaborateur leCollaborateur;
        /// <summary>
        /// variable Booléen de controle valide pour la réponse au controleur appelant
        /// </summary>
        internal Boolean contratOK=false;
        /// <summary>
        /// ref au form de création de contrat
        /// </summary>
        private frmContrat formContrat;
 
        /// <summary>
        /// Constructeur du controleur prenant en paramètre un objet collaborateur pour instancier le contrat
        /// </summary>
        /// <param name="unCollaborateur">Le collaborateur utilisé à qui sera associé le contrat</param>
        public ctrlNouveauContrat(Collaborateur unCollaborateur )
        {

            this.leCollaborateur = unCollaborateur;
            formContrat = new frmContrat();
            formContrat.cBxTypeContrat.Items.AddRange(new String[]{"STAGE","CDD","INTERIM","CDI"});
            formContrat.panelAgence.Enabled = false;
            formContrat.txBxNumeroContrat.Enabled = false;
            formContrat.panelAgence.Visible = false;
            formContrat.panelEcole.Visible = false;
            formContrat.panelAvenant.Visible = false;
            formContrat.panelDate.Visible = false;
            formContrat.panelEcole.Visible = false;
            formContrat.panelMotif.Visible = false;
            formContrat.panelSalaire.Visible = false;
            formContrat.panelLibelle.Visible = false;
            formContrat.panelCadre.Visible = false;
            formContrat.panelFonction.Visible = false;
            formContrat.panelQualification.Visible = false;
            formContrat.panelDebut.Visible = false;
            formContrat.txBxNumeroContrat.Visible = true;
            if (leCollaborateur.LesContrats.Count == 0)
            {
                formContrat.txBxNumeroContrat.Text = "1";
            }
            else formContrat.txBxNumeroContrat.Text = ((leCollaborateur.LesContrats.Count) + 1).ToString();
            formContrat.cBxTypeContrat.SelectedValueChanged += new EventHandler(cBxTypeContrat_SelectedIndexChanged);
                formContrat.btnValiderContrat.Click += new EventHandler(btnValiderContrat_click);
            formContrat.btnAnnuler.Click += new EventHandler(btnAnnucler_Click);
            formContrat.ShowDialog();

        }

        public frmContrat frmContrat
        {
            get => default(frmContrat);
            set
            {
            }
        }

        /// <summary>
        /// fonction appelée au clic sur le bouton annuler
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnucler_Click(object sender, EventArgs e)
        {
            formContrat.Close();
        }
        /// <summary>
        /// fonction de modification du form en fonction du type de contrat choisi
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cBxTypeContrat_SelectedIndexChanged(object sender,EventArgs e)
        {
                Collaborateur unColab = DictionnaireCollaborateur.retrouverCollaborateur(leCollaborateur.Matricule);
                if (unColab.LesContrats!=null)
                {
                if (unColab.LesContrats.Count != 0)
                {
                    formContrat.panelAvenant.Visible = true;
                }
                }
                else formContrat.panelAvenant.Visible = false;
            if (formContrat.cBxTypeContrat.SelectedItem.ToString() == "CDI")
            {
                
                formContrat.panelAgence.Visible = false;
                formContrat.panelDate.Visible = false;
                formContrat.panelEcole.Visible = false;
                formContrat.panelMotif.Visible = true;
                formContrat.panelSalaire.Visible = true;
                formContrat.panelLibelle.Visible = true;
                formContrat.panelCadre.Visible = true;
                formContrat.panelFonction.Visible = true;
                formContrat.panelQualification.Visible = true;
                formContrat.panelDebut.Visible = true;

            }
            else if (formContrat.cBxTypeContrat.SelectedItem.ToString() == "CDD")
            {

                formContrat.panelDate.Visible = true;
                formContrat.panelAgence.Visible = false;
                formContrat.panelEcole.Visible = false;
                formContrat.panelDate.Visible = true;
                formContrat.panelMotif.Visible = true;
                formContrat.panelSalaire.Visible = true;
                formContrat.panelLibelle.Visible = true;
                formContrat.panelCadre.Visible = true;
                formContrat.panelFonction.Visible = true;
                formContrat.panelQualification.Visible = true;
                formContrat.panelDebut.Visible = true;

                
            }
            else if (formContrat.cBxTypeContrat.SelectedItem.ToString() == "STAGE")
            {

                formContrat.panelAgence.Visible = false;
                formContrat.panelEcole.Visible = true;
                formContrat.panelDate.Visible = true;
                formContrat.panelMotif.Visible = true;
                formContrat.panelSalaire.Visible = false;
                formContrat.panelLibelle.Visible = true;
                formContrat.panelCadre.Visible = true;
                formContrat.panelFonction.Visible = true;
                formContrat.panelQualification.Visible = true;
                formContrat.panelDebut.Visible = true;
            }
            else if(formContrat.cBxTypeContrat.SelectedItem.ToString()=="INTERIM")
            {
                formContrat.panelAgence.Visible = true;
                formContrat.panelAgence.Enabled = false;
                formContrat.panelEcole.Visible = false;
                formContrat.panelDate.Visible = true;
                formContrat.panelMotif.Visible = true;
                formContrat.panelSalaire.Visible = true;
                formContrat.panelLibelle.Visible = true;
                formContrat.panelCadre.Visible = true;
                formContrat.panelFonction.Visible = true;
                formContrat.panelQualification.Visible = true;
                formContrat.panelDebut.Visible = true;
            }
        }
        /// <summary>
        /// Méthode de contrôle des champs de saisie, appelée lors de la validation du form
        /// </summary>
        /// <param name="leForm">ref au form a contrôler</param>
        /// <returns></returns>
        private Boolean Controle(frmContrat leForm)
        {
            Boolean test = true;
            if (leForm.tBxEcole.Text == "" && leForm.panelEcole.Visible == true)
            {
                test = false;
                leForm.errorProviderContrat.SetError(leForm.tBxEcole, "Veuillez entrer l'école du stagiaire");
            }
            if (leForm.tBxFonctionContrat.Text == "")
            {
                test = false;
                leForm.errorProviderContrat.SetError(leForm.tBxFonctionContrat, "Veuillez entrer la fonction du collaborateur");
            }
            if (leForm.tBxAgence.Text == "" && leForm.panelAgence.Visible == true)
            {
                test = false;
                leForm.errorProviderContrat.SetError(leForm.tBxAgence, "Veuillez entrer l'agence interim du collaborateur interimaire");
            }
            if (leForm.tBxSalaire.Text == "" && leForm.panelSalaire.Visible == true)
            {
                test = false;
                leForm.errorProviderContrat.SetError(leForm.tBxSalaire, "Veuillez entrer le salaire du collaborateur");
            }
            if (leForm.tBxLibelle.Text == "")
            {
                test = false;
                leForm.errorProviderContrat.SetError(leForm.tBxLibelle, "Veuillez entrer le libellé du contrat");
            }
            if (leForm.tBxMotifContrat.Text == "")
            {
                test = false;
                leForm.errorProviderContrat.SetError(leForm.tBxMotifContrat, "Veuillez entrer le motif du contrat temporaire");
            }
            if (leForm.tBxQualification.Text == "")
            {
                test = false;
                leForm.errorProviderContrat.SetError(leForm.tBxQualification, "Veuillez entrer la qualification du collaborateur");
            }
            if (leForm.ChoixDateFinContrat.Text == leForm.choixDateDebutContrat.Text && formContrat.panelDate.Visible == true)
            {
                test = false;
                leForm.errorProviderContrat.SetError(leForm.ChoixDateFinContrat, "Veuillez entrer la date de fin de contrat du contrat temporaire");
            }
            if (test)
            {
                return true;
            }
            else return false;
        }
        /// <summary>
        /// méthode appelée lors de la validation du form, appelle les méthode contrôle du form et instanciation du contrat si valide
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnValiderContrat_click(object sender,EventArgs e)
        {
            if (Controle(formContrat))
            {
                if (Instancie())
                {
                    DonneesDAO.DbContextCollaborateurs.SaveChanges();
                    formContrat.DialogResult = DialogResult.OK;
                    contratOK = true;
                    formContrat.Close();
                }
            }
            
        }
        /// <summary>
        /// méthode d'instanciation du contrat après validation par les contrôles
        /// Ajoute le contrat au collaborateur reçu dans l'appel du form
        /// et enregistre en BDD
        /// </summary>
        /// <returns></returns>
        private bool Instancie()
        {
            try
            {
                Boolean cadre;
                if (formContrat.rbtCadreOui.Checked)
                {
                    cadre = true;
                }
                else cadre = false;

                Collaborateur unCollaborateur = DictionnaireCollaborateur.retrouverCollaborateur(leCollaborateur.Matricule);
                if (formContrat.cBxTypeContrat.SelectedItem.ToString()=="CDD")
                {
                    ContratCDD leCDD = new ContratCDD(formContrat.tBxLibelle.Text, formContrat.ChoixDateFinContrat.Value, formContrat.tBxMotifContrat.Text, Convert.ToInt32( formContrat.txBxNumeroContrat.Text), formContrat.tBxFonctionContrat.Text, formContrat.tBxQualification.Text, cadre, formContrat.choixDateDebutContrat.Value, leCollaborateur.LesContrats.Count);
                    unCollaborateur.ajoutContrat(leCDD);
                    ClassesDAO.ContratCDD leCDDBDD = new ClassesDAO.ContratCDD(leCDD.Libelle, leCDD.DateFinContrat, leCDD.MotifContrat, leCDD.NumContrat, leCDD.FonctionCollaborateur, leCDD.QualificationCollaborateur, leCDD.LeStatut, leCDD.DateDebutContrat, leCDD.IdContrat);
                    DonneesDAO.DbContextCollaborateurs.ContratsSet.Add(leCDDBDD);
                    DonneesDAO.DbContextCollaborateurs.SaveChanges();
                }
                else if (formContrat.cBxTypeContrat.SelectedItem.ToString()=="CDI")
                {
                    ContratCDI leCDI = new ContratCDI(formContrat.tBxLibelle.Text, Convert.ToDouble(formContrat.tBxSalaire.Text), Convert.ToInt32(formContrat.txBxNumeroContrat.Text), formContrat.tBxFonctionContrat.Text, formContrat.tBxQualification.Text, cadre, formContrat.choixDateDebutContrat.Value,leCollaborateur.LesContrats.Count);
                    unCollaborateur.LesContrats.Add(leCDI.IdContrat,leCDI);
                    ClassesDAO.ContratCDI leCDIBDD = new ClassesDAO.ContratCDI(leCDI.LibelleContrat, leCDI.SalaireBrut, leCDI.NumContrat, leCDI.FonctionCollaborateur, leCDI.QualificationCollaborateur, leCDI.LeStatut, leCDI.DateDebutContrat, leCDI.IdContrat);
                    DonneesDAO.DbContextCollaborateurs.ContratsSet.Add(leCDIBDD);
                    DonneesDAO.DbContextCollaborateurs.SaveChanges();
                }
                else if (formContrat.cBxTypeContrat.SelectedItem.ToString()=="STAGE")
                {
                    ContratStage leStage = new ContratStage(formContrat.tBxEcole.Text, formContrat.tBxMotifContrat.Text, formContrat.ChoixDateFinContrat.Value, formContrat.txBxMissionStage.Text,formContrat.txBxMissionStage.Text,Convert.ToInt32( formContrat.txBxNumeroContrat.Text),formContrat.tBxFonctionContrat.Text,formContrat.tBxQualification.Text,formContrat.tBxLibelle.Text,cadre,formContrat.choixDateDebutContrat.Value,leCollaborateur.LesContrats.Count);
                    unCollaborateur.ajoutContrat(leStage);
                    ClassesDAO.ContratStage leStageBDD = new ClassesDAO.ContratStage(leStage.Ecole, leStage.Motif, leStage.DateDeFin, leStage.UneMission, leStage.UnMaitre, leStage.NumContrat, leStage.FonctionCollaborateur, leStage.QualificationCollaborateur, leStage.LibelleContrat, leStage.LeStatut, leStage.DateDebutContrat, leStage.IdContrat);
                    DonneesDAO.DbContextCollaborateurs.ContratsSet.Add(leStageBDD);
                    DonneesDAO.DbContextCollaborateurs.SaveChanges();
                }
                else if (formContrat.cBxTypeContrat.SelectedItem.ToString()=="INTERIM")
                {
                    contratInterim leContratInterim = new contratInterim(formContrat.tBxAgence.Text, formContrat.tBxMotifContrat.Text, Convert.ToDouble(formContrat.tBxSalaire.Text), formContrat.ChoixDateFinContrat.Value, Convert.ToInt32(formContrat.txBxNumeroContrat.Text), formContrat.tBxFonctionContrat.Text, formContrat.tBxQualification.Text, formContrat.tBxLibelle.Text, cadre, formContrat.choixDateDebutContrat.Value, leCollaborateur.LesContrats.Count);
                    unCollaborateur.ajoutContrat(leContratInterim);
                    ClassesDAO.ContratInterim lInterimBDD = new ContratInterim(leContratInterim.Agence, leContratInterim.MotifContrat, leContratInterim.Salaire,leContratInterim.LaDateFin, leContratInterim.NumContrat, leContratInterim.FonctionCollaborateur, leContratInterim.QualificationCollaborateur, leContratInterim.LibelleContrat, leContratInterim.LeStatut, leContratInterim.DateDebutContrat, leContratInterim.IdContrat);
                    DonneesDAO.DbContextCollaborateurs.ContratsSet.Add(lInterimBDD);
                    DonneesDAO.DbContextCollaborateurs.SaveChanges();
                }
               
                return true;
            }
            catch (Exception)
            {

                throw new Exception("erreur");
            }
        }
    }
}
