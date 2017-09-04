using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
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

        /// <summary>
        /// ref au collaborateur à créer
        /// </summary>
        private Collaborateur leColab;
        private Boolean resultat = false;
        public Collaborateur LeColab
        {
            get
            {
                return leColab;
            }
        }



        private void cBxContratSelectedValueChanged(object sender, EventArgs e)
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
            leForm.cBxTypeContratColab.Items.AddRange(new String[]
               {"stage","cdd","interim","CDI"});
            leForm.cBxCivilite.Items.AddRange(new String[]
    {"Mr","Mme","Mlle"});
            this.leForm.Text = "Ajouter un collaborateur au projet en cours";
            this.leForm.btnOKNvColab.Click += new EventHandler(this.btnOK_Click);
            this.leForm.btnAnnulerNvColab.Click += new EventHandler(this.btnAnnuler_Click);
            leForm.cBxContrat.Items.AddRange(new String[] { "oui", "non" });
            this.leForm.cBxContrat.SelectedValueChanged += new EventHandler(this.cBxContratSelectedValueChanged);
            this.leForm.btnParcourircollab.Click += new EventHandler(btnParcourirCollab_Click);
            Int32 numColab;
            leForm.btnModifierPhoto.Visible = false;
            numColab = DictionnaireCollaborateur.nbCollab();
            leForm.txtBoxMatriculeCollab.Text = (numColab + 1).ToString();
            leForm.ShowDialog();
            //leForm.cBxTypeContratColab.Enabled = leForm.chkBxContrat.Checked ? false : true;
        }
        String path;
        private void btnParcourirCollab_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openPhoto = new OpenFileDialog();
                openPhoto.Filter = "Images files jpeg | *.jpg";
                openPhoto.Multiselect = false;
                if (openPhoto.ShowDialog() == DialogResult.OK)
                {
                    path = openPhoto.FileName;
                    leForm.txtBxAdressePhoto.Enabled = false;
                    leForm.txtBxAdressePhoto.Text = path;
                    FileStream fs = new FileStream(@path, FileMode.Open);
                    leForm.pictureBoxPhotoCollab.Image = Image.FromStream(fs);
                    fs.Close();
                    using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open), new UTF8Encoding())) ;
                }
            }
            catch (Exception)
            {

                throw new Exception(" erreur rencontrée:" + e);
            }

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.leForm.Close();
        }

        internal Boolean Controle()
        {
            Boolean code = true;
            if (!(Outils.EstEntier(leForm.txtBxCP.Text.ToString())))
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

                Collaborateur unColab = new Collaborateur(Convert.ToInt32(leForm.txtBoxMatriculeCollab.Text), leForm.cBxCivilite.Text, leForm.txtBoxNomCollab.Text, leForm.txtBoxPrenomCollab.Text, leForm.txtBoxRueCollab.Text, leForm.txtBxVille.Text, leForm.txtBxCP.Text, Convert.ToInt32(leForm.TbxAugmentation.Text), leForm.tBxTel.Text,leForm.txtBxAdressePhoto.Text);
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


            this.resultat = true;
            leForm.DialogResult = DialogResult.OK;

            if (leForm.cBxContrat.SelectedItem.ToString() == "oui")
            {
                frmContratCDI leCdi = new frmContratCDI();
                leCdi.ShowDialog();
            }
            else
            {
                Collaborateur unColab = new Collaborateur(Convert.ToInt32(leForm.txtBoxMatriculeCollab.Text), leForm.cBxCivilite.Text, leForm.txtBoxNomCollab.Text, leForm.txtBoxPrenomCollab.Text, leForm.txtBoxRueCollab.Text, leForm.txtBxVille.Text, leForm.txtBxCP.Text, Convert.ToInt32(leForm.TbxAugmentation.Text), leForm.tBxTel.Text, leForm.txtBxAdressePhoto.Text);
                DictionnaireCollaborateur.Ajouter(unColab);
                leForm.DialogResult = DialogResult.OK;
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

