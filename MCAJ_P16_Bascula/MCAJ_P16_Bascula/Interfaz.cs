using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_P16_Bascula
{
    class Interfaz
    {
        private float Peso;
        private float Tara;
        private float Precio;

        public Interfaz()
        {
            Peso = 0;
            Tara = 0;
            Precio = 0;
        }

        public void PedirPeso()
        {
            Console.Write("Dame peso: ");
            Peso = float.Parse(Console.ReadLine());
        }

        public void PedirTara()
        {
            Console.Write("Dame Tara: ");
            Tara = float.Parse(Console.ReadLine());
        }

        public void PedirPrecio()
        {
            Console.Write("Dame Precio: ");
            Precio = float.Parse(Console.ReadLine());
        }

        public float GetPeso()
        {
            return Peso;
        }

        public float GetTara()
        {
            return Tara;
        }

        public float GetPrecio()
        {
            return Precio;
        }

        public void ImprimirBascula(double Total)
        {
            Console.WriteLine("\nPeso: " + Peso);
            Console.WriteLine("Tara: " + Tara);
            Console.WriteLine("Precio: " + Precio);
            Console.WriteLine("Total: $" + Total);
            Console.WriteLine("Precione Cualquier tecla para salir...");
            Console.ReadKey();
        }
    }
}
