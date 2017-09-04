using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace ABIenCouche
{
    public partial class frmContratCDI : frmContrat
    {
        public frmContratCDI()
        {
            InitializeComponent();
            cBxTypeContrat.Items.Clear();
            cBxTypeContrat.Items.Add( "CDI");
            cBxTypeContrat.SelectedItem = "CDI";
            cBxTypeContrat.Enabled = false;
            lblDateFinContrat.Visible = false;
            ChoixDateFinContrat.Visible = false;
            
        }
        String path;
        private void btnContratParcourir_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog openPhoto = new OpenFileDialog();
                openPhoto.Filter = "Images files jpeg | *.jpg";
                openPhoto.Multiselect = false;
                if(openPhoto.ShowDialog()==DialogResult.OK)
                {
                     path = openPhoto.FileName;
                    txtBxAdressePhotoContrat.Enabled = false;
                    this.txtBxAdressePhotoContrat.Text = path;
                    FileStream fs = new FileStream(@path, FileMode.Open);
                    pictureBoxPhotoContrat.Image = Image.FromStream(fs);
                    fs.Close();
                    using(StreamReader reader = new StreamReader(new FileStream(path, FileMode.Open), new UTF8Encoding()));
                }
            }
            catch (Exception )
            {

                throw new Exception(" erreur rencontrée:" + e) ;
            }
            
        }


    }
}
