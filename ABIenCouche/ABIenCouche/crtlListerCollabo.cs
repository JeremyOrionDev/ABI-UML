using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace ABIenCouche
{
    public class crtlListerCollabo
    {
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

        public  crtlListerCollabo()
        {
            init();
            //formAfficheColab = new frmDspCollaborateur();
            formAfficheColab.btnAnnulerRecherche.Click += new EventHandler(btnAnnulerRecherche_Click);
            formAfficheColab.btnAjouter.Click += new EventHandler(btnAjout_Click);
            formAfficheColab.btnSupprimer.Click += new EventHandler(btnSupprimer_Click);
            formAfficheColab.btnQuitter.Click += new EventHandler(btnQuitter_Click);
            formAfficheColab.dgCollabo.DoubleClick += new EventHandler(dgCollabo_CellContentDoubleClick);
            formAfficheColab.btnRechercher.Click += new EventHandler(btnRecherche_Click);
            
            formAfficheColab.ShowDialog();
        }

        internal void btnAnnulerRecherche_Click(object sender,EventArgs e)
        {
            (formAfficheColab.dgCollabo.DataSource as DataTable).DefaultView.RowFilter = null;

        }

        internal void btnRecherche_Click(object sender,EventArgs e)
        {

            if (formAfficheColab.tBxRechercher.Text!=null)
            {
                if (formAfficheColab.cBxRechercheCollab.Text == "")
                {
                    ((DataView)(formAfficheColab.dgCollabo.DataSource)).RowFilter = string.Format(this.formAfficheColab.tBxRechercher.Text);
                    formAfficheColab.dgCollabo.Refresh();
                }
                if (formAfficheColab.cBxRechercheCollab.SelectedItem.ToString()=="nom")
                {
                    //((DataView)(formAfficheColab.dgCollabo.DataSource)).RowFilter = string.Format("Nom like'%{0}%'", this.formAfficheColab.tBxRechercher.Text);
                    //((DataView)(formAfficheColab.dgCollabo.DataSource)).RowFilter = string.Format("Nom like '%" + this.formAfficheColab.tBxRechercher.Text + "%'");
                    //(formAfficheColab.dgCollabo.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nom like '{0}%' OR nom LIKE '% {0}%'", formAfficheColab.tBxRechercher.Text);
                    //DataTable nomColabDT = DictionnaireCollaborateur.ListNomCollab(formAfficheColab.tBxRechercher.Text);
                    //formAfficheColab.dgCollabo.DataSource = nomColabDT;
                    //formAfficheColab.dgCollabo.Refresh();

                    (formAfficheColab.dgCollabo.DataSource as DataTable).DefaultView.RowFilter = string.Format("Nom = '{0}'", formAfficheColab.tBxRechercher.Text);
                }
            }


        }

        internal void btnAjout_Click(object sender, EventArgs e)
        {
            ctrlNouveauCollaborateur ctrl = new ctrlNouveauCollaborateur();

            if (ctrl.Resultat)
            {
                this.afficheCollabo();
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
            formAfficheColab.Close();
        }

        public void afficheCollabo()
        {
            
            formAfficheColab.dgCollabo.DataSource = DictionnaireCollaborateur.ListCollab();
            formAfficheColab.dgCollabo.Refresh();
            formAfficheColab.btnSupprimer.Enabled = (formAfficheColab.dgCollabo.SelectedRows == null ? false : true);
        }

        internal void init()
        {
            Collaborateur leCol = new Collaborateur(1, "Mr", "nom", "prenom", "la rue", "la ville", "12345", 0, "0123456789","");
            Collaborateur jeremy = new Collaborateur(3, "Mr", "orion", "jeremy", "la rue", "la ville", "12345", 0, "0123456789","");
            DictionnaireCollaborateur.Ajouter(jeremy);
            DictionnaireCollaborateur.Ajouter(leCol);
            Contrat leContrat = new ContratCDD(1, "libelle contrat", new DateTime(), "motif contrat", "ma fonction", "ma qualif", true, new DateTime(), "rue ici", "la ville", "23456");
            avenantContrat lavenant = new avenantContrat(1, "mon avenant", new DateTime());
            leCol.ajoutContrat(leContrat);
            ContratCDD unCDD = new ContratCDD(3, "le libelle", new DateTime(), "le motif", "lafonction", "sans qualif", true, new DateTime(), "ma rue", "ma ville", "mon CP");
            leCol.lesContrats.Add(unCDD.NumContrat, unCDD);
            leContrat.ListAvenant.Add(lavenant.NumeroAvenant, lavenant);
            Collaborateur unCollab = new Collaborateur(2, "Mme", "nom", "prenom", "244 route de turin", "nice", "06300", 2, "0541236587","");
            DictionnaireCollaborateur.Ajouter(unCollab);
            this.afficheCollabo();
            formAfficheColab.dgCollabo.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            formAfficheColab.dgCollabo.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            formAfficheColab.dgCollabo.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;

        }
    }
}
