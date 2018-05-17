using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace projetRHcreation
{
    public partial class frmNouveauStagiaire : projetRHcreation.frmNouveauCollaborateur
    {
        public frmNouveauStagiaire()
        {
            InitializeComponent();
            label18.Visible = false;
            comboBox6.Visible = false;
            label15.Visible = false;
            txtEcole.Visible = false;
            label16.Visible = false;
            textBox7.Visible = false;
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
           
        }

        private void frmNouveauStagiaire_Load(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            if (comboBox2.SelectedIndex == 0)
            {
               
                label18.Visible = false;
                comboBox6.Visible = false;
                label15.Visible = false;
                txtEcole.Visible = false;
                label16.Visible = false;
                textBox7.Visible = false;

            }
            if (comboBox2.SelectedIndex ==1)//CDD
            {
                
                label18.Visible = true;
                comboBox6.Visible = true;
                label15.Visible = false;
                txtEcole.Visible = false;
                label16.Visible = false;
                textBox7.Visible = false;

            }


            if (comboBox2.SelectedIndex == 2)//CDI
            {

                label18.Visible = false;
                comboBox6.Visible = false;
                label15.Visible = false;
                txtEcole.Visible = false;
                label16.Visible = false;
                textBox7.Visible = false;

            }


            if (comboBox2.SelectedIndex == 3)//Stage
            {

                label18.Visible = false;
                comboBox6.Visible = false;
                label15.Visible = true;
                txtEcole.Visible = true;
                label16.Visible = false;
                textBox7.Visible = false;

            }
            if (comboBox2.SelectedIndex == 4)//Stage
            {

                label18.Visible = false;
                comboBox6.Visible = false;
                label15.Visible = false;
                txtEcole.Visible = false;
                label16.Visible = true;
                textBox7.Visible = true;

            }
        }
    }
}
