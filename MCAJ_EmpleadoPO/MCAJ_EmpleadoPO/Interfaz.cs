using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_EmpleadoPO
{
    class Interfaz
    {
        private int opc;
        private string Nombre;
        private int HT;

        public Interfaz()
        {
            Nombre = "";
            HT = 0;
            opc = 0;

        }

        public void ImprimirMenu()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.Clear();
            Console.WriteLine("1. Administrativo: ");
            Console.WriteLine("2. Servicios: ");
            Console.WriteLine("3. Operadores: ");
            Console.WriteLine("4. Salir");
            Console.WriteLine();
            Console.Write("Seleciione la opcion: ");
            opc = int.Parse(Console.ReadLine());
        }



        public void PedirNombre()
        {
            Console.Write("Nombre del empleado: ");
            Nombre = Console.ReadLine();
        }


        public void PedirHT()
        {
            Console.Write("Introduce las horas trabajadas: ");
            HT = int.Parse(Console.ReadLine());
        }
        public int Getopc()
        {
            return opc;
        }
        public int GetHT()
        {
            return HT;

        }
        public string GetNombre()
        {
            return Nombre;
        }
        public void ImprimirEmpleado(Empleado mEmpleado)
        {
            Console.WriteLine("Nombre del empleado: " + Nombre + " $ " + mEmpleado.GetTotalAPagar());
            Console.ReadKey();
        }
    }
}
