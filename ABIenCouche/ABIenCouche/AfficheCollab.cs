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

      
        

        public frmDspCollaborateur()
        {
          
            InitializeComponent();
    
            Collaborateur leCol = new Collaborateur(1,"Mr", "nom" , "prenom" , "la rue", "la ville", "12345",0,"0123456789");
            DictionnaireCollaborateur.Ajouter(leCol);
            Contrat leContrat= new ContratCDD(1,"libelle contrat", new DateTime(), "motif contrat","ma fonction","ma qualif", true,new DateTime(),"rue ici", "la ville","23456");
            avenantContrat lavenant = new avenantContrat(1, "mon avenant", new DateTime());
            ContratCDD unCDD = new ContratCDD(1, "le libelle", new DateTime(), "le motif", "lafonction", "sans qualif", true, new DateTime(), "ma rue", "ma ville", "mon CP");
            leCol.lesContrats.Add(unCDD.NumContrat, unCDD);
            leContrat.ListAvenant.Add(lavenant.NumeroAvenant, lavenant);
            Collaborateur unCollab = new Collaborateur(2,"Mme", "nom", "prenom", "244 route de turin", "nice", "06300",2,"0541236587");
            DictionnaireCollaborateur.Ajouter(unCollab);
            this.afficheCollabo();
            dgCollabo.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
            dgCollabo.Columns[4].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            dgCollabo.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
        }

        public void afficheCollabo()
        {
            this.dgCollabo.DataSource = DictionnaireCollaborateur.ListCollab();
            this.dgCollabo.Refresh();
            this.btnSupprimer.Enabled = (this.dgCollabo.CurrentRow == null ? false : true);
        }



        private void dgCollabo_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //instancie le controleur lister collabo
            //this.ctrlListerCollabo ctrl = new ctrlListerCollabo();
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

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            ctrlNouveauCollaborateur ctrl = new ctrlNouveauCollaborateur();
            
            if (ctrl.Resultat)
            {
                this.afficheCollabo();
            }
            
        }

        private void btnContrat_Click(object sender, EventArgs e)
        {
            frmContratCDI unCDI = new frmContratCDI();

            if (this.DialogResult == DialogResult.OK)
            {
                unCDI.ShowDialog();
            }
            else throw new Exception("Fatal error!!!!!!FFFUUUUCCCCKKKK");
        }

        private void btnQuitter_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
