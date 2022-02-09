using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_P17_MediaYDes
{
    class Interfaz
    {
        private int Opcion;
        private double Edad;
        private int i;

        public Interfaz()
        {
            Edad = 0;
            Opcion = 0;
            i = 0;
        }

        public void PedirVezes()
        {
            Console.WriteLine("vezes: ");
            Opcion = int.Parse(Console.ReadLine());
        }

        public void PedirEdades()
        {
            
                Console.WriteLine("Dame Edad: ");
                Edad = double.Parse(Console.ReadLine());
            
        }

        

        internal double GetEdades()
        {
            return Edad;
        }


        public int GetOpcion()
        {
            return Opcion;
        }

        public void ImprimirEdades(Estadistica mEstadistica)
        {
            int i;
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine("numero: " + mEstadistica.GetEdad(i));
            }
        }

        public void ImprimirMedia(Estadistica mEstadistica)
        {
            Console.WriteLine("Media: " + mEstadistica.GetMedia());
            Console.ReadKey();
            
        }
        public void ImprimirDesviacion(Estadistica mEstadistica)
        {
            Console.WriteLine("Desviacion Estandar: " + mEstadistica.GetDesviacion());
            Console.ReadKey();
        }
    }
}
