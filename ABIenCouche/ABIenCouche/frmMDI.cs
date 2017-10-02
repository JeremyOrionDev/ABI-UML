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
    public partial class frmMDI : Form
    {
        //private int childFormNumber = 0;
        private frmDspCollaborateur Affich =new frmDspCollaborateur();
        public frmMDI()
        {
            InitializeComponent();
            this.IsMdiContainer = true;
            
           
        }


        private void OpenFile(object sender, EventArgs e)
        {
            crtlListerCollabo ctrl = new crtlListerCollabo(this);
          
            if (ctrl.DR==DialogResult.OK)
            {
                this.Close();
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void btnAfficheColab_Click(object sender, EventArgs e)
        {
            crtlListerCollabo ctrl = new crtlListerCollabo(this);
            if (ctrl.DR == DialogResult.OK)
            {
                this.Close();
            }
        }
    }
}
