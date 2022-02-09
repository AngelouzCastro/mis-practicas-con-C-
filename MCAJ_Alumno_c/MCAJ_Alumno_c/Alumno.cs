using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_Alumno_c
{
    class Alumno
    {
        private string NC;
        private string Nombre;

        public Alumno()
        {
            NC = "";
            Nombre = "";
        }

        public void SetNC(string NC)
        {
            this.NC = NC;
        }

        public void SetNombre(string Nombre)
        {
            this.Nombre = Nombre;
        }

        public string GetNC()
        {
            return NC;
        }

        public string GetNombre()
        {
            return Nombre;
        }
    }
}
