using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_Tienda
{
    class Venta
    {
        private int Folio;
        private DateTime Fecha;
        private Cajero mCajero;
        private Producto[] ListaProductos;
        private float Total;
        private float Efectivo;
        private float Cambio;

        public Venta(int NumeroProducto)
        {
            Folio = 0;
            Fecha = DateTime.Now;
            ListaProductos =new Producto [NumeroProducto];
            mCajero = new Cajero();
            Total = 0;
            Efectivo = 0;
            Cambio = 0;
        }

        public void SetFolio(int Folio)
        {
            this.Folio = Folio;
        }

        public void SetFecha(DateTime Fecha)
        {
            this.Fecha = Fecha;
        }

        public void SetProductos(Producto mProducto, int Posicion)
        {
            ListaProductos[Posicion] = mProducto;
        }

        public void SetmCajero(Cajero mCajero)
        {
            this.mCajero = mCajero;
        }
        
        public void SetEfectivo(float Efectivo)
        {
            this.Efectivo = Efectivo;
        }

        public void CalcularTotal()
        {
            float Suma = 0;
            int i;

            for (i = 0; i < ListaProductos.Length; i ++)
            {
                Suma = Suma + ListaProductos[i].GetPrecio();
            }
            Total = Suma;
        }

        public void CalculaCambio()
        {
            float Cambio = 0;
            Cambio = Total - Cambio;
            
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

        public Producto GetProducto(int Posicion)
        {
            return ListaProductos[Posicion];
        }

        public Cajero GetCajero(int Posicion)
        {
            return mCajero;
        }


      
    }
}
