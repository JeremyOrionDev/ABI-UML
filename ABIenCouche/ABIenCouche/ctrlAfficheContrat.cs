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
        private Contrat leContrat;
        private ContratCDD leCDD;
        private ContratCDI leCDI;
        private contratInterim lInterim;
        private ContratStage leStage;
        private frmAfficheContrat leForm;
        private void btnValider_Click(object sender,EventArgs e)
        {
            leForm.Close();
        }

        public ctrlAfficheContrat(Contrat unContrat)
        {
            leForm = new frmAfficheContrat(unContrat);
            this.leContrat = unContrat;
            leForm.btnValiderContrat.Text = "&Fermer";
            leForm.btnAnnuler.Visible = false;
            leForm.cBxTypeContrat.Items.AddRange(new String[] { "CDI", "CDD", "INTERIM","STAGE" });
                leForm.panelAvenant.Visible = true;
            if (unContrat is ContratCDI)
            {
                leCDI = (ContratCDI)unContrat;
                leForm.btnValiderContrat.Click += new EventHandler(btnValider_Click);
                leForm.txBxNumeroContrat.Text = leCDI.NumContrat.ToString();
                leForm.cBxTypeContrat.SelectedItem = "CDI";
                if (leCDI.LeStatut == true)
                {
                    leForm.rbtCadreOui.Checked = true;
                }
                else leForm.rbtCadreNon.Checked = true;
                leForm.panelMotif.Visible = false;
                leForm.panelDate.Visible = false;
                leForm.panelAgence.Visible = false;
                leForm.panelEcole.Visible = false;
                leForm.tBxFonctionContrat.Text = leCDI.FonctionCollaborateur;
                leForm.tBxQualification.Text = leCDI.QualificationCollaborateur;
                leForm.choixDateDebutContrat.Text = leCDI.DateDebutContrat.ToString();
                leForm.tBxSalaire.Text = leCDI.SalaireBrut.ToString();
            }
            else
            {
                if (unContrat is ContratCDD)
                {
                    //leForm = new frmAfficheContrat(unContrat);
                    leCDD = (ContratCDD)unContrat;
                    leForm.btnValiderContrat.Click += new EventHandler(btnValider_Click);
                    leForm.panelAgence.Visible = false;
                    leForm.panelEcole.Visible = false;
                    leForm.tBxLibelle.Enabled = false;
                    leForm.tBxLibelle.Text = leCDD.Libelle;
                    leForm.tBxSalaire.Enabled = false;
                    leForm.txBxNumeroContrat.Text = leCDD.NumContrat.ToString();
                    leForm.txBxNumeroContrat.Enabled = false;
                    leForm.tBxMotifContrat.Text = leCDD.MotifContrat;
                    leForm.tBxMotifContrat.Enabled = false;
                    leForm.cBxTypeContrat.SelectedItem = "CDD";
                    if (leCDD.LeStatut == true)
                    {
                        leForm.rbtCadreOui.Checked = true;
                    }
                    else leForm.rbtCadreNon.Checked = true;
                    leForm.gBxCadre.Enabled = false;
                    leForm.tBxFonctionContrat.Text = leCDD.FonctionCollaborateur;
                    leForm.tBxFonctionContrat.Enabled = false;
                    leForm.tBxQualification.Text = leCDD.QualificationCollaborateur;
                    leForm.tBxQualification.Enabled = false;
                    leForm.choixDateDebutContrat.Value= leCDD.DateDebutContrat;
                    leForm.choixDateDebutContrat.Enabled = false;
                    leForm.ChoixDateFinContrat.Value = leCDD.DateFinContrat;
                    leForm.ChoixDateFinContrat.Enabled = false;
                    leForm.btnAnnuler.Visible = false;
                    leForm.btnValiderContrat.Text = "Fermer";
                }
                else if (unContrat is contratInterim )
                {
                    lInterim = (contratInterim)unContrat;
                    leForm.btnValiderContrat.Click += new EventHandler(btnValider_Click);
                    leForm.txBxNumeroContrat.Text = lInterim.NumContrat.ToString();
                    leForm.tBxMotifContrat.Text = lInterim.MotifContrat;
                    leForm.cBxTypeContrat.SelectedItem = "INTERIM";
                    if (lInterim.LeStatut == true)
                    {
                        leForm.rbtCadreOui.Checked = true;
                    }
                    else leForm.rbtCadreNon.Checked = true;
                    leForm.panelEcole.Visible = false;
                    leForm.tBxFonctionContrat.Text = lInterim.FonctionCollaborateur;
                    leForm.tBxQualification.Text = lInterim.QualificationCollaborateur;
                    leForm.choixDateDebutContrat.Text = lInterim.DateDebutContrat.ToString();
                    leForm.ChoixDateFinContrat.Text = lInterim.LaDateFin.ToString();

                }
                else if (unContrat is ContratStage)
                {
                    leStage = (ContratStage)unContrat;
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
