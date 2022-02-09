using Diseño_Gym_Hulk.Logica;
using Diseño_Gym_Hulk.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace Diseño_Gym_Hulk
{
    public partial class FRMVentaMembresia : Form
    {
       
        ControlCliente mControlCliente;
        ControlMembresia mControlmembresia;
        ControlMembresia mControlmembresia2;
        //ControlVentas mControlVentas;
        Ventas mVentass;
        private float preciosemana;
        private float preciodia;
        private float precio15dias;
        private float preciomes;
        private float precioanio;
        private float cambio;
        private int telefono;
        private int IDventas,IDcliente,IDMembresia=0;
        private String nombre;
        private String apellidos;
        private String descripcion;
        private string fecha_inicio;
        private string fecha_fin;
        VALIDACION mVALIDACION = new VALIDACION();


        public FRMVentaMembresia()
        {
            InitializeComponent();
            
           
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {

            fecha_inicio = DtpFechaInicio.Text;

            if (RbdSemana.Checked)
            {
                LblTotal.Text = preciosemana.ToString();
                fecha_fin = DtpFechaInicio.Value.AddDays(7).ToString();
            }
            if (Rbd15dias.Checked)
            {
                LblTotal.Text = precio15dias.ToString();
                fecha_fin = DtpFechaInicio.Value.AddDays(15).ToString();
                //fecha_fin = DtpFechaInicio.Value = DateTime.Today.AddDays(15);
            }
            if (RbdMes.Checked)
            {
                LblTotal.Text = preciomes.ToString();
                fecha_fin = DtpFechaInicio.Value.AddMonths(1).ToString();
                //fecha_fin = DtpFechaInicio.Value = DateTime.Today.AddMonths(1);
            }
            if (RbdDia.Checked)
            {
                LblTotal.Text = preciodia.ToString();
                //fecha_fin = DtpFechaInicio.Value = DateTime.Today.AddDays(1);
                fecha_fin = DtpFechaInicio.Value.AddDays(1).ToString();
            }
            if (RbdAnio.Checked)
            {
                LblTotal.Text = precioanio.ToString();
                //fecha_fin = DtpFechaInicio.Value = DateTime.Today.AddYears(1);
                fecha_fin = DtpFechaInicio.Value.AddYears(1).ToString();
            }

            if (validar())
            {
                double Cambiesin = float.Parse(TxtDinero.Text) - float.Parse(LblTotal.Text);



                MessageBox.Show("Cambio: " + Cambiesin);



                //}


                try
                {
                    Ventas mVentas = new Ventas();
                    mVentas.Fecha_inicio = DtpFechaInicio.Text;
                    mVentas.Fecha_fin = DtpFechaFin.Text;
                    mVentas.Total = float.Parse(LblTotal.Text);
                    mVentas.IDCliente = int.Parse(LblIdCliente.Text);
                    mVentas.IDMembresia = int.Parse(LblIdMembresia.Text);

                    cambio = float.Parse(TxtDinero.Text) - float.Parse(LblTotal.Text);



                    ControlVentas mControlVentas = new ControlVentas();

                    mControlVentas.agregarVenta(mVentas);


                    MessageBox.Show("Grasias por su preferencia");

                }
                catch (Exception error)
                {
                    MessageBox.Show("algo salio mal" + error);
                }

            }


        }
        
        private void FRMVentaMembresia_Load(object sender, EventArgs e)
        {
            
            mControlCliente = new ControlCliente();
            TblClientes.DataSource = mControlCliente.consultarClientes().Tables[0];
            mControlmembresia = new ControlMembresia();
            TblMembresia.DataSource = mControlmembresia.consultarMembresias().Tables[0];
            IDMembresia = 0;
           // IDMembresia = (int)TblMembresia.SelectedRows[0].Cells[0].Value;
           // actualizar();
            
            RbdDia.Select();
            BtnAceptar.Enabled = false;
            
            
        }

        private void TblClientes_MouseClick(object sender, MouseEventArgs e)
        {
            IDcliente = (int)TblClientes.SelectedRows[0].Cells[0].Value;
            nombre = TblClientes.SelectedRows[0].Cells[1].Value.ToString();
            telefono = TblClientes.SelectedRows[0].Cells[2].Value.ToString();
            apellidos = TblClientes.SelectedRows[0].Cells[3].Value.ToString();

            LblIdCliente.Text = IDcliente.ToString();
            LblNombreCliente.Text = nombre;
            LblApellido.Text = apellidos;
            BtnAceptar.Enabled = true;
        }

        private void TblMembresia_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Rbd15dias_CheckedChanged(object sender, EventArgs e)
        {
            actualizar();
            DtpFechaFin.Value = DateTime.Today.AddDays(15);
            precio15dias = (float)TblMembresia.SelectedRows[0].Cells[1].Value;
            LblTotal.Text = precio15dias.ToString();
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void TblMembresia_MouseClick(object sender, MouseEventArgs e)
        {
            actualizar();
            if (RbdSemana.Checked)
            {
                LblTotal.Text = preciosemana.ToString();
            }
            if (Rbd15dias.Checked)
            {
                LblTotal.Text = precio15dias.ToString();
            }
            if (RbdMes.Checked)
            {
                LblTotal.Text = preciomes.ToString();
            }
            if (RbdDia.Checked)
            {
                LblTotal.Text = preciodia.ToString();
            }
            if (RbdAnio.Checked)
            {
                LblTotal.Text = precioanio.ToString();
            }
        }

        private void RbdSemana_MouseClick(object sender, MouseEventArgs e)
        {
            //DtpFechaFin.Value = DateTime.Today.AddDays(7);
            DtpFechaFin.Value = DtpFechaInicio.Value.AddDays(7);
            if (RbdSemana.Checked)
            {
                LblTotal.Text = preciosemana.ToString();
            }
            if (Rbd15dias.Checked)
            {
                LblTotal.Text = precio15dias.ToString();
            }
            if (RbdMes.Checked)
            {
                LblTotal.Text = preciomes.ToString();
            }
            if (RbdDia.Checked)
            {
                LblTotal.Text = preciodia.ToString();
            }
            if (RbdAnio.Checked)
            {
                LblTotal.Text = precioanio.ToString();
            }
        }

        private void Rbd15dias_MouseClick(object sender, MouseEventArgs e)
        {
            DtpFechaFin.Value = DtpFechaInicio.Value.AddDays(15);
            actualizar();
            if (RbdSemana.Checked)
            {
                LblTotal.Text = preciosemana.ToString();
            }
            if (Rbd15dias.Checked)
            {
                LblTotal.Text = precio15dias.ToString();
            }
            if (RbdMes.Checked)
            {
                LblTotal.Text = preciomes.ToString();
            }
            if (RbdDia.Checked)
            {
                LblTotal.Text = preciodia.ToString();
            }
            if (RbdAnio.Checked)
            {
                LblTotal.Text = precioanio.ToString();
            }
           // DtpFechaFin.Value = DateTime.Today.AddDays(15);
          
        }

        private void RbdMes_MouseClick(object sender, MouseEventArgs e)
        {
            actualizar();
            if (RbdSemana.Checked)
            {
                LblTotal.Text = preciosemana.ToString();
            }
            if (Rbd15dias.Checked)
            {
                LblTotal.Text = precio15dias.ToString();
            }
            if (RbdMes.Checked)
            {
                LblTotal.Text = preciomes.ToString();
            }
            if (RbdDia.Checked)
            {
                LblTotal.Text = preciodia.ToString();
            }
            if (RbdAnio.Checked)
            {
                LblTotal.Text = precioanio.ToString();
            }
            //DtpFechaFin.Value = DateTime.Today.AddMonths(1);
            DtpFechaFin.Value = DtpFechaInicio.Value.AddMonths(1);
        }

        private void RbdAnio_MouseClick(object sender, MouseEventArgs e)
        {
            actualizar();
            if (RbdSemana.Checked)
            {
                LblTotal.Text = preciosemana.ToString();
            }
            if (Rbd15dias.Checked)
            {
                LblTotal.Text = precio15dias.ToString();
            }
            if (RbdMes.Checked)
            {
                LblTotal.Text = preciomes.ToString();
            }
            if (RbdDia.Checked)
            {
                LblTotal.Text = preciodia.ToString();
            }
            if (RbdAnio.Checked)
            {
                LblTotal.Text = precioanio.ToString();
            }
            // DtpFechaFin.Value = DateTime.Today.AddYears(1);
            DtpFechaFin.Value = DtpFechaInicio.Value.AddYears(1);
        }

        private void RbdDia_MouseClick(object sender, MouseEventArgs e)
        {
            actualizar();
            //DtpFechaFin.Value = DateTime.Today.AddDays(1);
            DtpFechaFin.Value = DtpFechaInicio.Value.AddDays(1);
        }

        private void FRMVentaMembresia_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void RbdDia_CheckedChanged(object sender, EventArgs e)
        {
            actualizar();
            LblMem.Text = descripcion;
            if (RbdSemana.Checked)
            {
                LblTotal.Text = preciosemana.ToString();
            }
            if (Rbd15dias.Checked)
            {
                LblTotal.Text = precio15dias.ToString();
            }
            if (RbdMes.Checked)
            {
                LblTotal.Text = preciomes.ToString();
            }
            if (RbdDia.Checked)
            {
                LblTotal.Text = preciodia.ToString();
            }
            if (RbdAnio.Checked)
            {
                LblTotal.Text = precioanio.ToString();
            }
            //DtpFechaFin.Value = DateTime.Today.AddDays(1);
            DtpFechaFin.Value = DtpFechaInicio.Value.AddDays(1);

        }

        public void actualizar()
        {
            IDMembresia = (int)TblMembresia.SelectedRows[0].Cells[0].Value;
            preciosemana = (float)TblMembresia.SelectedRows[0].Cells[1].Value;
            descripcion = (String)TblMembresia.SelectedRows[0].Cells[2].Value;
            precio15dias = (float)TblMembresia.SelectedRows[0].Cells[3].Value;
            preciomes = (float)TblMembresia.SelectedRows[0].Cells[4].Value;
            precioanio = (float)TblMembresia.SelectedRows[0].Cells[5].Value;
            preciodia = (float)TblMembresia.SelectedRows[0].Cells[6].Value;
            
            LblMem.Text = descripcion;
            LblIdMembresia.Text = IDMembresia.ToString();

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            TblClientes.DataSource = mControlCliente.consultarClientes3(TxtCliente.Text).Tables[0];
        }

        private void TxtMembresia_KeyPress(object sender, KeyPressEventArgs e)
        {
            TblMembresia.DataSource = mControlmembresia.consultarMembresia2(TxtMembresia.Text).Tables[0];
        }

        private void TxtDinero_KeyPress(object sender, KeyPressEventArgs e)
        {
            mVALIDACION.solonumeros(e);
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void DtpFechaInicio_ValueChanged(object sender, EventArgs e)
        {
            if (RbdSemana.Checked)
            {
                DtpFechaFin.Value = DtpFechaInicio.Value.AddDays(7);
            }
            if (Rbd15dias.Checked)
            {
                DtpFechaFin.Value = DtpFechaInicio.Value.AddDays(15);
            }
            if (RbdMes.Checked)
            {
                DtpFechaFin.Value = DtpFechaInicio.Value.AddMonths(1);
            }
            if (RbdDia.Checked)
            {
                DtpFechaFin.Value = DtpFechaInicio.Value.AddDays(1);
            }
            if (RbdAnio.Checked)
            {
                DtpFechaFin.Value = DtpFechaInicio.Value.AddYears(1);
            }
            
        }

        public void selecionarCliente()
        {
            IDcliente = (int)TblClientes.SelectedRows[0].Cells[0].Value;
            nombre = TblClientes.SelectedRows[0].Cells[1].Value.ToString();
            telefono = (int)TblClientes.SelectedRows[0].Cells[2].Value;
            apellidos = TblClientes.SelectedRows[0].Cells[3].Value.ToString();

            LblIdCliente.Text = IDcliente.ToString();
            LblNombreCliente.Text = nombre;
            LblApellido.Text = apellidos;

        }
        public bool validar()
        {
            if (float.Parse(TxtDinero.Text) < float.Parse(LblTotal.Text))
            {
                MessageBox.Show("Dinero insuficiente");
                return false;
            }
            else
            {
                try
                {
                    float ca = float.Parse(TxtDinero.Text);
                }
                catch (Exception e)
                {
                    MessageBox.Show(this, "Formato de cantidad o precio incorrecto");
                    TxtDinero.Text = "";
                    TxtDinero.Focus();
                    return false;
                }
                return true;
            }
        }
    }
}
