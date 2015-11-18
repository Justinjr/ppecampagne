using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using GesCampagneBLL;

namespace ApplicationGestionCampagne
{
    public partial class frmAjoutArtiste : Form
    {
        public frmAjoutArtiste()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void txtNomArtiste_TextChanged(object sender, EventArgs e)
        {

        }



        private void button1_Click(object sender, EventArgs e)
        {
            int res = ArtisteManager.GetInstance().CreerArtiste(txtNomArtiste.Text, txtSiteWeb.Text, (int)lstCourantArtiste.SelectedValue);
        }
        private void lstCourantArtiste_SelectedIndexChanged(object sender, EventArgs e)
        {
            lstCourantArtiste.DataSource = ArtisteManager.GetInstance().GetArtistes();
            lstCourantArtiste.DisplayMember = "libelle";
            lstCourantArtiste.ValueMember = "id";
        }
    }
}
