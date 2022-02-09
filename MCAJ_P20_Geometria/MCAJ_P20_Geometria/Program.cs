using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_P20_Geometria
{
    class Program
    {
        private Interfaz mInterfaz;
        private Cuadrado mCuadrado;
        private Rectangulo mRectangulo;
        private Triangulo mTriangulo;
        private Circulo mCirculo;

        public Program()
        {
            mInterfaz = new Interfaz();
            mCuadrado = new Cuadrado();
            mRectangulo = new Rectangulo();
            mTriangulo = new Triangulo();
            mCirculo = new Circulo();
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
                    case 1:
                        mInterfaz.PedirLadoCuadrado();
                        mCuadrado.SetLadoCuadrado(mInterfaz.GetLadoCuadrado());
                        mCuadrado.CalcularAreaCuadrado();
                        mCuadrado.CalcularPerimetroCuadrado();
                        mInterfaz.ImprimirCuadrado(mCuadrado);
                        break;


                    case 2:
                        mInterfaz.PedirBaseRectangulo();
                        mRectangulo.SetBaseRectangulo(mInterfaz.GetBaseRectangulo());
                        mInterfaz.PedirAlturaRectangulo();
                        mRectangulo.SetAlturaRectangulo(mInterfaz.GetAlturaRectangulo());
                        mRectangulo.CalcularAreaRectangulo();
                        mRectangulo.CalcularPerimetroRectangulo();
                        mInterfaz.ImprimirRectangulo(mRectangulo);
                        break;
                    

                    case 3:
                        mInterfaz.PedirBaseTriangulo();
                        mTriangulo.SetBaseTriangulo(mInterfaz.GetBaseTriangulo());
                        mInterfaz.PedirAlturaTriangulo();
                        mTriangulo.SetAlturaTriangulo(mInterfaz.GetAlturaTriangulo());
                        mTriangulo.CalcularAreaTriangulo();
                        mTriangulo.CalcularPerimetroTriangulo();
                        mInterfaz.ImprimirTriangulo(mTriangulo);
                        break;

                    case 4:
                        mInterfaz.PedirRadio();
                        mCirculo.SetRadio(mInterfaz.GetRadio());
                        mCirculo.CalcularAreaCirculo();
                        mCirculo.CalcularPerimetroCirculo();
                        mInterfaz.ImprimirCirculo(mCirculo);
                        break;

                }
            } while (Opc != 5);
        }


        static void Main(string[] args)
        {
            Program mProgram = new Program();
            mProgram.Correr();
        }
    }
}
