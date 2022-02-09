using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MCAJ_Dados
{
    class Program
    {
        static void Main(string[] args)
        {
            int Segundos;
            string RE="si";
            int[] numerosU;
            int[] numerosC;
            int sumaU=0, SumaC=0;
            int pts, pts2;
            Random R = new Random();
            int lol, la;

            while (RE == "si")
            {
                Console.WriteLine("Dame Cantidad de segundos: ");
                Segundos = int.Parse(Console.ReadLine());
                numerosU = new int[Segundos];
                numerosC = new int[Segundos];

                for (int i = 0; i < Segundos; i++)
                {
                    for (i = 0; i < Segundos; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Green;
                        lol = R.Next(1, 7);
                        numerosU[i] = lol;
                        sumaU = sumaU + numerosU[i];
                        Console.WriteLine("Usuario: " + numerosU[i]);
                        Thread.Sleep(1000);
                    }
                    Console.WriteLine("Total: " + sumaU);
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.White;
                    for (i = 0; i < Segundos; i++)
                    {
                        la = R.Next(1, 7);
                        numerosC[i] = la;
                        SumaC = SumaC + numerosC[i];
                        Console.WriteLine("CPU: " + numerosC[i]);
                        Thread.Sleep(1000);
                    }
                    Console.WriteLine("Total: " + SumaC);

                }
                pts = sumaU;
                pts2 = SumaC;
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine();
                if (pts > pts2)
                {
                    Console.WriteLine("El Ganador es el usuario :)");
                    Console.WriteLine("pts Usuario: " + pts);
                    
                }
                else if (pts < pts2)
                {
                    Console.WriteLine("El ganador es el pc: ");
                    Console.WriteLine("pts pc: " + pts2);
                    
                }
                else
                {
                    Console.WriteLine("Empate");
                    Console.WriteLine("Pts usuario: " + pts + "\nPts Pc: " + pts2);
                }
            }
            Console.ReadKey();
        }
    }
}
