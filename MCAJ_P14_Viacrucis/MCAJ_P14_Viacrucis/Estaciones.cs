using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_P14_Viacrucis
{
    class Estaciones
    {
        private string Nombre;
        private float Recorrido;
        
        public Estaciones()
        {
            Nombre = "";
            Recorrido = 0;
        }

        public void SetNombre(string Nombre)
        {
            this.Nombre = Nombre;
        }

        public void SetRecorrido( float Recorrido)
        {
            this.Recorrido = Recorrido;
        }

        public string GetNombre()
        {
            return Nombre;
        }

        public float GetRecorrido()
        {
            return Recorrido;
        }

    }
}
