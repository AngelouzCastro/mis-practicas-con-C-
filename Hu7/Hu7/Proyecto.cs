using System;
using System.Collections.Generic;
using System.Text;

namespace Hu7
{
    class Proyecto
    {
        public Proyecto()
        {
            Docente = "";
            ProyectoDescarga = "";
        }

        public Proyecto(string docente, string proyectoDescarga)
        {
            Docente = docente;
            ProyectoDescarga = proyectoDescarga;
        }

        public String Docente { get; set; }
        public String ProyectoDescarga { get; set; }

        public override String ToString()
        {
            return Docente + " - " + ProyectoDescarga;
        }
    }
}
