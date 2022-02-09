using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_P20_Geometria
{
    class Interfaz
    {
        private int Opcion;
        private float LadoCuadrado;

        private float BaseRectangulo;
        private float AlturaRectangulo;

        private float BaseTriangulo;
        private float AlturaTriangulo;

        private double Radio;

        public Interfaz()
        {
            Opcion = 0;
        LadoCuadrado = 0;

        BaseRectangulo = 0;
        AlturaRectangulo = 0;

        BaseTriangulo = 0;
        AlturaTriangulo = 0;

        Radio = 0;
    }
        public void PedirLadoCuadrado()
        {
            Console.WriteLine("Dame Medida de Lado: ");
            LadoCuadrado = float.Parse(Console.ReadLine());
        }

        public void PedirBaseRectangulo()
        {
            Console.WriteLine("Dame Medida de base: ");
            BaseRectangulo = float.Parse(Console.ReadLine());
        }

        public void PedirAlturaRectangulo()
        {
            Console.WriteLine("Dame Medida de altura: ");
            AlturaRectangulo = float.Parse(Console.ReadLine());
        }

        public void PedirBaseTriangulo()
        {
            Console.WriteLine("Dame Medida de base: ");
            BaseTriangulo = float.Parse(Console.ReadLine());
        }

        public void PedirAlturaTriangulo()
        {
            Console.WriteLine("Dame Medida de altura: ");
            AlturaTriangulo = float.Parse(Console.ReadLine());
        }

        public void PedirRadio()
        {
            Console.WriteLine("Dame Medida de radio: ");
            Radio = float.Parse(Console.ReadLine());
        }

        public void ImprimirMenu()
        {
            Console.WriteLine("\nMENU GEOMETRICO :)");
            Console.WriteLine("1. Calcular Area /Base de Cuadrado");
            Console.WriteLine("2. Calcular Area /Base de Rectangulo");
            Console.WriteLine("3. Calcular Area /Base de Triangulo");
            Console.WriteLine("4. Calcular Area /Base de Circulo");
            /*Console.WriteLine("5. Area del Cuadrado");
            Console.WriteLine("6. Perimetro del Cuadrado");
            Console.WriteLine("7. Area del Rectangulo");
            Console.WriteLine("8. Perimetro del Rectangulo");
            Console.WriteLine("9. Area del Triangulo");
            Console.WriteLine("10. Perimetro del Triangulo");
            Console.WriteLine("11. Area del Circulo");
            Console.WriteLine("12. Perimetro del Circulo");*/
            Console.WriteLine("5. Salir :(");
            Console.WriteLine("Elige una opción");
            Opcion = int.Parse(Console.ReadLine());
        }

        public float GetLadoCuadrado()
        {
            return LadoCuadrado;
        }

        public float GetBaseRectangulo()
        {
            return BaseRectangulo;
        }

        public float GetAlturaRectangulo()
        {
            return AlturaRectangulo;
        }

        public float GetBaseTriangulo()
        {
            return BaseTriangulo;
        }

        public float GetAlturaTriangulo()
        {
            return AlturaTriangulo;
        }

        public double GetRadio()
        {
            return Radio;
        }

        public int GetOpcion()
        {
            return Opcion;
        }

        public void ImprimirCuadrado(Cuadrado mCuadrado)
        {
            Console.WriteLine("CUADRADO");
            Console.WriteLine("Lado: " + mCuadrado.GetLadoCuadrado());
            Console.WriteLine("Area: " + mCuadrado.GetAreaCuadrado());
            Console.WriteLine("Perimetro: " + mCuadrado.GetPerimetroCuadrado());
        }

        public void ImprimirRectangulo(Rectangulo mRectangulo)
        {
            Console.WriteLine("RECTANGULO");
            Console.WriteLine("Base: " + mRectangulo.GetBaseRectangulo());
            Console.WriteLine("Altura: " + mRectangulo.GetAlturaRectangulo());
            Console.WriteLine("Area: " + mRectangulo.GetAreaRectangulo());
            Console.WriteLine("Perimetro: " + mRectangulo.GetPerimetroRectangulo());
        }

        public void ImprimirTriangulo(Triangulo mTriangulo)
        {
            Console.WriteLine("TRIANGULO");
            Console.WriteLine("Base: " + mTriangulo.GetBaseTriangulo());
            Console.WriteLine("Altura: " + mTriangulo.GetAlturaTriangulo());
            Console.WriteLine("Area: " + mTriangulo.GetAreaTriangulo());
            Console.WriteLine("Perimetro: " + mTriangulo.GetPerimetroTriangulo());
        }

        public void ImprimirCirculo(Circulo mCirculo)
        {
            Console.WriteLine("CIRCULO");
            Console.WriteLine("Radio: " + mCirculo.GetRadio());
            Console.WriteLine("Area: " + mCirculo.GetAreaCirculo());
            Console.WriteLine("Perimetro: " + mCirculo.GetPerimetroCirculo());
        }
    }
}
