using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hu7
{
    public partial class FrmGenerarArchivoCsv : Form
    {
        private ArchivoCsv mArchivoCsv;
        public FrmGenerarArchivoCsv()
        {
            InitializeComponent();
            mArchivoCsv = new ArchivoCsv();
        }

        private void FrmGenerarArchivoCsv_Load(object sender, EventArgs e)
        {
            LblArchivo.Text = "";
            
            
        }

        private void BtnAceptar_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog Ubicacion = new FolderBrowserDialog();
            if (Ubicacion.ShowDialog() == DialogResult.OK)
            {
                LblArchivo.Text = Ubicacion.SelectedPath;
                mArchivoCsv.crearArchivoCsv(Listas.ListaProyectos,LblArchivo.Text+ @"\proyectos_de_descarga.csv");
                MessageBox.Show("Se a creado el archivo exitosamente");
                this.Close();
            }
            else
            {
                MessageBox.Show("No se pudo crear el archivo!");
                this.Close();
            }
        }

        private void BtnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
