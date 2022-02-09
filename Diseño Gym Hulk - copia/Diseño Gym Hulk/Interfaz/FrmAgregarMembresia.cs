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
    public partial class FrmAgregarMembresia : Form
    {
        FrmControlMembresia mFrmControlMembresia;
        public FrmAgregarMembresia()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                Membresia mMembresia = new Membresia();
                mMembresia.Preciosemana = float.Parse(TxtPrecioSemana.Text);
                mMembresia.Descripcion = TxtDescripcion.Text;
                mMembresia.Precio15dias = float.Parse(TxtPrecio15dias.Text);
                mMembresia.Preciomes = float.Parse(TxtPreciomes.Text);
                mMembresia.Precioanio = float.Parse(TxtPrecioAnio.Text);
                mMembresia.Preciodia = float.Parse(TxtPrecioDia.Text);
               

                ControlMembresia mControlMembresia = new ControlMembresia();
                mControlMembresia.agregarMembresia(mMembresia);
                MessageBox.Show("Membresia Registrada con exito");
                mFrmControlMembresia.actualizartabla();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al registrar");
            }
            Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void FrmAgregarMembresia_Load(object sender, EventArgs e)
        {

        }
    }
}
