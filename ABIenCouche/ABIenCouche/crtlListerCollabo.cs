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
    public class crtlListerCollabo
    {
        internal DialogResult DR;
        /// <summary>
        /// ref au colaborateur pour les modifications/suppresions
        /// </summary>
        private Collaborateur leColab;
        /// <summary>
        /// ref au form d'affichage des collaborateurs
        /// </summary>
        public frmDspCollaborateur formAfficheColab=new frmDspCollaborateur ();
        
        /// <summary>
        /// obtient la réference du collaborateur
        /// </summary>
        public Collaborateur LeColab
        {
            get
            {
                return leColab;
            }
        }

        public   crtlListerCollabo()
        {
            init();
            formAfficheColab.cBxRechercheCollab.Items.AddRange(new String[]{ "matricule","nom","telephone","ville"
            });
            formAfficheColab.btnAnnulerRecherche.Click += new EventHandler(btnAnnulerRecherche_Click);
            formAfficheColab.btnAjouter.Click += new EventHandler(btnAjout_Click);
            formAfficheColab.btnSupprimer.Click += new EventHandler(btnSupprimer_Click);
            formAfficheColab.btnQuitter.Click += new EventHandler(btnQuitter_Click);
            formAfficheColab.dgCollabo.DoubleClick += new EventHandler(dgCollabo_CellContentDoubleClick);
            formAfficheColab.btnRechercher.Click += new EventHandler(btnRecherche_Click);
            
            formAfficheColab.ShowDialog();
            if (formAfficheColab.DialogResult==DialogResult.OK)
            {
                this.afficheCollabo();
            }
        }

        private void init2()
        {

            
        }

        internal void btnAnnulerRecherche_Click(object sender,EventArgs e)
        {
            (formAfficheColab.dgCollabo.DataSource as DataTable).DefaultView.RowFilter = null;

        }

        internal void btnRecherche_Click(object sender,EventArgs e)
        {

            if (formAfficheColab.tBxRechercher.Text!=null)
            {
                if (formAfficheColab.cBxRechercheCollab.SelectedItem.ToString()=="nom")
                {
                    (formAfficheColab.dgCollabo.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nom = '{0}'", formAfficheColab.tBxRechercher.Text);
                }
                //if (formAfficheColab.cBxRechercheCollab.SelectedItem.ToString()=="ville")
                //{
                //    (formAfficheColab.dgCollabo.DataSource as DataTable).DefaultView.RowFilter = string.Format("VilleCollab = '{0}'", formAfficheColab.tBxRechercher.Text);
                //}
            }


        }

        internal void btnAjout_Click(object sender, EventArgs e)
        {
            ctrlNouveauCollaborateur ctrl = new ctrlNouveauCollaborateur();
            if (ctrl.resultatForm!="")
            {
                ctrlNouveauContrat leContrat = new ctrlNouveauContrat(ctrl.uncolab, ctrl.resultatForm);
                if (leContrat.contratOK)
                {
                    this.afficheCollabo();
                }
            }

            

        }

        internal void btnSupprimer_Click(object sender, EventArgs e)
        {

            Int32 numColab = Convert.ToInt32(formAfficheColab.dgCollabo.CurrentRow.Cells[0].Value.ToString());
            leColab = DictionnaireCollaborateur.retrouverCollaborateur(numColab);
            DialogResult MB = MessageBox.Show(leColab.NomCollaborateur + " " + leColab.PrenomCollaborateur, "Supprimer le contact", MessageBoxButtons.OKCancel);
            if (MB == DialogResult.OK)
            {
                DictionnaireCollaborateur.SupprimerCollab(leColab);
                MessageBox.Show("le collaborateur viens d'être supprimé", "suppression confirmée", MessageBoxButtons.OK);
                this.afficheCollabo();
            }
        }

        internal void dgCollabo_CellContentDoubleClick(object sender, EventArgs e)
        {
            //instancie le controleur lister collabo
            //this.ctrlListerCollabo ctrl = new ctrlListerCollabo();
            //Console.WriteLine("coucou");
            Collaborateur leCollabo;
            Int32 numcolab;

            if (formAfficheColab.dgCollabo.RowCount != 0)
            {
                numcolab = Convert.ToInt32(formAfficheColab.dgCollabo.CurrentRow.Cells[0].Value.ToString());
            }
            else numcolab = 0;

            leCollabo = DictionnaireCollaborateur.retrouverCollaborateur(numcolab);
            ctrlAfficheCollab leCtrlAffiche = new ctrlAfficheCollab(leCollabo);
           
            if (leCtrlAffiche.FormResult==DialogResult.OK)
            {
                this.afficheCollabo();
            }
            //frmColab.Text = leCollabo.NomCollaborateur.ToString() + " "; leCollabo.PrenomCollaborateur.ToString();

            //frmColab.Show();
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

        internal void afficheCollabo()
        {
            MCollaborateurDAOEFStatic.instancieCollaborateurs();
           

            this.formAfficheColab.dgCollabo.DataSource =DictionnaireCollaborateur.ListCollab() ;
            this.formAfficheColab.dgCollabo.Refresh();
            this.formAfficheColab.btnSupprimer.Enabled = (formAfficheColab.dgCollabo.SelectedRows == null ? false : true);
        }

        internal void init()
        {

            this.afficheCollabo();
            formAfficheColab.dgCollabo.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            formAfficheColab.dgCollabo.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            formAfficheColab.dgCollabo.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        }
    }
}
