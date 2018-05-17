namespace projetRHcreation
{
    partial class frmDetailSalarie
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.btnEditer = new System.Windows.Forms.Button();
            this.btnAjoutContrat = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dcDebut = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcType = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcQualification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcService = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dcNom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcTypeProjet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcTacheCollaborateur = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Location = new System.Drawing.Point(70, 62);
            // 
            // groupBox2
            // 
            this.groupBox2.Location = new System.Drawing.Point(70, 323);
            this.groupBox2.Size = new System.Drawing.Size(746, 179);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(741, 808);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(660, 808);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(31, 11);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(669, 161);
            this.dataGridView1.TabIndex = 3;
            // 
            // btnEditer
            // 
            this.btnEditer.Location = new System.Drawing.Point(-1, 88);
            this.btnEditer.Name = "btnEditer";
            this.btnEditer.Size = new System.Drawing.Size(65, 26);
            this.btnEditer.TabIndex = 4;
            this.btnEditer.Text = "&Editer";
            this.btnEditer.UseVisualStyleBackColor = true;
            this.btnEditer.Click += new System.EventHandler(this.btnEditer_Click);
            // 
            // btnAjoutContrat
            // 
            this.btnAjoutContrat.Location = new System.Drawing.Point(562, 807);
            this.btnAjoutContrat.Name = "btnAjoutContrat";
            this.btnAjoutContrat.Size = new System.Drawing.Size(92, 24);
            this.btnAjoutContrat.TabIndex = 6;
            this.btnAjoutContrat.Text = "&Ajout contrat";
            this.btnAjoutContrat.UseVisualStyleBackColor = true;
            this.btnAjoutContrat.Click += new System.EventHandler(this.btnAjoutContrat_Click);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dcDebut,
            this.dcFin,
            this.dcType,
            this.dcQualification,
            this.dcService});
            this.dataGridView2.Location = new System.Drawing.Point(70, 534);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(746, 104);
            this.dataGridView2.TabIndex = 17;
            // 
            // dcDebut
            // 
            this.dcDebut.HeaderText = "Début ";
            this.dcDebut.Name = "dcDebut";
            // 
            // dcFin
            // 
            this.dcFin.HeaderText = "Fin";
            this.dcFin.Name = "dcFin";
            // 
            // dcType
            // 
            this.dcType.HeaderText = "Type";
            this.dcType.Name = "dcType";
            // 
            // dcQualification
            // 
            this.dcQualification.HeaderText = "Qualification";
            this.dcQualification.Name = "dcQualification";
            // 
            // dcService
            // 
            this.dcService.HeaderText = "Service";
            this.dcService.Name = "dcService";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(70, 515);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(177, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "Liste des Contrats du Collaborateur :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(74, 647);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(255, 13);
            this.label16.TabIndex = 19;
            this.label16.Text = "Liste des projets auxquels le collaborateur intervient :";
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dcNom,
            this.dcTypeProjet,
            this.dcTacheCollaborateur});
            this.dataGridView3.Location = new System.Drawing.Point(73, 677);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(742, 82);
            this.dataGridView3.TabIndex = 20;
            // 
            // dcNom
            // 
            this.dcNom.HeaderText = "Nom Projet";
            this.dcNom.Name = "dcNom";
            this.dcNom.ReadOnly = true;
            // 
            // dcTypeProjet
            // 
            this.dcTypeProjet.HeaderText = "Type de Projet";
            this.dcTypeProjet.Name = "dcTypeProjet";
            this.dcTypeProjet.ReadOnly = true;
            // 
            // dcTacheCollaborateur
            // 
            this.dcTacheCollaborateur.HeaderText = "Tache Assignée";
            this.dcTacheCollaborateur.Name = "dcTacheCollaborateur";
            this.dcTacheCollaborateur.ReadOnly = true;
            // 
            // frmDetailSalarie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(852, 843);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.btnAjoutContrat);
            this.Controls.Add(this.btnEditer);
            this.Name = "frmDetailSalarie";
            this.Load += new System.EventHandler(this.frmDetailSalarie_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtMatricule, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.btnEditer, 0);
            this.Controls.SetChildIndex(this.btnAjoutContrat, 0);
            this.Controls.SetChildIndex(this.dataGridView2, 0);
            this.Controls.SetChildIndex(this.label15, 0);
            this.Controls.SetChildIndex(this.label16, 0);
            this.Controls.SetChildIndex(this.dataGridView3, 0);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnEditer;
        private System.Windows.Forms.Button btnAjoutContrat;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcDebut;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcFin;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcType;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcQualification;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcService;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcNom;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcTypeProjet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcTacheCollaborateur;
    }
}
