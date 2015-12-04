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
    public partial class FrmAjoutMessage : Form
    {
        public FrmAjoutMessage()
        {
            InitializeComponent();
            MessageManager.GetInstance().SetChaineConnexion(ConfigurationManager.ConnectionStrings["GesCampagne"]);

            cbxCampagne.DataSource = CampagneDAO.GetInstanceDAOCampagne().GetCampagnes();
            cbxCampagne.DisplayMember = "Intitule";
            cbxCampagne.ValueMember = "Id";

            cbxEvenement.DataSource = EventDAO.GetInstanceDAOEvent().GetEvents();
            cbxEvenement.DisplayMember = "Theme";
            cbxEvenement.ValueMember = "Id";

            cbxCategorieVip.DataSource = CategorieVipDAO.GetInstanceCategorieVipDAO().GetCategoriesVip();
            cbxCategorieVip.DisplayMember = "Libelle";
            cbxCategorieVip.ValueMember = "Id";

        }
    }
}
