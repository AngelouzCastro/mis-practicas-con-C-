using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCAJ_Calculadora
{
    class Program
    {
        private Calculadora mCalculadora;
        private Interfaz mInterfaz;

        public Program()
        {
            mCalculadora = new Calculadora();
            mInterfaz = new Interfaz();
        }

        public void Correr()
        {
            int opc;

            do
            {
                mInterfaz.ImprimirMenu();
                opc = mInterfaz.GetOpcion();

                switch (opc)
                {
                    case 1:
                        mInterfaz.PedirNumero1();
                        mCalculadora.Setnumero1(mInterfaz.GetNumero1());
                        mInterfaz.PedirNumero2();
                        mCalculadora.Setnumero2(mInterfaz.GetNumero2());
                        break;
                    case 2:
                        mCalculadora.CalcularSuma();
                        mInterfaz.ImprimirResultado(mCalculadora.GetResultado());
                        break;

                    case 3:
                        mCalculadora.CalcularResta();
                        mInterfaz.ImprimirResultado(mCalculadora.GetResultado());
                        break;

                    case 4:
                        mCalculadora.CalcularMultiplicacion();
                        mInterfaz.ImprimirResultado(mCalculadora.GetResultado());
                        break;


                    case 5:
                        mCalculadora.CalcularDivision();
                        mInterfaz.ImprimirResultado(mCalculadora.GetResultado());
                        break;
                }


            } while (opc != 6);
        }

        static void Main(string[] args)
        {
            Program mProgram = new Program();
            mProgram.Correr();
        }
    }
}
