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
        private frmDspCollaborateur toto;
        private Collaborateur leCollaborateur;
        public frmAfficheCollab(Collaborateur unCollab)
        {
           
            InitializeComponent();
            this.afficheCollabo(unCollab);
            this.txtBoxRueCollab.Enabled = false;
            this.txtBxVille.Enabled = false;
            this.txtBxCP.Enabled = false;
            this.txtBoxMatriculeCollab.Enabled = false;
            this.txtBoxNomCollab.Enabled = false;
            this.txtBoxPrenomCollab.Enabled = false;
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
            this.txtBoxRueCollab.Text = unCollabo.RueCollab;
            this.txtBxCP.Text = unCollabo.CpCollab;
            this.txtBxVille.Text= unCollabo.VilleCollab;

        }

        private void btnModifier_Click(object sender, EventArgs e)
        {
            this.txtBoxRueCollab.Enabled = true;
            this.txtBxVille.Enabled = true;
            this.txtBxCP.Enabled = true;
            //this.txtBoxMatriculeCollab.Enabled = true;
            this.txtBoxNomCollab.Enabled = true;
            this.txtBoxPrenomCollab.Enabled = true;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private Collaborateur enregistreCollabo()
        {
            Collaborateur unCollab = new Collaborateur(Convert.ToInt32( txtBoxMatriculeCollab.Text),txtBoxNomCollab.Text, txtBoxPrenomCollab.Text, txtBoxRueCollab.Text,txtBxVille.Text,txtBxCP.Text);
            return unCollab;
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            Int32 numColab = Convert.ToInt32( txtBoxMatriculeCollab.Text);
            DictionnaireCollaborateur.SupprimerCollab(numColab);
            Collaborateur leColab = enregistreCollabo();
            DictionnaireCollaborateur.listCollaborateur.Add(leColab.Matricule, leColab);
            //afficheCollabo.dgC
           
            this.Close();
        }
    }
}
