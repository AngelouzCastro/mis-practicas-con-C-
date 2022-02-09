using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_Tienda
{
    class Ventas
    {
        private DateTime Fecha;
        private Venta[] Listaventa;

        public Ventas(int NumeroVentas)
        {
            Fecha = DateTime.Now;
            Listaventa = new Venta[NumeroVentas];
        }

        public void SetFecha(DateTime Fecha)
        {
            this.Fecha = Fecha;
        }

        public void SetListaVentas(Venta mVenta, int Posicion)
        {
            Listaventa[Posicion] = mVenta;
        }
    }
}
