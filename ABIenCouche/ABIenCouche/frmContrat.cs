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
    public partial class frmContrat : Form
    {
        public frmContrat()
        {
            InitializeComponent();
        
            cBxTypeContrat.Items.AddRange(new String[] { "CDI", "CDD", "stage", "interim" });
        }

        private void cBxTypeContrat_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void lblTypeContrat_Click(object sender, EventArgs e)
        {

        }

        private void lblFonctionContrat_Click(object sender, EventArgs e)
        {

        }

        private void tBxFonctionContrat_TextChanged(object sender, EventArgs e)
        {

        }

        private void tBxSalaire_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
