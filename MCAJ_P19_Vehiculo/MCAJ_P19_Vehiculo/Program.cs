using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_P19_Vehiculo
{
    class Program
    {
        private Interfaz mInterfaz;
        private Vehiculo mVehiculo;

        public Program()
        {
            mInterfaz = new Interfaz();
            mVehiculo = new Vehiculo();
        }

        public void Correr()
        {
            int Opc;
            do
            {
                mInterfaz.ImprimirMenu();
                Opc = mInterfaz.GetOpcion();

                switch (Opc)
                {
                    //Calcular Tiempo
                    case 1:
                        mInterfaz.PedirDistancia();
                        mVehiculo.SetDistancia(mInterfaz.GetDistancia());
                        mInterfaz.PedirVelocidad();
                        mVehiculo.SetVelocidad(mInterfaz.GetVelocidad());
                        mVehiculo.CalcularTiempo();
                        mInterfaz.ImprimirResultado(mVehiculo);
                        break;

                    //Calcular Distancia
                    case 2:
                        mInterfaz.PedirVelocidad();
                        mVehiculo.SetVelocidad(mInterfaz.GetVelocidad());
                        mInterfaz.PedirTiempo();
                        mVehiculo.SetTiempo(mInterfaz.GetTiempo());
                        mVehiculo.CalcularDistancia();
                        mInterfaz.ImprimirResultado(mVehiculo);
                        break;

                    //Calcular Vlocidad
                    case 3:
                        mInterfaz.PedirDistancia();
                        mVehiculo.SetDistancia(mInterfaz.GetDistancia());
                        mInterfaz.PedirTiempo();
                        mVehiculo.SetTiempo(mInterfaz.GetTiempo());
                        mVehiculo.CalcularVelocidad();
                        mInterfaz.ImprimirResultado(mVehiculo);
                        break;
                }
            } while (Opc != 4);

        }

        static void Main(string[] args)
        {
            Program mProgram = new Program();
            mProgram.Correr();
        }
    }
}
