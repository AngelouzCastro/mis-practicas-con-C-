using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_Equipo1
{
    class Program
    {
        private Interfaz minterfaz;
        private Equipo mEquipo;

        public Program()
        {
            minterfaz = new Interfaz();
            mEquipo = new Equipo();
        }

        public void Correr()
        {
            minterfaz = new Interfaz();
            mEquipo = new Equipo();
            string Nombre1;
            int JG;
            int JP1;
            int JE1;
            
            string Nombre2;
            int JG2;
            int JP2;
            int JE2;
            
            string Nombre3;
            int JG3;
            int JP3;
            int JE3;
            


            minterfaz.PedirNombre1();
            Nombre1 = minterfaz.GetNombre1();
            mEquipo.SetNombre1(Nombre1);

            minterfaz.PedirJG();
            JG = minterfaz.GetJG();
            mEquipo.SetJG(JG);

            minterfaz.PedirJP1();
            JP1 = minterfaz.GetJP1();
            mEquipo.SetJP1(JP1);

            minterfaz.PedirJE1();
            JE1 = minterfaz.GetJE1();
            mEquipo.SetJE1(JE1);
            mEquipo.CalcularJJ1();
            mEquipo.CalcularPuntos();




            minterfaz.PedirNombre2();
            Nombre2 = minterfaz.GetNombre2();
            mEquipo.SetNombre2(Nombre2);

            minterfaz.PedirJG2();
            JG2 = minterfaz.GetJG2();
            mEquipo.SetJG2(JG2);

            minterfaz.PedirJP2();
            JP2 = minterfaz.GetJP2();
            mEquipo.SetJP2(JP2);

            minterfaz.PedirJE2();
            JE2 = minterfaz.GetJE2();
            mEquipo.SetJE2(JE2);
            mEquipo.CalcularJJ2();
            mEquipo.CalcularPuntos2();




            minterfaz.PedirNombre3();
            Nombre3 = minterfaz.GetNombre3();
            mEquipo.SetNombre3(Nombre3);

            minterfaz.PedirJG3();
            JG3 = minterfaz.GetJG3();
            mEquipo.SetJG3(JG3);

            minterfaz.PedirJP3();
            JP3 = minterfaz.GetJP3();
            mEquipo.SetJP3(JP3);

            minterfaz.PedirJE3();
            JE3 = minterfaz.GetJE3();
            mEquipo.SetJE3(JE3);
            mEquipo.CalcularJJ3();
            mEquipo.CalcularPuntos3();



            mEquipo.CalcularGanador();

            minterfaz.ImprimirJJ1(mEquipo);
            minterfaz.ImprimirJJ2(mEquipo);
            minterfaz.ImprimirJJ3(mEquipo);

            minterfaz.ImprimirGanador(mEquipo);
        }

        static void Main(string[] args)
        {
            Program nProgram = new Program();
            nProgram.Correr();
        }
    }
}


