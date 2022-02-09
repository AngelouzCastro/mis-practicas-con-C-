using Diseño_Gym_Hulk.Datos;
using Diseño_Gym_Hulk.Logica;
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
    public partial class FrmAltaCliente : Form
    {
        public FrmAltaCliente()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente mCliente = new Cliente();
                mCliente.Nombre = TxtNombres.Text;
                mCliente.Apellido = TxtApellidos.Text;
                mCliente.Telefono = int.Parse(TxtTelefono.Text);

                ControlCliente mControlCliente = new ControlCliente();
                mControlCliente.agregarCliente(mCliente);
                MessageBox.Show("Cliente Registrado");
                this.Visible = false;
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al Registrar");
            }

        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void FrmAltaCliente_Load(object sender, EventArgs e)
        {

        }
    }
}
