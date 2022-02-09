using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_EDADES2
{
    class Alumno
    {
        private float[] Edades = new float[1000];
        private float Media;
        private double Desviacion;
        private int N;


        public Alumno()
        {
            Media = 0;
            Desviacion = 0;
            N = 0;
        }

        public void SetN(int N)
        {
            this.N = N;
        }
        public void SetEdades(float[] Edades)
        {
            this.Edades = Edades;
        }

        public void CalcularMedia(Interfaz mInterfaz)
        {
            float suma;
            suma = 0;
            for (int i = 0; i < mInterfaz.GetN(); i++)
            {
                suma = suma + Edades[i];
            }
            Media = suma / 10;
        }

        public void CalcularDesviacion(Alumno mAlumnos, Interfaz mInterfaz)
        {
            double c;
            c = 0;
            double suma;
            suma = 0;
            for (int i = 0; i < mInterfaz.GetN(); i++)
            {
                c = c + Math.Pow((Edades[i] - mAlumnos.GetMedia()), 2);

            }

            suma = c / 9;
            Desviacion = Math.Pow(suma, 0.5);
        }

        public double GetMedia()
        {
            return Media;
        }

        public double GetDesviacion()
        {
            return Desviacion;
        }

        public float[] GetEdades()
        {
            return Edades;
        }
        public int GetN()
        {
            return N;
        }
    }
}
