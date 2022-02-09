using System;
using System.Collections.Generic;
using System.Text;

namespace HU07ExportarCsv
{
    class ArchivoCsv
    {
        public void CrearArchivoCsv()
        {
            string docente = "juan";
            string proyectodescarga = "chocomilk";
            Listas.ListaProyectos = new List<Proyecto>();
            Proyecto mProyecto = new Proyecto();
            mProyecto.Docente = docente;
            mProyecto.ProyectoDescarga = proyectodescarga;
            Listas.ListaProyectos.Add(mProyecto);
        }
    }
}
