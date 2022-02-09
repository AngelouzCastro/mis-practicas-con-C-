using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_Vehiculo2
{
    class Interfaz
    {
        private int Tiempo;
        private int Distancia;
        private int Velocidad;
        private int Opcion;
        private string CadTiempo;



        public Interfaz()
        {
            Tiempo = 0;
            Distancia = 0;
            Velocidad = 0;
            Opcion = 0;
            CadTiempo = "";

        }

        public void ImprimirMenu()
        {
            Console.Clear();
            Console.WriteLine("H O L A");
            Console.WriteLine("1. Calcular tiempo recorrido: ");
            Console.WriteLine("2. Calcular distancia recorrida: ");
            Console.WriteLine("3. Calcular velocidad: ");
            Console.WriteLine("4. Salir");
            Console.WriteLine();
            Console.Write("Elija opcion: ");
            Opcion = int.Parse(Console.ReadLine());

        }

        public void PedirDistancia()
        {
            Console.WriteLine("Dame distancia recorrida: ");
            Distancia = int.Parse(Console.ReadLine());
        }

        public void PedirTiempo()
        {
            Console.WriteLine("Dame tiempo recorrido: ");
            Tiempo = int.Parse(Console.ReadLine());
        }

        public void PedirVelocidad()
        {
            Console.WriteLine("Dame velocidad: ");
            Velocidad = int.Parse(Console.ReadLine());
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

        public int GetOpcion()
        {
            return Opcion;
        }


        public string GetCadena()
        {
            return CadTiempo;
        }
        public void ImprimirCadTiempo(string CadTiempo)
        {

            Console.WriteLine("El tiempo recorrido es: " + CadTiempo);
            Console.ReadKey();
        }

        public void ImprimirDistancia(int Distancia)
        {
            Console.WriteLine("La distancia recorrida es: " + Distancia);
            Console.ReadKey();
        }

        public void ImprimirVelocidad(int Velocidad)
        {
            Console.WriteLine("La velocidad es: " + Velocidad);
            Console.ReadKey();
        }
    }
}
