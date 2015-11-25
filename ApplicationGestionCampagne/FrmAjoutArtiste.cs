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
    public partial class FrmAjoutArtiste : Form
    {
        public FrmAjoutArtiste()
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
            int res = ArtisteManager.GetInstance().CreerArtiste(txtNomArtiste.Text, txtSiteWeb.Text, (int)cbxCourantArtiste.SelectedValue);
        }

        private void cbxCourantArtiste_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxCourantArtiste.DataSource = CourantManager.GetInstance().GetCourants();
            cbxCourantArtiste.DisplayMember = "libelle";
            cbxCourantArtiste.ValueMember = "id";
        }
    }
}
