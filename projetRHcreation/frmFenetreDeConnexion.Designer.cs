namespace projetRHcreation
{
    partial class frmFenetreDeConnexion
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
            this.lblIdentifiant = new System.Windows.Forms.Label();
            this.lblMotDePasse = new System.Windows.Forms.Label();
            this.txtbIdentifiant = new System.Windows.Forms.TextBox();
            this.txtbMotDePasse = new System.Windows.Forms.TextBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblIdentifiant
            // 
            this.lblIdentifiant.AutoSize = true;
            this.lblIdentifiant.Location = new System.Drawing.Point(29, 19);
            this.lblIdentifiant.Name = "lblIdentifiant";
            this.lblIdentifiant.Size = new System.Drawing.Size(59, 13);
            this.lblIdentifiant.TabIndex = 0;
            this.lblIdentifiant.Text = "Identifiant :";
            // 
            // lblMotDePasse
            // 
            this.lblMotDePasse.AutoSize = true;
            this.lblMotDePasse.Location = new System.Drawing.Point(14, 58);
            this.lblMotDePasse.Name = "lblMotDePasse";
            this.lblMotDePasse.Size = new System.Drawing.Size(74, 13);
            this.lblMotDePasse.TabIndex = 1;
            this.lblMotDePasse.Text = "MotDePasse :";
            // 
            // txtbIdentifiant
            // 
            this.txtbIdentifiant.Location = new System.Drawing.Point(94, 16);
            this.txtbIdentifiant.Name = "txtbIdentifiant";
            this.txtbIdentifiant.Size = new System.Drawing.Size(114, 20);
            this.txtbIdentifiant.TabIndex = 2;
            this.txtbIdentifiant.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtbMotDePasse
            // 
            this.txtbMotDePasse.Location = new System.Drawing.Point(94, 55);
            this.txtbMotDePasse.Name = "txtbMotDePasse";
            this.txtbMotDePasse.Size = new System.Drawing.Size(114, 20);
            this.txtbMotDePasse.TabIndex = 3;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(94, 129);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(95, 26);
            this.btnOK.TabIndex = 4;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(195, 129);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(95, 26);
            this.btnAnnuler.TabIndex = 5;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // FenetreDeConnexion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(306, 169);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.txtbMotDePasse);
            this.Controls.Add(this.txtbIdentifiant);
            this.Controls.Add(this.lblMotDePasse);
            this.Controls.Add(this.lblIdentifiant);
            this.Name = "FenetreDeConnexion";
            this.Text = "Fenetre de connexion";
            this.Load += new System.EventHandler(this.FenetreDeConnexion_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblIdentifiant;
        private System.Windows.Forms.Label lblMotDePasse;
        private System.Windows.Forms.TextBox txtbIdentifiant;
        private System.Windows.Forms.TextBox txtbMotDePasse;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnAnnuler;
    }
}