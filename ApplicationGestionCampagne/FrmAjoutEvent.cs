using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using GesCampagneBLL;
using GesCampagneBO;
using GesCampagneDAL;
using System.Configuration;

namespace ApplicationGestionCampagne
{
    public partial class FrmAjoutEvent : Form
    {
        public FrmAjoutEvent()
        {
            InitializeComponent();
            EventManager.GetInstance().SetChaineConnexion(ConfigurationManager.ConnectionStrings["GesCampagne"]);

            cbxCampagne.DataSource = CampagneDAO.GetInstanceDAOCampagne().GetCampagnes();
            cbxCampagne.DisplayMember = "unIntitule";
            cbxCampagne.DisplayMember = "unId";
            cbxCampagne.Text = "veuillez selectionner une campagne";
            cbxCampagne.SelectedIndex = -1;

            cbxVille.DataSource = VilleDAO.GetInstanceDAOVille().GetVilles();
            cbxVille.DisplayMember = "numInsee";
            cbxVille.DisplayMember = "libelle";
            cbxVille.Text = "veuillez selectionner une campagne";
            cbxVille.SelectedIndex = -1;





        }

        private void btnAjoutEvent_Click(object sender, EventArgs e)
        {
            object res = EventManager.GetInstance().CreerEvent(txtTheme.Text, dtpDateDebut.MinDate, dtpDateFin.MaxDate, (Campagne)cbxCampagne.SelectedValue, (Ville)cbxVille.SelectedValue);
            if (res == null)
            {
                MessageBox.Show("l'ajout de l'évenement est erronée");
            }
            else
            {
                MessageBox.Show("l'ajout s'est bien déroulé");
            }

        }

        private void cbxCampagne_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbxCampagne.DataSource = CampagneDAO.GetInstanceDAOCampagne().GetCampagnes();
            cbxCampagne.DisplayMember = "intitule";
            cbxCampagne.ValueMember = "id";


        }
    }
}
