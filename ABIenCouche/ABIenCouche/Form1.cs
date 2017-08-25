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

        public frmDspCollaborateur()
        {
            InitializeComponent();
            this.leCol = new Collaborateur(1, "nom", "prenom", "la rue", "la ville", "12345");
            this.leContrat = new Contrat(1, 1, 1000, "CDI", 12/2/12); 
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
