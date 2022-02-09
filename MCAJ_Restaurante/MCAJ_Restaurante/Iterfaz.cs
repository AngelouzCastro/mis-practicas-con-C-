using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_Restaurante
{
    class Iterfaz
    {
        public string Bebida;
        public string Comida;
        public int Opcion;

        public Iterfaz()
        {
            Bebida = "";
            Comida = "";
            Opcion = 0;
        }

        public void PedirBebida()
        {
            Console.WriteLine("Agregar Bebida? [s/n]");
            Bebida = Console.ReadLine();
        }
        public void PedirComida()
        {
            Console.WriteLine("Tipo Comida? [m/t/a]");
            Comida = Console.ReadLine();
        }

        public void ImprimirMenu()
        {
            Console.WriteLine("Restaurante Mar y Tierra");
            Console.WriteLine("Eliga opcion");
            Console.WriteLine("1. Pedido");
            Console.WriteLine("2. Calcular Total");
            Console.WriteLine("3. Salir");
            Opcion = int.Parse(Console.ReadLine());
        }

        public string GetBebida()
        {
            return Bebida;
        }
        public string GetComida()
        {
            return Comida;
        }
        public int GetOpcion()
        {
            return Opcion;
        }

        public void ImprimirTotal(Restaurante mRestaurante)
        {
            Console.WriteLine("Total: " + mRestaurante.GetTotal());
            Console.ReadKey();
        }

    }
}
