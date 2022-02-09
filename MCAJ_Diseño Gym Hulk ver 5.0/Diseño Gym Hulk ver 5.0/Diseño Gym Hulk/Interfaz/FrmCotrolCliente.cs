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
    public partial class FrmCotrolCliente : Form
    {
        FrmAltaCliente mfrmAltaCliente;
        FrmCliente_Membresia mFrmCliente_Membresia;
        FrmEditarCliente mFrmEditarCliente;
        ControlCliente mControlCliente;
        private int ID;
        private String nombre;
        private String apellidos;
        private String telefono;
       
        public FrmCotrolCliente()
        {
            InitializeComponent();
            mfrmAltaCliente = new FrmAltaCliente();
            mFrmCliente_Membresia = new FrmCliente_Membresia();
            mFrmEditarCliente = new FrmEditarCliente();
            BtnActualizar.Visible = false;
        }

        private void FrmCotrolCliente_Activated(object sender, EventArgs e)
        {
            mControlCliente = new ControlCliente();
            TblClientes.DataSource = mControlCliente.consultarClientes().Tables[0];
        }

        private void FrmCotrolCliente_Load(object sender, EventArgs e)
        {
            
            mControlCliente = new ControlCliente();
            TblClientes.DataSource = mControlCliente.consultarClientes().Tables[0];
           
            BtnVerCliente.Enabled = false;
            BtnEditarCliente.Enabled = false;
            BtnBajaCliente.Enabled = false;
        }

        private void BtnVerCliente_Click(object sender, EventArgs e)
        {
           
           
            try
            {
                mFrmCliente_Membresia.ShowDialog();
            }
            catch (Exception)
            {
                MessageBox.Show("Selecione Primero un cliente");
            }
        }

        private void BtnEditarCliente_Click(object sender, EventArgs e)
        {
            mFrmEditarCliente.ShowDialog();
        }

        private void BtnAltaCliente_Click(object sender, EventArgs e)
        {
            mfrmAltaCliente.ShowDialog();
            BtnActualizar.Visible = true;
        }

        private void BtnBajaCliente_Click(object sender, EventArgs e)
        {
            try
            {
                Cliente mCliente = new Cliente();
                int ID = (int)TblClientes.SelectedRows[0].Cells[0].Value;

                ControlCliente mControl = new ControlCliente();
                mControl.eliminarCliente(ID);
                MessageBox.Show("Cliente eliminado");
            }
            catch (Exception error)
            {
                MessageBox.Show("Error al eliminar ");
            }
        }

        private void TblMembresias_MouseClick(object sender, MouseEventArgs e)
        {
            ID = (int)TblClientes.SelectedRows[0].Cells[0].Value;
            nombre = TblClientes.SelectedRows[0].Cells[1].Value.ToString();
            telefono = TblClientes.SelectedRows[0].Cells[2].Value.ToString();
            apellidos = TblClientes.SelectedRows[0].Cells[3].Value.ToString();
           

            mFrmEditarCliente.Id = ID;
            mFrmCliente_Membresia.Id = ID.ToString();
            mFrmEditarCliente.Nombre = nombre;
            mFrmEditarCliente.Apellidos = apellidos;
            mFrmEditarCliente.Telefono = telefono;

            BtnVerCliente.Enabled = true;
            BtnEditarCliente.Enabled = true;
            BtnBajaCliente.Enabled = true;
        }
        
        private void BtnCerrar_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void TblClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
        }

        private void TxtBuscar_KeyPress(object sender, KeyPressEventArgs e)
        {
            TblClientes.DataSource = mControlCliente.consultarClientes3(TxtBuscar.Text).Tables[0];
            
        }

        private void BtnBuscar_Click(object sender, EventArgs e)
        {
            
            TblClientes.DataSource = mControlCliente.consultarClientes2(TxtBuscar.Text).Tables[0];
            BtnActualizar.Visible = true;
        }

        private void BtnActualizar_Click(object sender, EventArgs e)
        {
            mControlCliente = new ControlCliente();
            TblClientes.DataSource = mControlCliente.consultarClientes().Tables[0];
            BtnActualizar.Visible = false;
            TxtBuscar.Text = "";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            mfrmAltaCliente.ShowDialog();
            BtnActualizar.Visible = true;
        }
    }
}
