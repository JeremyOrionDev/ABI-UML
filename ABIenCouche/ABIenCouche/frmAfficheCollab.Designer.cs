namespace ABIenCouche
{
    partial class frmAfficheCollab
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
            this.dgContrats = new System.Windows.Forms.DataGridView();
            this.btnAjouterContrat = new System.Windows.Forms.Button();
            this.panelContrat = new System.Windows.Forms.Panel();
            this.panelDGAugmentation = new System.Windows.Forms.Panel();
            this.btnAjouterAugmentation = new System.Windows.Forms.Button();
            this.dgAugmentation = new System.Windows.Forms.DataGridView();
            this.lblAugmentations = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.splitter1 = new System.Windows.Forms.Splitter();
            ((System.ComponentModel.ISupportInitialize)(this.dgContrats)).BeginInit();
            this.panelContrat.SuspendLayout();
            this.panelDGAugmentation.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAugmentation)).BeginInit();
            this.SuspendLayout();
            // 
            // dgContrats
            // 
            this.dgContrats.AllowUserToAddRows = false;
            this.dgContrats.AllowUserToDeleteRows = false;
            this.dgContrats.AllowUserToResizeColumns = false;
            this.dgContrats.AllowUserToResizeRows = false;
            this.dgContrats.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.dgContrats.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dgContrats.Location = new System.Drawing.Point(3, 6);
            this.dgContrats.MultiSelect = false;
            this.dgContrats.Name = "dgContrats";
            this.dgContrats.ReadOnly = true;
            this.dgContrats.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dgContrats.RowTemplate.Height = 24;
            this.dgContrats.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgContrats.ShowEditingIcon = false;
            this.dgContrats.Size = new System.Drawing.Size(377, 209);
            this.dgContrats.TabIndex = 22;
            // 
            // btnAjouterContrat
            // 
            this.btnAjouterContrat.AutoSize = true;
            this.btnAjouterContrat.Location = new System.Drawing.Point(0, 221);
            this.btnAjouterContrat.Name = "btnAjouterContrat";
            this.btnAjouterContrat.Size = new System.Drawing.Size(113, 27);
            this.btnAjouterContrat.TabIndex = 23;
            this.btnAjouterContrat.Text = "A&jouter Contrat";
            this.btnAjouterContrat.UseVisualStyleBackColor = true;
            // 
            // panelContrat
            // 
            this.panelContrat.AutoSize = true;
            this.panelContrat.Controls.Add(this.label1);
            this.panelContrat.Controls.Add(this.dgContrats);
            this.panelContrat.Controls.Add(this.btnAjouterContrat);
            this.panelContrat.Location = new System.Drawing.Point(422, 5);
            this.panelContrat.Name = "panelContrat";
            this.panelContrat.Size = new System.Drawing.Size(383, 399);
            this.panelContrat.TabIndex = 25;
            // 
            // panelDGAugmentation
            // 
            this.panelDGAugmentation.Controls.Add(this.lblAugmentations);
            this.panelDGAugmentation.Controls.Add(this.btnAjouterAugmentation);
            this.panelDGAugmentation.Controls.Add(this.dgAugmentation);
            this.panelDGAugmentation.Location = new System.Drawing.Point(419, 259);
            this.panelDGAugmentation.Name = "panelDGAugmentation";
            this.panelDGAugmentation.Size = new System.Drawing.Size(383, 145);
            this.panelDGAugmentation.TabIndex = 26;
            // 
            // btnAjouterAugmentation
            // 
            this.btnAjouterAugmentation.Location = new System.Drawing.Point(3, 122);
            this.btnAjouterAugmentation.Name = "btnAjouterAugmentation";
            this.btnAjouterAugmentation.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterAugmentation.TabIndex = 1;
            this.btnAjouterAugmentation.Text = "Ajou&ter";
            this.btnAjouterAugmentation.UseVisualStyleBackColor = true;
            // 
            // dgAugmentation
            // 
            this.dgAugmentation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAugmentation.Location = new System.Drawing.Point(6, 19);
            this.dgAugmentation.Name = "dgAugmentation";
            this.dgAugmentation.Size = new System.Drawing.Size(374, 97);
            this.dgAugmentation.TabIndex = 0;
            // 
            // lblAugmentations
            // 
            this.lblAugmentations.AutoSize = true;
            this.lblAugmentations.Location = new System.Drawing.Point(3, 3);
            this.lblAugmentations.Name = "lblAugmentations";
            this.lblAugmentations.Size = new System.Drawing.Size(102, 13);
            this.lblAugmentations.TabIndex = 2;
            this.lblAugmentations.Text = "Liste Augmentations";
            // 
            // label1
            // 
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Location = new System.Drawing.Point(-19, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(10, 392);
            this.label1.TabIndex = 28;
            // 
            // splitter1
            // 
            this.splitter1.Location = new System.Drawing.Point(0, 0);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(13, 407);
            this.splitter1.TabIndex = 27;
            this.splitter1.TabStop = false;
            // 
            // frmAfficheCollab
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(808, 407);
            this.Controls.Add(this.splitter1);
            this.Controls.Add(this.panelDGAugmentation);
            this.Controls.Add(this.panelContrat);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmAfficheCollab";
            this.Text = "frmAfficheCollab";
            this.Controls.SetChildIndex(this.panelContrat, 0);
            this.Controls.SetChildIndex(this.panelDGAugmentation, 0);
            this.Controls.SetChildIndex(this.splitter1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgContrats)).EndInit();
            this.panelContrat.ResumeLayout(false);
            this.panelContrat.PerformLayout();
            this.panelDGAugmentation.ResumeLayout(false);
            this.panelDGAugmentation.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgAugmentation)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        internal System.Windows.Forms.Button btnAjouterContrat;
        internal System.Windows.Forms.Panel panelContrat;
        internal System.Windows.Forms.DataGridView dgContrats;
        internal System.Windows.Forms.Panel panelDGAugmentation;
        internal System.Windows.Forms.DataGridView dgAugmentation;
        internal System.Windows.Forms.Button btnAjouterAugmentation;
        private System.Windows.Forms.Label lblAugmentations;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Splitter splitter1;
    }
}