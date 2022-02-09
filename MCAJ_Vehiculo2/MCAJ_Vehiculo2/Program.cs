using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_Vehiculo2
{
    class Program
    {
        private Vehiculo mVehiculo;
        private Interfaz mInterfaz;

        public Program()
        {
            mVehiculo = new Vehiculo();
            mInterfaz = new Interfaz();
        }

        public void Correr()
        {
            int Opcion;

            do
            {
                mInterfaz.ImprimirMenu();
                Opcion = mInterfaz.GetOpcion();

                switch (Opcion)
                {
                    case 1:
                        mInterfaz.PedirDistancia();
                        mVehiculo.SetDistancia(mInterfaz.GetDistancia());
                        mInterfaz.PedirVelocidad();
                        mVehiculo.SetVelocidad(mInterfaz.GetVelocidad());
                        mVehiculo.CalcularTiempo();
                        mInterfaz.ImprimirCadTiempo(mVehiculo.GetCadTiempo());
                        break;

                    case 2:
                        mInterfaz.PedirTiempo();
                        mVehiculo.SetTiempo(mInterfaz.GetTiempo());
                        mInterfaz.PedirVelocidad();
                        mVehiculo.SetVelocidad(mInterfaz.GetVelocidad());
                        mVehiculo.CalcularDistancia();
                        mInterfaz.ImprimirDistancia(mVehiculo.GetDistancia());
                        break;

                    case 3:
                        mInterfaz.PedirDistancia();
                        mVehiculo.SetDistancia(mInterfaz.GetDistancia());
                        mInterfaz.PedirTiempo();
                        mVehiculo.SetTiempo(mInterfaz.GetTiempo());
                        mVehiculo.CalcularVelocidad();
                        mInterfaz.ImprimirVelocidad(mVehiculo.GetVelocidad());
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
