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
    class ctrlAfficheCollab
    {
        /// <summary>
        /// ref au form d'affichage du collaborateur
        /// </summary>
        private frmAfficheCollab formAffiche;
        /// <summary>
        /// ref au collaborateur à afficher
        /// </summary>
        private Collaborateur leCollaborateur;
        private DialogResult formResult;
        private Boolean Modifier = false;

        internal DialogResult FormResult
        {
            get
            {
                return formResult;
            }

            set
            {
                formResult = value;
            }
        }

        private void dgContrat_DoubleClick(object sender, EventArgs e)
        {
            Contrat leContrat;
            Int32 numContrat;
            Int32 nbContrat = this.leCollaborateur.lesContrats.Count();

            if (formAffiche.dgContrats.RowCount != 0)
            {
                numContrat = Convert.ToInt32(formAffiche.dgContrats.CurrentRow.Cells[0].Value.ToString());
            }
            else numContrat = 0;
            if (leCollaborateur.lesContrats.ContainsKey(numContrat))
            {
                leContrat = leCollaborateur.lesContrats[numContrat];
            }
            else throw new Exception("erreur le contrat demandé n'existe pas");
            if (leContrat is ContratCDD)
            {
                leContrat = (ContratCDD)leContrat;
            }
            else if (leContrat is ContratCDI)
            {
                leContrat = (ContratCDI)leContrat;
            }
            else if (leContrat is contratInterim)
            {
                leContrat = (contratInterim)leContrat;
            }
            else if (leContrat is ContratStage)
            {
                leContrat = (ContratStage)leContrat;
            }
            else throw new ArgumentOutOfRangeException("le contrat n'est pas défini sur un type de contrat précis (stage,interim,CDD ou CDI)");
            ctrlAfficheContrat affichecontrat = new ctrlAfficheContrat(leContrat);
            //MessageBox.Show("test", "test", MessageBoxButtons.OK);
        }
        private void btnContrats_Click(object sender, EventArgs e)
        {
            formAffiche.panelContrat.Visible = true;
            init();


        }
        public ctrlAfficheCollab(Collaborateur unColab)
        {
            this.leCollaborateur = unColab;
            formAffiche = new frmAfficheCollab(leCollaborateur);
            init();
            formAffiche.txtBoxMatriculeCollab.Enabled = false;
            formAffiche.cBxCivilite.Enabled=false;
            formAffiche.txtBoxNomCollab.Enabled=false;
            formAffiche.txtBoxPrenomCollab.Enabled = false;
            formAffiche.txtBoxRueCollab.Enabled = false;
            formAffiche.txtBxVille.Enabled = false;
            formAffiche.txtBxCP.Enabled = false;
            formAffiche.tBxTel.Enabled = false;
            formAffiche.panelAugmentation.Visible=true;
            formAffiche.cBxSituation.Enabled = false;
            formAffiche.panelContrat.Visible = false;
            formAffiche.cBxCivilite.Items.AddRange(new String[] { "Mr", "Mme" });
            formAffiche.cBxSituation.Items.AddRange(new String[] { "célibataire", "marié","divorcé" });
            formAffiche.txtBoxMatriculeCollab.Text = unColab.Matricule.ToString();
            formAffiche.txtBoxNomCollab.Text = unColab.NomCollaborateur;
            formAffiche.txtBoxPrenomCollab.Text = unColab.PrenomCollaborateur;
            formAffiche.txtBoxRueCollab.Text = unColab.RueCollab;
            formAffiche.txtBxVille.Text = unColab.VilleCollab;
            formAffiche.txtBxCP.Text = unColab.CpCollab;
            formAffiche.tBxTel.Text = unColab.Telephone;
            formAffiche.cBxSituation.SelectedItem = unColab.SituationMaritale;
            formAffiche.cBxCivilite.SelectedItem = unColab.Civilite;
            formAffiche.TbxAugmentation.Text = unColab.Augmentation.ToString();
            formAffiche.panelPhoto.Visible = false;
            formAffiche.panelAffichagePhoto.Visible = false;
            formAffiche.panelTypeContrat.Visible = false;
            formAffiche.TbxAugmentation.Enabled = false;
            formAffiche.btnAnnulerColab.Click += new EventHandler(btnAnnuler_Click);
            formAffiche.btnContrats.Click += new EventHandler(this.btnContrats_Click);
            formAffiche.dgContrats.DoubleClick += new EventHandler(dgContrat_DoubleClick);
            formAffiche.btnModifier.Click += new EventHandler(btnModifier_Click);
            formAffiche.btnOKColab.Click += new EventHandler(btnOK_Click);
            formAffiche.btnSupprimerContrat.Click += new EventHandler(btnSupprimer_Click);
            //OpenFileDialog openPhoto = new OpenFileDialog();
            //openPhoto.Filter = "Images files jpeg | *.jpg";
            //openPhoto.Multiselect = false;
            //FileStream fs = new FileStream(leCollaborateur.LaPhoto, FileMode.Open, FileAccess.Read);
            //formAffiche.pictureBoxPhotoCollab.Image = Image.FromStream(fs);
            //fs.Close();
            formAffiche.ShowDialog();
        }

        private void btnSupprimer_Click(object sender, EventArgs e)
        {
            int numContrat = Convert.ToInt32(formAffiche.dgContrats.CurrentRow.Cells[0].Value.ToString());
            Contrat leContrat = Contrat.retrouverContrat(leCollaborateur, numContrat);
            DialogResult DR = MessageBox.Show("Voulez vous supprimer le contrat n°" + leContrat.NumContrat + " du collaborateur: " + leCollaborateur.NomCollaborateur + " " + leCollaborateur.PrenomCollaborateur + " ?", "Suppresion de contrat", MessageBoxButtons.OKCancel);
            if (DR==DialogResult.OK)
            {
                leCollaborateur.supprimeContrat(leContrat);
                init();
            }

        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Modifier)
            {
                String Modif="";
                int i=0;
                if (formAffiche.cBxCivilite.SelectedItem.ToString()!=leCollaborateur.Civilite)
                {
                    i++;
                    Modif += "\t\u2022 la civilité: " + leCollaborateur.Civilite + " deviendra: " + formAffiche.cBxCivilite.Text + "\r";

                }
                if (formAffiche.cBxSituation.SelectedItem.ToString()!=leCollaborateur.SituationMaritale)
                {
                    i++;
                    Modif += "\t\u2022 la situation maritale: " + leCollaborateur.SituationMaritale + " deviendra: " + formAffiche.cBxSituation.Text + "\r";

                }
                if (formAffiche.txtBoxNomCollab.Text!=leCollaborateur.NomCollaborateur)
                {
                    i++;
                    Modif += "\t\u2022 le nom du Collaborateur: " + leCollaborateur.NomCollaborateur + " va être modifié en: " + formAffiche.txtBoxNomCollab.Text + "\r";
                }
                if (formAffiche.txtBoxPrenomCollab.Text != leCollaborateur.PrenomCollaborateur)
                {
                    i++;
                    Modif += "\t\u2022 le prénom du Collaborateur: " + leCollaborateur.PrenomCollaborateur + " va être modifié en: " + formAffiche.txtBoxPrenomCollab.Text + "\r";
                if (formAffiche.tBxTel.Text!=leCollaborateur.Telephone)
                {
                    i++;
                    Modif += "\t\u2022 le téléphone: " + leCollaborateur.Telephone + " deviendra: " + formAffiche.tBxTel.Text+"\r";
                    
                }
                }
                if (formAffiche.txtBoxRueCollab.Text != leCollaborateur.RueCollab)
                {
                    i++;
                    Modif += "\t\u2022 la rue du Collaborateur: " + leCollaborateur.RueCollab + " va être modifié en: " + formAffiche.txtBoxRueCollab.Text + "\r";
                }
                if (formAffiche.txtBxVille.Text != leCollaborateur.VilleCollab)
                {
                    i++;
                    Modif += "\t\u2022 la ville du Collaborateur: " + leCollaborateur.VilleCollab + " va être modifié en: " + formAffiche.txtBxVille.Text + "\r";
                }
                if (formAffiche.txtBxCP.Text != leCollaborateur.CpCollab)
                {
                    i++;
                    Modif += "\t\u2022 le code postal du Collaborateur: " + leCollaborateur.CpCollab + " va être modifié en: " + formAffiche.txtBxCP.Text + "\r";
                }
                if (formAffiche.TbxAugmentation.Text != leCollaborateur.Augmentation.ToString())
                {
                    i++;
                    Modif += "\t\u2022 le Collaborateur va être augmenté de : " + leCollaborateur.Augmentation + " va être modifié en: " + formAffiche.TbxAugmentation.Text + "\r";
                }
                Modif ="Vous avez fait "+i+" modifications: \r"+Modif;
                DialogResult DR = MessageBox.Show(Modif, "Valider les modifications ?", MessageBoxButtons.OKCancel);
                if (DR==DialogResult.OK)
                {
                    leCollaborateur.Telephone = formAffiche.tBxTel.Text;
                    leCollaborateur.Civilite=formAffiche.cBxCivilite.SelectedItem.ToString();
                    leCollaborateur.SituationMaritale=formAffiche.cBxSituation.SelectedItem.ToString();
                    leCollaborateur.NomCollaborateur= formAffiche.txtBoxNomCollab.Text;
                    leCollaborateur.PrenomCollaborateur=formAffiche.txtBoxPrenomCollab.Text;
                    leCollaborateur.RueCollab=formAffiche.txtBoxRueCollab.Text;
                    leCollaborateur.VilleCollab= formAffiche.txtBxVille.Text;
                    leCollaborateur.CpCollab=formAffiche.txtBxCP.Text;

                    //formAffiche.Close();
                }
            }
            formAffiche.DialogResult = DialogResult.OK;
            FormResult = DialogResult.OK;
        }
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            formAffiche.Close();
        }
         private void btnModifier_Click(object sender,EventArgs e)
        {
            Modifier = true;
            formAffiche.cBxCivilite.Enabled = true;
            formAffiche.txtBoxNomCollab.Enabled = true;
            formAffiche.txtBoxPrenomCollab.Enabled = true;
            formAffiche.txtBoxRueCollab.Enabled = true;
            formAffiche.txtBxVille.Enabled = true;
            formAffiche.txtBxCP.Enabled = true;
            formAffiche.tBxTel.Enabled = true;
            formAffiche.cBxSituation.Enabled = true;
            formAffiche.TbxAugmentation.Enabled = true;
            formAffiche.btnOKColab.Text = "Enregistrer";
        }



        internal void init()
        {
            formAffiche.dgContrats.DataSource = DictionnaireCollaborateur.ListContrats(leCollaborateur);
            formAffiche.dgContrats.Refresh();
            

        }



    }
}
