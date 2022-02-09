using System;
using System.Collections.Generic;
using System.Text;

namespace Hu7
{
    class llenarLista
    {
        public llenarLista()
        {
            Listas.ListaProyectos = new List<Proyecto>();
        }
        public void llenar()
        {
            string Docente = "juan";
            string ProyectoDescarga = "proyecto";
            Proyecto mProyecto;
            mProyecto = new Proyecto();
            mProyecto.Docente = Docente;
            mProyecto.ProyectoDescarga = ProyectoDescarga;
            Listas.ListaProyectos.Add(mProyecto);
        }
    }
}
