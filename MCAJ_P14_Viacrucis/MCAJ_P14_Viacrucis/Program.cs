using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_P14_Viacrucis
{
    class Program
    {
        private Interfaz mInterfaz;
        private Sujeto mSujeto;
        private Estaciones mEstaciones;

        public Program()
        {
            mInterfaz = new Interfaz();
        }

        public void Correr()
        {
            int Opc;
            int i;

            do
            {
                mInterfaz.ImprimirMenu();
                Opc = mInterfaz.GetOpcion();

                switch (Opc)
                {
                    case 1:
                        mInterfaz.PedirNombreSujeto();
                        mInterfaz.PedirNumeroEstaciones();
                        mSujeto = new Sujeto(mInterfaz.GetNumeroEstaciones());
                        mSujeto.SetNombre(mInterfaz.GetNombreSujeto());
                        for (i = 0; i < mSujeto.GetNumeroEstaciones(); i++)
                        {


                            mInterfaz.PedirNombreEstacion();
                            mEstaciones.SetNombre(mInterfaz.GetNombreEstacion());
                            mInterfaz.PedirRecorrido();
                            mEstaciones.SetRecorrido(mInterfaz.GetRecorrido());
                            mSujeto.SetEstacion(mEstaciones, i);

                        }
                        mSujeto.CalcularRecorrido();

                        break;

                    case 2:
                        mInterfaz.ImprimirSujeto(mSujeto);
                        break;
                }
            } while (Opc != 3);
        }
        static void Main(string[] args)
        {
            Program mProgram = new Program();
            mProgram.Correr();
        }
    }
}
