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
    public partial class FrmEditarCliente : Form
    {
        VALIDACION mVALIDACION = new VALIDACION();
        public FrmEditarCliente()
        {
            InitializeComponent();
        }
        private void FrmEditarCliente_Load(object sender, EventArgs e)
        {
            LblIdCliente.Text = Id.ToString();
            Txtnombre.Text = Nombre;
            Txtapellidos.Text = Apellidos;
            Txttelefono.Text = Telefono.ToString();
           
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente mCliente = new Cliente();
                int ID = Id;
                mCliente.IDCliente = ID;
                mCliente.Nombre = Txtnombre.Text;
                mCliente.Telefono = Txttelefono.Text;
                mCliente.Apellido = Txtapellidos.Text;

                ControlCliente mControlCliente = new ControlCliente();
                mControlCliente.modificarCliente(mCliente);
                MessageBox.Show("Cliente actualizado");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al actualizar ");
                if (Txtnombre.Text == "")
                {
                    MessageBox.Show("dato en el campo 'Nombre' incorrecto");
                }
                else if (Txtapellidos.Text == "")
                {
                    MessageBox.Show("dato en el campo 'Apellidos' incorrecto");
                }
                else if (Txttelefono.Text == "")
                {
                    MessageBox.Show("dato en el campo 'Telefono' incorrecto");
                }
            }
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellidos { get; set; }
        public string Telefono { get; set; }

        private void FrmEditarCliente_Load_1(object sender, EventArgs e)
        {
            LblIdCliente.Text = Id.ToString();
            Txtnombre.Text = Nombre;
            Txtapellidos.Text = Apellidos;
            Txttelefono.Text = Telefono.ToString();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void Txtnombre_KeyPress(object sender, KeyPressEventArgs e)
        {
            mVALIDACION.sololetras(e);
        }

        private void Txtapellidos_KeyPress(object sender, KeyPressEventArgs e)
        {
            mVALIDACION.sololetras(e);
        }

        private void Txttelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            mVALIDACION.telefono(e);
        }
    }
}
