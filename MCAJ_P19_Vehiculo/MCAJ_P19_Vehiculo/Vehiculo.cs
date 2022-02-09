using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_P19_Vehiculo
{
    class Vehiculo
    {
        private float Tiempo;
        private float Distancia;
        private float Velocidad;

        public Vehiculo()
        {
            Tiempo = 0;
            Distancia = 0;
            Velocidad = 0;
        }

        public void SetTiempo(float Tiempo)
        {
            this.Tiempo = Tiempo;
        }

        public void SetDistancia(float Distancia)
        {
            this.Distancia = Distancia;
        }

        public void SetVelocidad(float Velocidad)
        {
            this.Velocidad = Velocidad;
        }

        public void CalcularTiempo()
        {
            Tiempo = Distancia / Velocidad;
        }

        public void CalcularDistancia()
        {
            Distancia = (Velocidad * Tiempo);
        }

        public void CalcularVelocidad()
        {
            Velocidad = Distancia / Tiempo;
        }

        public float GetTiempo()
        {
            return Tiempo;
        }

        public float GetDistancia()
        {
            return Distancia;
        }

        public float GetVelocidad()
        {
            return Velocidad;
        }
    }
}
