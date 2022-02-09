using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_Alumno_c
{
    class Program
    {
        private Alumno mAlumno;
        private Interfaz mInterfaz;

        public Program()
        {
            mAlumno = new Alumno();
            mInterfaz = new Interfaz();
        }

        public void Correr()
        {
            string NC;
            string Nombre;
            int OPC;

            do {
                mInterfaz.ImprimirMenu();
                OPC = mInterfaz.GetOPC();
                switch (OPC)
                {
                    case 1:
                        mInterfaz.PedirNC();
                        NC = mInterfaz.GetNC();
                        mAlumno.SetNC(NC);
                        mInterfaz.PedirNombre();
                        Nombre = mInterfaz.GetNombre();
                        mAlumno.SetNombre(Nombre);
                        break;
                    case 2:
                        mInterfaz.ImprimirSaludo(mAlumno);
                        break;


                }
            } while (OPC != 3);

        }
        static void Main(string[] args)
        {
            Program mProgram = new Program();
            mProgram.Correr();
        }
    }
}
