using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGMI_Geometria
{
    class Program
    {
        private Cuadrado mCuadrado;
        private Rectangulo mRectangulo;
        private Triangulo mTriangulo;
        private Circulo mCirculo;
        private Interfaz mInterfaz;

        public Program()
        {
            mCuadrado = new Cuadrado();
            mRectangulo = new Rectangulo();
            mTriangulo = new Triangulo();
            mCirculo = new Circulo();
            mInterfaz = new Interfaz();
        }

        public void Correr()
        {
            int Lado;
            int Base;
            int Altura;
            int Radio;
            int Opcion;
            int Area;
            int Perimetro;

            do
            {
                mInterfaz.ImprimirMenu();
                Opcion = mInterfaz.GetOpcion();

                switch (Opcion)
                {
                    case 1:
                        mInterfaz.PedirLado();
                        Lado = mInterfaz.GetLado();
                        mCuadrado.SetLado(Lado);
                        mCuadrado.CalcularArea();
                        mCuadrado.CalcularPerimetro();
                        Area = mCuadrado.GetArea();
                        Perimetro = mCuadrado.GetPerimetro();
                        mInterfaz.ImprimirResultados("cuadrado", Area, Perimetro);
                        break;
                    case 2:
                        mInterfaz.PedirBase();
                        mInterfaz.PedirAltura();
                        Base = mInterfaz.GetBase();
                        Altura = mInterfaz.GetAltura();
                        mRectangulo.SetBase(Base);
                        mRectangulo.SetAltura(Altura);
                        mRectangulo.CalcularArea();
                        mRectangulo.CalcularPerimetro();
                        Area = mRectangulo.GetArea();
                        Perimetro = mRectangulo.GetPerimetro();
                        mInterfaz.ImprimirResultados("rectangulo", Area, Perimetro);
                        break;
                    case 3:
                        mInterfaz.PedirBase();
                        mInterfaz.PedirAltura();
                        Base = mInterfaz.GetBase();
                        Altura = mInterfaz.GetAltura();
                        mTriangulo.SetBase(Base);
                        mTriangulo.SetAltura(Altura);
                        mTriangulo.CalcularArea();
                        mTriangulo.CalcularPerimetro();
                        Area = mTriangulo.GetArea();
                        Perimetro = mTriangulo.GetPerimetro();
                        mInterfaz.ImprimirResultados("triangulo", Area, Perimetro);
                        break;
                    case 4:
                        mInterfaz.PedirRadio();
                        Radio = mInterfaz.GetRadio();
                        mCirculo.SetRadio(Radio);
                        mCirculo.CalcularArea();
                        mCirculo.CalcularPerimetro();
                        Area = mCirculo.GetArea();
                        Perimetro = mCirculo.GetPerimetro();
                        mInterfaz.ImprimirResultados("circulo", Area, Perimetro);
                        break;
                }
            } while (Opcion != 5);
        }

        static void Main(string[] args)
        {
            Program mProgram = new Program();
            mProgram.Correr();
        }
    }
}
