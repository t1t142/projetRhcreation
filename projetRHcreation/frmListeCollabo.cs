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
    public partial class frmListeCollabo : Form
    {
        public frmListeCollabo()
        {
            InitializeComponent();
        }

        private void grdListe_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            frmDetailSalarie frmDetail = new frmDetailSalarie();
            // afficher le form détail en modal
            frmDetail.ShowDialog();
        }

       

        private void btnAjouter_Click(object sender, EventArgs e)
        {
            frmNouveauStagiaire frmDetail = new frmNouveauStagiaire();
            // afficher le form détail en modal
            frmDetail.ShowDialog();
        }
    }
}
