using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_Alumnolol
{
    class Materia
    {
        private string Clave;
        private string Nombre;
        private Unidad[] ListaUnidades;
        private float Promedio;


        public Materia(int NumeroUnidades)
        {
            Clave = "";
            Nombre = "";
            ListaUnidades = new Unidad[NumeroUnidades]; 
            Promedio = 0;
        }
        public void SetClave(string Clave)
        {
            this.Clave = Clave;
        }

        public void SetNombre(string Nombre)
        {
            this.Nombre = Nombre;
        }

        public void SetUnidad(Unidad mUnidad, int Posicion)
        {
            ListaUnidades[Posicion] = mUnidad;
        }

        public Unidad GetUnidad(int Posicion)
        {
            return ListaUnidades[Posicion];
        }

        public void CalcularPromedio()
        {
            float Suma = 0;
            int i;
            for (i= 0; i < ListaUnidades.Length; i++)
                {
                Suma = Suma + ListaUnidades[i].GetCalifcacion();
                }

            Promedio = Suma / ListaUnidades.Length;
        }

        public string GetClave()
        {
            return Clave;
        }

        public string GetNombre()
        {
            return Nombre;
        }

        public float GetPromedio()
        {
            return Promedio;
        }



    }
}
