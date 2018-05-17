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
            this.dcDebutProjet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dcFinProjet = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.chkDesactive = new System.Windows.Forms.CheckBox();
            this.comboBox6 = new System.Windows.Forms.ComboBox();
            this.label17 = new System.Windows.Forms.Label();
            this.dateTimePicker2 = new System.Windows.Forms.DateTimePicker();
            this.label18 = new System.Windows.Forms.Label();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.txtEcole = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            this.lblSalaire = new System.Windows.Forms.Label();
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
            this.groupBox1.Size = new System.Drawing.Size(746, 255);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblSalaire);
            this.groupBox2.Controls.Add(this.txtEcole);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.textBox7);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.comboBox6);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.dateTimePicker2);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Location = new System.Drawing.Point(70, 323);
            this.groupBox2.Size = new System.Drawing.Size(746, 179);
            this.groupBox2.Controls.SetChildIndex(this.label12, 0);
            this.groupBox2.Controls.SetChildIndex(this.label11, 0);
            this.groupBox2.Controls.SetChildIndex(this.dateTimePicker1, 0);
            this.groupBox2.Controls.SetChildIndex(this.comboBox4, 0);
            this.groupBox2.Controls.SetChildIndex(this.label9, 0);
            this.groupBox2.Controls.SetChildIndex(this.label10, 0);
            this.groupBox2.Controls.SetChildIndex(this.comboBox3, 0);
            this.groupBox2.Controls.SetChildIndex(this.comboBox2, 0);
            this.groupBox2.Controls.SetChildIndex(this.label14, 0);
            this.groupBox2.Controls.SetChildIndex(this.comboBox5, 0);
            this.groupBox2.Controls.SetChildIndex(this.txtSalaire, 0);
            this.groupBox2.Controls.SetChildIndex(this.label18, 0);
            this.groupBox2.Controls.SetChildIndex(this.dateTimePicker2, 0);
            this.groupBox2.Controls.SetChildIndex(this.label17, 0);
            this.groupBox2.Controls.SetChildIndex(this.comboBox6, 0);
            this.groupBox2.Controls.SetChildIndex(this.label19, 0);
            this.groupBox2.Controls.SetChildIndex(this.textBox7, 0);
            this.groupBox2.Controls.SetChildIndex(this.label20, 0);
            this.groupBox2.Controls.SetChildIndex(this.txtEcole, 0);
            this.groupBox2.Controls.SetChildIndex(this.lblSalaire, 0);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(741, 836);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(660, 836);
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
            this.btnAjoutContrat.Location = new System.Drawing.Point(562, 835);
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
            this.dataGridView2.Location = new System.Drawing.Point(70, 576);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(529, 104);
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
            this.label15.Location = new System.Drawing.Point(70, 560);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(177, 13);
            this.label15.TabIndex = 18;
            this.label15.Text = "Liste des Contrats du Collaborateur :";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(74, 692);
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
            this.dcTacheCollaborateur,
            this.dcDebutProjet,
            this.dcFinProjet});
            this.dataGridView3.Location = new System.Drawing.Point(70, 708);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.Size = new System.Drawing.Size(529, 82);
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
            // dcDebutProjet
            // 
            this.dcDebutProjet.HeaderText = "Début";
            this.dcDebutProjet.Name = "dcDebutProjet";
            this.dcDebutProjet.ReadOnly = true;
            // 
            // dcFinProjet
            // 
            this.dcFinProjet.HeaderText = "Fin";
            this.dcFinProjet.Name = "dcFinProjet";
            this.dcFinProjet.ReadOnly = true;
            // 
            // chkDesactive
            // 
            this.chkDesactive.AutoSize = true;
            this.chkDesactive.Location = new System.Drawing.Point(70, 520);
            this.chkDesactive.Name = "chkDesactive";
            this.chkDesactive.Size = new System.Drawing.Size(288, 17);
            this.chkDesactive.TabIndex = 26;
            this.chkDesactive.Text = "Collaborateur Désactivé (ne fait plus partie des effectifs)";
            this.chkDesactive.UseVisualStyleBackColor = true;
            // 
            // comboBox6
            // 
            this.comboBox6.FormattingEnabled = true;
            this.comboBox6.Location = new System.Drawing.Point(519, 45);
            this.comboBox6.Name = "comboBox6";
            this.comboBox6.Size = new System.Drawing.Size(200, 21);
            this.comboBox6.TabIndex = 30;
            this.comboBox6.Text = "Accroissement d\'Activité";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(433, 53);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(36, 13);
            this.label17.TabIndex = 29;
            this.label17.Text = "Motif :";
            // 
            // dateTimePicker2
            // 
            this.dateTimePicker2.Location = new System.Drawing.Point(519, 19);
            this.dateTimePicker2.Name = "dateTimePicker2";
            this.dateTimePicker2.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker2.TabIndex = 28;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(433, 22);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(79, 13);
            this.label18.TabIndex = 27;
            this.label18.Text = "Fin de Contrat :";
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(535, 75);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(184, 20);
            this.textBox7.TabIndex = 32;
            this.textBox7.Text = "Poudlard Power";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(433, 78);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(92, 13);
            this.label19.TabIndex = 31;
            this.label19.Text = "Agence d\'Interim :";
            // 
            // txtEcole
            // 
            this.txtEcole.Location = new System.Drawing.Point(535, 102);
            this.txtEcole.Name = "txtEcole";
            this.txtEcole.Size = new System.Drawing.Size(184, 20);
            this.txtEcole.TabIndex = 34;
            this.txtEcole.Text = "Hogwarts";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(433, 105);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(40, 13);
            this.label20.TabIndex = 33;
            this.label20.Text = "Ecole :";
            // 
            // lblSalaire
            // 
            this.lblSalaire.AutoSize = true;
            this.lblSalaire.Location = new System.Drawing.Point(30, 156);
            this.lblSalaire.Name = "lblSalaire";
            this.lblSalaire.Size = new System.Drawing.Size(113, 13);
            this.lblSalaire.TabIndex = 35;
            this.lblSalaire.Text = "Salaire Brut Mensuel : ";
            // 
            // frmDetailSalarie
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(852, 871);
            this.Controls.Add(this.dataGridView3);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.chkDesactive);
            this.Controls.Add(this.btnAjoutContrat);
            this.Controls.Add(this.btnEditer);
            this.Name = "frmDetailSalarie";
            this.Text = "Informations sur le Salarié";
            this.Load += new System.EventHandler(this.frmDetailSalarie_Load);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtMatricule, 0);
            this.Controls.SetChildIndex(this.groupBox1, 0);
            this.Controls.SetChildIndex(this.groupBox2, 0);
            this.Controls.SetChildIndex(this.button1, 0);
            this.Controls.SetChildIndex(this.button2, 0);
            this.Controls.SetChildIndex(this.btnEditer, 0);
            this.Controls.SetChildIndex(this.btnAjoutContrat, 0);
            this.Controls.SetChildIndex(this.chkDesactive, 0);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn dcDebutProjet;
        private System.Windows.Forms.DataGridViewTextBoxColumn dcFinProjet;
        private System.Windows.Forms.CheckBox chkDesactive;
        protected System.Windows.Forms.ComboBox comboBox6;
        private System.Windows.Forms.Label label17;
        protected System.Windows.Forms.DateTimePicker dateTimePicker2;
        private System.Windows.Forms.Label label18;
        protected System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label label19;
        protected System.Windows.Forms.TextBox txtEcole;
        private System.Windows.Forms.Label label20;
        protected System.Windows.Forms.Label lblSalaire;
    }
}
