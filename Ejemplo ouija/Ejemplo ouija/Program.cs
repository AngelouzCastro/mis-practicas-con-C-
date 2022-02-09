using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejemplo_ouija
{
    class Program
    {
        static void Main(string[] args)
        {
            ConsoleKeyInfo Tecla;
            string Texto = "";
            string Respuesta;
            string frase = "freddie mercury, contesta desde el mas aya, te puedo hacer una pregunta?";
            int i, x=0;

            Console.ForegroundColor = ConsoleColor.White;
            for (i = 0; i < 72; i++)
            {
                if (x >= frase.Length)
                {
                    Console.Clear();
                    x = -1;
                }
                else
                {
                    Console.Write(frase[x]);
                    x++;
                    Thread.Sleep(100);

                }
            }


                Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\nRealiza tú Pregunta:");
            Console.ForegroundColor = ConsoleColor.White;
            Respuesta = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("Por favor espere");
            do
            {
                Tecla = Console.ReadKey(true);
                Console.Write(".");
                Thread.Sleep(1000);
                if (Tecla.Key != ConsoleKey.Enter)
                {
                    Texto = Texto + Tecla.KeyChar;
                }
            } while (Tecla.Key != ConsoleKey.Enter);

            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("\n"+Texto);
            Console.ReadKey();
        }
    }
}
