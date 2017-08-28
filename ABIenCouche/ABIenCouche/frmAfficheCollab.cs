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
    public partial class frmAfficheCollab :  frmCollab
    {
        private Collaborateur leCollaborateur;
        public frmAfficheCollab(Collaborateur unCollab)
        {
            InitializeComponent();

        }

        private void frmAfficheCollab_Load(object sender, EventArgs e)
        {
            this.afficheCollabo(this.leCollaborateur);
        }

        internal void afficheCollabo(Collaborateur unCollabo)
        {
           
            this.txtBoxNomCollab.Text = unCollabo.NomCollaborateur;
            this.txtBoxPrenomCollab.Text = unCollabo.PrenomCollaborateur;
            this.txtBoxMatriculeCollab.Text = unCollabo.Matricule.ToString();
            this.txtBoxAdresseCollab.Text = unCollabo.RueCollab + " " + unCollabo.CpCollab + " " + unCollabo.VilleCollab;

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            this.txtBoxAdresseCollab.Enabled = true;
            this.txtBoxMatriculeCollab.Enabled = true;
            this.txtBoxNomCollab.Enabled = true;
            this.txtBoxPrenomCollab.Enabled = true;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmAfficheCollab_Load_1(object sender, EventArgs e)
        {

        }
    }
}
