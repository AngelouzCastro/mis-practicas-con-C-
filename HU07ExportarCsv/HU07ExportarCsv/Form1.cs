using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HU07ExportarCsv
{
    public partial class FrmArchivoCsv : Form
    {
        
        public FrmArchivoCsv()
        {
            InitializeComponent();
            //int cantidad = Listas.ListaProyectos.Count;
            int cantidad = 2;
            PBCarga.Maximum = cantidad;
        }
        public void llenarlista()
        {
            Proyecto mProyecto;
            Listas.ListaProyectos = new List<Proyecto>();
            for (int i = 0; i < 10; i++)
            {
                string docente = "juan";
                string proyectodescarga = "chocomilk";
                mProyecto = new Proyecto();
                mProyecto.Docente = docente;
                mProyecto.ProyectoDescarga = proyectodescarga;
                Listas.ListaProyectos.Add(mProyecto);
                MessageBox.Show("llenando" + Listas.ListaProyectos);
            }
            
        }
        struct ArchivoCsv
        {
            public List<Proyecto> listaProyectosTemporal;
            public string NombreArchivo { get; set; }
        }
        ArchivoCsv mArchivoCsv;
        private void Form1_Load(object sender, EventArgs e)
        {
            llenarlista();
        /*
            if (BWayuda.IsBusy)
                return;
        */
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "CSV|*.csv", ValidateNames = true })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    mArchivoCsv.listaProyectosTemporal = Listas.ListaProyectos;
                    mArchivoCsv.NombreArchivo = sfd.FileName;
                    BWayuda.RunWorkerAsync(mArchivoCsv);
                }
            }
            //MessageBox.Show("Archico creado");
            this.Close();

        }
        private void BWayuda_DoWork(object sender, DoWorkEventArgs e)
        {

            List<Proyecto> proyectoslista = ((ArchivoCsv)e.Argument).listaProyectosTemporal;
            string nombreArchivo = ((ArchivoCsv)e.Argument).NombreArchivo;

            using (StreamWriter sw = new StreamWriter(new FileStream(nombreArchivo, FileMode.Create), Encoding.UTF8))
            {
                StringBuilder sb = new StringBuilder();
                sb.AppendLine("Docente,proyecto de descarga");
                
                foreach (Proyecto p in proyectoslista)
                {
                    PBCarga.PerformStep();
                    sb.AppendLine(string.Format("{0},{1}", p.Docente, p.ProyectoDescarga));
                }
                sw.Write(sb.ToString());
            }
        }
    }
}
