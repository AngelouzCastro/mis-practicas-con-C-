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
        VALIDACION mVALIDACION = new VALIDACION();
        FrmControlMembresia mFrmControlMembresia;
        public FrmAgregarMembresia()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            

            try
            {
                if (float.Parse(TxtPrecioDia.Text) <= 0)
                {
                    TxtPrecioDia.Text = "";
                }
                if (float.Parse(TxtPrecio15dias.Text) <= 0)
                {
                    TxtPrecio15dias.Text = "";
                }
                if (float.Parse(TxtPrecioSemana.Text) <= 0)
                {
                    TxtPrecioSemana.Text = "";
                }
                if (float.Parse(TxtPreciomes.Text) <= 0)
                {
                    TxtPreciomes.Text = "";
                }
                if (float.Parse(TxtPrecioAnio.Text) <= 0)
                {
                    TxtPrecioAnio.Text = "";
                }

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
                
                
                Visible = false;
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al registrar");
                if(TxtDescripcion.Text == "")
                {
                    MessageBox.Show("dato en el campo 'Descripcion' incorrecto");
                }
                else if(TxtPrecioDia.Text == "")
                {
                    MessageBox.Show("dato en el campo 'precio por Día' incorrecto");
                }
                else if (TxtPrecioSemana.Text == "")
                {
                    MessageBox.Show("dato en el campo 'precio por Semana' incorrecto");
                }
                else if (TxtPrecio15dias.Text == "")
                {
                    MessageBox.Show("dato en el campo 'precio por 15 Dias' incorrecto");
                }
                else if (TxtPreciomes.Text == "")
                {
                    MessageBox.Show("dato en el campo 'precio por Més' incorrecto");
                }
                else if (TxtPrecioAnio.Text == "")
                {
                    MessageBox.Show("dato en el campo 'precio por Año' incorrecto");
                }
               

            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void FrmAgregarMembresia_Load(object sender, EventArgs e)
        {
            TxtDescripcion.Text = "";
            TxtPrecioDia.Text = "";
            TxtPrecioSemana.Text = "";
            TxtPrecio15dias.Text = "";
            TxtPreciomes.Text = "";
            TxtPrecioAnio.Text = "";
        }

        private void TxtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            mVALIDACION.sololetras(e);

            
        }

        private void TxtPrecioDia_KeyPress(object sender, KeyPressEventArgs e)
        {
            mVALIDACION.solonumeros(e);
        }

        private void TxtPrecioSemana_KeyPress(object sender, KeyPressEventArgs e)
        {
            mVALIDACION.solonumeros(e);
        }

        private void TxtPrecio15dias_KeyPress(object sender, KeyPressEventArgs e)
        {
            mVALIDACION.solonumeros(e);
        }

        private void TxtPreciomes_KeyPress(object sender, KeyPressEventArgs e)
        {
            mVALIDACION.solonumeros(e);
        }

        private void TxtPrecioAnio_KeyPress(object sender, KeyPressEventArgs e)
        {
            mVALIDACION.solonumeros(e);
        }
    }
}
