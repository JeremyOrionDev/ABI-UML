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
                if (leCollaborateur.lesContrats.Count==0)
                {
                    formContratCDI.txBxNumeroContrat.Text = "1";
                }
                formContratCDI.btnValiderContrat.Click += new EventHandler(btnValiderContrat_Click);
                formContratCDI.ShowDialog();
            }
            else
            {
                frmContratTemporaire formContratTemp = new frmContratTemporaire(unType);
                formContratTemp.txBxNumeroContrat.Enabled = false;
                if (DictionnaireCollaborateur.Exist(unCollaborateur))
                {
                    formContratTemp.txBxNumeroContrat.Text = (leCollaborateur.lesContrats.Count() + 1).ToString();

                }
                else formContratTemp.txBxNumeroContrat.Text = "1";
                formContratTemp.ShowDialog();
            formContratCDI.btnValiderContrat.Click += new EventHandler(btnValiderContrat_Click);
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
