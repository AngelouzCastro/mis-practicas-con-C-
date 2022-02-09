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
        validacion Teclado = new validacion();
        FrmControlMembresia mFrmControlMembresia;
        public FrmEditarMembresia()
        {
            InitializeComponent();
        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            try
            {
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
                mFrmControlMembresia.actualizartabla();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al actualizar ");
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
            Teclado.sololetras(e);
        }

        private void TxtPreciodia_KeyPress(object sender, KeyPressEventArgs e)
        {
            Teclado.solonumeros(e);
        }

        private void TxtPreciosemana_KeyPress(object sender, KeyPressEventArgs e)
        {
            Teclado.solonumeros(e)
        }

        private void TxtPrecio15dias_KeyPress(object sender, KeyPressEventArgs e)
        {
            Teclado.solonumeros(e);
        }

        private void TxtPreciomes_KeyPress(object sender, KeyPressEventArgs e)
        {
            Teclado.solonumeros(e);
        }

        private void TxtPrecioAnio_KeyPress(object sender, KeyPressEventArgs e)
        {
            Teclado.solonumeros(e);
        }
    }
}
