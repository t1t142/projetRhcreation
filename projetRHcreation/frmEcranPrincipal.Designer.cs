namespace projetRHcreation
{
    partial class frmEcranPrincipal
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.connexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changerDutlisateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.déconnexionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ressourcesHumainesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ajouterCollaborateurToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesCollaborateursToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.affichageToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.listeDesCollaborateursToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.adminToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.droitDaccèsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.connexionToolStripMenuItem,
            this.ressourcesHumainesToolStripMenuItem,
            this.affichageToolStripMenuItem,
            this.adminToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // connexionToolStripMenuItem
            // 
            this.connexionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changerDutlisateurToolStripMenuItem,
            this.déconnexionToolStripMenuItem});
            this.connexionToolStripMenuItem.Name = "connexionToolStripMenuItem";
            this.connexionToolStripMenuItem.Size = new System.Drawing.Size(76, 20);
            this.connexionToolStripMenuItem.Text = "&Connexion";
            // 
            // changerDutlisateurToolStripMenuItem
            // 
            this.changerDutlisateurToolStripMenuItem.Name = "changerDutlisateurToolStripMenuItem";
            this.changerDutlisateurToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.changerDutlisateurToolStripMenuItem.Text = "&Changer d\'utlisateur";
            this.changerDutlisateurToolStripMenuItem.Click += new System.EventHandler(this.changerDutlisateurToolStripMenuItem_Click);
            // 
            // déconnexionToolStripMenuItem
            // 
            this.déconnexionToolStripMenuItem.Name = "déconnexionToolStripMenuItem";
            this.déconnexionToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.déconnexionToolStripMenuItem.Text = "&Déconnexion";
            // 
            // ressourcesHumainesToolStripMenuItem
            // 
            this.ressourcesHumainesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ajouterCollaborateurToolStripMenuItem,
            this.listeDesCollaborateursToolStripMenuItem});
            this.ressourcesHumainesToolStripMenuItem.Name = "ressourcesHumainesToolStripMenuItem";
            this.ressourcesHumainesToolStripMenuItem.Size = new System.Drawing.Size(134, 20);
            this.ressourcesHumainesToolStripMenuItem.Text = "&Ressources Humaines";
            // 
            // ajouterCollaborateurToolStripMenuItem
            // 
            this.ajouterCollaborateurToolStripMenuItem.Name = "ajouterCollaborateurToolStripMenuItem";
            this.ajouterCollaborateurToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.ajouterCollaborateurToolStripMenuItem.Text = "&Ajouter collaborateur";
            this.ajouterCollaborateurToolStripMenuItem.Click += new System.EventHandler(this.ajouterCollaborateurToolStripMenuItem_Click);
            // 
            // listeDesCollaborateursToolStripMenuItem
            // 
            this.listeDesCollaborateursToolStripMenuItem.Name = "listeDesCollaborateursToolStripMenuItem";
            this.listeDesCollaborateursToolStripMenuItem.Size = new System.Drawing.Size(197, 22);
            this.listeDesCollaborateursToolStripMenuItem.Text = "&Liste des collaborateurs";
            this.listeDesCollaborateursToolStripMenuItem.Click += new System.EventHandler(this.listeDesCollaborateursToolStripMenuItem_Click);
            // 
            // affichageToolStripMenuItem
            // 
            this.affichageToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.listeDesCollaborateursToolStripMenuItem1});
            this.affichageToolStripMenuItem.Name = "affichageToolStripMenuItem";
            this.affichageToolStripMenuItem.Size = new System.Drawing.Size(70, 20);
            this.affichageToolStripMenuItem.Text = "&Affichage";
            // 
            // listeDesCollaborateursToolStripMenuItem1
            // 
            this.listeDesCollaborateursToolStripMenuItem1.Name = "listeDesCollaborateursToolStripMenuItem1";
            this.listeDesCollaborateursToolStripMenuItem1.Size = new System.Drawing.Size(197, 22);
            this.listeDesCollaborateursToolStripMenuItem1.Text = "&Liste des collaborateurs";
            this.listeDesCollaborateursToolStripMenuItem1.Click += new System.EventHandler(this.listeDesCollaborateursToolStripMenuItem1_Click);
            // 
            // adminToolStripMenuItem
            // 
            this.adminToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.droitDaccèsToolStripMenuItem});
            this.adminToolStripMenuItem.Name = "adminToolStripMenuItem";
            this.adminToolStripMenuItem.Size = new System.Drawing.Size(55, 20);
            this.adminToolStripMenuItem.Text = "&Admin";
            // 
            // droitDaccèsToolStripMenuItem
            // 
            this.droitDaccèsToolStripMenuItem.Name = "droitDaccèsToolStripMenuItem";
            this.droitDaccèsToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.droitDaccèsToolStripMenuItem.Text = "&Droit d\'accès";
            // 
            // frmEcranPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmEcranPrincipal";
            this.Text = "Ecran principal";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem connexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changerDutlisateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem déconnexionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ressourcesHumainesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ajouterCollaborateurToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesCollaborateursToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem affichageToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem listeDesCollaborateursToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem adminToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem droitDaccèsToolStripMenuItem;
    }
}