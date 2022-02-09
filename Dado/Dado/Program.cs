using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dado
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int Dado;
            string Respuesta;

            Dado = random.Next(1, 7);

            Console.WriteLine("Tirar dado? [si/no]: ");
            Respuesta = Console.ReadLine();
             while (Respuesta == "si")
            {
                Console.WriteLine("numero" + Dado);
                Console.WriteLine("\nTirar dado? [si/no]: ");
                Respuesta = Console.ReadLine();
                Random random = new Random();
            }
            Console.ReadKey();

        }
    }
}
