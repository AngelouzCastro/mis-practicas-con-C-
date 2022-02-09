using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_Recursividad_clase
{
    class Recursividad
    {
        private int Numero;
        private int Potenciax;

        public Recursividad()
        {
            Numero = 0;
            Potenciax = 0;

        }
        

        public int Potencia(int x, int y)
        {
            if (y == 1)
            {
                return x;
            }
            else if (y == 0)
            {
                return 1;
            }
            else
            {
                return x * Potencia(x, y - 1);
            }

        }

        public int factorial(int z)
        {
            if (z == 0)
            {
                return 1;
            }
            else
            {
                return z * factorial(z - 1);
            }
        }

        


        public void Zero(int w)
        {
            if (w > 0)
            {
                Console.WriteLine(w);
                Zero(w - 1);
            }

        }

       
    }
}
