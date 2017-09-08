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
        internal Collaborateur uncolab;
        internal String resultatForm;
        private Boolean resultat = false;
        public Collaborateur LeColab
        {
            get
            {
                return uncolab;
            }
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
            leForm.txtBoxMatriculeCollab.Enabled = false;
            leForm.panelAffichagePhoto.Visible = true;
            leForm.panelPhoto.Visible = true;
            leForm.btnContrats.Visible = false;
            leForm.btnModifier.Visible = false;
            leForm.panelAugmentation.Visible = false;
            leForm.cBxSituation.Items.AddRange(new String[]
   {"Célibataire","Marié","Divorcé"});
            leForm.cBxSituation.Text = "cliquez-moi";
            leForm.cBxTypeContratColab.Items.AddRange(new String[]
               {"stage","cdd","interim","CDI"});
            leForm.cBxTypeContratColab.Text = "cliquez-moi";
            leForm.cBxCivilite.Items.AddRange(new String[]
    {"Mr","Mme","Mlle"});
            leForm.cBxCivilite.Text = "cliquez-moi";
            this.leForm.Text = "Ajouter un collaborateur au projet en cours";
            this.leForm.btnOKColab.Click += new EventHandler(this.btnOK_Click);
            this.leForm.btnAnnulerColab.Click += new EventHandler(this.btnAnnuler_Click);
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
                    using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open), new UTF8Encoding()));
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

        internal Boolean Controle(frmNouveauCollab unForm)
        {


            String erreur="";
            Int32 i = 0;
            if (!(Outils.CPControl(leForm.txtBxCP.Text)))
            {
                i++;
                leForm.warningCP.Visible = true;
                erreur += "\t\u2022 Le code postal n'est pas un entier de 5 caractères \r";
            }
            if (leForm.cBxSituation.SelectedItem==null)
            {
                i++;
                leForm.warningSituation.Visible = true;
                erreur += "\t\u2022 La situation maritale n'a pas été sélectionnée \r";
            }
            if (!(Outils.controlTel(leForm.tBxTel.Text.ToString())))
            {
                i++;
                erreur += "\t\u2022 La valeur du telephone n'est pas un nombre composé de 10 chiffres \r";
                leForm.warningTel.Visible = true;
            }
            if (leForm.cBxCivilite.SelectedText==null)
            {
                i++;
                erreur += "\t\u2022 La civilité du collaborateur enregistré n'à pas été sélectionnée\r";
                leForm.warningCivilite.Visible = true;
            }
            if (leForm.txtBoxPrenomCollab.Text=="")
            {
                i++;
                erreur += "\t\u2022 Le prénom du collaborateur n'a pas été renseigné \r";
                leForm.warningPrenom.Visible = true;
            }
            if (leForm.txtBoxNomCollab.Text == "")
            {
                i++;
                erreur += "\t\u2022 Le nom du collaborateur enregistré n'à pas été entré\r";
                leForm.warningNom.Visible = true;
            }
            if (leForm.txtBoxRueCollab.Text=="")
            {
                i++;
                erreur += "\t\u2022 La rue du collaborateur n'a pas été renseigné\r";
                leForm.warningRue.Visible = true; 
            }
            if (leForm.txtBxVille.Text=="")
            {
                i++;
                erreur += "\t\u2022 La ville n'a pas été renseignée";
                leForm.warningVille.Visible = true;
            }
            if (i != 0)
            {
                 MessageBox.Show("nombre d'erreurs: " + i + "\r" + erreur, "Erreurs dans le formulaire", MessageBoxButtons.RetryCancel);
                return false;
            }
            else return true;
        }
        internal Boolean Instancie(Collaborateur uncolab)
        {

            
            try
            {

                 this.uncolab = new Collaborateur(Convert.ToInt32(leForm.txtBoxMatriculeCollab.Text),leForm.cBxCivilite.SelectedItem.ToString(),leForm.cBxSituation.SelectedItem.ToString(), leForm.txtBoxNomCollab.Text, leForm.txtBoxPrenomCollab.Text, leForm.txtBoxRueCollab.Text,
                     leForm.txtBxVille.Text, leForm.txtBxCP.Text, 0, leForm.tBxTel.Text, "") ;
                DictionnaireCollaborateur.Ajouter(this.uncolab);

                return true;
            }
            catch (Exception ex)
            {
                this.uncolab = null;
                MessageBox.Show("Erreur : \n" + ex.Message, "Ajout de stagiaire");
                return false;
            }

        }
        private void btnOK_Click(object sender, EventArgs e)
        {

        
            if (Controle(leForm))
            {
                if (Instancie(uncolab))
                {
                    resultatForm = leForm.cBxTypeContratColab.SelectedItem.ToString();
                    leForm.DialogResult = DialogResult.OK;
                }
                
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

