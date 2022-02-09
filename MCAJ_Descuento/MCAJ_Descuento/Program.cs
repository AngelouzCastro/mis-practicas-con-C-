using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_Descuento
{
    class Program
    {
        static void Main(string[] args)
        {
            double Precio = 0.0;
            String Nombre = "";
            double Subtotal = 0;
            double Subtotalx = 0;
            bool x = false;
            double Total = 0;
            String Cadena = "";
            double descuento = 0.0005;
            double descuento2 = 0.05;
            double descuento3 = 0.0;
            String Mientras;


            while (x == false)
            {
                Console.Write("Dame Nombre de productos: ");
                Nombre = Console.ReadLine();
                Console.Write("Dame Precio: ");
                Precio = double.Parse(Console.ReadLine());
                descuento3 = descuento3 + Precio * descuento;
                Subtotalx = Precio - descuento3;
                Subtotal = Subtotal + Precio - descuento3;
                Cadena = Cadena + Nombre + " - " + Precio + " - " + descuento2 + "%" + " - " + Subtotalx + "\n";
                descuento = descuento * 2;
                descuento2 = descuento2 * 2;
                Console.WriteLine("Otro producto?:  si/no");
                Mientras = Console.ReadLine();
                if (Mientras == "SI" || Mientras == "si" || Mientras == "Si" || Mientras == "sI")
                {
                    x = false;
                }
                else
                {
                    x = !false;
                }
            }

            Subtotalx = Subtotal * 0.16;
            Total = Subtotalx + Subtotal;
            Console.WriteLine(Cadena + "\n" + "Subtotal: $" + Subtotal + "\n" + "Total: $" + Total);
            Console.ReadKey();

        }
    }
}