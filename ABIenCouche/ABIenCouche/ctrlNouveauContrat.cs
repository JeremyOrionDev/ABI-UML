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
        /// <summary>
        /// ref au form non CDI
        /// </summary>
        //private frmContratTemporaire formContratTemp;

        public ctrlNouveauContrat(Collaborateur unCollaborateur,String unType)
        {
            this.leCollaborateur = unCollaborateur;
            if (unType == "CDI")
            {
                formContratCDI = new frmContratCDI();
                formContratCDI.cBxTypeContrat.SelectedItem = "CDI";
                formContratCDI.txBxNumeroContrat.Enabled = false;
                formContratCDI.panelAgence.Visible = false;
                formContratCDI.panelEcole.Visible = false;
                formContratCDI.panelDate.Visible = false;
                formContratCDI.panelPhoto.Visible = false;
                if (leCollaborateur.LesContrats.Count==0)
                {
                    formContratCDI.txBxNumeroContrat.Text = "1";
                }
                formContratCDI.btnValiderContrat.Click += new EventHandler(btnValiderContrat_Click);
                formContratCDI.ShowDialog();
            }
            else
            {
                formContratTemp = new frmContratTemporaire(unType);
                formContratTemp.txBxNumeroContrat.Enabled = false;
                formContratTemp.btnAnnuler.Hide();
                if (DictionnaireCollaborateur.Exist(unCollaborateur))
                {
                    formContratTemp.txBxNumeroContrat.Text = (leCollaborateur.LesContrats.Count() + 1).ToString();

                }
                else formContratTemp.txBxNumeroContrat.Text = "1";
                if (unType=="stage")
                {
                    formContratTemp.panelAgence.Visible = false;
                    formContratTemp.panelSalaire.Visible = false;
                    formContratTemp.panelDate.Visible = true;
                }
                formContratTemp.btnValiderContrat.Click += new EventHandler(btnValiderContratTemp_click);
                formContratTemp.ShowDialog();
            }

        }


        private void btnValiderContratTemp_click(object sender,EventArgs e)
        {
            Boolean test=true;
            if (formContratTemp.tBxEcole.Text=="" && formContratTemp.panelEcole.Visible == true)
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
            ContratCDI leContrat = new ContratCDI(formContratCDI.tBxLibelle.Text,Convert.ToDouble( formContratCDI.tBxSalaire.Text), formContratCDI.txtBxAdressePhotoContrat.Text,Convert.ToInt32( formContratCDI.txBxNumeroContrat.Text), formContratCDI.tBxFonctionContrat.Text, formContratCDI.tBxQualification.Text,cadre, formContratCDI.choixDateDebutContrat.Value);
            leCollaborateur.ajoutContrat(leContrat);
            formContratCDI.DialogResult = DialogResult.OK;
            contratOK = true;
            formContratCDI.Close();
        }


    }
}
