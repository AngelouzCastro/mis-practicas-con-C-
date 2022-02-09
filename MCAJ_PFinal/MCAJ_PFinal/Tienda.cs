using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MCAJ_PFinal
{
    class Tienda
    {
        
        private Producto[] ListaProductos;
        private string Nombre;
        private double PrecioCosto;
        private double PrecioVenta;
        private double Mayor;
        private double Menor;
        private string Pro;
        private string Me;
        private double Ganancia;

        public Tienda(int NumeroProductos)
        {
            ListaProductos = new Producto[NumeroProductos];
            Nombre = "";
            PrecioCosto = 0;
            PrecioVenta = 0;
            Mayor = 0;
            Menor = 0;
            Pro = "";
            Me = "";
        }

        public void SetNombre(string Nombre)
        {
            this.Nombre = Nombre;
        }


        public void SetProducto(Producto mProducto, int i)
        {
            ListaProductos[i] = mProducto;
        }
        public void CalcularPC()
        {
            double Suma1 = 0;
            int J;
            for (J = 0; J < ListaProductos.Length; J++)
            {
                Suma1 = Suma1 + ListaProductos[J].GetPrecio();
            }
            PrecioCosto = Suma1;
        }
        public void CalcularPV()
        {
            double Suma2 = 0;
            int k;
            for (k = 0; k < ListaProductos.Length; k++)
            {
                Suma2 = Suma2 + ListaProductos[k].GetPrecioV();
            }
            PrecioVenta = Suma2;
        }
        public void CalcularGanancia()
        {
            double Suma3 = 0;
            int m;
            double Suma4 = 0;
            int n;
            for (m = 0; m < ListaProductos.Length; m++)
            {
                Suma3 = Suma3 + ListaProductos[m].GetPrecio();
            }
            PrecioCosto = Suma3;
            for (n = 0; n < ListaProductos.Length; n++)
            {
                Suma4 = Suma4 + ListaProductos[n].GetPrecioV();
            }
            PrecioVenta = Suma4;
            Ganancia = PrecioVenta - PrecioCosto;


        }
        
        public void CalcularMaYMe()
        {
            int x;
            for (x = 0; x < ListaProductos.Length; x++)
            {
                if (x == 0)
                {
                    Menor = ListaProductos[x].GetPrecio();
                    Me = ListaProductos[x].GetClave() + "   " + ListaProductos[x].GetNombre() + "   $" + Menor;
                    Mayor = ListaProductos[x].GetPrecio();
                    Pro = ListaProductos[x].GetClave() + "   " + ListaProductos[x].GetNombre() + "  $" + Mayor;
                    
                }
                else if (x != 0)
                {
                    if (ListaProductos[x].GetPrecio() < Menor)
                    {
                        Menor = ListaProductos[x].GetPrecio();
                        Pro = ListaProductos[x].GetClave() + "   " + ListaProductos[x].GetNombre() + "  $" + Menor;
                    }
                    if (ListaProductos[x].GetPrecio() > Mayor)
                    {
                        Mayor = ListaProductos[x].GetPrecio();
                        Me = ListaProductos[x].GetClave() + "   " + ListaProductos[x].GetNombre() + "   $" + Mayor;
                    }


                }
            }
        }

        public string GetNombre()
        {
            return Nombre;
        }
        public Producto GetProducto(int i)
        {
            return ListaProductos[i];
        }
        public double GetPC()
        {
            return PrecioCosto;
        }
        public double GetPV()
        {
            return PrecioVenta;
        }
        public int GetNumeroProductos()
        {
            return ListaProductos.Length;
        }
        public string GetMayor()
        {
            return Pro;
        }
        public  string GetMenor()
        {
            return Me;
        }
        public double GetGanancia()
        {
            return Ganancia;
        }
    }
}
