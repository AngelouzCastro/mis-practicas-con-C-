using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_Recursividad_clase
{
    class Program
    {
        Recursividad mRecursividad;
        Interfaz mInterfaz;

        public Program()
        {
            mRecursividad = new Recursividad();
            mInterfaz = new Interfaz();
        }


        public void Correr()
        {
            int Opc;
            int Numero;
            int Potencia;
            int n;

            do {
                mInterfaz.ImprimirMenu();
                Opc = mInterfaz.GetOpcion();

                switch (Opc)
                {
                    case 1:
                        mInterfaz.PedirNumero();
                        Numero = mInterfaz.GetNumero();
                        mInterfaz.PedirPotencia();
                        Potencia = mInterfaz.GetPotenciax();
                        n = mRecursividad.Potencia(Numero, Potencia);
                        mInterfaz.ImprimirPotencia(n);

                        break;
                    case 2:
                        mInterfaz.PedirNumero();
                        Numero = mInterfaz.GetNumero();
                        n=mRecursividad.factorial(Numero);
                        mInterfaz.ImprimirFactorial(n);
                        break;
                    case 3:
                        mInterfaz.PedirNumero();
                        Numero = mInterfaz.GetNumero();
                        mRecursividad.Zero(Numero);
                        break;
                }
            } while (Opc != 4);
        }
        
        static void Main(string[] args)
        {
            Program mprogram = new Program();
            mprogram.Correr();
        }
    }
}
