using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_ClaseGenerica
{
    class Program
    {
        private Intercambio<int> mIntercambio1;
        private Intercambio<string> mIntercambio2;
        private Intercambio<Persona> mIntercambio3;

        public Program()
        {
            mIntercambio1 = new Intercambio<int>();
            mIntercambio2 = new Intercambio<string>();
            mIntercambio3 = new Intercambio<Persona>();
        }

        public void Correr()
        {
            int numero1;
            int numero2;
            string nombre1;
            string nombre2;

            Persona mPersona1 = new Persona();
            Persona mPersona2 = new Persona();

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.Blue;
            numero1 = 10;
            numero2 = 15;
            nombre1 = "Maria";
            nombre2 = "Ramiro";
            mPersona1.SetNombre("Fulano de tal");
            mPersona1.SetEdad(10);
            mPersona2.SetNombre("Zutano de tal");
            mPersona2.SetEdad(30);

            
            mIntercambio1.Intercambiar(ref numero1, ref numero2);
            mIntercambio2.Intercambiar(ref nombre1, ref nombre2);
            mIntercambio3.Intercambiar(ref mPersona1, ref mPersona2);

            Console.WriteLine("numero1: " + numero1);
            Console.WriteLine("numero2: " + numero2);
            Console.WriteLine("nombre1: " + nombre1);
            Console.WriteLine("nombre2: " + nombre2);
            Console.WriteLine("nombre2: " + nombre2);
            Console.WriteLine("Nombre Persona1: " + mPersona1.GetNombre() + ",de " + mPersona1.GetEdad() + " años");
            Console.WriteLine("Nombre Persona2: " + mPersona2.GetNombre() + ",de " + mPersona2.GetEdad() + " años");

            Console.ReadKey();

        }

        static void Main(string[] args)
        {
            Program mProgram = new Program();
            mProgram.Correr();
        }
    }
}
