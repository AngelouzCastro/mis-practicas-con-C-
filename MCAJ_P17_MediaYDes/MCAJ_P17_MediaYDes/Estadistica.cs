using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_P17_MediaYDes
{
    class Estadistica
    {
        private double Media;
        private double Desviacion;
        private double[] Edades;

        public Estadistica()
        {
            Media = 0;
            Desviacion = 0;
            Edades = new double[numero];
        }

        

        public void SetEdad(double Edad, int Posicion)
        {
            this.Edades[Posicion] = Edad;
        }

        public double GetEdad(int Posicion)
        {
            return Edades[Posicion];
        }

         public void CalcularMedia()
        {
            double Suma = 0;
            int i;

            for(i=0; i < 10; i++)
            {
                Suma = Suma + Edades[i];
            }
            Media = Suma / 10;
        }

       

        public void CalcularDesciacion()
        {
            
            double Suma = 0;
            double SumaCua = 0;
            double[] Restina = new double[10];
            double[] Cuadrado = new double[10];
            double Raiz;
            int i;

            for (i = 0; i < 10; i++)
            {
                Suma = Suma + Edades[i];
            }
            Media = Suma / 10;

            for (i=0; i<10; i++)
            {
                Restina[i] = Edades[i] - Media;
            }

            for(i = 0; i < 10; i++)
            {
                Cuadrado[i] = Restina[i] * Restina[i];
            }

            for (i = 0; i < 10; i++)
            {
                SumaCua = SumaCua + Cuadrado[i];
            }

            SumaCua = SumaCua / 9;
            
            Raiz = Math.Sqrt(SumaCua);
            Desviacion = Raiz;
        }

        public double GetMedia()
        {
            return Media;
        }

        public double GetDesviacion()
        {
            return Desviacion;
        }


    }
}
