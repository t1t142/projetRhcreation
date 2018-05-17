using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace projetRHcreation
{
    public partial class frmEcranPrincipal : Form
    {
       
        private frmListeCollabo frmListeCollabo;
        private frmDetailSalarie frmDetailSalarie;
        private frmFenetreDeConnexion frmConnex;



        public frmEcranPrincipal()
        {
            InitializeComponent();
        }

        private void EcranPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void listeDesCollaborateursToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (this.frmListeCollabo == null) // le form secondaire n'est pas affiché ==> l'instancier            
            {
              
                this.frmListeCollabo = new frmListeCollabo(); // instancie le form                 
                                                                               // implémente un événement sur le nouveau form                  
                                                                               // pour libérer la ref à ce form               
                this.frmListeCollabo.FormClosing += new FormClosingEventHandler(this.fermeListCollabo);
                this.frmListeCollabo.Show();
            }
            else // le form secondaire est affiché 
            {
                this.frmListeCollabo.Activate(); // réactive le form (lui donne le focus) 
            }
            



        }
       

        private void ajouterCollaborateurToolStripMenuItem_Click(object sender, EventArgs e)
        {


            if (this.frmDetailSalarie == null) // le form secondaire n'est pas affiché ==> l'instancier            
            {

                this.frmDetailSalarie = new frmDetailSalarie(); // instancie le form                 
                                                              // implémente un événement sur le nouveau form                  
                                                              // pour libérer la ref à ce form               
                this.frmDetailSalarie.FormClosing += new FormClosingEventHandler(this.fermeDetailCollabo);
                this.frmDetailSalarie.Show();
            }
            else // le form secondaire est affiché 
            {
                this.frmDetailSalarie.Activate(); // réactive le form (lui donne le focus) 
            }


        }

        public void fermeListCollabo(object sender, EventArgs e)
        {
            this.frmListeCollabo = null; // libère la réf au from chrono  

        }

        public void fermeDetailCollabo(object sender, EventArgs e)
        {
            this.frmDetailSalarie = null; // libère la réf au from chrono  

        }

        private void listeDesCollaborateursToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (this.frmListeCollabo == null) // le form secondaire n'est pas affiché ==> l'instancier            
            {

                this.frmListeCollabo = new frmListeCollabo(); // instancie le form                 
                                                              // implémente un événement sur le nouveau form                  
                                                              // pour libérer la ref à ce form               
                this.frmListeCollabo.FormClosing += new FormClosingEventHandler(this.fermeListCollabo);
                this.frmListeCollabo.Show();
            }
            else // le form secondaire est affiché 
            {
                this.frmListeCollabo.Activate(); // réactive le form (lui donne le focus) 
            }



        }

        private void changerDutlisateurToolStripMenuItem_Click(object sender, EventArgs e)
        {
           

            frmConnex = new frmFenetreDeConnexion(); // instancie le form                 
                                                          // implémente un événement sur le nouveau form                  
                                                          // pour libérer la ref à ce form               
           
           
            this.frmConnex.Show();

        }
    }
}
