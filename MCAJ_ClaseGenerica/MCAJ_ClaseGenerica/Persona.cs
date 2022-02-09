using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_ClaseGenerica
{
    class Persona
    {
        private string Nombre;
        private int Edad;

        public Persona()
        {
            Nombre = "";
            Edad = 0;
        }

        public void SetNombre(string Nombre)
        {
            this.Nombre = Nombre;
        }

        public void SetEdad(int Edad)
        {
            this.Edad = Edad;
        }

        public string GetNombre()
        {
            return Nombre;
        }

        public int GetEdad()
        {
            return Edad;
        }     
    }
}
