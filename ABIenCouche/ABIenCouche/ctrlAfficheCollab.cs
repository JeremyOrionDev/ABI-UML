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
        private Contrat leContrat;
        public ctrlAfficheCollab(Collaborateur unColab)
        {
            this.leCollaborateur = unColab;
            formAffiche = new frmAfficheCollab(leCollaborateur);
            formAffiche.txtBoxMatriculeCollab.Text = unColab.Matricule.ToString();
            formAffiche.txtBoxNomCollab.Text = unColab.NomCollaborateur;
            formAffiche.txtBoxPrenomCollab.Text = unColab.PrenomCollaborateur;
            formAffiche.txtBoxRueCollab.Text = unColab.RueCollab;
            formAffiche.txtBxVille.Text = unColab.VilleCollab;
            formAffiche.txtBxCP.Text = unColab.CpCollab;
            formAffiche.tBxTel.Text = unColab.Telephone;
            formAffiche.cBxContrat.Items.AddRange(new String[] { "oui", "non" });
            formAffiche.TbxAugmentation.Text = unColab.Augmentation.ToString();
            //formAffiche.panelPhoto.Visible = false;
            //OpenFileDialog openPhoto = new OpenFileDialog();
            //openPhoto.Filter = "Images files jpeg | *.jpg";
            //openPhoto.Multiselect = false;
            //String path = unColab.LaPhoto;
            //formAffiche.txtBxAdressePhoto.Enabled = false;
            //formAffiche.txtBxAdressePhoto.Text = path;
            //FileStream fs = new FileStream(@path, FileMode.Open);
            //formAffiche.pictureBoxPhotoCollab.Image = Image.FromStream(fs);
            //fs.Close();
            //formAffiche.gBxContrat.Visible = false;
            //using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open), new UTF8Encoding())) ;
            formAffiche.btnContrats.Click += new EventHandler(btnContrats_Click);
            formAffiche.dgContrats.DoubleClick += new EventHandler(dgContrat_DoubleClick);
            formAffiche.panelContrat.Visible = false;
            formAffiche.ShowDialog();
            init();
        }

         

        private void dgContrat_DoubleClick(object sender, EventArgs e)
        {
     
            Int32 numContrat;
            if (formAffiche.dgContrats.RowCount != 0)
            {
                numContrat = Convert.ToInt32(formAffiche.dgContrats.CurrentRow.Cells[0].Value.ToString());
            }
            else numContrat = 0;
            if (leCollaborateur.lesContrats.ContainsKey(leContrat.NumContrat))
            {
                leContrat = leCollaborateur.lesContrats[leContrat.NumContrat];
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
        internal void init()
        {
            formAffiche.dgContrats.DataSource = DictionnaireCollaborateur.ListContrats(leCollaborateur);
            formAffiche.dgContrats.Refresh();
        }
        private void btnContrats_Click(object sender, EventArgs e)
        {
            formAffiche.panelContrat.Visible = true;
            init();
            

        }


    }
}
