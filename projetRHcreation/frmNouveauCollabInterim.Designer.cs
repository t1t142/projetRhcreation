namespace projetRHcreation
{
    partial class frmNouveauCollabInterim
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
            this.lblSalaire = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // comboBox2
            // 
            this.comboBox2.Text = "Interim";
            // 
            // comboBox4
            // 
            this.comboBox4.SelectedIndexChanged += new System.EventHandler(this.comboBox4_SelectedIndexChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.lblSalaire);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.groupBox2.Controls.SetChildIndex(this.comboBox4, 0);
            this.groupBox2.Controls.SetChildIndex(this.comboBox3, 0);
            this.groupBox2.Controls.SetChildIndex(this.comboBox2, 0);
            this.groupBox2.Controls.SetChildIndex(this.comboBox5, 0);
            this.groupBox2.Controls.SetChildIndex(this.txtSalaire, 0);
            this.groupBox2.Controls.SetChildIndex(this.label17, 0);
            this.groupBox2.Controls.SetChildIndex(this.dateTimePicker2, 0);
            this.groupBox2.Controls.SetChildIndex(this.lblSalaire, 0);
            this.groupBox2.Controls.SetChildIndex(this.label15, 0);
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
            this.label17.Size = new System.Drawing.Size(80, 13);
            this.label17.TabIndex = 26;
            this.label17.Text = "Fin de Mission :";
            // 
            // lblSalaire
            // 
            this.lblSalaire.AutoSize = true;
            this.lblSalaire.Location = new System.Drawing.Point(30, 156);
            this.lblSalaire.Name = "lblSalaire";
            this.lblSalaire.Size = new System.Drawing.Size(113, 13);
            this.lblSalaire.TabIndex = 28;
            this.lblSalaire.Text = "Salaire Brut Mensuel : ";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(375, 52);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(92, 13);
            this.label15.TabIndex = 29;
            this.label15.Text = "Agence d\'Interim :";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(477, 49);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(184, 20);
            this.textBox7.TabIndex = 30;
            this.textBox7.Text = "Poudlard Power";
            // 
            // frmNouveauCollabInterim
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(723, 653);
            this.Name = "frmNouveauCollabInterim";
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
        protected System.Windows.Forms.Label lblSalaire;
        protected System.Windows.Forms.Label label17;
        protected System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label15;
    }
}
