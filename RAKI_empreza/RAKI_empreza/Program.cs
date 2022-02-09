using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAKI_empreza
{
    class Program
    {
        private aDMINISTRATIVO mAdministrativo;
        private Servicios mServicios;
        private operador mOperador;
        private Interfaz mInterfaz;

        public Program()
        {
            mAdministrativo = new aDMINISTRATIVO();
            mServicios = new Servicios();
            mOperador = new operador();
            mInterfaz = new Interfaz();
        }

        public void Correr()
        {
            string Tipo;
            int Piezas;
            float Sueldo;
            float HorasT;
            int Opcion;
            string Nombre;

            do
            {
                mInterfaz.ImprimirMenu();
                Opcion = mInterfaz.GetOpcion();

                switch (Opcion)
                {
                    case 1:
                        mInterfaz.PedirHoras();
                        HorasT = mInterfaz.GetHorasT();
                        mAdministrativo.SetHorasT(HorasT);
                        mInterfaz.PedirTipo();
                        Tipo = mInterfaz.GetTipo();
                        mAdministrativo.SetTipo(Tipo);
                        mInterfaz.PedirNombre();
                        Nombre = mInterfaz.GetNombre();
                        mAdministrativo.SetNombre(Nombre);
                        mAdministrativo.CalcularTotalPagarA();
                        Sueldo = mAdministrativo.GetSueldo();
                        HorasT = mAdministrativo.GetHorasT();
                        mInterfaz.ImprimirSueldoA("Empleado Administrativo", Sueldo, HorasT, Tipo, Nombre);
                        break;

                    case 2:
                        mInterfaz.PedirHoras();
                        HorasT = mInterfaz.GetHorasT();
                        mInterfaz.PedirNombre();
                        Nombre = mInterfaz.GetNombre();
                        mAdministrativo.SetNombre(Nombre);
                        mServicios.SetHorasT(HorasT);
                        mServicios.CalcularTotalPS();
                        Sueldo = mServicios.GetSueldo();
                        HorasT = mServicios.GetHorasT();
                        mInterfaz.ImprimirSueldo("Emplado de Servicios", Sueldo, HorasT, Nombre);
                        break;

                    case 3:
                        mInterfaz.PedirHoras();
                        HorasT = mInterfaz.GetHorasT();
                        mOperador.SetHorasT(HorasT);
                        mInterfaz.PedirPiezas();
                        Piezas = mInterfaz.GetPiezas();
                        mOperador.SetPiezas(Piezas);
                        mInterfaz.PedirNombre();
                        Nombre = mInterfaz.GetNombre();
                        mAdministrativo.SetNombre(Nombre);
                        mOperador.CalcularTotalPagarO();
                        Sueldo = mOperador.GetSueldo();
                        HorasT = mOperador.GetHorasT();
                        mInterfaz.ImprimirSueldoO("Empleado Operador", Sueldo, HorasT, Piezas, Nombre);
                        break;
                }
            } while (Opcion != 4);

        }

        static void Main(string[] args)
        {
            Program mProgram = new Program();
            mProgram.Correr();
        }
    }
}

