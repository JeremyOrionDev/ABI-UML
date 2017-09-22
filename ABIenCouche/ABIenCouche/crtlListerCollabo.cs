using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using ClassesDAO;


namespace ABIenCouche
{
    /// <summary>
    /// Controleur d'affichage du form de visualisation des collaborateurs en Datagrid
    /// </summary>
    public class crtlListerCollabo
    {
        /// <summary>
        /// variable interne de resultat pour envoi au controleur suivant
        /// </summary>
        internal DialogResult DR;
        /// <summary>
        /// ref au form d'affichage des collaborateurs
        /// </summary>
        public frmDspCollaborateur formAfficheColab=new frmDspCollaborateur();

        /// <summary>
        /// attribut interne pour modification de la datasource de la DataGrid afin de visualiser les collaborateurs archivés ou non
        /// </summary>
        private Boolean Clic;
        public   crtlListerCollabo()
        {
            init();
            formAfficheColab.cBxRechercheCollab.Items.AddRange(new String[]{ "matricule","nom","telephone","ville","cadre","non-cadre"
            });
            formAfficheColab.btnAnnulerRecherche.Click += new EventHandler(btnAnnulerRecherche_Click);
            formAfficheColab.btnAjouter.Click += new EventHandler(btnAjout_Click);
            formAfficheColab.btnArchiver.Click += new EventHandler(btnArchiver_Click);
            formAfficheColab.btnQuitter.Click += new EventHandler(btnQuitter_Click);
            formAfficheColab.dgCollabo.DoubleClick += new EventHandler(dgCollabo_CellContentDoubleClick);
            formAfficheColab.btnRechercher.Click += new EventHandler(btnRecherche_Click);
            formAfficheColab.btnVoirArchive.Click += new EventHandler(btnVoirArchive_Click);
            formAfficheColab.ShowDialog();
            if (formAfficheColab.DialogResult==DialogResult.OK)
            {
                this.afficheCollabo();
            }
        }
        /// <summary>
        /// Méthode appelée au clic sur le bouton de visualisation des archives
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnVoirArchive_Click(object sender, EventArgs e)
        {
            if (formAfficheColab.dgCollabo.Columns.Count == 6)
            {
                formAfficheColab.dgCollabo.DataSource = DictionnaireCollaborateur.listArchive();
                formAfficheColab.dgCollabo.Columns[6].Visible = false;
                formAfficheColab.btnVoirArchive.Text = "Sortir Archives";
                Clic = true;
            }
            else
            {
                formAfficheColab.btnVoirArchive.Text = "Voir Archives";
                afficheCollabo();
            }
        }
        /// <summary>
        /// Méthode appelée lors du clic sur le bouton annuler la recherche qui annule le filtre de recherche sur la datagrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        internal void btnAnnulerRecherche_Click(object sender,EventArgs e)
        {
            this.formAfficheColab.dgCollabo.DataSource = DictionnaireCollaborateur.ListCollab();
           
        }
        /// <summary>
        /// Méthode appelée lors du clic sur le bouton recherche qui récupère en BDD les collaborateurs correspondants au filtre de recherche
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        internal void btnRecherche_Click(object sender,EventArgs e)
        {


            if (formAfficheColab.tBxRechercher.Text!=null)
            {
                String cibleRecherche = formAfficheColab.cBxRechercheCollab.SelectedItem.ToString();

                DataTable dt = new DataTable();
                if (cibleRecherche=="nom")
                {

                    var query = from  c in DonneesDAO.DbContextCollaborateurs.CollaborateursSet
                                where c.Nom==formAfficheColab.tBxRechercher.Text
                                select c;
                    DataRow DR = dt.NewRow();
                    dt.Columns.Add(new DataColumn("#", typeof(Int32)));
                    dt.Columns.Add(new DataColumn("Civ", typeof(String)));
                    dt.Columns.Add(new DataColumn("Nom", typeof(String)));
                    dt.Columns.Add(new DataColumn("Prénom", typeof(String)));
                    dt.Columns.Add(new DataColumn("Adresse", typeof(String)));
                    dt.Columns.Add(new DataColumn("Telephone", typeof(String)));

                        foreach (Collaborateurs D in query)
                        {
                            DR = dt.NewRow();
                            DR[0] = D.matricule;
                            DR[1] = D.Civilite;
                            DR[2] = D.Nom;
                            DR[3] = D.Prenom;
                            DR[4] = D.Rue + " " + D.CodePostal + " " + D.Ville;
                            DR[5] = D.Telephone;
                            dt.Rows.Add(DR);

                        }
                    
                }
                else if(cibleRecherche=="prenom")
                {
                    var query = from c in DonneesDAO.DbContextCollaborateurs.CollaborateursSet
                                where c.Prenom == formAfficheColab.tBxRechercher.Text
                                select c;
                    DataRow DR = dt.NewRow();
                    dt.Columns.Add(new DataColumn("#", typeof(Int32)));
                    dt.Columns.Add(new DataColumn("Civ", typeof(String)));
                    dt.Columns.Add(new DataColumn("Nom", typeof(String)));
                    dt.Columns.Add(new DataColumn("Prénom", typeof(String)));
                    dt.Columns.Add(new DataColumn("Adresse", typeof(String)));
                    dt.Columns.Add(new DataColumn("Telephone", typeof(String)));

                    foreach (Collaborateurs D in query)
                    {
                        DR = dt.NewRow();
                        DR[0] = D.matricule;
                        DR[1] = D.Civilite;
                        DR[2] = D.Nom;
                        DR[3] = D.Prenom;
                        DR[4] = D.Rue + " " + D.CodePostal + " " + D.Ville;
                        DR[5] = D.Telephone;
                        dt.Rows.Add(DR);

                    }
                }
                else if(cibleRecherche=="ville")
                {
                    var query = from c in DonneesDAO.DbContextCollaborateurs.CollaborateursSet
                                where c.Ville == formAfficheColab.tBxRechercher.Text
                                select c;
                    DataRow DR = dt.NewRow();
                    dt.Columns.Add(new DataColumn("#", typeof(Int32)));
                    dt.Columns.Add(new DataColumn("Civ", typeof(String)));
                    dt.Columns.Add(new DataColumn("Nom", typeof(String)));
                    dt.Columns.Add(new DataColumn("Prénom", typeof(String)));
                    dt.Columns.Add(new DataColumn("Adresse", typeof(String)));
                    dt.Columns.Add(new DataColumn("Telephone", typeof(String)));

                    foreach (Collaborateurs D in query)
                    {
                        DR = dt.NewRow();
                        DR[0] = D.matricule;
                        DR[1] = D.Civilite;
                        DR[2] = D.Nom;
                        DR[3] = D.Prenom;
                        DR[4] = D.Rue + " " + D.CodePostal + " " + D.Ville;
                        DR[5] = D.Telephone;
                        dt.Rows.Add(DR);

                    }
                }
                else if(cibleRecherche=="cadre")
                {
                    var query = from c in DonneesDAO.DbContextCollaborateurs.ContratsSet.Include("CollaborateursSet")
                                where c.Statut == true
                                select c.Collaborateurs;

                    var t = DonneesDAO.DbContextCollaborateurs.ContratsSet.Include("CollaborateursSet").Where(c => c.Statut == true).Select(c => c.Collaborateurs);
                    DataRow DR = dt.NewRow();
                    dt.Columns.Add(new DataColumn("#", typeof(Int32)));
                    dt.Columns.Add(new DataColumn("Civ", typeof(String)));
                    dt.Columns.Add(new DataColumn("Nom", typeof(String)));
                    dt.Columns.Add(new DataColumn("Prénom", typeof(String)));
                    dt.Columns.Add(new DataColumn("Adresse", typeof(String)));
                    dt.Columns.Add(new DataColumn("Telephone", typeof(String)));

                    foreach (Collaborateurs D in query)
                    {
                        DR = dt.NewRow();
                        DR[0] = D.matricule;
                        DR[1] = D.Civilite;
                        DR[2] = D.Nom;
                        DR[3] = D.Prenom;
                        DR[4] = D.Rue + " " + D.CodePostal + " " + D.Ville;
                        DR[5] = D.Telephone;
                        dt.Rows.Add(DR);

                    }
                }
                        formAfficheColab.dgCollabo.DataSource=dt;
                    formAfficheColab.dgCollabo.Refresh();
            }

        }
        /// <summary>
        /// Méthode appelée lors du clic sur le bouton ajout de collaborateur, qui appelle les méthode Controle du form et instanciation du collaborateur
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        internal void btnAjout_Click(object sender, EventArgs e)
        {
            ctrlNouveauCollaborateur ctrl = new ctrlNouveauCollaborateur();
            if (ctrl.Resultat)
            {
                ctrlNouveauContrat leContrat = new ctrlNouveauContrat(ctrl.uncolab);
                if (leContrat.contratOK)
                {
                    this.afficheCollabo();
                }
            }
        }
        /// <summary>
        /// Méthode appelée lors du clic sur le bouton archiver
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        internal void btnArchiver_Click(object sender, EventArgs e)
        {

            Int32 numColab = Convert.ToInt32(formAfficheColab.dgCollabo.CurrentRow.Cells[0].Value.ToString());
            Collaborateurs C = DonneesDAO.DbContextCollaborateurs.CollaborateursSet.Find(numColab);
            DialogResult MB = MessageBox.Show(C.Nom + " " + C.Prenom, "Archiver le collaborateur", MessageBoxButtons.OKCancel);
            if (MB == DialogResult.OK)
            {
                C.Archive = true;
                MessageBox.Show("le collaborateur viens d'être archivé", "Archivage confirmé", MessageBoxButtons.OK);
                this.afficheCollabo();
            }
        }
        /// <summary>
        /// Méthode appelée lors du double clic sur un collaborateur dans la DataGrid
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        internal void dgCollabo_CellContentDoubleClick(object sender, EventArgs e)
        {
            Collaborateurs leCollabo;
            Int32 numcolab;

            if (formAfficheColab.dgCollabo.RowCount != 0)
            {
                numcolab = Convert.ToInt32(formAfficheColab.dgCollabo.CurrentRow.Cells[0].Value.ToString());
            }
            else numcolab = 0;

            leCollabo = DonneesDAO.DbContextCollaborateurs.CollaborateursSet.Find(numcolab);
            ctrlAfficheCollab leCtrlAffiche = new ctrlAfficheCollab(leCollabo);
           
            if (leCtrlAffiche.FormResult==DialogResult.OK)
            {
                this.afficheCollabo();
            }
        }


        /// <summary>
        /// Fonction du bouton quitter du form d'affichage des collaborateurs
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        internal void btnQuitter_Click(object sender, EventArgs e)
        {
            DR = DialogResult.OK;
            
            formAfficheColab.Close();
        }
        /// <summary>
        /// Méthode interne instanciant les collaborateurs enregistrés en BDD et remplissant la DataGrid en créant une DataTable avec les données reçues de la base
        /// </summary>
        internal void afficheCollabo()
        {
            MCollaborateurDAOEFStatic.instancieCollaborateurs();
           

            this.formAfficheColab.dgCollabo.DataSource =DictionnaireCollaborateur.ListCollab() ;
            this.formAfficheColab.dgCollabo.Refresh();
            this.formAfficheColab.btnArchiver.Enabled = (formAfficheColab.dgCollabo.SelectedRows == null ? false : true);
        }
        /// <summary>
        /// Méthode d'initialisation appelée a l'ouverture du form
        /// </summary>
        internal void init()
        {

            this.afficheCollabo();
            formAfficheColab.dgCollabo.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            formAfficheColab.dgCollabo.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            formAfficheColab.dgCollabo.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            formAfficheColab.dgCollabo.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

        }
    }
}
