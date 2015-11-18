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

            CampagneManager.GetInstance().SetChaineConnexion(ConfigurationManager.ConnectionStrings["Clientele"]);


        }

        private void FrmAjoutCampagne_Load(object sender, EventArgs e)
        {

        }
    }
}
