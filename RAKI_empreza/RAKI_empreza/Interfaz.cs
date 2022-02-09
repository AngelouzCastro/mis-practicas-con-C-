using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAKI_empreza
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
            Console.WriteLine("\nTipo Emplado: " + Texto + "Sueldo: $" + Sueldo
                + "\nHoras Trabajadas:" + HorasT + " Hrs" + "\nTipo Administrador: " + Tipo
                + "\nNombre: " + Nombre);

            Console.ReadKey();
        }

        public void ImprimirSueldoO(string Texto, float Sueldo, float HorasT, int Piezas, string Nombre)
        {
            Console.WriteLine("\nTipo Empleado: " + Texto + "\nSueldo: $" + Sueldo
                + "\nHoras Trabajadas" + HorasT + " Hrs" + "\nPiezas Terminadas: " + Piezas + " Pzs"
                + "\nNombre: " + Nombre);

            Console.ReadKey();
        }

        public void ImprimirSueldo(string Texto, float Sueldo, float HorasT, string Nombre)
        {
            Console.WriteLine("\nTipo Empleado: " + Texto + "\nSueldo: $" + Sueldo
                + "\nNombre: " + Nombre +
                "\nHoras Trabajadas: " + HorasT + " Hrs");
            Console.ReadKey();
        }

    }
}
