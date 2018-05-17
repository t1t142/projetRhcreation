namespace projetRHcreation
{
    partial class frmNouveauStagiaire
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
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label17 = new System.Windows.Forms.Label();
            this.lblIndemnites = new System.Windows.Forms.Label();
            this.txtEcole = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.Items.AddRange(new object[] {
            "",
            "CDD",
            "CDI",
            "STAGE",
            "INTERIM"});
            this.comboBox2.Text = "";
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            this.comboBox2.SelectedValueChanged += new System.EventHandler(this.comboBox2_SelectedValueChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.txtEcole);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.lblIndemnites);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Size = new System.Drawing.Size(667, 225);
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            this.groupBox2.Controls.SetChildIndex(this.label11, 0);
            this.groupBox2.Controls.SetChildIndex(this.label9, 0);
            this.groupBox2.Controls.SetChildIndex(this.label10, 0);
            this.groupBox2.Controls.SetChildIndex(this.label14, 0);
            this.groupBox2.Controls.SetChildIndex(this.label12, 0);
            this.groupBox2.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.groupBox2.Controls.SetChildIndex(this.comboBox4, 0);
            this.groupBox2.Controls.SetChildIndex(this.comboBox3, 0);
            this.groupBox2.Controls.SetChildIndex(this.comboBox2, 0);
            this.groupBox2.Controls.SetChildIndex(this.comboBox5, 0);
            this.groupBox2.Controls.SetChildIndex(this.txtSalaire, 0);
            this.groupBox2.Controls.SetChildIndex(this.label17, 0);
            this.groupBox2.Controls.SetChildIndex(this.dateTimePicker2, 0);
            this.groupBox2.Controls.SetChildIndex(this.lblIndemnites, 0);
            this.groupBox2.Controls.SetChildIndex(this.label15, 0);
            this.groupBox2.Controls.SetChildIndex(this.txtEcole, 0);
            this.groupBox2.Controls.SetChildIndex(this.label16, 0);
            this.groupBox2.Controls.SetChildIndex(this.label18, 0);
            this.groupBox2.Controls.SetChildIndex(this.textBox7, 0);
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(461, 19);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 27;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(375, 22);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(79, 13);
            this.label17.TabIndex = 26;
            this.label17.Text = "Fin de Contrat :";
            // 
            // lblIndemnites
            // 
            this.lblIndemnites.AutoSize = true;
            this.lblIndemnites.Location = new System.Drawing.Point(30, 156);
            this.lblIndemnites.Name = "lblIndemnites";
            this.lblIndemnites.Size = new System.Drawing.Size(64, 13);
            this.lblIndemnites.TabIndex = 30;
            this.lblIndemnites.Text = "Indemnités :";
            // 
            // txtEcole
            // 
            this.txtEcole.Location = new System.Drawing.Point(477, 48);
            this.txtEcole.Name = "txtEcole";
            this.txtEcole.Size = new System.Drawing.Size(184, 20);
            this.txtEcole.TabIndex = 32;
            this.txtEcole.Text = "Hogwarts";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(375, 51);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(40, 13);
            this.label15.TabIndex = 31;
            this.label15.Text = "Ecole :";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(477, 74);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(184, 20);
            this.textBox7.TabIndex = 34;
            this.textBox7.Text = "Poudlard Power";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(375, 77);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(92, 13);
            this.label16.TabIndex = 33;
            this.label16.Text = "Agence d\'Interim :";
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(193, 502);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(200, 21);
            this.comboBox6.TabIndex = 36;
            this.comboBox6.Text = "Accroissement d\'Activité";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(30, 187);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(36, 13);
            this.label18.TabIndex = 35;
            this.label18.Text = "Motif :";
            // 
            // frmNouveauStagiaire
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(741, 653);
            this.Controls.Add(this.comboBox6);
            this.Name = "frmNouveauStagiaire";
            this.Load += new System.EventHandler(this.frmNouveauStagiaire_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtMatricule, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.comboBox6, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        protected System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label17;
        protected System.Windows.Forms.Label lblIndemnites;
        protected System.Windows.Forms.TextBox txtEcole;
        private System.Windows.Forms.Label label15;
        protected System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label18;
        protected System.Windows.Forms.ComboBox comboBox6;
    }
}
