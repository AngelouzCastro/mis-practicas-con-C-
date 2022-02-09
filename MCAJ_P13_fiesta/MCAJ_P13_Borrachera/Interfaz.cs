using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_P13_Borrachera
{
    class Interfaz
    {
        private int Personas;
        private int Opcion;

        public Interfaz()
        {
            Personas = 0;
            Opcion = 0;
        }

        public void PedirPersonas()
        {
            Console.Write("Cuantas personas son: ");
            Personas = int.Parse(Console.ReadLine());
        }

        public void ImprimirMenu()
        {
            
            Console.WriteLine("MENU");
            Console.WriteLine("1. Pedir Personas");
            Console.WriteLine("2. Calcular Borrachera");
            Console.WriteLine("3. Salir");
            Console.WriteLine();
            Console.Write("Elija opción ");
            Opcion = int.Parse(Console.ReadLine());
        }

        public int GetPersonas()
        {
            return Personas;
        }

        public int GetOpcion()
        {
            return Opcion;
        }
        /*
        public void ImprimirTotal(float Total)
        {
            Console.WriteLine("Total: $ " + Total);
            Console.ReadKey();
        }*/
        public void ImprimirTotal(Peda mPeda)
        {
            
            Console.WriteLine("Total: $ " + mPeda.GetTotal());
            Console.WriteLine("le tocan de: $ " + mPeda.GetDivicion() + " por ser " + Personas + " Personas");
            Console.WriteLine();
        }
    }
}
