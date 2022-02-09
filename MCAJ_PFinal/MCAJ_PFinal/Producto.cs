using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_PFinal
{
    class Producto
    {
        private string Clave;
        private string Nombre;
        private double Precio;
        private double PrecioV;

        public Producto()
        {
            Clave = "";
            Nombre = "";
            Precio =0;
            Precio = 0;
        }

        public void SetCalve(string Clave)
        {
            this.Clave = Clave;
        }
        public void SetNombre(string Nombre)
        {
            this.Nombre = Nombre;
        }
        public void SetPrecio(double Precio)
        {
            this.Precio = Precio;
        }
        public  void SetPrecioV(double PrecioV)
        {
            this.PrecioV = PrecioV;
        }

        public string GetClave()
        {
            return Clave;
        }
        public string GetNombre()
        {
            return Nombre;
        }
        public double GetPrecio()
        {
            return Precio;
        }
        public double GetPrecioV()
        {
            return PrecioV;
        }
    }
}
