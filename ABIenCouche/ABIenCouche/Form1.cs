using ABIenCouche;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABIenCouche
{
    public partial class frmDspCollaborateur : Form
    {
        /// <summary>
        /// Le collaborateur
        /// </summary>
        private Collaborateur leCol;
        private Contrat leContrat;
        DictionnaireCollaborateur.
        public frmDspCollaborateur()
        {
            InitializeComponent();
            this.leCol = new Collaborateur(1, "nom", "prenom", "la rue", "la ville", "12345");
            Contrat unContrat= new Contrat(1,1,1000,"CDI",new DateTime());
            leCol.lstContrat.Add(unContrat.NumContrat, unContrat);
            //this.unContrat = new Contrat(1, 1, 1000 , null, "CDI", null, new DateTime(), null); // valide
            Collaborateur unCollab;
            unCollab = new Collaborateur(1, "nom", "prenom", "244 route de turin", "nice", "06300");
            
        }

        private void afficheCollabo()
        {
            this.dgCollabo.DataSource=
        }
    }
}
