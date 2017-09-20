using ClassesDAO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ABIenCouche
{
    class ctrlAfficheContrat
    {
        private Contrats leContrat;
        private ClassesDAO.ContratCDD leCDD;
        private ClassesDAO.ContratCDI leCDI;
        private ContratInterim lInterim;
        private ClassesDAO.ContratStage leStage;
        private frmAfficheContrat leForm;
        private void btnValider_Click(object sender,EventArgs e)
        {
            leForm.Close();
        }

        public ctrlAfficheContrat(Contrats unContrat)
        {
            leForm = new frmAfficheContrat(unContrat);
            this.leContrat = unContrat;
            leForm.btnValiderContrat.Text = "&Fermer";
            leForm.btnAnnuler.Visible = false;
            leForm.cBxTypeContrat.Items.AddRange(new String[] { "CDI", "CDD", "INTERIM","STAGE" });
                leForm.panelAvenant.Visible = true;
            if (unContrat is ClassesDAO.ContratCDI)
            {
                leCDI = (ClassesDAO.ContratCDI)unContrat;
                leForm.btnValiderContrat.Click += new EventHandler(btnValider_Click);
                leForm.txBxNumeroContrat.Text = leCDI.NumContrat.ToString();
                leForm.cBxTypeContrat.SelectedItem = "CDI";
                if (leCDI.Statut == true)
                {
                    leForm.rbtCadreOui.Checked = true;
                }
                else leForm.rbtCadreNon.Checked = true;
                leForm.panelMotif.Visible = false;
                leForm.panelDate.Visible = false;
                leForm.panelAgence.Visible = false;
                leForm.panelEcole.Visible = false;
                leForm.tBxFonctionContrat.Text = leCDI.Fonction;
                leForm.tBxQualification.Text = leCDI.Qualification;
                leForm.choixDateDebutContrat.Text = leCDI.DateDebut.ToString();
                leForm.tBxSalaire.Text = leCDI.Salaire.ToString();
            }
            else
            {
                if (unContrat is ClassesDAO.ContratCDD)
                {
                    //leForm = new frmAfficheContrat(unContrat);
                    leCDD = (ClassesDAO.ContratCDD)unContrat;
                    leForm.btnValiderContrat.Click += new EventHandler(btnValider_Click);
                    leForm.panelAgence.Visible = false;
                    leForm.panelEcole.Visible = false;
                    leForm.tBxLibelle.Enabled = false;
                    leForm.tBxLibelle.Text = leCDD.Libelle;
                    leForm.tBxSalaire.Enabled = false;
                    leForm.txBxNumeroContrat.Text = leCDD.NumContrat.ToString();
                    leForm.txBxNumeroContrat.Enabled = false;
                    leForm.tBxMotifContrat.Text = leCDD.Motif;
                    leForm.tBxMotifContrat.Enabled = false;
                    leForm.cBxTypeContrat.SelectedItem = "CDD";
                    if (leCDD.Statut == true)
                    {
                        leForm.rbtCadreOui.Checked = true;
                    }
                    else leForm.rbtCadreNon.Checked = true;
                    leForm.gBxCadre.Enabled = false;
                    leForm.tBxFonctionContrat.Text = leCDD.Fonction;
                    leForm.tBxFonctionContrat.Enabled = false;
                    leForm.tBxQualification.Text = leCDD.Qualification;
                    leForm.tBxQualification.Enabled = false;
                    leForm.choixDateDebutContrat.Value= leCDD.DateDebut;
                    leForm.choixDateDebutContrat.Enabled = false;
                    leForm.ChoixDateFinContrat.Value = leCDD.DateFin;
                    leForm.ChoixDateFinContrat.Enabled = false;
                    leForm.btnAnnuler.Visible = false;
                    leForm.btnValiderContrat.Text = "Fermer";
                }
                else if (unContrat is ContratInterim)
                {
                    lInterim = (ContratInterim)unContrat;
                    leForm.btnValiderContrat.Click += new EventHandler(btnValider_Click);
                    leForm.txBxNumeroContrat.Text = lInterim.NumContrat.ToString();
                    leForm.tBxMotifContrat.Text = lInterim.Motif;
                    leForm.cBxTypeContrat.SelectedItem = "INTERIM";
                    if (lInterim.Statut == true)
                    {
                        leForm.rbtCadreOui.Checked = true;
                    }
                    else leForm.rbtCadreNon.Checked = true;
                    leForm.panelEcole.Visible = false;
                    leForm.tBxFonctionContrat.Text = lInterim.Fonction;
                    leForm.tBxQualification.Text = lInterim.Qualification;
                    leForm.choixDateDebutContrat.Text = lInterim.DateFin.ToString();
                    leForm.ChoixDateFinContrat.Text = lInterim.DateFin.ToString();

                }
                else if (unContrat is ClassesDAO.ContratStage)
                {
                    leStage = (ClassesDAO.ContratStage)unContrat;
                    leForm.panelEcole.Visible = true;
                    leForm.panelAgence.Visible = false;
                    leForm.panelSalaire.Visible = false;
                    leForm.btnValiderContrat.Click += new EventHandler(btnValider_Click);

                }
                leForm.dgAvenant.DataSource = MCollaborateurDAOEFStatic.ListerAvenant(unContrat);
                leForm.dgAvenant.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.ColumnHeader;
                leForm.dgAvenant.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
                leForm.dgAvenant.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;
                leForm.dgAvenant.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                            //formAfficheColab.dgCollabo.Columns[0].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCellsExceptHeader;

            } 
            leForm.ShowDialog();
      
        }


    }
}
