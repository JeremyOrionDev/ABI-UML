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
            this.dgContrats.Size = new System.Drawing.Size(377, 243);
            this.dgContrats.TabIndex = 22;
            // 
            // btnAjouterContrat
            // 
            this.btnAjouterContrat.AutoSize = true;
            this.btnAjouterContrat.Location = new System.Drawing.Point(3, 255);
            this.btnAjouterContrat.Name = "btnAjouterContrat";
            this.btnAjouterContrat.Size = new System.Drawing.Size(113, 27);
            this.btnAjouterContrat.TabIndex = 23;
            this.btnAjouterContrat.Text = "A&jouter Contrat";
            this.btnAjouterContrat.UseVisualStyleBackColor = true;
            // 
            // panelContrat
            // 
            this.panelContrat.AutoSize = true;
            this.panelContrat.Controls.Add(this.dgContrats);
            this.panelContrat.Controls.Add(this.btnAjouterContrat);
            this.panelContrat.Location = new System.Drawing.Point(362, 12);
            this.panelContrat.Name = "panelContrat";
            this.panelContrat.Size = new System.Drawing.Size(383, 285);
            this.panelContrat.TabIndex = 25;
            // 
            // panelDGAugmentation
            // 
            this.panelDGAugmentation.Controls.Add(this.btnAjouterAugmentation);
            this.panelDGAugmentation.Controls.Add(this.dgAugmentation);
            this.panelDGAugmentation.Location = new System.Drawing.Point(362, 303);
            this.panelDGAugmentation.Name = "panelDGAugmentation";
            this.panelDGAugmentation.Size = new System.Drawing.Size(380, 139);
            this.panelDGAugmentation.TabIndex = 26;
            // 
            // btnAjouterAugmentation
            // 
            this.btnAjouterAugmentation.Location = new System.Drawing.Point(3, 103);
            this.btnAjouterAugmentation.Name = "btnAjouterAugmentation";
            this.btnAjouterAugmentation.Size = new System.Drawing.Size(75, 23);
            this.btnAjouterAugmentation.TabIndex = 1;
            this.btnAjouterAugmentation.Text = "Ajou&ter";
            this.btnAjouterAugmentation.UseVisualStyleBackColor = true;
            // 
            // dgAugmentation
            // 
            this.dgAugmentation.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgAugmentation.Location = new System.Drawing.Point(3, 0);
            this.dgAugmentation.Name = "dgAugmentation";
            this.dgAugmentation.Size = new System.Drawing.Size(374, 97);
            this.dgAugmentation.TabIndex = 0;
            // 
            // frmAfficheCollab
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(748, 445);
            this.Controls.Add(this.panelDGAugmentation);
            this.Controls.Add(this.panelContrat);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "frmAfficheCollab";
            this.Text = "frmAfficheCollab";
            this.Controls.SetChildIndex(this.panelContrat, 0);
            this.Controls.SetChildIndex(this.panelDGAugmentation, 0);
            ((System.ComponentModel.ISupportInitialize)(this.dgContrats)).EndInit();
            this.panelContrat.ResumeLayout(false);
            this.panelContrat.PerformLayout();
            this.panelDGAugmentation.ResumeLayout(false);
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
    }
}