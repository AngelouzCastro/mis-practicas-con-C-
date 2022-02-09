using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_DiaDeLasMadres
{
    class Program
    {
        private Interfaz mInterfaz;

        public Program()
        {
            mInterfaz = new Interfaz();
        }

        public void Correr()
        {
            int Opc;

            do
            {
                mInterfaz.ImprimirMenu();
                Opc = mInterfaz.GetOpcion();

                if (Opc == 1)
                {
                    mInterfaz.ImprimirMensaje();
                }
                if (Opc ==2)
                {
                    mInterfaz.ImprimirmensajeH();
                }
                if (Opc == 3)
                {
                    mInterfaz.ImprimirMensajeT();
                }
                if(Opc == 4)
                {
                    mInterfaz.ImprimirMensajeA();
                }

            } while (Opc != 5);
        }
        static void Main(string[] args)
        {
            Program mProgram = new Program();
            mProgram.Correr();
        }
    }
}
