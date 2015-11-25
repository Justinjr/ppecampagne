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

        private void FrmAjoutCampagne_Load(object sender, EventArgs e)
        {

            




        }
    }
}
