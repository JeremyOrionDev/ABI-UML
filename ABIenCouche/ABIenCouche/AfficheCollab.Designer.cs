namespace ABIenCouche
{
    partial class frmDspCollaborateur
    {
        /// <summary>
        /// Variable nécessaire au concepteur.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Nettoyage des ressources utilisées.
        /// </summary>
        /// <param name="disposing">true si les ressources managées doivent être supprimées ; sinon, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Code généré par le Concepteur Windows Form

        /// <summary>
        /// Méthode requise pour la prise en charge du concepteur - ne modifiez pas
        /// le contenu de cette méthode avec l'éditeur de code.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.contextMenuStrip2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.dgCollabo = new System.Windows.Forms.DataGridView();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnArchiver = new System.Windows.Forms.Button();
            this.btnQuitter = new System.Windows.Forms.Button();
            this.tBxRechercher = new System.Windows.Forms.TextBox();
            this.cBxRechercheCollab = new System.Windows.Forms.ComboBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.btnAnnulerRecherche = new System.Windows.Forms.Button();
            this.btnVoirArchive = new System.Windows.Forms.Button();
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.dgCollabo)).BeginInit();
            this.flowLayoutPanel1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            this.contextMenuStrip2.Name = "contextMenuStrip2";
            this.contextMenuStrip2.Size = new System.Drawing.Size(61, 4);
            // 
            // dgCollabo
            // 
            this.dgCollabo.AllowUserToAddRows = false;
            this.dgCollabo.AllowUserToDeleteRows = false;
            this.dgCollabo.AllowUserToOrderColumns = true;
            this.dgCollabo.AllowUserToResizeColumns = false;
            this.dgCollabo.AllowUserToResizeRows = false;
            this.dgCollabo.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgCollabo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgCollabo.Location = new System.Drawing.Point(3, 3);
            this.dgCollabo.MultiSelect = false;
            this.dgCollabo.Name = "dgCollabo";
            this.dgCollabo.ReadOnly = true;
            this.dgCollabo.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgCollabo.RowHeadersVisible = false;
            this.dgCollabo.RowHeadersWidth = 20;
            this.dgCollabo.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgCollabo.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgCollabo.ShowEditingIcon = false;
            this.dgCollabo.Size = new System.Drawing.Size(566, 401);
            this.dgCollabo.TabIndex = 5;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(370, 5);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(75, 23);
            this.btnAjouter.TabIndex = 6;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            // 
            // btnArchiver
            // 
            this.btnArchiver.Enabled = false;
            this.btnArchiver.Location = new System.Drawing.Point(289, 5);
            this.btnArchiver.Name = "btnArchiver";
            this.btnArchiver.Size = new System.Drawing.Size(75, 23);
            this.btnArchiver.TabIndex = 7;
            this.btnArchiver.Text = "Ar&chiver";
            this.btnArchiver.UseVisualStyleBackColor = true;
            // 
            // btnQuitter
            // 
            this.btnQuitter.Location = new System.Drawing.Point(451, 5);
            this.btnQuitter.Name = "btnQuitter";
            this.btnQuitter.Size = new System.Drawing.Size(75, 23);
            this.btnQuitter.TabIndex = 8;
            this.btnQuitter.Text = "&Quitter";
            this.btnQuitter.UseVisualStyleBackColor = true;
            // 
            // tBxRechercher
            // 
            this.tBxRechercher.Location = new System.Drawing.Point(108, 6);
            this.tBxRechercher.Name = "tBxRechercher";
            this.tBxRechercher.Size = new System.Drawing.Size(175, 20);
            this.tBxRechercher.TabIndex = 9;
            // 
            // cBxRechercheCollab
            // 
            this.cBxRechercheCollab.FormattingEnabled = true;
            this.cBxRechercheCollab.Location = new System.Drawing.Point(3, 5);
            this.cBxRechercheCollab.Name = "cBxRechercheCollab";
            this.cBxRechercheCollab.Size = new System.Drawing.Size(99, 21);
            this.cBxRechercheCollab.TabIndex = 10;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(289, 4);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(75, 23);
            this.btnRechercher.TabIndex = 11;
            this.btnRechercher.Text = "&Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            // 
            // btnAnnulerRecherche
            // 
            this.btnAnnulerRecherche.Location = new System.Drawing.Point(370, 4);
            this.btnAnnulerRecherche.Name = "btnAnnulerRecherche";
            this.btnAnnulerRecherche.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulerRecherche.TabIndex = 12;
            this.btnAnnulerRecherche.Text = "A&nnuler";
            this.btnAnnulerRecherche.UseVisualStyleBackColor = true;
            // 
            // btnVoirArchive
            // 
            this.btnVoirArchive.AutoSize = true;
            this.btnVoirArchive.Location = new System.Drawing.Point(3, 5);
            this.btnVoirArchive.Name = "btnVoirArchive";
            this.btnVoirArchive.Size = new System.Drawing.Size(79, 23);
            this.btnVoirArchive.TabIndex = 13;
            this.btnVoirArchive.Text = "&Voir Archives";
            this.btnVoirArchive.UseVisualStyleBackColor = true;
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoSize = true;
            this.flowLayoutPanel1.Controls.Add(this.panel1);
            this.flowLayoutPanel1.Controls.Add(this.panel2);
            this.flowLayoutPanel1.Controls.Add(this.panel3);
            this.flowLayoutPanel1.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(12, 31);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(612, 495);
            this.flowLayoutPanel1.TabIndex = 14;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cBxRechercheCollab);
            this.panel1.Controls.Add(this.tBxRechercher);
            this.panel1.Controls.Add(this.btnRechercher);
            this.panel1.Controls.Add(this.btnAnnulerRecherche);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 33);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.AutoSize = true;
            this.panel2.Controls.Add(this.dgCollabo);
            this.panel2.Location = new System.Drawing.Point(3, 42);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(572, 407);
            this.panel2.TabIndex = 1;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnVoirArchive);
            this.panel3.Controls.Add(this.btnAjouter);
            this.panel3.Controls.Add(this.btnArchiver);
            this.panel3.Controls.Add(this.btnQuitter);
            this.panel3.Location = new System.Drawing.Point(3, 455);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(583, 35);
            this.panel3.TabIndex = 2;
            // 
            // frmDspCollaborateur
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(659, 632);
            this.ControlBox = false;
            this.Controls.Add(this.flowLayoutPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MinimizeBox = false;
            this.Name = "frmDspCollaborateur";
            this.Text = "Affichage des Collaborateurs au projet";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.dgCollabo)).EndInit();
            this.flowLayoutPanel1.ResumeLayout(false);
            this.flowLayoutPanel1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip2;
        internal System.Windows.Forms.DataGridView dgCollabo;
        internal System.Windows.Forms.Button btnAjouter;
        internal System.Windows.Forms.Button btnArchiver;
        internal System.Windows.Forms.Button btnQuitter;
        internal System.Windows.Forms.TextBox tBxRechercher;
        internal System.Windows.Forms.ComboBox cBxRechercheCollab;
        internal System.Windows.Forms.Button btnRechercher;
        internal System.Windows.Forms.Button btnAnnulerRecherche;
        public System.Windows.Forms.Button btnVoirArchive;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}

