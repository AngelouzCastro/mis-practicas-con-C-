using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCAJ_Calculadora
{
    class Interfaz
    {
        private int Numero1;
        private int Numero2;
        private int Opcion;

        public Interfaz()
        {
            Numero1 = 0;
            Numero2 = 0;
            Opcion = 0;
        }

        public void ImprimirMenu()
        {
            Console.Clear();
            Console.WriteLine("MENU");
            Console.WriteLine("1. Capturar Datos");
            Console.WriteLine("2. Sumar");
            Console.WriteLine("3. Restar");
            Console.WriteLine("4. Multiplicar");
            Console.WriteLine("5. Dividir");
            Console.WriteLine("6. Salir");
            Console.WriteLine();
            Console.WriteLine("Elija opción");
            Opcion = int.Parse(Console.ReadLine());
        }

        public void PedirNumero1()
        {
            Console.WriteLine("Dame primer numero: ");
            Numero1 = int.Parse(Console.ReadLine());
        }

        public void PedirNumero2()
        {
            Console.WriteLine("Dame Segundo numero numero: ");
            Numero2 = int.Parse(Console.ReadLine());
        }

        public int GetOpcion()
        {
            return Opcion;
        }

        public int GetNumero1()
        {
            return Numero1;
        }

        public int GetNumero2()
        {
            return Numero2;
        }

        public void ImprimirResultado(int Resultado)
        {
            Console.WriteLine("El resultado es: " + Resultado);
            Console.ReadKey();
        }

    }
}
