using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ApplicationGestionCampagne
{
    public partial class FrmMenu : Form
    {
        public FrmMenu()
        {
            InitializeComponent();
        }

        private void btnAjoutCampagne_Click(object sender, EventArgs e)
        {
            FrmAjoutCampagne leFrmCampagne;
            leFrmCampagne = new FrmAjoutCampagne();
            leFrmCampagne.ShowDialog();
        }

        private void btnAjoutEvent_Click(object sender, EventArgs e)
        {
            FrmAjoutEvent leFrmEvent;
            leFrmEvent = new FrmAjoutEvent();
            leFrmEvent.ShowDialog();
        }

        private void btnAjoutArtiste_Click(object sender, EventArgs e)
        {
            FrmAjoutArtiste leFrmArtiste;
            leFrmArtiste = new FrmAjoutArtiste();
            leFrmArtiste.ShowDialog();
        }

        private void btnAjoutMessage_Click(object sender, EventArgs e)
        {
            FrmAjoutMessage leFrmMessage;
            leFrmMessage = new FrmAjoutMessage();
            leFrmMessage.ShowDialog();
        }
    }
}
