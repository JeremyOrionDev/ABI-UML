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
            formAffiche.TbxAugmentation.Text = unColab.Augmentation.ToString();
            formAffiche.panelPhoto.Visible = false;
            OpenFileDialog openPhoto = new OpenFileDialog();
            openPhoto.Filter = "Images files jpeg | *.jpg";
            openPhoto.Multiselect = false;
            String path = unColab.LaPhoto;
            formAffiche.txtBxAdressePhoto.Enabled = false;
            formAffiche.txtBxAdressePhoto.Text = path;
            FileStream fs = new FileStream(@path, FileMode.Open);
            formAffiche.pictureBoxPhotoCollab.Image = Image.FromStream(fs);
            fs.Close();
            using (StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open), new UTF8Encoding())) ;

    
            formAffiche.ShowDialog();
        }
    }
}
