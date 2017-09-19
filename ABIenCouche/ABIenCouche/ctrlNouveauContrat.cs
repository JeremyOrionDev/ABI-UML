using ClassesDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABIenCouche
{
    class ctrlNouveauContrat
    {

        /// <summary>
        /// ref au collaborateur à qui ajouter le collaborateur
        /// </summary>
        private Collaborateur leCollaborateur;
        private frmContratTemporaire formContratTemp;
        internal Boolean contratOK=false;
        /// ref au form de nouveau contrat CDI
        /// </summary>
        private frmContratCDI formContratCDI;

        private frmContrat formContrat;
        /// <summary>
        /// ref au form non CDI
        /// </summary>
        //private frmContratTemporaire formContratTemp;

        public ctrlNouveauContrat(Collaborateur unCollaborateur,String unType)
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
            formContrat.txBxNumeroContrat.Enabled = false;
            if (leCollaborateur.LesContrats.Count == 0)
            {
                formContrat.txBxNumeroContrat.Text = "1";
            }
            else formContrat.txBxNumeroContrat.Text = ((leCollaborateur.LesContrats.Count) + 1).ToString();
            formContrat.cBxTypeContrat.SelectedValueChanged += new EventHandler(cBxTypeContrat_SelectedIndexChanged);
                formContrat.btnValiderContrat.Click += new EventHandler(btnValiderContrat_Click);
            formContrat.ShowDialog();

        }
        private void cBxTypeContrat_SelectedIndexChanged(object sender,EventArgs e)
        {
            if (formContrat.cBxTypeContrat.SelectedItem.ToString() == "CDI")
            {
                formContrat.panelMotif.Visible = true;
                formContrat.panelSalaire.Visible = true;
                formContrat.panelLibelle.Visible = true;
                formContrat.panelCadre.Visible = true;
                formContrat.panelFonction.Visible = true;
                formContrat.panelQualification.Visible = true;
                formContrat.panelDebut.Visible = true;
                formContrat.txBxNumeroContrat.Enabled = false;

            }
            else if (formContrat.cBxTypeContrat.SelectedItem.ToString() == "CDD")
            {

                formContrat.txBxNumeroContrat.Enabled = false;
                formContrat.panelDate.Visible = true;
                
                if (DictionnaireCollaborateur.Exist(leCollaborateur))
                {
                    formContrat.txBxNumeroContrat.Text = (leCollaborateur.LesContrats.Count() + 1).ToString();

                }
                else formContrat.txBxNumeroContrat.Text = "1";
                
            }
            else if (formContrat.cBxTypeContrat.SelectedItem.ToString() == "STAGE")
            {



            }
        }

        private void btnValiderContrat_click(object sender,EventArgs e)
        {
            Boolean test=true;
            if (formContrat.tBxEcole.Text=="" && formContrat.panelEcole.Visible == true)
            {
                test = false;
                formContratTemp.errorProviderContrat.SetError(formContratTemp.tBxEcole, "merci de renseigner le champ");
            }
            if (formContratTemp.tBxFonctionContrat.Text=="")
            {
                test = false;
                formContratTemp.errorProviderContrat.SetError(formContratTemp.tBxFonctionContrat, "merci de renseigner le champ");
            }
            if (formContratTemp.tBxAgence.Text == ""&&formContratTemp.panelAgence.Visible==true)
            {
                test = false;
                formContratTemp.errorProviderContrat.SetError(formContratTemp.tBxAgence, "merci de renseigner le champ");
            }
            if (formContratTemp.tBxSalaire.Text == "" && formContratTemp.panelSalaire.Visible == true)
            {
                test = false;
                formContratTemp.errorProviderContrat.SetError(formContratTemp.tBxSalaire, "merci de renseigner le champ");
            }
            if (formContratTemp.tBxLibelle.Text == "" )
            {
                test = false;
                formContratTemp.errorProviderContrat.SetError(formContratTemp.tBxLibelle, "merci de renseigner le champ");
            }
            if (formContratTemp.tBxMotifContrat.Text == "")
            {
                test = false;
                formContratTemp.errorProviderContrat.SetError(formContratTemp.tBxMotifContrat, "merci de renseigner le champ");
            }
            if (formContratTemp.tBxQualification.Text == "")
            {
                test = false;
                formContratTemp.errorProviderContrat.SetError(formContratTemp.tBxQualification, "merci de renseigner le champ");
            }
            if (formContratTemp.ChoixDateFinContrat.Text == formContratTemp.choixDateDebutContrat.Text&&formContratTemp.panelDate.Visible==true)
            {
                test = false;
                formContratTemp.errorProviderContrat.SetError(formContratTemp.ChoixDateFinContrat, "merci de renseigner le champ");
            }
        }

        private void btnValiderContrat_Click(object sender,EventArgs e)
        {
            Boolean cadre;
            if (formContratCDI.rbtCadreOui.Checked)
            {
                cadre = true;
            } else cadre = false;
            ContratCDI leContrat = new ContratCDI(formContratCDI.tBxLibelle.Text,Convert.ToDouble( formContratCDI.tBxSalaire.Text), Convert.ToInt32( formContratCDI.txBxNumeroContrat.Text), formContratCDI.tBxFonctionContrat.Text, formContratCDI.tBxQualification.Text,cadre, formContratCDI.choixDateDebutContrat.Value);
            leCollaborateur.ajoutContrat(leContrat);
            Collaborateurs unCollaborateur = DonneesDAO.DbContextCollaborateurs.CollaborateursSet.Find(leCollaborateur.Matricule);
            ClassesDAO.ContratCDI leCDI = new ClassesDAO.ContratCDI(leContrat.LibelleContrat, leContrat.SalaireBrut, leContrat.NumContrat, leContrat.FonctionCollaborateur, leContrat.QualificationCollaborateur, leContrat.LeStatut, leContrat.DateDebutContrat);
            unCollaborateur.Contrats.Add(leCDI);
            DonneesDAO.DbContextCollaborateurs.SaveChanges();
            formContratCDI.DialogResult = DialogResult.OK;
            contratOK = true;
            formContratCDI.Close();
        }


    }
}
