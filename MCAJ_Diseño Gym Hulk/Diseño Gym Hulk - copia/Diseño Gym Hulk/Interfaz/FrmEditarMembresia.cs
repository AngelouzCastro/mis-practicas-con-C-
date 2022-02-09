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
    public partial class FrmEditarMembresia : Form
    {
        FrmControlMembresia mFrmControlMembresia;
        VALIDACION mValidacion = new VALIDACION();
        public FrmEditarMembresia()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                if (float.Parse(TxtPreciodia.Text) <= 0)
                {
                    TxtPreciodia.Text = "";
                }
                if (float.Parse(TxtPrecio15dias.Text) <= 0)
                {
                    TxtPrecio15dias.Text = "";
                }
                if (float.Parse(TxtPreciosemana.Text) <= 0)
                {
                    TxtPreciosemana.Text = "";
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
                int ID = Id;
                mMembresia.IDMembresia = ID;
                mMembresia.Preciosemana = float.Parse(TxtPreciosemana.Text);
                mMembresia.Descripcion = TxtDescripcion.Text;
                mMembresia.Precio15dias = float.Parse(TxtPrecio15dias.Text);
                mMembresia.Preciomes = float.Parse(TxtPreciomes.Text);
                mMembresia.Precioanio = float.Parse(TxtPrecioAnio.Text);
                mMembresia.Preciodia = float.Parse(TxtPreciodia.Text);
                
               
                

                ControlMembresia mControlMembresia = new ControlMembresia();
                mControlMembresia.modificarMembresia(mMembresia);
                
               
                MessageBox.Show("Datos de Membresia actualizada");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al actualizar ");
                if (TxtDescripcion.Text == "")
                {
                    MessageBox.Show("dato en el campo 'Descripcion' incorrecto");
                }
                else if (TxtPreciodia.Text == "")
                {
                    MessageBox.Show("dato en el campo 'precio por Día' incorrecto");
                }
                else if (TxtPreciosemana.Text == "")
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
        public int Id { get; set; }
        public float Preciosemana { get; set; }
        public String Descripcion { get; set; }
        public float Preciodia { get; set; }
        public float Precio15dias { get; set; }
        public float Preciomes { get; set; }
        public float Precioanio { get; set; }

        private void FrmEditarMembresia_Load(object sender, EventArgs e)
        {
            LblID.Text = Id.ToString();
            TxtDescripcion.Text = Descripcion;
            TxtPreciosemana.Text = Preciosemana.ToString();
            TxtPreciodia.Text = Preciodia.ToString();
            TxtPrecio15dias.Text = Precio15dias.ToString();
            TxtPreciomes.Text = Preciomes.ToString();
            TxtPrecioAnio.Text = Precioanio.ToString();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void TxtDescripcion_KeyPress(object sender, KeyPressEventArgs e)
        {
            mValidacion.sololetras(e);
        }

        private void TxtPreciodia_KeyPress(object sender, KeyPressEventArgs e)
        {
            mValidacion.solonumeros(e);
        }

        private void TxtPreciosemana_KeyPress(object sender, KeyPressEventArgs e)
        {
            mValidacion.solonumeros(e);
        }

        private void TxtPrecio15dias_KeyPress(object sender, KeyPressEventArgs e)
        {
            mValidacion.solonumeros(e);
        }

        private void TxtPreciomes_KeyPress(object sender, KeyPressEventArgs e)
        {
            mValidacion.solonumeros(e);
        }

        private void TxtPrecioAnio_KeyPress(object sender, KeyPressEventArgs e)
        {
            mValidacion.solonumeros(e);
        }
    }
}
