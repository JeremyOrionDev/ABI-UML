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
            this.txtBoxRueCollab = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtBoxMatriculeCollab = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtBoxPrenomCollab = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtBoxNomCollab = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lblCP = new System.Windows.Forms.Label();
            this.txtBxCP = new System.Windows.Forms.TextBox();
            this.lblVille = new System.Windows.Forms.Label();
            this.txtBxVille = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtBoxRueCollab
            // 
            this.txtBoxRueCollab.Location = new System.Drawing.Point(76, 92);
            this.txtBoxRueCollab.Name = "txtBoxRueCollab";
            this.txtBoxRueCollab.Size = new System.Drawing.Size(221, 20);
            this.txtBoxRueCollab.TabIndex = 15;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 95);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(25, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "rue ";
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
            // lblCP
            // 
            this.lblCP.AutoSize = true;
            this.lblCP.Location = new System.Drawing.Point(12, 121);
            this.lblCP.Name = "lblCP";
            this.lblCP.Size = new System.Drawing.Size(62, 13);
            this.lblCP.TabIndex = 14;
            this.lblCP.Text = "code postal";
            // 
            // txtBxCP
            // 
            this.txtBxCP.Location = new System.Drawing.Point(76, 118);
            this.txtBxCP.Name = "txtBxCP";
            this.txtBxCP.Size = new System.Drawing.Size(221, 20);
            this.txtBxCP.TabIndex = 15;
            // 
            // lblVille
            // 
            this.lblVille.AutoSize = true;
            this.lblVille.Location = new System.Drawing.Point(12, 147);
            this.lblVille.Name = "lblVille";
            this.lblVille.Size = new System.Drawing.Size(26, 13);
            this.lblVille.TabIndex = 14;
            this.lblVille.Text = "Ville";
            // 
            // txtBxVille
            // 
            this.txtBxVille.Location = new System.Drawing.Point(76, 144);
            this.txtBxVille.Name = "txtBxVille";
            this.txtBxVille.Size = new System.Drawing.Size(221, 20);
            this.txtBxVille.TabIndex = 15;
            // 
            // frmCollab
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(309, 261);
            this.Controls.Add(this.txtBxVille);
            this.Controls.Add(this.lblVille);
            this.Controls.Add(this.txtBxCP);
            this.Controls.Add(this.lblCP);
            this.Controls.Add(this.txtBoxRueCollab);
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
        protected System.Windows.Forms.TextBox txtBoxRueCollab;
        protected System.Windows.Forms.TextBox txtBoxMatriculeCollab;
        protected System.Windows.Forms.TextBox txtBoxPrenomCollab;
        protected System.Windows.Forms.TextBox txtBoxNomCollab;
        private System.Windows.Forms.Label lblCP;
        protected System.Windows.Forms.TextBox txtBxCP;
        private System.Windows.Forms.Label lblVille;
        protected System.Windows.Forms.TextBox txtBxVille;
    }
}