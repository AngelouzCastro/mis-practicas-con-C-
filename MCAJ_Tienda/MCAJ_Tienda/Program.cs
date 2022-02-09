using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_Tienda
{
    class Program
    {
        private Venta mVenta;
        private Interfaz mInterfaz;
        private Cajero mCajero;
        private Ventas mVentas;
        private Producto mProducto;

        public Program()
        {
            
            mInterfaz = new Interfaz();
            mCajero = new Cajero();
            mProducto = new Producto();
        }

        static void Main(string[] args)
        {

        }
    }
}
