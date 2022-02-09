using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_Candidatas
{
    class Interfaz
    {
        private string Nombre;
        private string Talento;
        private string Carrera;
        private int Opc;
        private int Opc2;
        private int Voto;

        public Interfaz()
        {
            Nombre = "";
            Talento = "";
            Carrera = "";
            Opc = 0;
            Opc2 = 0;
            Voto = 0;
        }

        public void PeddrirNombre()
        {
            Console.WriteLine("Dame Nombre: ");
            Nombre = Console.ReadLine();
        }

        public void PedirTalento()
        {
            Console.WriteLine("Dame Talento: ");
            Talento = Console.ReadLine();
        }

        public void PedirCarrera()
        {
            Console.WriteLine("Dame Carrera: ");
            Carrera = Console.ReadLine();
        }

        public void PedirVoto()
        {
            Console.WriteLine("Dame Cantidad de Votos: ");
            Voto = int.Parse(Console.ReadLine());
        }

        public void ImprimirMenu()
        {
            Console.WriteLine("MENU DE OPCIONES");
            Console.WriteLine("REGISTRAR CANDIDATAS");
            Console.WriteLine("EMITIR VOTOS");
            Console.WriteLine("MOSTRAR RESULTADOS");
            Console.WriteLine("SALIR");
            Opc = int.Parse(Console.ReadLine());
        }

        public void ImprimirSubMenu()
        {
            Console.WriteLine("Candidata 1");
            Console.WriteLine("Candidata 2");
            Console.WriteLine("Candidata 3");
            Opc2 = int.Parse(Console.ReadLine());
        }

        public string GetNombre()
        {
            return Nombre;
        }

        public string GetTalento()
        {
            return Talento;
        }

        public string GetCarrera()
        {
            return Carrera;
        }

        public int GetVoto()
        {
            return Voto;
        }

        public int GetOpc()
        {
            return Opc;
        }
        public int GetOpc2()
        {
            return Opc2;
        }

        public void ImprimirCandidatas(ListaCandidatas mListaCandidatas)
        {
            Candidatas mCandidatas;
            int i;

            Console.WriteLine("Resultados");
            Console.WriteLine("Total Votos: " + mListaCandidatas.GetTotalVotos());
            for(i = 0; i < 3; i++)
            {
                mCandidatas = mListaCandidatas.GetCandidatas(i);
                Console.WriteLine("\tCandidatas");
                Console.WriteLine("\tNombre: " + mCandidatas.GetNombre());
                Console.WriteLine("\tCarrera: " + mCandidatas.GetCarrera());
                Console.WriteLine("\tTalento: " + mCandidatas.GetTalento());
                Console.WriteLine("\tVotos: " +mCandidatas.GetVotos());
            }
        }
    }
}
