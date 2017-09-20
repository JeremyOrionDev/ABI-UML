using ClassesDAO;
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
            leForm.btnAnnulerColab.Click += new EventHandler(btnAnnuler_Click);
            leForm.txtBoxMatriculeCollab.Enabled = false;
            leForm.btnContrats.Visible = false;
            leForm.btnModifier.Visible = false;
            leForm.cBxSituation.Items.AddRange(new String[]
   {"Célibataire","Marié","Divorcé"});
            leForm.cBxSituation.Text = "cliquez-moi";
              
            leForm.cBxCivilite.Items.AddRange(new String[]
    {"Mr","Mme","Mlle"});
            leForm.cBxCivilite.Text = "cliquez-moi";
            this.leForm.Text = "Ajouter un collaborateur au projet en cours";
            this.leForm.btnOKColab.Click += new EventHandler(this.btnOK_Click);
            Int32 numColab;
            numColab = DictionnaireCollaborateur.nbCollab();
            leForm.txtBoxMatriculeCollab.Text = (DictionnaireCollaborateur.listCollaborateur.Count).ToString();
            leForm.ShowDialog();
         
            //leForm.cBxTypeContratColab.Enabled = leForm.chkBxContrat.Checked ? false : true;
        }


        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            leForm.DialogResult = DialogResult.Cancel;
            resultat = false;
            if (leForm.DialogResult==DialogResult.Cancel)
            {
                leForm.Close();
            }
            
        }

        internal Boolean Controle(frmNouveauCollab unForm)
        {


            String erreur="";
            Int32 i = 0;
            if (!(Outils.CPControl(leForm.txtBxCP.Text)))
            {
                i++;                
                leForm.errorProviderCollab.SetError(leForm.txtBxCP, "erreur de code postale");
                erreur += "\t\u2022 Le code postal n'est pas un entier de 5 caractères \r";
            }
            if (leForm.cBxSituation.SelectedItem==null)
            {
                i++;
                erreur += "\t\u2022 La situation maritale n'a pas été sélectionnée \r";
                leForm.errorProviderCollab.SetError(leForm.cBxSituation, "Veuillez sélectionner la situation maritale du collaborateur");
            }
            if (!(Outils.controlTel(leForm.tBxTel.Text.ToString())))
            {
                i++;
                erreur += "\t\u2022 La valeur du telephone n'est pas un nombre composé de 10 chiffres \r";
                leForm.errorProviderCollab.SetError(leForm.tBxTel, "erreur de telephone");
            }
            if (leForm.cBxCivilite.SelectedItem==null)
            {
                i++;
                erreur += "\t\u2022 La civilité du collaborateur enregistré n'à pas été sélectionnée\r";
                leForm.errorProviderCollab.SetError(leForm.cBxCivilite, "Veuillez sélectionner la civilité du collaborateur");
            }
            if (leForm.txtBoxPrenomCollab.Text=="")
            {
                i++;
                erreur += "\t\u2022 Le prénom du collaborateur n'a pas été renseigné \r";
                leForm.errorProviderCollab.SetError(leForm.txtBoxPrenomCollab, "Veuillez entrer le prénom du collaborateur");
            }
            if (leForm.txtBoxNomCollab.Text == "")
            {
                i++;
                erreur += "\t\u2022 Le nom du collaborateur enregistré n'à pas été entré\r";
                leForm.errorProviderCollab.SetError(leForm.txtBoxNomCollab, "Veuillez entrer le nom du collaborateur");
            }
            if (leForm.txtBoxRueCollab.Text=="")
            {
                i++;
                erreur += "\t\u2022 La rue du collaborateur n'a pas été renseigné\r";
                leForm.errorProviderCollab.SetError(leForm.txtBoxRueCollab, "Veuillez entrer la rue du collaborateur");
            }
            if (leForm.txtBxVille.Text=="")
            {
                i++;
                erreur += "\t\u2022 La ville n'a pas été renseignée";
                leForm.errorProviderCollab.SetError(leForm.txtBxVille, "Veuillez entrer la ville du collaborateur");
            }
            if (i != 0)
            {
                 MessageBox.Show("nombre d'erreurs: " + i + "\r" + erreur, "Erreurs dans le formulaire", MessageBoxButtons.RetryCancel);
                return false;
            }
            else return true;
        }
        internal Boolean Instancie()
        {

            
            try
            {

                uncolab = new Collaborateur(Convert.ToInt32(leForm.txtBoxMatriculeCollab.Text),leForm.cBxCivilite.SelectedItem.ToString(),leForm.cBxSituation.SelectedItem.ToString(), leForm.txtBoxNomCollab.Text, leForm.txtBoxPrenomCollab.Text, leForm.txtBoxRueCollab.Text,
                     leForm.txtBxVille.Text, leForm.txtBxCP.Text, leForm.tBxTel.Text) ;
                DictionnaireCollaborateur.Ajouter(uncolab);
                Collaborateurs E = new Collaborateurs(uncolab.Matricule, uncolab.Civilite, uncolab.SituationMaritale, uncolab.NomCollaborateur, uncolab.PrenomCollaborateur, uncolab.RueCollab, uncolab.VilleCollab, uncolab.CpCollab, uncolab.Telephone);
                DonneesDAO.DbContextCollaborateurs.CollaborateursSet.Add(E);
                DonneesDAO.DbContextCollaborateurs.SaveChanges();
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
                if (Instancie())
                {
                    leForm.DialogResult = DialogResult.OK;
                    ctrlNouveauContrat leNouveauContrat = new ctrlNouveauContrat(uncolab);
                }
                
            } 

        }
    }
}

