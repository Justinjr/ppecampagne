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
            cbxCampagne.DisplayMember = "Intitule";
            cbxCampagne.ValueMember = "Id";
           // cbxCampagne.Text = "veuillez selectionner une campagne";
            cbxCampagne.SelectedIndex = -1;

            cbxVille.DataSource = VilleDAO.GetInstanceDAOVille().GetVilles();
            cbxVille.DisplayMember = "libelle";
            cbxVille.ValueMember = "numInsee";
            //cbxVille.Text = "veuillez selectionner une ville";
            cbxVille.SelectedIndex = 0;

            cbxTheme.DataSource = ThemeDAO.GetInstanceDAOTheme().GetThemes();
            cbxTheme.DisplayMember = "libelle";
            cbxTheme.ValueMember = "id";
            // cbxTheme.Text = "veuillez selectionner un theme";
            cbxTheme.SelectedIndex = 0;





        }

        private void btnAjoutEvent_Click(object sender, EventArgs e)
        {
            if ((int)cbxTheme.SelectedValue > -1 && dtpDateFin.Value > dtpDateDebut.Value && (int)cbxCampagne.SelectedValue > -1 && (int)cbxVille.SelectedValue > -1 )
            {
                if (dtpDateFin.Value.Day - dtpDateDebut.Value.Day <= 3)
                {


                    int res = EventManager.GetInstance().CreerEvent((int)cbxTheme.SelectedValue, dtpDateDebut.Value, dtpDateFin.Value, (int)cbxCampagne.SelectedValue, (int)cbxVille.SelectedValue);
                    if (res == 0)
                    {
                        MessageBox.Show("l'ajout de l'évenement est erronée");
                    }
                    else
                    {
                        MessageBox.Show("l'ajout s'est bien déroulé");
                    }
                }
                else
                {
                    MessageBox.Show("l'évenement ne peut pas se dérouler sur une periode de plus de 3 jours");
                }
            }
            

            



        }

       

       
    }
}
