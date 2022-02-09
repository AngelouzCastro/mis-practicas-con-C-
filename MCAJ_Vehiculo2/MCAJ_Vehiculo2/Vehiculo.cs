using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_Vehiculo2
{
    class Vehiculo
    {
        private int Tiempo;
        private int Distancia;
        private int Velocidad;
        private DateTime V;
        private DateTime D;
        private DateTime T;
        TimeSpan Lapso;
        private string CadTiempo;




        public Vehiculo()
        {
            Tiempo = 0;
            Distancia = 0;
            Velocidad = 0;
            T = DateTime.Now;

        }

        public void SetD(DateTime D)
        {
            this.D = D;
        }

        public void SetV(DateTime V)
        {
            this.V = V;
        }
        public void SetTiempo(int Tiempo)
        {
            this.Tiempo = Tiempo;
        }

        public void SetDistancia(int Distancia)
        {
            this.Distancia = Distancia;
        }

        public void SetVelocidad(int Velocidad)
        {
            this.Velocidad = Velocidad;
        }

        public void CalcularTiempo()
        {
            Tiempo
                = Distancia / Velocidad;
            int h = Tiempo / 60;
            int m = Tiempo % 60;
            CadTiempo = h + ":" + m;

        }

        public void CalcularDistancia()
        {
            Distancia = Tiempo * Velocidad;
        }

        public void CalcularVelocidad()
        {
            Velocidad = Distancia / Tiempo;
        }

        public int GetTiempo()
        {
            return Tiempo;
        }

        public int GetDistancia()
        {
            return Distancia;
        }

        public int GetVelocidad()
        {
            return Velocidad;
        }

        public string GetCadTiempo()
        {
            return CadTiempo;
        }
    }
}
