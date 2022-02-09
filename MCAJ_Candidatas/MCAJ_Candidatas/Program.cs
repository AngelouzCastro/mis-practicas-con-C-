using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_Candidatas
{
    class Program
    {
        private Interfaz mInterfaz;
        private Candidatas mCandidatas;

        public Program()
        {
            mInterfaz = new Interfaz();
        }

        public void Correr()
        {
            int Opc, Opc2, i;

            do
            {
                mInterfaz.ImprimirMenu();
                Opc = mInterfaz.GetOpc();

                switch(Opc)
                {
                    case 1:
                        mListaC = new ListaCandidatas(3);
                        break;
                }
            }while(Opc)

        }

        static void Main(string[] args)
        {
        }
    }
}
