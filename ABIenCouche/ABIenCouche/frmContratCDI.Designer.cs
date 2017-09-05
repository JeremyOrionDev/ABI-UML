namespace ABIenCouche
{
    partial class frmContratCDI
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
            this.btnContratCDI = new System.Windows.Forms.Button();
            this.btnAnnulerContratCDI = new System.Windows.Forms.Button();
            this.openFileDialogPhotoContrat = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // btnContratCDI
            // 
            this.btnContratCDI.Location = new System.Drawing.Point(151, 572);
            this.btnContratCDI.Name = "btnContratCDI";
            this.btnContratCDI.Size = new System.Drawing.Size(75, 23);
            this.btnContratCDI.TabIndex = 16;
            this.btnContratCDI.Text = "Valider";
            this.btnContratCDI.UseVisualStyleBackColor = true;
            // 
            // btnAnnulerContratCDI
            // 
            this.btnAnnulerContratCDI.Location = new System.Drawing.Point(232, 572);
            this.btnAnnulerContratCDI.Name = "btnAnnulerContratCDI";
            this.btnAnnulerContratCDI.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulerContratCDI.TabIndex = 17;
            this.btnAnnulerContratCDI.Text = "Annuler";
            this.btnAnnulerContratCDI.UseVisualStyleBackColor = true;
            // 
            // openFileDialogPhotoContrat
            // 
            this.openFileDialogPhotoContrat.FileName = "openFileDialogPhotoContrat";
            // 
            // frmContratCDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(337, 667);
            this.Controls.Add(this.btnAnnulerContratCDI);
            this.Controls.Add(this.btnContratCDI);
            this.Name = "frmContratCDI";
            this.Text = "frmContratCDI";
            this.Controls.SetChildIndex(this.btnContratCDI, 0);
            this.Controls.SetChildIndex(this.btnAnnulerContratCDI, 0);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.OpenFileDialog openFileDialogPhotoContrat;
        internal System.Windows.Forms.Button btnContratCDI;
        internal System.Windows.Forms.Button btnAnnulerContratCDI;
    }
}