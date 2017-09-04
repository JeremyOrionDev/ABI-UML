using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ABIenCouche
{
    class ctrlAfficheContrat
    {
        private Collaborateur leCollaborateur;
        private Contrat leContrat;
        private ContratCDD leCDD;
        private ContratCDI leCDI;
        private contratInterim lInterim;
        private ContratStage leStage;
        private avenantContrat lAvenant;
        private frmAfficheContrat leForm;
        public ctrlAfficheContrat(Contrat unContrat)
        {
            this.leContrat = unContrat;
            if (unContrat is ContratCDD)
            {
                Int32 numContrat;
                numContrat = unContrat.NumContrat;
                if (leCollaborateur.lesContrats.ContainsKey(numContrat))
                {
                    leCDD = DictionnaireCollaborateur.retrouverContrat(leCollaborateur, numContrat);
                }
                //leCDD = leCollaborateur.lesContrats.Values[numContrat];
            }
            leForm = new frmAfficheContrat(unContrat);
            leForm.tBxFonctionContrat.Text = unContrat.FonctionCollaborateur;
            leForm.tBxMotifContrat.Text=unContrat.mo
            leForm.ShowDialog();
        }
    }
}
