using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Diseño_Gym_Hulk
{
    public partial class FrmControlMembresia : Form
    {
        FrmAgregarMembresia mFrmAgregarMembresia;
        FrmEditarMembresia mFrmEditarMembresia;
        public FrmControlMembresia()
        {
            InitializeComponent();
            mFrmAgregarMembresia = new FrmAgregarMembresia();
            mFrmEditarMembresia = new FrmEditarMembresia();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            mFrmAgregarMembresia.ShowDialog();
        }

        private void BtnModificarMembresia_Click(object sender, EventArgs e)
        {
            mFrmEditarMembresia.ShowDialog();
        }
    }
}
