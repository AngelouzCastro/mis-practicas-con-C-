using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_P14_Viacrucis
{
    class Interfaz
    {
        private string NombreSujeto;
        private string NombreEstacion;
        private float Recorrido;
        private int NumeroEstaciones;
        private int Opcion;

        public Interfaz()
        {
            NombreSujeto = "";
            NombreEstacion = "";
            NumeroEstaciones = 0;
            Opcion = 0;
            Recorrido = 0;
        }

        public void PedirNombreSujeto()
        {
            Console.WriteLine("Dame Tu Nombre: ");
            NombreSujeto = Console.ReadLine();
        }

        public void PedirNombreEstacion()
        {
            Console.WriteLine("Dame Nombre de la estacio: ");
            NombreEstacion = Console.ReadLine();
        }

        public void PedirNumeroEstaciones()
        {
            Console.WriteLine("Dame numero de estaciones: ");
            NumeroEstaciones =int.Parse(Console.ReadLine());
        }

        public void PedirRecorrido()
        {
            Console.WriteLine("Dame Distancia Recorrida de estacion: ");
            Recorrido = float.Parse(Console.ReadLine());
        }

        public void ImprimirMenu()
        {
            Console.WriteLine("MENU DE OPCIONES");
            Console.WriteLine("1. Alta de Recorrido");
            Console.WriteLine("2. Mostrar Distancia Recorrida");
            Console.WriteLine("3. Salir");
            Console.Write("Elige opción: ");
            Opcion = int.Parse(Console.ReadLine());
        }

        public string GetNombreSujeto()
        {
            return NombreSujeto;
        }

        public string GetNombreEstacion()
        {
            return NombreEstacion;
        }

        public int GetNumeroEstaciones()
        {
            return NumeroEstaciones;
        }

        public float GetRecorrido()
        {
            return Recorrido;
        }

        public int GetOpcion()
        {
            return Opcion;
        }

        public void ImprimirSujeto(Sujeto mSujeto)
        {
            Estaciones mEstaciones;
            int i;

            Console.WriteLine("P E R E G R I N O");
            Console.WriteLine("Nombre: " + mSujeto.GetNombre());
            Console.WriteLine("Total Recorrido: " + mSujeto.GetRecorrido());

            for(i=0; i < mSujeto.GetNumeroEstaciones(); i++)
            {
                mEstaciones = mSujeto.GetEstaciones(i);
                Console.WriteLine("\tE S T A C I Ó N");
                Console.WriteLine("\tNombre: " + mEstaciones.GetNombre());
                Console.WriteLine("\tRecorrido con esta Estación: " + mEstaciones.GetRecorrido());
            }
        }
    }
}
