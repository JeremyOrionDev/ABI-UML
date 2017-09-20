namespace ABIenCouche
{
    partial class frmContrat
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.lblNumContrat = new System.Windows.Forms.Label();
            this.txBxNumeroContrat = new System.Windows.Forms.TextBox();
            this.lblCadre = new System.Windows.Forms.Label();
            this.gBxCadre = new System.Windows.Forms.GroupBox();
            this.rbtCadreNon = new System.Windows.Forms.RadioButton();
            this.rbtCadreOui = new System.Windows.Forms.RadioButton();
            this.lblFonctionContrat = new System.Windows.Forms.Label();
            this.tBxFonctionContrat = new System.Windows.Forms.TextBox();
            this.lblQualificationContrat = new System.Windows.Forms.Label();
            this.tBxQualification = new System.Windows.Forms.TextBox();
            this.choixDateDebutContrat = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.ChoixDateFinContrat = new System.Windows.Forms.DateTimePicker();
            this.lblDateFinContrat = new System.Windows.Forms.Label();
            this.lblTypeContrat = new System.Windows.Forms.Label();
            this.cBxTypeContrat = new System.Windows.Forms.ComboBox();
            this.panelDate = new System.Windows.Forms.Panel();
            this.flowLayoutPanel2 = new System.Windows.Forms.FlowLayoutPanel();
            this.panelContratNumero = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panelTypeContrat = new System.Windows.Forms.Panel();
            this.panelLibelle = new System.Windows.Forms.Panel();
            this.tBxLibelle = new System.Windows.Forms.TextBox();
            this.lblLibelleContrat = new System.Windows.Forms.Label();
            this.panelCadre = new System.Windows.Forms.Panel();
            this.panelMotif = new System.Windows.Forms.Panel();
            this.tBxMotifContrat = new System.Windows.Forms.TextBox();
            this.lblMotifContrat = new System.Windows.Forms.Label();
            this.panelFonction = new System.Windows.Forms.Panel();
            this.panelQualification = new System.Windows.Forms.Panel();
            this.panelEcole = new System.Windows.Forms.Panel();
            this.tBxEcole = new System.Windows.Forms.TextBox();
            this.lblEcole = new System.Windows.Forms.Label();
            this.panelAgence = new System.Windows.Forms.Panel();
            this.tBxAgence = new System.Windows.Forms.TextBox();
            this.lblAgence = new System.Windows.Forms.Label();
            this.panelSalaire = new System.Windows.Forms.Panel();
            this.tBxSalaire = new System.Windows.Forms.TextBox();
            this.lblSalaire = new System.Windows.Forms.Label();
            this.panelDebut = new System.Windows.Forms.Panel();
            this.panelAvenant = new System.Windows.Forms.Panel();
            this.dgAvenant = new System.Windows.Forms.DataGridView();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnValiderContrat = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.notifyIcon1 = new System.Windows.Forms.NotifyIcon(this.components);
            this.errorProviderContrat = new System.Windows.Forms.ErrorProvider(this.components);
            this.gBxCadre.SuspendLayout();
            this.panelDate.SuspendLayout();
            this.flowLayoutPanel2.SuspendLayout();
            this.panelContratNumero.SuspendLayout();
            this.panelTypeContrat.SuspendLayout();
            this.panelLibelle.SuspendLayout();
            this.panelCadre.SuspendLayout();
            this.panelMotif.SuspendLayout();
            this.panelFonction.SuspendLayout();
            this.panelQualification.SuspendLayout();
            this.panelEcole.SuspendLayout();
            this.panelAgence.SuspendLayout();
            this.panelSalaire.SuspendLayout();
            this.panelDebut.SuspendLayout();
            this.panelAvenant.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAvenant)).BeginInit();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContrat)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNumContrat
            // 
            this.lblNumContrat.AutoSize = true;
            this.lblNumContrat.BackColor = System.Drawing.Color.Transparent;
            this.lblNumContrat.Location = new System.Drawing.Point(3, 6);
            this.lblNumContrat.Name = "lblNumContrat";
            this.lblNumContrat.Size = new System.Drawing.Size(82, 13);
            this.lblNumContrat.TabIndex = 0;
            this.lblNumContrat.Text = "Contrat numéro:";
            // 
            // txBxNumeroContrat
            // 
            this.txBxNumeroContrat.Enabled = false;
            this.txBxNumeroContrat.Location = new System.Drawing.Point(100, 3);
            this.txBxNumeroContrat.Name = "txBxNumeroContrat";
            this.txBxNumeroContrat.Size = new System.Drawing.Size(174, 20);
            this.txBxNumeroContrat.TabIndex = 0;
            // 
            // lblCadre
            // 
            this.lblCadre.AutoSize = true;
            this.lblCadre.BackColor = System.Drawing.Color.Transparent;
            this.lblCadre.Location = new System.Drawing.Point(3, 13);
            this.lblCadre.Name = "lblCadre";
            this.lblCadre.Size = new System.Drawing.Size(35, 13);
            this.lblCadre.TabIndex = 2;
            this.lblCadre.Text = "Cadre";
            // 
            // gBxCadre
            // 
            this.gBxCadre.BackColor = System.Drawing.Color.Transparent;
            this.gBxCadre.Controls.Add(this.rbtCadreNon);
            this.gBxCadre.Controls.Add(this.rbtCadreOui);
            this.gBxCadre.Location = new System.Drawing.Point(100, -3);
            this.gBxCadre.Name = "gBxCadre";
            this.gBxCadre.Size = new System.Drawing.Size(133, 39);
            this.gBxCadre.TabIndex = 2;
            this.gBxCadre.TabStop = false;
            // 
            // rbtCadreNon
            // 
            this.rbtCadreNon.AutoSize = true;
            this.rbtCadreNon.Location = new System.Drawing.Point(76, 14);
            this.rbtCadreNon.Name = "rbtCadreNon";
            this.rbtCadreNon.Size = new System.Drawing.Size(45, 17);
            this.rbtCadreNon.TabIndex = 1;
            this.rbtCadreNon.TabStop = true;
            this.rbtCadreNon.Text = "Non";
            this.rbtCadreNon.UseVisualStyleBackColor = true;
            // 
            // rbtCadreOui
            // 
            this.rbtCadreOui.AutoSize = true;
            this.rbtCadreOui.Location = new System.Drawing.Point(6, 14);
            this.rbtCadreOui.Name = "rbtCadreOui";
            this.rbtCadreOui.Size = new System.Drawing.Size(41, 17);
            this.rbtCadreOui.TabIndex = 0;
            this.rbtCadreOui.TabStop = true;
            this.rbtCadreOui.Text = "Oui";
            this.rbtCadreOui.UseVisualStyleBackColor = true;
            // 
            // lblFonctionContrat
            // 
            this.lblFonctionContrat.AutoSize = true;
            this.lblFonctionContrat.BackColor = System.Drawing.Color.Transparent;
            this.lblFonctionContrat.Location = new System.Drawing.Point(4, 6);
            this.lblFonctionContrat.Name = "lblFonctionContrat";
            this.lblFonctionContrat.Size = new System.Drawing.Size(48, 13);
            this.lblFonctionContrat.TabIndex = 4;
            this.lblFonctionContrat.Text = "Fonction";
            // 
            // tBxFonctionContrat
            // 
            this.tBxFonctionContrat.Location = new System.Drawing.Point(100, 3);
            this.tBxFonctionContrat.Name = "tBxFonctionContrat";
            this.tBxFonctionContrat.Size = new System.Drawing.Size(174, 20);
            this.tBxFonctionContrat.TabIndex = 4;
            // 
            // lblQualificationContrat
            // 
            this.lblQualificationContrat.AutoSize = true;
            this.lblQualificationContrat.BackColor = System.Drawing.Color.Transparent;
            this.lblQualificationContrat.Location = new System.Drawing.Point(3, 3);
            this.lblQualificationContrat.Name = "lblQualificationContrat";
            this.lblQualificationContrat.Size = new System.Drawing.Size(65, 13);
            this.lblQualificationContrat.TabIndex = 11;
            this.lblQualificationContrat.Text = "Qualification";
            // 
            // tBxQualification
            // 
            this.tBxQualification.Location = new System.Drawing.Point(100, 2);
            this.tBxQualification.Name = "tBxQualification";
            this.tBxQualification.Size = new System.Drawing.Size(174, 20);
            this.tBxQualification.TabIndex = 5;
            // 
            // choixDateDebutContrat
            // 
            this.choixDateDebutContrat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.choixDateDebutContrat.Location = new System.Drawing.Point(99, 3);
            this.choixDateDebutContrat.Name = "choixDateDebutContrat";
            this.choixDateDebutContrat.Size = new System.Drawing.Size(109, 20);
            this.choixDateDebutContrat.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(3, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Debut";
            // 
            // ChoixDateFinContrat
            // 
            this.ChoixDateFinContrat.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.ChoixDateFinContrat.Location = new System.Drawing.Point(100, 3);
            this.ChoixDateFinContrat.Name = "ChoixDateFinContrat";
            this.ChoixDateFinContrat.Size = new System.Drawing.Size(108, 20);
            this.ChoixDateFinContrat.TabIndex = 10;
            // 
            // lblDateFinContrat
            // 
            this.lblDateFinContrat.AutoSize = true;
            this.lblDateFinContrat.Location = new System.Drawing.Point(3, 7);
            this.lblDateFinContrat.Name = "lblDateFinContrat";
            this.lblDateFinContrat.Size = new System.Drawing.Size(21, 13);
            this.lblDateFinContrat.TabIndex = 3;
            this.lblDateFinContrat.Text = "Fin";
            // 
            // lblTypeContrat
            // 
            this.lblTypeContrat.AutoSize = true;
            this.lblTypeContrat.BackColor = System.Drawing.Color.Transparent;
            this.lblTypeContrat.Location = new System.Drawing.Point(3, 6);
            this.lblTypeContrat.Name = "lblTypeContrat";
            this.lblTypeContrat.Size = new System.Drawing.Size(68, 13);
            this.lblTypeContrat.TabIndex = 15;
            this.lblTypeContrat.Text = "Type Contrat";
            // 
            // cBxTypeContrat
            // 
            this.cBxTypeContrat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cBxTypeContrat.FormattingEnabled = true;
            this.cBxTypeContrat.Location = new System.Drawing.Point(100, 3);
            this.cBxTypeContrat.Name = "cBxTypeContrat";
            this.cBxTypeContrat.Size = new System.Drawing.Size(121, 21);
            this.cBxTypeContrat.TabIndex = 0;
            // 
            // panelDate
            // 
            this.panelDate.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panelDate.BackColor = System.Drawing.Color.Transparent;
            this.panelDate.Controls.Add(this.lblDateFinContrat);
            this.panelDate.Controls.Add(this.ChoixDateFinContrat);
            this.panelDate.Location = new System.Drawing.Point(3, 375);
            this.panelDate.Name = "panelDate";
            this.panelDate.Size = new System.Drawing.Size(351, 28);
            this.panelDate.TabIndex = 17;
            // 
            // flowLayoutPanel2
            // 
            this.flowLayoutPanel2.AutoSize = true;
            this.flowLayoutPanel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.flowLayoutPanel2.Controls.Add(this.panelContratNumero);
            this.flowLayoutPanel2.Controls.Add(this.panelTypeContrat);
            this.flowLayoutPanel2.Controls.Add(this.panelLibelle);
            this.flowLayoutPanel2.Controls.Add(this.panelCadre);
            this.flowLayoutPanel2.Controls.Add(this.panelMotif);
            this.flowLayoutPanel2.Controls.Add(this.panelFonction);
            this.flowLayoutPanel2.Controls.Add(this.panelQualification);
            this.flowLayoutPanel2.Controls.Add(this.panelEcole);
            this.flowLayoutPanel2.Controls.Add(this.panelAgence);
            this.flowLayoutPanel2.Controls.Add(this.panelSalaire);
            this.flowLayoutPanel2.Controls.Add(this.panelDebut);
            this.flowLayoutPanel2.Controls.Add(this.panelDate);
            this.flowLayoutPanel2.Controls.Add(this.panelAvenant);
            this.flowLayoutPanel2.Controls.Add(this.panel3);
            this.flowLayoutPanel2.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel2.Location = new System.Drawing.Point(12, 12);
            this.flowLayoutPanel2.Name = "flowLayoutPanel2";
            this.flowLayoutPanel2.Size = new System.Drawing.Size(357, 601);
            this.flowLayoutPanel2.TabIndex = 20;
            // 
            // panelContratNumero
            // 
            this.panelContratNumero.Controls.Add(this.panel2);
            this.panelContratNumero.Controls.Add(this.lblNumContrat);
            this.panelContratNumero.Controls.Add(this.txBxNumeroContrat);
            this.panelContratNumero.Location = new System.Drawing.Point(3, 3);
            this.panelContratNumero.Name = "panelContratNumero";
            this.panelContratNumero.Size = new System.Drawing.Size(351, 26);
            this.panelContratNumero.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Location = new System.Drawing.Point(-3, 32);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(351, 31);
            this.panel2.TabIndex = 1;
            // 
            // panelTypeContrat
            // 
            this.panelTypeContrat.Controls.Add(this.cBxTypeContrat);
            this.panelTypeContrat.Controls.Add(this.lblTypeContrat);
            this.panelTypeContrat.Location = new System.Drawing.Point(3, 35);
            this.panelTypeContrat.Name = "panelTypeContrat";
            this.panelTypeContrat.Size = new System.Drawing.Size(351, 28);
            this.panelTypeContrat.TabIndex = 1;
            // 
            // panelLibelle
            // 
            this.panelLibelle.Controls.Add(this.tBxLibelle);
            this.panelLibelle.Controls.Add(this.lblLibelleContrat);
            this.panelLibelle.Location = new System.Drawing.Point(3, 69);
            this.panelLibelle.Name = "panelLibelle";
            this.panelLibelle.Size = new System.Drawing.Size(348, 28);
            this.panelLibelle.TabIndex = 28;
            // 
            // tBxLibelle
            // 
            this.tBxLibelle.Location = new System.Drawing.Point(100, 5);
            this.tBxLibelle.Name = "tBxLibelle";
            this.tBxLibelle.Size = new System.Drawing.Size(174, 20);
            this.tBxLibelle.TabIndex = 1;
            // 
            // lblLibelleContrat
            // 
            this.lblLibelleContrat.AutoSize = true;
            this.lblLibelleContrat.Location = new System.Drawing.Point(0, 8);
            this.lblLibelleContrat.Name = "lblLibelleContrat";
            this.lblLibelleContrat.Size = new System.Drawing.Size(37, 13);
            this.lblLibelleContrat.TabIndex = 0;
            this.lblLibelleContrat.Text = "Libellé";
            // 
            // panelCadre
            // 
            this.panelCadre.Controls.Add(this.gBxCadre);
            this.panelCadre.Controls.Add(this.lblCadre);
            this.panelCadre.Location = new System.Drawing.Point(3, 103);
            this.panelCadre.Name = "panelCadre";
            this.panelCadre.Size = new System.Drawing.Size(351, 40);
            this.panelCadre.TabIndex = 2;
            // 
            // panelMotif
            // 
            this.panelMotif.Controls.Add(this.tBxMotifContrat);
            this.panelMotif.Controls.Add(this.lblMotifContrat);
            this.panelMotif.Location = new System.Drawing.Point(3, 149);
            this.panelMotif.Name = "panelMotif";
            this.panelMotif.Size = new System.Drawing.Size(351, 26);
            this.panelMotif.TabIndex = 19;
            // 
            // tBxMotifContrat
            // 
            this.tBxMotifContrat.Location = new System.Drawing.Point(100, 3);
            this.tBxMotifContrat.Name = "tBxMotifContrat";
            this.tBxMotifContrat.Size = new System.Drawing.Size(174, 20);
            this.tBxMotifContrat.TabIndex = 3;
            // 
            // lblMotifContrat
            // 
            this.lblMotifContrat.AutoSize = true;
            this.lblMotifContrat.Location = new System.Drawing.Point(3, 6);
            this.lblMotifContrat.Name = "lblMotifContrat";
            this.lblMotifContrat.Size = new System.Drawing.Size(30, 13);
            this.lblMotifContrat.TabIndex = 0;
            this.lblMotifContrat.Text = "Motif";
            // 
            // panelFonction
            // 
            this.panelFonction.Controls.Add(this.tBxFonctionContrat);
            this.panelFonction.Controls.Add(this.lblFonctionContrat);
            this.panelFonction.Location = new System.Drawing.Point(3, 181);
            this.panelFonction.Name = "panelFonction";
            this.panelFonction.Size = new System.Drawing.Size(351, 27);
            this.panelFonction.TabIndex = 3;
            // 
            // panelQualification
            // 
            this.panelQualification.Controls.Add(this.tBxQualification);
            this.panelQualification.Controls.Add(this.lblQualificationContrat);
            this.panelQualification.Location = new System.Drawing.Point(3, 214);
            this.panelQualification.Name = "panelQualification";
            this.panelQualification.Size = new System.Drawing.Size(351, 23);
            this.panelQualification.TabIndex = 4;
            // 
            // panelEcole
            // 
            this.panelEcole.Controls.Add(this.tBxEcole);
            this.panelEcole.Controls.Add(this.lblEcole);
            this.panelEcole.Location = new System.Drawing.Point(3, 243);
            this.panelEcole.Name = "panelEcole";
            this.panelEcole.Size = new System.Drawing.Size(351, 26);
            this.panelEcole.TabIndex = 21;
            // 
            // tBxEcole
            // 
            this.tBxEcole.Location = new System.Drawing.Point(100, 3);
            this.tBxEcole.Name = "tBxEcole";
            this.tBxEcole.Size = new System.Drawing.Size(174, 20);
            this.tBxEcole.TabIndex = 6;
            // 
            // lblEcole
            // 
            this.lblEcole.AutoSize = true;
            this.lblEcole.Location = new System.Drawing.Point(3, 6);
            this.lblEcole.Name = "lblEcole";
            this.lblEcole.Size = new System.Drawing.Size(34, 13);
            this.lblEcole.TabIndex = 0;
            this.lblEcole.Text = "Ecole";
            // 
            // panelAgence
            // 
            this.panelAgence.Controls.Add(this.tBxAgence);
            this.panelAgence.Controls.Add(this.lblAgence);
            this.panelAgence.Location = new System.Drawing.Point(3, 275);
            this.panelAgence.Name = "panelAgence";
            this.panelAgence.Size = new System.Drawing.Size(351, 27);
            this.panelAgence.TabIndex = 22;
            // 
            // tBxAgence
            // 
            this.tBxAgence.Location = new System.Drawing.Point(100, 3);
            this.tBxAgence.Name = "tBxAgence";
            this.tBxAgence.Size = new System.Drawing.Size(174, 20);
            this.tBxAgence.TabIndex = 7;
            // 
            // lblAgence
            // 
            this.lblAgence.AutoSize = true;
            this.lblAgence.Location = new System.Drawing.Point(3, 6);
            this.lblAgence.Name = "lblAgence";
            this.lblAgence.Size = new System.Drawing.Size(44, 13);
            this.lblAgence.TabIndex = 0;
            this.lblAgence.Text = "Agence";
            // 
            // panelSalaire
            // 
            this.panelSalaire.Controls.Add(this.tBxSalaire);
            this.panelSalaire.Controls.Add(this.lblSalaire);
            this.panelSalaire.Location = new System.Drawing.Point(3, 308);
            this.panelSalaire.Name = "panelSalaire";
            this.panelSalaire.Size = new System.Drawing.Size(351, 28);
            this.panelSalaire.TabIndex = 23;
            // 
            // tBxSalaire
            // 
            this.tBxSalaire.Location = new System.Drawing.Point(100, 4);
            this.tBxSalaire.Name = "tBxSalaire";
            this.tBxSalaire.Size = new System.Drawing.Size(174, 20);
            this.tBxSalaire.TabIndex = 8;
            // 
            // lblSalaire
            // 
            this.lblSalaire.AutoSize = true;
            this.lblSalaire.Location = new System.Drawing.Point(3, 7);
            this.lblSalaire.Name = "lblSalaire";
            this.lblSalaire.Size = new System.Drawing.Size(39, 13);
            this.lblSalaire.TabIndex = 0;
            this.lblSalaire.Text = "Salaire";
            // 
            // panelDebut
            // 
            this.panelDebut.Controls.Add(this.label1);
            this.panelDebut.Controls.Add(this.choixDateDebutContrat);
            this.panelDebut.Location = new System.Drawing.Point(3, 342);
            this.panelDebut.Name = "panelDebut";
            this.panelDebut.Size = new System.Drawing.Size(351, 27);
            this.panelDebut.TabIndex = 18;
            // 
            // panelAvenant
            // 
            this.panelAvenant.Controls.Add(this.dgAvenant);
            this.panelAvenant.Location = new System.Drawing.Point(3, 409);
            this.panelAvenant.Name = "panelAvenant";
            this.panelAvenant.Size = new System.Drawing.Size(351, 154);
            this.panelAvenant.TabIndex = 26;
            // 
            // dgAvenant
            // 
            this.dgAvenant.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAvenant.Location = new System.Drawing.Point(3, 5);
            this.dgAvenant.Name = "dgAvenant";
            this.dgAvenant.Size = new System.Drawing.Size(271, 146);
            this.dgAvenant.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnValiderContrat);
            this.panel3.Controls.Add(this.btnAnnuler);
            this.panel3.Location = new System.Drawing.Point(3, 569);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(282, 29);
            this.panel3.TabIndex = 27;
            // 
            // btnValiderContrat
            // 
            this.btnValiderContrat.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnValiderContrat.Location = new System.Drawing.Point(6, 3);
            this.btnValiderContrat.Name = "btnValiderContrat";
            this.btnValiderContrat.Size = new System.Drawing.Size(75, 23);
            this.btnValiderContrat.TabIndex = 11;
            this.btnValiderContrat.Text = "Valider";
            this.btnValiderContrat.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAnnuler.Location = new System.Drawing.Point(96, 3);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(75, 23);
            this.btnAnnuler.TabIndex = 25;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // errorProviderContrat
            // 
            this.errorProviderContrat.ContainerControl = this;
            // 
            // frmContrat
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(306, 614);
            this.Controls.Add(this.flowLayoutPanel2);
            this.Name = "frmContrat";
            this.Text = "frmContrat";
            this.gBxCadre.ResumeLayout(false);
            this.gBxCadre.PerformLayout();
            this.panelDate.ResumeLayout(false);
            this.panelDate.PerformLayout();
            this.flowLayoutPanel2.ResumeLayout(false);
            this.panelContratNumero.ResumeLayout(false);
            this.panelContratNumero.PerformLayout();
            this.panelTypeContrat.ResumeLayout(false);
            this.panelTypeContrat.PerformLayout();
            this.panelLibelle.ResumeLayout(false);
            this.panelLibelle.PerformLayout();
            this.panelCadre.ResumeLayout(false);
            this.panelCadre.PerformLayout();
            this.panelMotif.ResumeLayout(false);
            this.panelMotif.PerformLayout();
            this.panelFonction.ResumeLayout(false);
            this.panelFonction.PerformLayout();
            this.panelQualification.ResumeLayout(false);
            this.panelQualification.PerformLayout();
            this.panelEcole.ResumeLayout(false);
            this.panelEcole.PerformLayout();
            this.panelAgence.ResumeLayout(false);
            this.panelAgence.PerformLayout();
            this.panelSalaire.ResumeLayout(false);
            this.panelSalaire.PerformLayout();
            this.panelDebut.ResumeLayout(false);
            this.panelDebut.PerformLayout();
            this.panelAvenant.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgAvenant)).EndInit();
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderContrat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNumContrat;
        private System.Windows.Forms.Label lblCadre;
        private System.Windows.Forms.Label lblFonctionContrat;
        private System.Windows.Forms.Label lblQualificationContrat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTypeContrat;
        internal System.Windows.Forms.ComboBox cBxTypeContrat;
        internal System.Windows.Forms.Label lblDateFinContrat;
        internal System.Windows.Forms.DateTimePicker ChoixDateFinContrat;
        internal System.Windows.Forms.Panel panelDate;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel2;
        private System.Windows.Forms.Panel panelContratNumero;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panelTypeContrat;
        internal System.Windows.Forms.TextBox txBxNumeroContrat;
        internal System.Windows.Forms.GroupBox gBxCadre;
        internal System.Windows.Forms.TextBox tBxFonctionContrat;
        internal System.Windows.Forms.TextBox tBxQualification;
        internal System.Windows.Forms.DateTimePicker choixDateDebutContrat;
        internal System.Windows.Forms.RadioButton rbtCadreNon;
        internal System.Windows.Forms.RadioButton rbtCadreOui;
        internal System.Windows.Forms.TextBox tBxMotifContrat;
        private System.Windows.Forms.Label lblMotifContrat;
        internal System.Windows.Forms.Panel panelMotif;
        internal System.Windows.Forms.Panel panelEcole;
        internal System.Windows.Forms.TextBox tBxEcole;
        private System.Windows.Forms.Label lblEcole;
        private System.Windows.Forms.Label lblAgence;
        internal System.Windows.Forms.TextBox tBxAgence;
        internal System.Windows.Forms.TextBox tBxSalaire;
        private System.Windows.Forms.Label lblSalaire;
        internal System.Windows.Forms.Panel panelAgence;
        internal System.Windows.Forms.Button btnValiderContrat;
        internal System.Windows.Forms.Button btnAnnuler;
        private System.Windows.Forms.NotifyIcon notifyIcon1;
        internal System.Windows.Forms.Panel panelAvenant;
        private System.Windows.Forms.Panel panel3;
        internal System.Windows.Forms.TextBox tBxLibelle;
        private System.Windows.Forms.Label lblLibelleContrat;
        internal System.Windows.Forms.Panel panelSalaire;
        internal System.Windows.Forms.ErrorProvider errorProviderContrat;
        internal System.Windows.Forms.DataGridView dgAvenant;
        internal System.Windows.Forms.Panel panelCadre;
        internal System.Windows.Forms.Panel panelFonction;
        internal System.Windows.Forms.Panel panelQualification;
        internal System.Windows.Forms.Panel panelLibelle;
        internal System.Windows.Forms.Panel panelDebut;
    }
}