namespace ABIenCouche
{
    partial class frmNouveauCollab
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
            this.btnAnnulerNvColab = new System.Windows.Forms.Button();
            this.btnOKNvColab = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnAnnulerNvColab
            // 
            this.btnAnnulerNvColab.Location = new System.Drawing.Point(255, 575);
            this.btnAnnulerNvColab.Name = "btnAnnulerNvColab";
            this.btnAnnulerNvColab.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulerNvColab.TabIndex = 15;
            this.btnAnnulerNvColab.Text = "Annuler";
            this.btnAnnulerNvColab.UseVisualStyleBackColor = true;
            // 
            // btnOKNvColab
            // 
            this.btnOKNvColab.Location = new System.Drawing.Point(174, 575);
            this.btnOKNvColab.Name = "btnOKNvColab";
            this.btnOKNvColab.Size = new System.Drawing.Size(75, 23);
            this.btnOKNvColab.TabIndex = 14;
            this.btnOKNvColab.Text = "OK";
            this.btnOKNvColab.UseVisualStyleBackColor = true;
            // 
            // frmNouveauCollab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(342, 607);
            this.Controls.Add(this.btnOKNvColab);
            this.Controls.Add(this.btnAnnulerNvColab);
            this.Name = "frmNouveauCollab";
            this.Text = "frmNouveauCollab";
            this.Controls.SetChildIndex(this.btnAnnulerNvColab, 0);
            this.Controls.SetChildIndex(this.btnOKNvColab, 0);
            this.ResumeLayout(false);

        }

        #endregion
        internal System.Windows.Forms.Button btnOKNvColab;
        internal System.Windows.Forms.Button btnAnnulerNvColab;
    }
}