using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_Recursividad_clase
{
    class Interfaz
    {
        private int Numero;
        private int Potenciax;
        private int Opc;

        public Interfaz()
        {
            Numero = 0;
            Potenciax = 0;
            Opc = 0;
        }

        public void PedirNumero()
        {
            Console.Write("Dame Numero: ");
            Numero = int.Parse(Console.ReadLine());
        }

        public void PedirPotencia()
        {
            Console.Write("Dame Elevacion: ");
            Potenciax = int.Parse(Console.ReadLine());
        }

        public void ImprimirMenu()
        {
            Console.WriteLine("\nMENU\n");
            Console.WriteLine("1. Calcular Potencia");
            Console.WriteLine("2. Calcular Factorial");
            Console.WriteLine("3. Imprimir Hasta Cero");
            Console.WriteLine("4. Salir");
            Console.WriteLine("Eliga Opción...");
            Opc = int.Parse(Console.ReadLine());
        }

        public int GetNumero()
        {
            return Numero;
        }

        public int GetPotenciax()
        {
            return Potenciax;
        }

        public int GetOpcion()
        {
            return Opc;
        }

        public void ImprimirPotencia(int x)
        {
            Console.WriteLine("Potencia = " + x);

        }

        public void ImprimirFactorial(int z)
        {
            Console.WriteLine("Factorial = " + z);

        }
    }
}
