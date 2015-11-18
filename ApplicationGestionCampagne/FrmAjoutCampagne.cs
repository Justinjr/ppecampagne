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

namespace ApplicationGestionCampagne
{
    public partial class FrmAjoutCampagne : Form
    {
        public FrmAjoutCampagne()
        {
            InitializeComponent();

            ClientManager.GetInstance().SetChaineConnexion(ConfigurationManager.ConnectionStrings["Clientele"]);


        }

        private void FrmAjoutCampagne_Load(object sender, EventArgs e)
        {

        }
    }
}
