using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABIenCouche
{
    class ctrlNouveauContrat
    {
        /// <summary>
        /// ref au form nouveau collaborateur appelant ce controleur
        /// </summary>
        private frmNouveauCollab formNouveauCollab;
        /// <summary>
        /// ref au collaborateur à qui ajouter le collaborateur
        /// </summary>
        private Collaborateur leCollaborateur;
        /// <summary>
        /// ref au contrat de base
        /// </summary>
        private Contrat leContrat;
        /// <summary>
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
            }

            
        }

        //public Boolean controleContrat()
        //{
        //    if (formContratCDI.tBxAgence.Visible)
        //    {
        //        if (formContratCDI.tBxAgence.Text!="")
        //        {

        //        }
        //    }
        //}
    }
}
