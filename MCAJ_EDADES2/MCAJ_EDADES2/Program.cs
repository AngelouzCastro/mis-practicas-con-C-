using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_EDADES2
{
    class Program
    {
        private Alumno mAlumnos;
        private Interfaz mInterfaz;

        public Program()
        {
            mAlumnos = new Alumno();
            mInterfaz = new Interfaz();
        }

        public void Correr()
        {
            mInterfaz.PedirN();
            mInterfaz.PedirNumeros(mAlumnos);
            mAlumnos.SetEdades(mInterfaz.GetEdades());
            mAlumnos.CalcularMedia(mInterfaz);
            mInterfaz.GetMedia();
            mAlumnos.GetMedia();
            mAlumnos.CalcularDesviacion(mAlumnos, mInterfaz);
            mInterfaz.GetDesviacion();
            mInterfaz.ImprimirDesviacion(mAlumnos.GetDesviacion());
        }
        static void Main(string[] args)
        {
            Program mProgram = new Program();
            mProgram.Correr();
        }
    }
}
