using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_P17_MediaYDes
{
    class Program
    {
        private Estadistica mEstadistica;
        private Interfaz mInterfaz;
        

        public Program()
        {
            
            mInterfaz = new Interfaz();
            mEstadistica = new Estadistica();

        }

        public void Correr()
        {




            for (int i = 0; i < 10; i++)
            {

                mInterfaz.PedirEdades();
                mEstadistica.SetEdad(mInterfaz.GetEdades(), i);
            }
            mEstadistica.CalcularMedia();
            mEstadistica.CalcularDesciacion();
            mInterfaz.ImprimirMedia(mEstadistica);
            mInterfaz.ImprimirDesviacion(mEstadistica);
        }
        
        

        static void Main(string[] args)
        {
            Program mProgram = new Program();
            mProgram.Correr();
        }
    }
}
