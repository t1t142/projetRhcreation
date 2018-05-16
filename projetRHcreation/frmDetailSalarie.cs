using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projetRHcreation
{
    public partial class frmDetailSalarie : projetRHcreation.frmNouveauCollaborateur
    {

       private frmDetailSalarie frmDetailSalar;

        public frmDetailSalarie()
        {
            InitializeComponent();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmDetailSalarie_Load(object sender, EventArgs e)
        {
            this.groupBox2.Visible = false;

            // this.txtMatricule.Enabled = false;
            //this.textBox1.Enabled = false;
            // this.groupBox1.Enabled = false;

            Griser();

            

        }

        private void btnAnnuler_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Griser()
        {
            TextBox maCase;
            ComboBox maComb;
            foreach (Control bidule in this.Controls)
            {
                if (bidule is TextBox)
                {


                    maCase = (TextBox)bidule;
                    maCase.Enabled = false;
                }
                else if (bidule is ComboBox)
                {


                    maComb = (ComboBox)bidule;
                    maComb.Enabled = false;
                }


                else if (bidule is GroupBox)
                {
                    foreach (Control bidules in bidule.Controls)
                    {


                        if (bidules is TextBox)
                        {



                            maCase = (TextBox)bidules;
                            maCase.Enabled = false;


                        }
                        else if (bidules is ComboBox)
                        {


                            maComb = (ComboBox)bidules;
                            maComb.Enabled = false;
                        }

                    }
                }


            }
        }

        private void Acces()
        {
            TextBox maCase;
            ComboBox maComb;
            foreach (Control bidule in this.Controls)
            {
                if (bidule is TextBox && bidule.Name!= "txtMatricule")
                {


                    maCase = (TextBox)bidule;
                    maCase.Enabled = true;
                }
                else if (bidule is ComboBox)
                {


                    maComb = (ComboBox)bidule;
                    maComb.Enabled = true;
                }


                else if (bidule is GroupBox)
                {
                    foreach (Control bidules in bidule.Controls)
                    {


                        if (bidules is TextBox)
                        {



                            maCase = (TextBox)bidules;
                            maCase.Enabled = true;


                        }
                        else if (bidules is ComboBox)
                        {


                            maComb = (ComboBox)bidules;
                            maComb.Enabled = true;
                        }

                    }
                }


            }
        }

        private void btnEditer_Click(object sender, EventArgs e)
        {
            Acces();
        }

        private void btnAjoutContrat_Click(object sender, EventArgs e)
        {
            frmContrat frmontra = new frmContrat();
            // afficher le form détail en modal
            frmontra.ShowDialog();
        }
    }
}
 