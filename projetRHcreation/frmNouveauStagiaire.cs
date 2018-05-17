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
            cbxmotif.Visible = false;
            lblecole.Visible = false;
            txtEcole.Visible = false;
            lblagence.Visible = false;
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
                cbxmotif.Visible = false;
                lblecole.Visible = false;
                txtEcole.Visible = false;
                lblagence.Visible = false;
                textBox7.Visible = false;
                dateTimePicker2.Visible = true;
                label17.Visible = true;
                lblIndemnites.Text = "Salaire brut mensuel :";
            }
            if (comboBox2.SelectedIndex ==1)//CDD
            {
                
                label18.Visible = true;
                cbxmotif.Visible = true;
                lblecole.Visible = false;
                txtEcole.Visible = false;
                lblagence.Visible = false;
                textBox7.Visible = false;
                dateTimePicker2.Visible = true;
                label17.Visible = true;
                lblIndemnites.Text = "Salaire brut mensuel :";
                
            }


            if (comboBox2.SelectedIndex == 2)//CDI
            {

                label18.Visible = false;
                cbxmotif.Visible = false;
                lblecole.Visible = false;
                txtEcole.Visible = false;
                lblagence.Visible = false;
                textBox7.Visible = false;
                dateTimePicker2.Visible = false;
                label17.Visible = false;
                lblIndemnites.Text = "Salaire brut mensuel :";
            }


            if (comboBox2.SelectedIndex == 3)//Stage
            {

                label18.Visible = false;
                cbxmotif.Visible = false;
                lblecole.Visible = true;
                txtEcole.Visible = true;
                lblagence.Visible = false;
                textBox7.Visible = false;
                dateTimePicker2.Visible = true;
                label17.Visible = true;
                lblIndemnites.Text = "indemnités:";
            }
            if (comboBox2.SelectedIndex == 4)//Interim
            { 
                label18.Visible = false;
                cbxmotif.Visible = false;
                lblecole.Visible = false;
                txtEcole.Visible = false;
                lblagence.Visible = true;
                textBox7.Visible = true;
                dateTimePicker2.Visible = true;
                label17.Visible = true;
                lblIndemnites.Text = "Salaire brut mensuel :";
            }
        }
    }
}
