using ABIenCouche;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABIenCouche
{
    public partial class frmDspCollaborateur : Form
    {
        /// <summary>
        /// Le collaborateur
        /// </summary>
        private Collaborateur leCol;
        private Contrat leContrat;

        public frmDspCollaborateur()
        {
            InitializeComponent();
            this.leCol = new Collaborateur(1, "nom", "prenom", "la rue", "la ville", "12345");
            this.leContrat= new ContratCDD(1,new DateTime(),"libelle contrat","motif contrat",new DateTime());
            leCol.lstContrat.Add(this.leContrat.NumContrat, this.leContrat);
            //this.unContrat = new Contrat(1, 1, 1000 , null, "CDI", null, new DateTime(), null); // valide
            Collaborateur unCollab;
            unCollab = new Collaborateur(1, "nom", "prenom", "244 route de turin", "nice", "06300");
            DictionnaireCollaborateur.listCollaborateur.Add(unCollab.Matricule, unCollab);
            this.afficheCollabo();
        }

        private void afficheCollabo()
        {
            this.dgCollabo.DataSource = DictionnaireCollaborateur.ListCollab();
            this.dgCollabo.Refresh();
            this.btnSupprimer.Enabled = (this.dgCollabo.CurrentRow == null ? false : true);
        }



        private void dgCollabo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //Console.WriteLine("coucou");
            Collaborateur leCollabo;
            Int32 numcolab;

            if (this.dgCollabo.RowCount != 0)
            {
                numcolab = Convert.ToInt32(this.dgCollabo.CurrentRow.Cells[0].Value.ToString());
            }
            else numcolab = 0;

            leCollabo = DictionnaireCollaborateur.retrouverCollaborateur(numcolab);
            frmAfficheCollab frmColab = new frmAfficheCollab(leCollabo);

            frmColab.Text = leCollabo.NomCollaborateur.ToString() + " ";leCollabo.PrenomCollaborateur.ToString();

            frmColab.Show();

            

        }


    }
}
