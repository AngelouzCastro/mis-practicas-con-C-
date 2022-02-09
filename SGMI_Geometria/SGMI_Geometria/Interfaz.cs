using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGMI_Geometria
{
    class Interfaz
    {
        private int Lado;
        private int Base;
        private int Altura;
        private int Radio;
        private int Opcion;

        public Interfaz()
        {
            Lado = 0;
            Base = 0;
            Altura = 0;
            Radio = 0;
            Opcion = 0;
        }

        public void ImprimirMenu()
        {
            Console.Clear();
            Console.WriteLine("MENU DE OPCIONES");
            Console.WriteLine("1. Cuadrado");
            Console.WriteLine("2. Rectángulo");
            Console.WriteLine("3. Triángulo");
            Console.WriteLine("4. Círculo");
            Console.WriteLine("5. Salir");
            Console.Write("Elige opcion: ");
            Opcion = int.Parse(Console.ReadLine());
        }

        public void PedirLado()
        {
            Console.Write("Dame Lado: ");
            Lado = int.Parse(Console.ReadLine());
        }

        public void PedirBase()
        {
            Console.Write("Dame Base: ");
            Base = int.Parse(Console.ReadLine());
        }

        public void PedirAltura()
        {
            Console.Write("Dame Altura: ");
            Altura = int.Parse(Console.ReadLine());
        }

        public void PedirRadio()
        {
            Console.Write("Dame Radio: ");
            Radio = int.Parse(Console.ReadLine());
        }

        public int GetOpcion()
        {
            return Opcion;
        }

        public int GetLado()
        {
            return Lado;
        }

        public int GetBase()
        {
            return Base;
        }

        public int GetAltura()
        {
            return Altura;
        }

        public int GetRadio()
        {
            return Radio;
        }

        public void ImprimirResultados(string Texto, int Area, int Perimetro)
        {
            Console.WriteLine("El área del " + Texto + 
                " es: " + Area + 
                ", el perímetro es: " + Perimetro);
            Console.ReadKey();
        }
    }
}
