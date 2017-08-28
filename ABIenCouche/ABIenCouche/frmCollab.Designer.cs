namespace ABIenCouche
{
    partial class frmCollab
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
            this.txtBoxAdresseCollab = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxMatriculeCollab = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxPrenomCollab = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxNomCollab = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtBoxAdresseCollab
            // 
            this.txtBoxAdresseCollab.Location = new System.Drawing.Point(76, 92);
            this.txtBoxAdresseCollab.Multiline = true;
            this.txtBoxAdresseCollab.Name = "txtBoxAdresseCollab";
            this.txtBoxAdresseCollab.Size = new System.Drawing.Size(221, 45);
            this.txtBoxAdresseCollab.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "Adresse";
            // 
            // txtBoxMatriculeCollab
            // 
            this.txtBoxMatriculeCollab.Enabled = false;
            this.txtBoxMatriculeCollab.Location = new System.Drawing.Point(76, 12);
            this.txtBoxMatriculeCollab.Name = "txtBoxMatriculeCollab";
            this.txtBoxMatriculeCollab.Size = new System.Drawing.Size(221, 20);
            this.txtBoxMatriculeCollab.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 12);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(56, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Matricule :";
            // 
            // txtBoxPrenomCollab
            // 
            this.txtBoxPrenomCollab.Location = new System.Drawing.Point(76, 66);
            this.txtBoxPrenomCollab.Name = "txtBoxPrenomCollab";
            this.txtBoxPrenomCollab.Size = new System.Drawing.Size(221, 20);
            this.txtBoxPrenomCollab.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 69);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 10;
            this.label2.Text = "Prénom: ";
            // 
            // txtBoxNomCollab
            // 
            this.txtBoxNomCollab.Location = new System.Drawing.Point(76, 39);
            this.txtBoxNomCollab.Name = "txtBoxNomCollab";
            this.txtBoxNomCollab.Size = new System.Drawing.Size(221, 20);
            this.txtBoxNomCollab.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Nom: ";
            // 
            // frmCollab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 261);
            this.Controls.Add(this.txtBoxAdresseCollab);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtBoxMatriculeCollab);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBoxPrenomCollab);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtBoxNomCollab);
            this.Controls.Add(this.label1);
            this.Name = "frmCollab";
            this.Text = "frmCollab";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.TextBox txtBoxAdresseCollab;
        protected System.Windows.Forms.TextBox txtBoxMatriculeCollab;
        protected System.Windows.Forms.TextBox txtBoxPrenomCollab;
        protected System.Windows.Forms.TextBox txtBoxNomCollab;
    }
}