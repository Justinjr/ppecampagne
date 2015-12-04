using System;
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
            //if qui verifie si un artiste exist déja dans la BD
            int existArtiste = ArtisteManager.GetInstance().ArtisteExist(txtNomArtiste.Text);
            if (existArtiste >= 1)
            {
                DialogResult result1 = MessageBox.Show("voulez-vous enregistrer malgrer qu'un artiste existe deja avec le meme nom ? :", "Important Question", MessageBoxButtons.YesNo);
                //demande à l'utilisateur si il veut enregistrer un artiste malgré qu'un autre artiste exist avec le meme nom
                if (result1 == DialogResult.Yes)
                {
                    int res = ArtisteManager.GetInstance().CreerArtiste(txtNomArtiste.Text, txtSiteWeb.Text, (int)cbxCourantArtiste.SelectedValue);
                    //enregistre dans la BD

                    if (res > 0)
                    {
                        MessageBox.Show("Enregistrement réussi");
                    }
                    else
                    {
                        MessageBox.Show("probleme Enregistrement");
                    }
                }
                else
                {
                    MessageBox.Show("Vous avez refuser l'enregistrement");
                }
            }
            else
            {
                int res = ArtisteManager.GetInstance().CreerArtiste(txtNomArtiste.Text, txtSiteWeb.Text, (int)cbxCourantArtiste.SelectedValue);
                //enregistre dans la BD
                if (res > 0)
                {
                    MessageBox.Show("Enregistrement réussi");
                }
                else
                {
                    MessageBox.Show("probleme Enregistrement");
                }
            }
        }
        private void cbxCourantArtiste_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }
    }
}
