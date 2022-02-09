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
    public partial class FrmPrincipal : Form
    {
       
        
        FrmControlMembresia mfrmControlMembresia;
        FrmCotrolCliente mfrmCotrolCliente;
        FrmReporte mfrmReporte;
        FRMVentaMembresia mFRMVentaMembresia;
        public FrmPrincipal()
        {
            InitializeComponent();
            mfrmControlMembresia = new FrmControlMembresia();
            mfrmCotrolCliente = new FrmCotrolCliente();
            mFRMVentaMembresia = new FRMVentaMembresia();
            mfrmReporte = new FrmReporte();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mfrmReporte.ShowDialog();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            mfrmControlMembresia.ShowDialog();
        }

        private void BtnControlCliente_Click(object sender, EventArgs e)
        {
            mfrmCotrolCliente.ShowDialog();
        }

        private void BtnVenta_Click(object sender, EventArgs e)
        {
            mFRMVentaMembresia.ShowDialog();
        }
    }
}
