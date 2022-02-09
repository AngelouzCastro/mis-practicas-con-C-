using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_P14_Viacrucis
{
    class Sujeto
    {
        private Estaciones[] Estaciones;
        private float Recorrido;
        private string Nombre;

        public Sujeto(int NumeroEstaciones)
        {
            Nombre = "";
            Recorrido = 0;
            Estaciones = new Estaciones[NumeroEstaciones];
        }
         public void SetNombre(string Nombre)
        {
            this.Nombre = Nombre;
        }

        public void SetEstacion(Estaciones mEstaciones, int Posicion)
        {
            Estaciones[Posicion] = mEstaciones;
        }

        public void CalcularRecorrido()
        {
            float Rec;
            int i;
            Rec = 0;
            for (i= 0; i < Estaciones.Length; i++)
            {
                Rec = Rec + Estaciones[i].GetRecorrido();
            }
            Recorrido = Rec;
        }

        public string GetNombre()
        {
            return Nombre;
        }

        public Estaciones GetEstaciones(int Posicion)
        {
            return Estaciones[Posicion];
        }

        public float GetRecorrido()
        {
            return Recorrido;
        }

        public int GetNumeroEstaciones()
        {
            return Estaciones.Length;
        }

    }
}
