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
            this.btnAnnulerNvColab.Location = new System.Drawing.Point(222, 217);
            this.btnAnnulerNvColab.Name = "btnAnnulerNvColab";
            this.btnAnnulerNvColab.Size = new System.Drawing.Size(75, 23);
            this.btnAnnulerNvColab.TabIndex = 16;
            this.btnAnnulerNvColab.Text = "Annuler";
            this.btnAnnulerNvColab.UseVisualStyleBackColor = true;
            this.btnAnnulerNvColab.Click += new System.EventHandler(this.btnAnnulerNvColab_Click);
            // 
            // btnOKNvColab
            // 
            this.btnOKNvColab.Location = new System.Drawing.Point(141, 217);
            this.btnOKNvColab.Name = "btnOKNvColab";
            this.btnOKNvColab.Size = new System.Drawing.Size(75, 23);
            this.btnOKNvColab.TabIndex = 17;
            this.btnOKNvColab.Text = "OK";
            this.btnOKNvColab.UseVisualStyleBackColor = true;
            this.btnOKNvColab.Click += new System.EventHandler(this.btnOKNvColab_Click);
            // 
            // frmNouveauCollab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 261);
            this.Controls.Add(this.btnOKNvColab);
            this.Controls.Add(this.btnAnnulerNvColab);
            this.Name = "frmNouveauCollab";
            this.Text = "frmNouveauCollab";
            this.Controls.SetChildIndex(this.txtBoxNomCollab, 0);
            this.Controls.SetChildIndex(this.txtBoxPrenomCollab, 0);
            this.Controls.SetChildIndex(this.txtBoxMatriculeCollab, 0);
            this.Controls.SetChildIndex(this.txtBoxRueCollab, 0);
            this.Controls.SetChildIndex(this.txtBxCP, 0);
            this.Controls.SetChildIndex(this.txtBxVille, 0);
            this.Controls.SetChildIndex(this.btnAnnulerNvColab, 0);
            this.Controls.SetChildIndex(this.btnOKNvColab, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnAnnulerNvColab;
        private System.Windows.Forms.Button btnOKNvColab;
    }
}