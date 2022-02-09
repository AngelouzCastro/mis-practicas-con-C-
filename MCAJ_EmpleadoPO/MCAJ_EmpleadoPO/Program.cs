using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_EmpleadoPO
{
    class Program
    {

        private Administrativo mAdministrativos;
        private Servicios mServicios;
        private Operador mOperadores;
        private Interfaz mInterfaz;
        private Empleado mEmpleado;

        public Program()
        {
            mInterfaz = new Interfaz();
        }
        public void Correr()
        {
            string Nombre;
            int opc;
            int HT;

            do
            {
                mInterfaz.ImprimirMenu();
                opc = mInterfaz.Getopc();

                if (opc == 1)
                {
                    mEmpleado = new Administrativo();
                }
                else if (opc == 2)
                {
                    mEmpleado = new Servicios();
                }
                else if (opc == 3)
                {
                    mEmpleado = new Operador();
                }

                if (opc != 4)
                {
                    mInterfaz.PedirNombre();
                    Nombre = mInterfaz.GetNombre();
                    mEmpleado.SetNombre(Nombre);
                    mInterfaz.PedirHT();
                    HT = mInterfaz.GetHT();
                    mEmpleado.SetHT(HT);
                    mEmpleado.CalcularTotalAPagar();
                    mInterfaz.ImprimirEmpleado(mEmpleado);
                }
            } while (opc != 4);
        }
        static void Main(string[] args)
        {
            Program mProgram = new Program();
            mProgram.Correr();
        }
    }
}
