using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_Equipo1
{
    class Interfaz
    {
        private string Nombre1;
        private int JG;
        private int JP1;
        private int JE1;
        private int JJ1;
        private string Nombre2;
        private int JG2;
        private int JP2;
        private int JE2;
        private int JJ2;
        private string Nombre3;
        private int JG3;
        private int JP3;
        private int JE3;
        private int JJ3;
        private int Puntos;
        private int Puntos2;
        private int Puntos3;
        public string Ganador;

        public void PedirNombre1()
        {
            
            Console.Write("Dame Equipo: ");
            Nombre1 = Console.ReadLine();
        }

        public void PedirJG()
        {
            
            Console.Write("Dame Juegos Ganados: ");
            JG = int.Parse(Console.ReadLine());

        }

        public void PedirJP1()
        {

            Console.Write("Dame Juegos Perdidos: ");
            JP1 = int.Parse(Console.ReadLine());

        }
        public void PedirJE1()
        {
            
            Console.Write("Dame Juegos Empatados: ");
            JE1 = int.Parse(Console.ReadLine());
        }

        public string GetNombre1()
        {
            return Nombre1;
        }

        public int GetJG()
        {
            return JG;
        }

        public int GetJP1()
        {
            return JP1;
        }

        public int GetJE1()
        {
            return JE1;
        }

        public void ImprimirJJ1(Equipo mEquipo)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(mEquipo.GetNombre1() + " " + mEquipo.GetPuntos() + " puntos");
        }



        public void PedirNombre2()
        {
            
            Console.WriteLine("Dame Equipo: ");
            Nombre2 = Console.ReadLine();
        }

        public void PedirJG2()
        {
            
            Console.WriteLine("Dame Juegos Ganados: ");
            JG2 = int.Parse(Console.ReadLine());

        }

        public void PedirJP2()
        {
            
            Console.WriteLine("Dame Juegos Perdidos: ");
            JP2 = int.Parse(Console.ReadLine());

        }
        public void PedirJE2()
        {
            
            Console.WriteLine("Dame Juegos Empatados: ");
            JE2 = int.Parse(Console.ReadLine());
        }

        public string GetNombre2()
        {
            return Nombre2;
        }

        public int GetJG2()
        {
            return JG2;
        }

        public int GetJP2()
        {
            return JP2;
        }

        public int GetJE2()
        {
            return JE2;
        }

        public void ImprimirJJ2(Equipo mEquipo)
        {
            
            Console.WriteLine(mEquipo.GetNombre2() + " " + mEquipo.GetPuntos2() + " puntos");
        }





        public void PedirNombre3()
        {
            
            Console.WriteLine("Dame Equipo: ");
            Nombre3 = Console.ReadLine();
        }

        public void PedirJG3()
        {
            
            Console.WriteLine("Dame Juegos Ganados: ");
            JG3 = int.Parse(Console.ReadLine());

        }

        public void PedirJP3()
        {
            
            Console.WriteLine("Dame Juegos Perdidos: ");
            JP3 = int.Parse(Console.ReadLine());

        }
        public void PedirJE3()
        {
            
            Console.WriteLine("Dame Juegos Empatados: ");
            JE3 = int.Parse(Console.ReadLine());
        }

        public string GetNombre3()
        {
            return Nombre3;
        }

        public int GetJG3()
        {
            return JG3;
        }

        public int GetJP3()
        {
            return JP3;
        }

        public int GetJE3()
        {
            return JE3;
        }

        public void ImprimirJJ3(Equipo mEquipo)
        {
            
            Console.WriteLine(mEquipo.GetNombre3() + " " + mEquipo.GetPuntos3() + " puntos ");
        }


        public void ImprimirGanador(Equipo mEquipo)
        {
            
            Console.WriteLine("Ganador: " + " " + mEquipo.Ganador);
            Console.ReadKey();
        }
    }
}
