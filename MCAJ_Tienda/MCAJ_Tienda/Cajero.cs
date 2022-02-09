using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_Tienda
{
    class Cajero
    {
        private string RFC;
        private string Nombre;

        public Cajero()
        {
            RFC = "";
            Nombre = "";
        }

        public void SetClave(string RFC)
        {
            this.RFC = RFC;
        }

        public void SetNombre(string Nombre)
        {
            this.Nombre = Nombre;
        }

        public string GetClave()
        {
            return RFC;
        }

        public string GetNombre()
        {
            return Nombre;
        }
    }
}
