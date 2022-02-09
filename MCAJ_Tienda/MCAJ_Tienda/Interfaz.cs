using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_Tienda
{
    class Interfaz
    {
        private string Clave;
        private string NombreProducto;
        private float Precio;
        private int Folio;
        private DateTime Fecha;
        private Cajero mCajero;
        private Producto[] ListaProductos;
        private float Total;
        private float Efectivo;
        private float Cambio;
        private string RFC;
        private string NombreCajero;
        private int Opcion;
        private int Opcion2;

        public Interfaz()
        {
            Clave = "";
            NombreProducto = "";
            Precio = 0;
            Folio = 0;
            Fecha = DateTime.Now;
            mCajero = new Cajero();
            Total = 0;
            Efectivo = 0;
            Cambio = 0;
            RFC = "";
            NombreCajero = "";
            Opcion = 0;
            Opcion2 = 0;
        }

        public void ImprimirMenu()
        {
            Console.WriteLine("TIENDA ESPALDA X2 :')");
            Console.WriteLine("1.Nueva Venta");
            Console.WriteLine("2.Calcular Producto");
            Console.WriteLine("3.Cerrar Venta");
            Console.WriteLine("4.Reporte Diario");
            Console.WriteLine("5.Calcular Comiciones");
            Console.WriteLine("6.Salir");
            Console.WriteLine("Elige Opcion");
            Opcion = int.Parse(Console.ReadLine());
        }

        public void PedirClave()
        {
            Console.Write("Dame Calve");
            Clave = Console.ReadLine();
        }

        public void PedirNombreProducto()
        {
            Console.Write("Dame Nombre De Producto: ");
            NombreProducto = Console.ReadLine();
        }

        public void PedirPrecio()
        {
            Console.Write("Dame precio de producto: ");
            Precio = float.Parse(Console.ReadLine());
        }

        public void PedirFolio()
        {
            Console.Write("Dame numero de folio: ");
            Folio = int.Parse(Console.ReadLine());
        }

        public void PedirFecha()
        {
            Console.WriteLine("Dame Fecha de hoy: ");
            Fecha = DateTime.Parse(Console.ReadLine());
        }

        public void PedirmCajero()
        {
            Console.WriteLine("1. Cajero: X");
            Console.WriteLine("2. cajero: y");
            Opcion2 = int.Parse(Console.ReadLine());
            if (Opcion2 == 0)
            {
                NombreCajero = "x";
            }
            else
            {
                NombreCajero = "y";
            }
        }

        public void PedirEfectivo()
        {
            Console.WriteLine("Efectivo: ");
            Efectivo = float.Parse(Console.ReadLine());
        }

       
        public void PedirRFC()
        {
            Console.WriteLine("Dame RFC de Cajero");
            RFC = Console.ReadLine();
        }



        public string GetClave()
        {
            return Clave;
        }

        public string GetNombreProducto()
        {
            return NombreProducto;
        }

        public float GetPrecio()
        {
            return Precio;
        }

        public int GetFolio()
        {
            return Folio;
        }

        public DateTime GetFecha()
        {
            return Fecha;
        }

        public float GetEfectivo()
        {
            return Efectivo;
        }

        public string GetRFC()
        {
            return RFC;
        }
         public int GetOpcion()
        {
            return Opcion;
        }

        public int GetOpcion2()
        {
            return Opcion2;
        }

        public void ImprimirTotal(float Total)
        {
            Console.WriteLine("El total es :" + Total);
        }

        public void imprimirCambio(float Cambio)
        {
            Console.WriteLine("Cambio" + Cambio);
        }
    }
}
