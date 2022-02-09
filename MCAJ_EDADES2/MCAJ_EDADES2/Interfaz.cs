using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_EDADES2
{
    class Interfaz
    {
        private float Media;
        private double Desviacion;
        private float[] Edades = new float[1000];
        private int N;

        public Interfaz()
        {
            Media = 0;
            Desviacion = 0;
            N = 0;
        }

        public void PedirN()
        {
            Console.WriteLine("Dame numero de edades: ");
            N = int.Parse(Console.ReadLine());
        }
        public void PedirNumeros(Alumno mAlumnos)
        {
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine("Dame edad: ");
                Edades[i] = float.Parse(Console.ReadLine());
            }
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

        public void ImprimirDesviacion(double Desviacion)
        {
            Console.WriteLine("El resultado es: " + Desviacion);
            Console.ReadKey();
        }
    }
}
