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
            this.lblSalaireContratCDI = new System.Windows.Forms.Label();
            this.tBxSalaireCDI = new System.Windows.Forms.TextBox();
            this.btnContratCDI = new System.Windows.Forms.Button();
            this.btnAnnulerContratCDI = new System.Windows.Forms.Button();
            this.gBxContratPhoto = new System.Windows.Forms.GroupBox();
            this.pictureBoxPhotoContrat = new System.Windows.Forms.PictureBox();
            this.txtBxAdressePhotoContrat = new System.Windows.Forms.TextBox();
            this.btnContratParcourir = new System.Windows.Forms.Button();
            this.openFileDialogPhotoContrat = new System.Windows.Forms.OpenFileDialog();
            this.gBxContratPhoto.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhotoContrat)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSalaireContratCDI
            // 
            this.lblSalaireContratCDI.AutoSize = true;
            this.lblSalaireContratCDI.Location = new System.Drawing.Point(16, 271);
            this.lblSalaireContratCDI.Name = "lblSalaireContratCDI";
            this.lblSalaireContratCDI.Size = new System.Drawing.Size(39, 13);
            this.lblSalaireContratCDI.TabIndex = 14;
            this.lblSalaireContratCDI.Text = "Salaire";
            // 
            // tBxSalaireCDI
            // 
            this.tBxSalaireCDI.Location = new System.Drawing.Point(103, 268);
            this.tBxSalaireCDI.Name = "tBxSalaireCDI";
            this.tBxSalaireCDI.Size = new System.Drawing.Size(217, 20);
            this.tBxSalaireCDI.TabIndex = 15;
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
            // gBxContratPhoto
            // 
            this.gBxContratPhoto.Controls.Add(this.pictureBoxPhotoContrat);
            this.gBxContratPhoto.Controls.Add(this.txtBxAdressePhotoContrat);
            this.gBxContratPhoto.Controls.Add(this.btnContratParcourir);
            this.gBxContratPhoto.Location = new System.Drawing.Point(12, 405);
            this.gBxContratPhoto.Name = "gBxContratPhoto";
            this.gBxContratPhoto.Size = new System.Drawing.Size(294, 145);
            this.gBxContratPhoto.TabIndex = 18;
            this.gBxContratPhoto.TabStop = false;
            this.gBxContratPhoto.Text = "Photo";
            // 
            // pictureBoxPhotoContrat
            // 
            this.pictureBoxPhotoContrat.Location = new System.Drawing.Point(39, 61);
            this.pictureBoxPhotoContrat.Name = "pictureBoxPhotoContrat";
            this.pictureBoxPhotoContrat.Size = new System.Drawing.Size(84, 72);
            this.pictureBoxPhotoContrat.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBoxPhotoContrat.TabIndex = 2;
            this.pictureBoxPhotoContrat.TabStop = false;
            // 
            // txtBxAdressePhotoContrat
            // 
            this.txtBxAdressePhotoContrat.Location = new System.Drawing.Point(29, 22);
            this.txtBxAdressePhotoContrat.Name = "txtBxAdressePhotoContrat";
            this.txtBxAdressePhotoContrat.Size = new System.Drawing.Size(179, 20);
            this.txtBxAdressePhotoContrat.TabIndex = 1;
            // 
            // btnContratParcourir
            // 
            this.btnContratParcourir.Location = new System.Drawing.Point(213, 19);
            this.btnContratParcourir.Name = "btnContratParcourir";
            this.btnContratParcourir.Size = new System.Drawing.Size(75, 23);
            this.btnContratParcourir.TabIndex = 0;
            this.btnContratParcourir.Text = "Parcourir";
            this.btnContratParcourir.UseVisualStyleBackColor = true;
            this.btnContratParcourir.Click += new System.EventHandler(this.btnContratParcourir_Click);
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
            this.Controls.Add(this.gBxContratPhoto);
            this.Controls.Add(this.btnAnnulerContratCDI);
            this.Controls.Add(this.btnContratCDI);
            this.Controls.Add(this.tBxSalaireCDI);
            this.Controls.Add(this.lblSalaireContratCDI);
            this.Name = "frmContratCDI";
            this.Text = "frmContratCDI";
            this.Controls.SetChildIndex(this.lblSalaireContratCDI, 0);
            this.Controls.SetChildIndex(this.tBxSalaireCDI, 0);
            this.Controls.SetChildIndex(this.btnContratCDI, 0);
            this.Controls.SetChildIndex(this.btnAnnulerContratCDI, 0);
            this.Controls.SetChildIndex(this.gBxContratPhoto, 0);
            this.gBxContratPhoto.ResumeLayout(false);
            this.gBxContratPhoto.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxPhotoContrat)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSalaireContratCDI;
        private System.Windows.Forms.TextBox tBxSalaireCDI;
        private System.Windows.Forms.Button btnContratCDI;
        private System.Windows.Forms.Button btnAnnulerContratCDI;
        private System.Windows.Forms.GroupBox gBxContratPhoto;
        private System.Windows.Forms.TextBox txtBxAdressePhotoContrat;
        private System.Windows.Forms.Button btnContratParcourir;
        private System.Windows.Forms.OpenFileDialog openFileDialogPhotoContrat;
        private System.Windows.Forms.PictureBox pictureBoxPhotoContrat;
    }
}