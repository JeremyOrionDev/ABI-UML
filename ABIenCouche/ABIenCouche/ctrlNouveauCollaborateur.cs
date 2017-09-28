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
        internal Collaborateurs uncolab;
        /// <summary>
        /// Attribut booléen permettant la communication au controleur appelant
        /// </summary>
        private Boolean resultat = false;
        /// <summary>
        /// getteur setteur de cet attribut
        /// </summary>
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

        internal ctrlNouveauContrat ctrlNouveauContrat
        {
            get => default(ctrlNouveauContrat);
            set
            {
            }
        }

        /// <summary>
        /// Constructeur de la classe Nouveau Collaborateur mettant en forme le formulaire de création de contrat
        /// et adaptant celui ci en fonction du type de contrat choisi
        /// les champs apparaissent afin de créer un contrat avec tous les paramètres requis par les différents constructeurs
        /// </summary>
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
        /// <summary>
        /// Méthode appelée lors du clic sur le bouton annuler fermant ce form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            leForm.DialogResult = DialogResult.Cancel;
            resultat = false;
            if (leForm.DialogResult==DialogResult.Cancel)
            {
                leForm.Close();
            }
            
        }
        /// <summary>
        /// Méthode interne permettant le contrôle des champs de saisies et générant un errorProvider en cas d'erreur avec un texte adapté a chaque champs
        /// </summary>
        /// <param name="unForm">le form a contrôler</param>
        /// <returns></returns>
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
        /// <summary>
        /// Méthode interne d'instanciation du collaborateur si les contrôles précédents sont passés avec succès
        /// </summary>
        /// <returns>true ou false en fonction de la réussite ou non de l'instanciation</returns>
        internal Boolean Instancie()
        {

            
            try
            {
                Boolean Archiver;
                if (leForm.rbtnArchiverOui.Checked == true)
                {
                    Archiver = true;
                }
                else Archiver = false;
                 Collaborateur E = new Collaborateur(Convert.ToInt32(leForm.txtBoxMatriculeCollab.Text),leForm.cBxCivilite.SelectedItem.ToString(),leForm.cBxSituation.SelectedItem.ToString(), leForm.txtBoxNomCollab.Text, leForm.txtBoxPrenomCollab.Text, leForm.txtBoxRueCollab.Text,
                     leForm.txtBxVille.Text, leForm.txtBxCP.Text, leForm.tBxTel.Text,Archiver) ;
                DictionnaireCollaborateur.Ajouter(E);
                uncolab = new Collaborateurs(uncolab.matricule, uncolab.Civilite, uncolab.SituationMaritale, uncolab.Nom, uncolab.Prenom, uncolab.Rue, uncolab.Ville, uncolab.CodePostal, uncolab.Telephone,uncolab.Archive);
                DonneesDAO.DbContextCollaborateurs.CollaborateursSet.Add(uncolab);
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
        /// <summary>
        /// Méthode privée appelée lors du clic sur le bouton OK appelant les méthodes contrôle et instancie citées précédemment
        /// et renvoyant le résultat pour le contrôleur appelant
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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

