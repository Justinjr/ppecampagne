﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Configuration;

using GesCampagneBLL;

namespace ApplicationGestionCampagne
{
    public partial class FrmAjoutArtiste : Form
    {
        public FrmAjoutArtiste()
        {
            InitializeComponent();

            ArtisteManager.GetInstance().SetChaineConnexion(ConfigurationManager.ConnectionStrings["GesCampagne"]);

            cbxCourantArtiste.DataSource = CourantManager.GetInstance().GetCourants();
            cbxCourantArtiste.ValueMember = "id";
            cbxCourantArtiste.DisplayMember = "libelle";
            cbxCourantArtiste.SelectedIndex = -1;
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
            
        }
    }
}
