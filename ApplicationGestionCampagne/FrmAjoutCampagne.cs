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
    public partial class FrmAjoutCampagne : Form
    {
        public FrmAjoutCampagne()
        {
            InitializeComponent();

            
            CampagneManager.GetInstance().SetChaineConnexion(ConfigurationManager.ConnectionStrings["GesCampagne"]);


            cbxPublicCampagne.DataSource = PublicDAO.GetInstanceDAOPublic().GetPublics();
            cbxPublicCampagne.DisplayMember = "Libelle";
            cbxPublicCampagne.ValueMember = "Id";
            //cbxPublicCampagne.Text = "Veuillez sélectionner un public";
            cbxPublicCampagne.SelectedIndex = 0;

            
            cbxEmployeCampagne.DataSource = EmployeDAO.GetInstanceDAOEmploye().GetEmployes();
            cbxEmployeCampagne.DisplayMember = "NomPrenom";
            cbxEmployeCampagne.ValueMember = "Id";
            //cbxEmployeCampagne.Text = "Veuillez sélectionner un Employe assigné";
            cbxEmployeCampagne.SelectedIndex = 0;
        }

        private void btnAjoutCampagne_Click(object sender, EventArgs e)
        {
            int res = 0;
            bool ajout = false;
            if ((int)cbxPublicCampagne.SelectedValue>0 && (int)cbxEmployeCampagne.SelectedValue>0 && dtpDateFinCampagne.Value>dtpDateDebutCampagne.Value && txtNomCampagne.Text!="" && txtObjectifCampagne.Text!="")
            {
                res = CampagneManager.GetInstance().CreerCampagne(txtNomCampagne.Text, txtObjectifCampagne.Text, dtpDateDebutCampagne.Value, dtpDateFinCampagne.Value, (int)cbxPublicCampagne.SelectedValue, (int)cbxEmployeCampagne.SelectedValue);

                if (res == 1)
                {
                    MessageBox.Show("L'enregistrement de la campagne a bien été effectuer");
                    ajout = true;
                }
            }
            if(ajout==false)
            {
                MessageBox.Show("Un problème est survenu lors de l'enregistrement de la campagne");
            }

            
        }

       
    }
}
