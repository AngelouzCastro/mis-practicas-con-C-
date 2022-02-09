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
    public partial class FrmCotrolCliente : Form
    {
        FrmAltaCliente mfrmAltaCliente;
        FrmCliente_Membresia mFrmCliente_Membresia;
        FrmEditarCliente mFrmEditarCliente;

        public FrmCotrolCliente()
        {
            InitializeComponent();
            mfrmAltaCliente = new FrmAltaCliente();
            mFrmCliente_Membresia = new FrmCliente_Membresia();
            mFrmEditarCliente = new FrmEditarCliente();
        }

        private void FrmCotrolCliente_Load(object sender, EventArgs e)
        {

        }

        private void BtnVerCliente_Click(object sender, EventArgs e)
        {
            mFrmCliente_Membresia.ShowDialog();
        }

        private void BtnEditarCliente_Click(object sender, EventArgs e)
        {
            mFrmEditarCliente.ShowDialog();
        }

        private void BtnAltaCliente_Click(object sender, EventArgs e)
        {
            mfrmAltaCliente.ShowDialog();
        }
    }
}
