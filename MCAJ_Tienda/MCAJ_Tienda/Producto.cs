using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_Tienda
{
    class Producto
    {
        private string Clave;
        private string Nombre;
        private float Precio;

        public Producto()
        {
            Clave = "";
            Nombre = "";
            Precio = 0;
        }

        public void SetClave(string Clave)
        {
            this.Clave = Clave;
        }

        public void SetNombre(string Nombre)
        {
            this.Nombre = Nombre;
        }

        public void SetPrecio(float Precio)
        {
            this.Precio = Precio;
        }

        public string GetClave()
        {
            return Clave;
        }

        public string GetNombre()
        {
            return Nombre;
        }

        public float GetPrecio()
        {
            return Precio;
        }

       
    }
}
