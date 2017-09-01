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
    public partial class frmNouveauCollab : frmBaseCollab
    {
        public frmNouveauCollab()
        {
            InitializeComponent();
            
        }
        
        private void btnOKNvColab_Click(object sender, EventArgs e)
        {
            frmContratCDI leCDI = new frmContratCDI();
            frmContratTemporaire contratTemp = new frmContratTemporaire();
            if (base.cBxTypeContratColab.Text=="CDI")
            {
                leCDI.ShowDialog();
            }
            else 
            {
                contratTemp.ShowDialog();
            }
    

        }

        private void btnAnnulerNvColab_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
