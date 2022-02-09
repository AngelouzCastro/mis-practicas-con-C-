using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_VentaDeGanado
{
    class Interfaz
    {
        private int Opcion;
        private double Peso;

        public Interfaz()
        {
            Opcion = 0;
            Peso = 0;
        }

        public void ImprimirMenu()
        {
            Console.Clear();
            Console.WriteLine("1. Venta de Ovino");
            Console.WriteLine("2. Venta de Vacuno");
            Console.WriteLine("3. Salir");
            Console.WriteLine();
            Console.WriteLine("Selecione Opción");
            Opcion = int.Parse(Console.ReadLine());
        }

        public void PedirPeso()
        {
            bool Correcto = false;

            do
            {
                Console.WriteLine("Dame Peso: ");
                try
                {
                    Peso = double.Parse(Console.ReadLine());
                    Correcto = true;
                }
                catch (Exception e)
                {
                    ImprimirError(e.Message);
                    Correcto = false;
                }

            } while (Correcto == false);
        }

        public double GetPeso()
        {
            return Peso;
        }

        public int GetOpcio()
        {
            return Opcion;
        }

        public void ImprimirError(string Texto)
        {
            Console.WriteLine("Error: " + Texto);
        }

        public void ImprimirTotal(Ganado mGanado)
        {
            Console.WriteLine("Total: $" + mGanado.GetTotal());
            Console.ReadKey();
        }
    }
}
