using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_Alumnolol
{
    class Unidad
    {
        private string Nombre;
        private float Calificacion;

        public Unidad()
        {
            Nombre = "";
            Calificacion = 0;
        }

        public void SetNombre(string Nombre)
        {
            this.Nombre = Nombre;
        }

        public void SetCalificacion(float Calificacion)
        {
            this.Calificacion = Calificacion;
        }

        public string GetNombre()
        {
            return Nombre;
        }

        public float GetCalifcacion()
        {
            return Calificacion;
        }
    }
}
