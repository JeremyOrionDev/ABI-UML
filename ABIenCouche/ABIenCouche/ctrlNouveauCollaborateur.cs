using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABIenCouche
{
    class ctrlNouveauCollaborateur
    {
        /// <summary>
        /// ref au form d'ajout de collaborateur
        /// </summary>
        private frmNouveauCollab leForm;
        private frmDspCollaborateur laffiche;
        /// <summary>
        /// ref au collaborateur à créer
        /// </summary>
        private Collaborateur leColab;
        private Boolean resultat=false;
        public Collaborateur LeColab
        {
            get
            {
                return leColab;
            }
        }

        public frmDspCollaborateur Laffiche
        {
            get
            {
                return laffiche;
            }

            set
            {
                laffiche = value;
            }
        }

        private void cBxContratSelectedValueChanged(object sender,EventArgs e)
        {
            leForm.cBxTypeContratColab.Enabled = (leForm.cBxContrat.SelectedItem.ToString() == "oui" ? true : false);
        }
        public Boolean Resultat
        {
            get
            {
                return resultat;
            }

            set
            {
                resultat = value;
            }
        }

        public ctrlNouveauCollaborateur()
        {
            this.leForm = new frmNouveauCollab();
            this.leForm.Text = "Ajouter un collaborateur au projet en cours";
            this.leForm.btnOKNvColab.Click += new EventHandler(this.btnOK_Click);
            this.leForm.btnAnnulerNvColab.Click += new EventHandler(this.btnAnnuler_Click);
            leForm.cBxContrat.Items.AddRange(new String[] { "oui", "non" });
            this.leForm.cBxContrat.SelectedValueChanged += new EventHandler(this.cBxContratSelectedValueChanged);
            Int32 numColab;
            numColab = DictionnaireCollaborateur.listCollaborateur.Count;
            leForm.txtBoxMatriculeCollab.Text = (numColab + 1).ToString();
            leForm.ShowDialog();
            //leForm.cBxTypeContratColab.Enabled = leForm.chkBxContrat.Checked ? false : true;
        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.leForm.Close();
        }

        internal Boolean Controle()
        {
            Boolean code = true;
            if (!(Outils.EstEntier( leForm.txtBxCP.Text.ToString())))
            {
                code = false;
                MessageBox.Show("le code postal n'est pas un entier valide", "ERREUR!!", MessageBoxButtons.OK);
            }
            if (!(Outils.EstEntier(leForm.TbxAugmentation.Text.ToString())))
            {
                code = false;
                MessageBox.Show("la valeur de l'augmentation n'est pas un entier valide", "ERREUR!!", MessageBoxButtons.OK);
            }
            if (!(Outils.EstEntier(leForm.tBxTel.Text.ToString())))
            {
                code = false;
                MessageBox.Show("la valeur de l'augmentation n'est pas un entier valide", "ERREUR!!", MessageBoxButtons.OK);
            }
            return code;
        }
        internal Boolean Instancie()
        {
        

            try
            {

                Collaborateur unColab = new Collaborateur(Convert.ToInt32( leForm.txtBoxMatriculeCollab.Text), leForm.cBxCivilite.Text, leForm.txtBoxNomCollab.Text, leForm.txtBoxPrenomCollab.Text, leForm.txtBoxRueCollab.Text, leForm.txtBxVille.Text, leForm.txtBxCP.Text, Convert.ToInt32(leForm.TbxAugmentation.Text), leForm.tBxTel.Text);
                DictionnaireCollaborateur.Ajouter(leColab);
                
                return true;
            }
            catch (Exception ex)
            {
                leColab = null;
                MessageBox.Show("Erreur : \n" + ex.Message, "Ajout de stagiaire");
                return false;
            }

        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            
            Collaborateur unColab = new Collaborateur(Convert.ToInt32(leForm.txtBoxMatriculeCollab.Text), leForm.cBxCivilite.Text, leForm.txtBoxNomCollab.Text, leForm.txtBoxPrenomCollab.Text, leForm.txtBoxRueCollab.Text, leForm.txtBxVille.Text, leForm.txtBxCP.Text, Convert.ToInt32(leForm.TbxAugmentation.Text), leForm.tBxTel.Text);
            DictionnaireCollaborateur.Ajouter(unColab);
            this.resultat = true;
            leForm.DialogResult = DialogResult.OK;

            if (leForm.cBxTypeContratColab.SelectedItem.ToString() == "CDI")
            {
                frmContratCDI leCdi = new frmContratCDI();
                leCdi.ShowDialog();
            }
            else 
            {
                frmContratTemporaire leTemporaire = new frmContratTemporaire(leForm.cBxTypeContratColab.Text);
                leTemporaire.ShowDialog();
            }
            
            //frmContratCDI leCDI = new frmContratCDI();
            //frmContratTemporaire contratTemp = new frmContratTemporaire();
            //if (leForm.cBxTypeContratColab.Text == "CDI")
            //{

            //    leCDI.ShowDialog();
            //}
            //else
            //{
            //    contratTemp.ShowDialog();
            //}
            //if (leCDI.DialogResult==DialogResult.OK)
            //{
            //    DictionnaireCollaborateur.Ajouter(leColab);

            //}


        }
    }
}
