using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassesDAO;
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
        private Collaborateurs leCollaborateur;
        /// <summary>
        /// Attribut privé de DialogResult pour le transmettre au contrôleur appelant
        /// </summary>
        private DialogResult formResult;
        /// <summary>
        /// Attribut privé de type booléen pour connaitre l'état de modification du collaborateur
        /// </summary>
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
        /// <summary>
        /// Méthode appelée au double clic sur un contrat du collaborateur permettant son affichage
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dgContrat_DoubleClick(object sender, EventArgs e)
        {
            Contrats leContrat;
            Int32 numContrat;
            Int32 nbContrat = this.leCollaborateur.Contrats.Count();
            if (formAffiche.dgContrats.RowCount != 0)
            {
                numContrat = Convert.ToInt32(formAffiche.dgContrats.CurrentRow.Cells[6].Value.ToString());
            }
            else numContrat = 0;
            Collaborateurs unColab = DonneesDAO.DbContextCollaborateurs.CollaborateursSet.Find(leCollaborateur.matricule);
            try
            {
                leContrat = DonneesDAO.DbContextCollaborateurs.ContratsSet.Find(numContrat);

            }
            catch (Exception)
            {

                throw new Exception("Erreur le contrat n'existe pas");
            }


            if (leContrat is ClassesDAO.ContratCDD)
            {
                leContrat = (ClassesDAO.ContratCDD)leContrat;
            }
            else if (leContrat is ClassesDAO.ContratCDI)
            {
                leContrat = (ClassesDAO.ContratCDI)leContrat;
            }
            else if (leContrat is ClassesDAO.ContratInterim)
            {
                leContrat = (ClassesDAO.ContratInterim)leContrat;
            }
            else if (leContrat is ClassesDAO.ContratStage)
            {
                leContrat = (ClassesDAO.ContratStage)leContrat;
            }
            else throw new ArgumentOutOfRangeException("le contrat n'est pas défini sur un type de contrat précis (stage,interim,CDD ou CDI)");
            ctrlAfficheContrat affichecontrat = new ctrlAfficheContrat(leContrat);
            //MessageBox.Show("test", "test", MessageBoxButtons.OK);
        }
        /// <summary>
        /// Méthode appelée lors du clic sur le bouton Contrats>> développant le form sur la droite afin d'afficher en DataGrid les contrats possédés par le collaborateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnContrats_Click(object sender, EventArgs e)
        {
            if (formAffiche.panelContrat.Visible == false)
            {
                formAffiche.panelContrat.Visible = true;
                formAffiche.btnContrats.Text = "<<Contrats";
                formAffiche.panelDGAugmentation.Visible = true;
            }
            else
            {
                formAffiche.panelContrat.Visible = false;
                formAffiche.panelDGAugmentation.Visible = false;
                formAffiche.btnContrats.Text = "Contrats>>";
            }
            init();

        }
        /// <summary>
        /// Constructeur du controleur d'affichage des données d'un collaborateur prenant en paramètre un objet collaborateur avec ses données
        /// </summary>
        /// <param name="unColab">Collaborateur à afficher</param>
        public ctrlAfficheCollab(Collaborateurs unColab)
        {
            this.leCollaborateur = unColab;
            formAffiche = new frmAfficheCollab(leCollaborateur);
            init();
            formAffiche.panelDGAugmentation.Visible = false;
            formAffiche.txtBoxMatriculeCollab.Enabled = false;
            formAffiche.cBxCivilite.Enabled=false;
            formAffiche.txtBoxNomCollab.Enabled=false;
            formAffiche.txtBoxPrenomCollab.Enabled = false;
            formAffiche.txtBoxRueCollab.Enabled = false;
            formAffiche.txtBxVille.Enabled = false;
            formAffiche.txtBxCP.Enabled = false;
            formAffiche.tBxTel.Enabled = false;
            formAffiche.cBxSituation.Enabled = false;
            formAffiche.panelContrat.Visible = false;
            formAffiche.cBxCivilite.Items.AddRange(new String[] { "Mr", "Mme","Mlle" });
            formAffiche.cBxSituation.Items.AddRange(new String[] { "Célibataire", "Marié","Divorcé" });
            formAffiche.txtBoxMatriculeCollab.Text = unColab.matricule.ToString();
            formAffiche.txtBoxNomCollab.Text = unColab.Nom;
            formAffiche.txtBoxPrenomCollab.Text = unColab.Prenom;
            formAffiche.txtBoxRueCollab.Text = unColab.Rue;
            formAffiche.txtBxVille.Text = unColab.Ville;
            formAffiche.txtBxCP.Text = unColab.CodePostal;
            formAffiche.tBxTel.Text = unColab.Telephone;
            formAffiche.cBxSituation.SelectedItem = unColab.SituationMaritale;
            formAffiche.cBxCivilite.SelectedItem = unColab.Civilite;
            formAffiche.btnAnnulerColab.Click += new EventHandler(btnAnnuler_Click);
            formAffiche.btnContrats.Click += new EventHandler(this.btnContrats_Click);
            formAffiche.dgContrats.DoubleClick += new EventHandler(dgContrat_DoubleClick);
            formAffiche.btnModifier.Click += new EventHandler(btnModifier_Click);
            formAffiche.btnAjouterContrat.Click += new EventHandler(btnAjoutContrat_Click);
            formAffiche.btnOKColab.Click += new EventHandler(btnOK_Click);
            formAffiche.ShowDialog();
        }
        /// <summary>
        /// Méthode appelée lors du clic sur le bouton ajout contrat permettant d'ouvrir le form d'ajout de contrat
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAjoutContrat_Click(object sender, EventArgs e)
        {
            ctrlNouveauContrat leNouveauContrat = new ctrlNouveauContrat(this.leCollaborateur);
            if (leNouveauContrat.contratOK)
            {
                init();
            }
        }

        /// <summary>
        /// Méthode privée appelée lors de l'enregistrement
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (Modifier)
            {
                String Modif = "";
                int i = 0;
                if (formAffiche.cBxCivilite.SelectedItem.ToString() != leCollaborateur.Civilite)
                {
                    i++;
                    Modif += "\t\u2022 la civilité: " + leCollaborateur.Civilite + " deviendra: " + formAffiche.cBxCivilite.Text + "\r";

                }
                if (formAffiche.cBxSituation.SelectedItem.ToString() != leCollaborateur.SituationMaritale)
                {
                    i++;
                    Modif += "\t\u2022 la situation maritale: " + leCollaborateur.SituationMaritale + " deviendra: " + formAffiche.cBxSituation.Text + "\r";

                }
                if (formAffiche.txtBoxNomCollab.Text != leCollaborateur.Nom)
                {
                    i++;
                    Modif += "\t\u2022 le nom du Collaborateur: " + leCollaborateur.Nom + " va être modifié en: " + formAffiche.txtBoxNomCollab.Text + "\r";
                }
                if (formAffiche.txtBoxPrenomCollab.Text != leCollaborateur.Prenom)
                {
                    i++;
                    Modif += "\t\u2022 le prénom du Collaborateur: " + leCollaborateur.Prenom + " va être modifié en: " + formAffiche.txtBoxPrenomCollab.Text + "\r";
                    if (formAffiche.tBxTel.Text != leCollaborateur.Telephone)
                    {
                        i++;
                        Modif += "\t\u2022 le téléphone: " + leCollaborateur.Telephone + " deviendra: " + formAffiche.tBxTel.Text + "\r";

                    }
                }
                if (formAffiche.txtBoxRueCollab.Text != leCollaborateur.Rue)
                {
                    i++;
                    Modif += "\t\u2022 la rue du Collaborateur: " + leCollaborateur.Rue + " va être modifié en: " + formAffiche.txtBoxRueCollab.Text + "\r";
                }
                if (formAffiche.txtBxVille.Text != leCollaborateur.Ville)
                {
                    i++;
                    Modif += "\t\u2022 la ville du Collaborateur: " + leCollaborateur.Ville + " va être modifié en: " + formAffiche.txtBxVille.Text + "\r";
                }
                if (formAffiche.txtBxCP.Text != leCollaborateur.CodePostal)
                {
                    i++;
                    Modif += "\t\u2022 le code postal du Collaborateur: " + leCollaborateur.CodePostal + " va être modifié en: " + formAffiche.txtBxCP.Text + "\r";
                }

                Modif = "Vous avez fait " + i + " modifications: \r" + Modif;
                DialogResult DR = MessageBox.Show(Modif, "Valider les modifications ?", MessageBoxButtons.OKCancel);
                if (DR == DialogResult.OK)
                {
                    leCollaborateur.Telephone = formAffiche.tBxTel.Text;
                    leCollaborateur.Civilite = formAffiche.cBxCivilite.SelectedItem.ToString();
                    leCollaborateur.SituationMaritale = formAffiche.cBxSituation.SelectedItem.ToString();
                    leCollaborateur.Nom = formAffiche.txtBoxNomCollab.Text;
                    leCollaborateur.Prenom = formAffiche.txtBoxPrenomCollab.Text;
                    leCollaborateur.Rue = formAffiche.txtBoxRueCollab.Text;
                    leCollaborateur.Ville = formAffiche.txtBxVille.Text;
                    leCollaborateur.CodePostal = formAffiche.txtBxCP.Text;
                    Collaborateurs lecolab = DonneesDAO.DbContextCollaborateurs.CollaborateursSet.Find(leCollaborateur.matricule);
                    lecolab.Civilite = formAffiche.cBxCivilite.SelectedItem.ToString();
                    lecolab.SituationMaritale = formAffiche.cBxSituation.SelectedItem.ToString();
                    lecolab.Nom = formAffiche.txtBoxNomCollab.Text;
                    lecolab.Prenom = formAffiche.txtBoxPrenomCollab.Text;
                    lecolab.Rue = formAffiche.txtBoxRueCollab.Text;
                    lecolab.Ville = formAffiche.txtBxVille.Text;
                    lecolab.CodePostal = formAffiche.txtBxCP.Text;
                    lecolab.Telephone = formAffiche.tBxTel.Text;
                    DonneesDAO.DbContextCollaborateurs.SaveChanges();
                    //formAffiche.Close();
                }
            }
            formAffiche.DialogResult = DialogResult.OK;
            FormResult = DialogResult.OK;
        }
        /// <summary>
        /// Méthode appelée au clic sur le bouton Annuler fermant le form sans enregistrer les données saisies
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            formAffiche.Close();
        }
        /// <summary>
        /// Méthode appelée lors du clic sur le bouton modifier débloquant les accès des textBox en modification
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
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
            formAffiche.btnOKColab.Text = "Enregistrer";
        }


        /// <summary>
        /// Méthode appelée à l'initialisation du form qui appelle la méthode lister les contrats du collaborateur et retournant une DataTable
        /// </summary>
        internal void init()
        {
            //formAffiche.dgContrats.DataSource = DictionnaireCollaborateur.ListContrats(leCollaborateur);
            formAffiche.dgContrats.DataSource = MCollaborateurDAOEFStatic.listerContratCollaborateurDAO(leCollaborateur);
            formAffiche.dgContrats.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
            formAffiche.dgContrats.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            formAffiche.dgContrats.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            formAffiche.dgContrats.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            formAffiche.dgContrats.Columns[formAffiche.dgContrats.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            formAffiche.dgContrats.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            formAffiche.dgContrats.Columns[6].Visible = false;
            formAffiche.dgAugmentation.DataSource = MCollaborateurDAOEFStatic.ListerAugmentation(leCollaborateur);
            formAffiche.dgContrats.Refresh();

            

        }

        public frmBaseCollab frmBaseCollab
        {
            get => default(frmBaseCollab);
            set
            {
            }
        }

        internal ctrlNouveauCollaborateur ctrlNouveauCollaborateur
        {
            get => default(ctrlNouveauCollaborateur);
            set
            {
            }
        }
    }
}
