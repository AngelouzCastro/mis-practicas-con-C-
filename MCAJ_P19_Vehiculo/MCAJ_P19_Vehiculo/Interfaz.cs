using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_P19_Vehiculo
{
    class Interfaz
    {
        private float Tiempo;
        private float Distancia;
        private float Velocidad;
        private int Opcion;

        public Interfaz()
        {
            Tiempo = 0;
            Distancia = 0;
            Velocidad = 0;
            Opcion = 0;
        }

        public void ImprimirMenu()
        {
            Console.WriteLine();
            Console.WriteLine("1. Calcular Tiempo");
            Console.WriteLine("2. Calcular Distancia");
            Console.WriteLine("3. Calcular Velocidad");
            Console.WriteLine("4. Salir");
            Console.WriteLine("Eliga una opcion");
            Opcion = int.Parse(Console.ReadLine());
        }

        public void PedirTiempo()
        {
            Console.WriteLine("Dame Tiempo: ");
            Tiempo = float.Parse(Console.ReadLine());
        }

        public void PedirDistancia()
        {
            Console.WriteLine("Dame Distancia: ");
            Distancia = float.Parse(Console.ReadLine());
        }

        public void PedirVelocidad()
        {
            Console.WriteLine("Dame Velocidad: ");
            Velocidad = float.Parse(Console.ReadLine());
        }

        public int GetOpcion()
        {
            return Opcion;
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


        public void ImprimirResultado(Vehiculo mVehiculo)
        {
            Console.WriteLine("Tiempo: " + mVehiculo.GetTiempo());
            Console.WriteLine("Distancia: " + mVehiculo.GetDistancia());
            Console.WriteLine("Velocidad: " + mVehiculo.GetVelocidad());
        }
    }
}
