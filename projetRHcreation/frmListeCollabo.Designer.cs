namespace projetRHcreation
{
    partial class frmListeCollabo
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
            this.grdListe = new System.Windows.Forms.DataGridView();
            this.Service = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prénom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Contrat = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Qualification = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dates = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblRecherche = new System.Windows.Forms.Label();
            this.txtbRecherche = new System.Windows.Forms.TextBox();
            this.btnRechercher = new System.Windows.Forms.Button();
            this.btnTous = new System.Windows.Forms.Button();
            this.btnAjouter = new System.Windows.Forms.Button();
            this.btnModifier = new System.Windows.Forms.Button();
            this.btnAnnuler = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdListe)).BeginInit();
            this.SuspendLayout();
            // 
            // grdListe
            // 
            this.grdListe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdListe.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Service,
            this.Nom,
            this.Prénom,
            this.Contrat,
            this.Qualification,
            this.Dates});
            this.grdListe.Location = new System.Drawing.Point(27, 96);
            this.grdListe.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.grdListe.Name = "grdListe";
            this.grdListe.RowTemplate.Height = 24;
            this.grdListe.Size = new System.Drawing.Size(646, 202);
            this.grdListe.TabIndex = 0;
            this.grdListe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.grdListe_CellContentClick);
            // 
            // Service
            // 
            this.Service.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Service.HeaderText = "Service";
            this.Service.Name = "Service";
            // 
            // Nom
            // 
            this.Nom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            // 
            // Prénom
            // 
            this.Prénom.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Prénom.HeaderText = "Prénom";
            this.Prénom.Name = "Prénom";
            // 
            // Contrat
            // 
            this.Contrat.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Contrat.HeaderText = "Contrat";
            this.Contrat.Name = "Contrat";
            // 
            // Qualification
            // 
            this.Qualification.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Qualification.HeaderText = "Qualification";
            this.Qualification.Name = "Qualification";
            // 
            // Dates
            // 
            this.Dates.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Dates.HeaderText = "Dates";
            this.Dates.Name = "Dates";
            // 
            // lblRecherche
            // 
            this.lblRecherche.AutoSize = true;
            this.lblRecherche.Location = new System.Drawing.Point(25, 39);
            this.lblRecherche.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblRecherche.Name = "lblRecherche";
            this.lblRecherche.Size = new System.Drawing.Size(60, 13);
            this.lblRecherche.TabIndex = 1;
            this.lblRecherche.Text = "Recherche";
            // 
            // txtbRecherche
            // 
            this.txtbRecherche.Location = new System.Drawing.Point(103, 38);
            this.txtbRecherche.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtbRecherche.Name = "txtbRecherche";
            this.txtbRecherche.Size = new System.Drawing.Size(396, 20);
            this.txtbRecherche.TabIndex = 2;
            // 
            // btnRechercher
            // 
            this.btnRechercher.Location = new System.Drawing.Point(523, 37);
            this.btnRechercher.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnRechercher.Name = "btnRechercher";
            this.btnRechercher.Size = new System.Drawing.Size(76, 22);
            this.btnRechercher.TabIndex = 3;
            this.btnRechercher.Text = "&Rechercher";
            this.btnRechercher.UseVisualStyleBackColor = true;
            // 
            // btnTous
            // 
            this.btnTous.Location = new System.Drawing.Point(616, 37);
            this.btnTous.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnTous.Name = "btnTous";
            this.btnTous.Size = new System.Drawing.Size(56, 22);
            this.btnTous.TabIndex = 4;
            this.btnTous.Text = "&Tous";
            this.btnTous.UseVisualStyleBackColor = true;
            // 
            // btnAjouter
            // 
            this.btnAjouter.Location = new System.Drawing.Point(386, 332);
            this.btnAjouter.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAjouter.Name = "btnAjouter";
            this.btnAjouter.Size = new System.Drawing.Size(71, 22);
            this.btnAjouter.TabIndex = 5;
            this.btnAjouter.Text = "&Ajouter";
            this.btnAjouter.UseVisualStyleBackColor = true;
            this.btnAjouter.Click += new System.EventHandler(this.btnAjouter_Click);
            // 
            // btnModifier
            // 
            this.btnModifier.Location = new System.Drawing.Point(478, 332);
            this.btnModifier.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnModifier.Name = "btnModifier";
            this.btnModifier.Size = new System.Drawing.Size(78, 22);
            this.btnModifier.TabIndex = 6;
            this.btnModifier.Text = "&Modifier";
            this.btnModifier.UseVisualStyleBackColor = true;
            this.btnModifier.Click += new System.EventHandler(this.btnModifier_Click);
            // 
            // btnAnnuler
            // 
            this.btnAnnuler.Location = new System.Drawing.Point(574, 332);
            this.btnAnnuler.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.btnAnnuler.Name = "btnAnnuler";
            this.btnAnnuler.Size = new System.Drawing.Size(64, 22);
            this.btnAnnuler.TabIndex = 7;
            this.btnAnnuler.Text = "Annuler";
            this.btnAnnuler.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(42, 301);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Double-clique pour consulter / modifier";
            // 
            // frmListeCollabo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(704, 378);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnAnnuler);
            this.Controls.Add(this.btnModifier);
            this.Controls.Add(this.btnAjouter);
            this.Controls.Add(this.btnTous);
            this.Controls.Add(this.btnRechercher);
            this.Controls.Add(this.txtbRecherche);
            this.Controls.Add(this.lblRecherche);
            this.Controls.Add(this.grdListe);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "frmListeCollabo";
            this.Text = "Liste des collaborateurs";
            ((System.ComponentModel.ISupportInitialize)(this.grdListe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblRecherche;
        private System.Windows.Forms.DataGridViewTextBoxColumn Service;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prénom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Contrat;
        private System.Windows.Forms.DataGridViewTextBoxColumn Qualification;
        private System.Windows.Forms.DataGridViewTextBoxColumn Dates;
        private System.Windows.Forms.Label label1;
        protected System.Windows.Forms.DataGridView grdListe;
        protected System.Windows.Forms.TextBox txtbRecherche;
        protected System.Windows.Forms.Button btnRechercher;
        protected System.Windows.Forms.Button btnTous;
        protected System.Windows.Forms.Button btnAjouter;
        protected System.Windows.Forms.Button btnModifier;
        protected System.Windows.Forms.Button btnAnnuler;
    }
}