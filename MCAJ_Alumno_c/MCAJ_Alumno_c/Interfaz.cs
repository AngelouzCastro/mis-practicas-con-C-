using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_Alumno_c
{
    class Interfaz
    {
        private string NC;
        private string Nombre;
        private int OPC;

        public Interfaz()
        {
            NC = "";
            Nombre = "";
            OPC = 0;
        }

        public void PedirNC()
        {
            Console.WriteLine("Dame numero de control: ");
            NC = Console.ReadLine();
        }
        public void PedirNombre()
        {
            Console.WriteLine("Dame Nombre: ");
            Nombre = Console.ReadLine();
        }
        public void ImprimirMenu()
        {
            Console.WriteLine("MENU");
            Console.WriteLine();
            Console.WriteLine("1. Agrgar Alumno");
            Console.WriteLine("2. Imprimir");
            Console.WriteLine("3. Salir");
            Console.WriteLine("Eliga Opcion...");
            OPC = int.Parse(Console.ReadLine());
        }

        public string GetNC()
        {
            return NC;
        }

        public string GetNombre()
        {
            return Nombre;
        }

        public int GetOPC()
        {
            return OPC;
        }

        public void ImprimirSaludo(Alumno mAlumno)
        {
            Console.WriteLine("Hola que tal " + mAlumno.GetNC() + " - " + mAlumno.GetNombre());
            Console.ReadKey();
        }
    }
}
