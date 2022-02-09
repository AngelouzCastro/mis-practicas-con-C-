using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace poteciacubic
{
    class Program
    {
        static void Main(string[] args)
        {
            int numero,elevacion;
            int Potencia =1;

            Console.Write("Dame numero: ");
            numero = int.Parse(Console.ReadLine());
            Console.Write("Dame elevacion: ");
            elevacion = int.Parse(Console.ReadLine());

            for (int i =0; i<elevacion
                ; i++)
            {
                Potencia = Potencia * numero;

                
            }
            
            Console.WriteLine("la potencia es: " + Potencia);
            Console.ReadKey();
            //potecia 
        }
    }
}
