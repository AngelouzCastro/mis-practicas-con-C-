using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_EmpresaHerencia
{
    class Interfaz
    {
        private string Tipo;
        private int Piezas;
        private int Opcion;
        private float HorasT;
        private string Nombre;

        public Interfaz()
        {
            Tipo = "";
            Piezas = 0;
            Opcion = 0;
            HorasT = 0;
            Nombre = "";
        }

        public void ImprimirMenu()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.WriteLine("MENU DE OPCIONES");
            Console.WriteLine("1. Empleado Administrativo");
            Console.WriteLine("2. Empleado de Servicios");
            Console.WriteLine("3. Empleado Operador");
            Console.WriteLine("4. Salir");
            Console.WriteLine("Eliga Opcion:");
            Opcion = int.Parse(Console.ReadLine());
        }

        public void PedirNombre()
        {
            Console.Write("Dame tu nombre: ");
            Nombre = Console.ReadLine();
        }

        public void PedirHoras()
        {
            Console.Write("Cuantas Horas Trabajaste?: ");
            HorasT = float.Parse(Console.ReadLine());
        }

        public void PedirTipo()
        {
            Console.Write("\nDame Tipo de Administrativo: [(C) Confianza/ (S) Secretaria]: ");
            Tipo = Console.ReadLine();
        }

        public void PedirPiezas()
        {
            Console.Write("Dame Cantidad de piezas Terminadas: ");
            Piezas = int.Parse(Console.ReadLine());
        }

        public string GetNombre()
        {
            return Nombre;
        }

        public float GetHorasT()
        {
            return HorasT;
        }

        public int GetOpcion()
        {
            return Opcion;
        }

        public string GetTipo()
        {
            return Tipo;
        }

        public int GetPiezas()
        {
            return Piezas;
        }

        public void ImprimirSueldoA(string Texto, float Sueldo, float HorasT, string Tipo, string Nombre)
        {
            Console.WriteLine("\nTipo Emplado: \t\t\t"  + Texto + "\nSueldo:\t\t\t\t$" + Sueldo
                + "\nHoras Trabajadas:\t\t" + HorasT + " Hrs" + "\nTipo Administrador: \t\t" +  Tipo
                + "\nNombre: \t\t\t" + Nombre +
                "\n\nSueldo Por Hora $100.00 por hora (Confianza)\n$50.00 por hora (secretaria)");
            
            Console.ReadKey();
        }

        public void ImprimirSueldoO(string Texto, float Sueldo, float HorasT, int Piezas, string Nombre)
        {
            Console.WriteLine("\nTipo Empleado: \t\t\t" + Texto + "\nSueldo:\t\t\t\t$" + Sueldo
                + "\nHoras Trabajadas:\t\t" + HorasT + " Hrs" + "\nPiezas Terminadas:\t\t" + Piezas + " Pzs"
                + "\nNombre: \t\t\t" + Nombre +
                "\nDos pesos por cada pieza terminada");

            Console.ReadKey();
        }

        public void ImprimirSueldo(string Texto, float Sueldo, float HorasT, string Nombre)
        {
            Console.WriteLine("\nTipo Empleado: \t\t\t" + Texto + "\nSueldo:\t\t\t\t$" + Sueldo
                + "\nNombre: \t\t\t" + Nombre +
                "\nHoras Trabajadas:\t\t" + HorasT + " Hrs \nSueldo por hora $40.00");
            Console.ReadKey();
        }

    }
}
