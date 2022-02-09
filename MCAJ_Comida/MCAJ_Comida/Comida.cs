using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_Comida
{
    //3.1 Clase base
    // Es derivada ya que hereda de la clase comida
    class Comida
    {
        protected string Nombre;
        protected double Precio;
        protected double Total;

        public Comida()
        {
            Nombre = "";
            Precio = 0;
            Total = 0;
        }

        public void SetNombre(string Nombre)
        {
            this.Nombre = Nombre;
        }

        public void SetPrecio(double Precio)
        {
            this.Precio = Precio;
        }

        public void CalcularTotal()
        {
            Total = Precio;
        }

        public string GetNombre()
        {
            return Nombre;
        }

        public double GetPrecio()
        {
            return Precio;
        }

        public double GetTotal()
        {
            return Total;
        }
    }
}
/*3.2 clasificación: herencia simple, herencia multiple
 * herencia simple: una clase base hereda a a varias derivadas
 * herencia multiple: varias clases base, hereda a una derivada*/