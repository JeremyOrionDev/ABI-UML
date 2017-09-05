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
        private frmContratTemporaire formContratTemp;

        public ctrlNouveauContrat(Collaborateur unCollaborateur,String unType)
        {
            this.leCollaborateur = unCollaborateur;
            if (unType == "CDI")
            {
                formContratCDI = new frmContratCDI();
                formContratCDI.cBxTypeContrat.SelectedItem = "CDI";
                formContratCDI.ShowDialog();
            }
            else
            {
                formContratTemp = new frmContratTemporaire(unType);
                formContratTemp.ShowDialog();
            }

            //formContratCDI.bt
        }

    }
}
