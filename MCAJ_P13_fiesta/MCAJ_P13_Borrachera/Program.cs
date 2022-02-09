using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_P13_Borrachera
{
    class Program
    {
        private Peda mPeda;
        private Interfaz mInterfaz;

        public Program()
        {
            mPeda = new Peda();
            mInterfaz = new Interfaz();
        }

        public void Correr()
        {
            int opc;

            do
            {
                mInterfaz.ImprimirMenu();
                opc = mInterfaz.GetOpcion();

                switch (opc)
                {
                    case 1:
                        mInterfaz.PedirPersonas();
                        mPeda.SetPersonas(mInterfaz.GetPersonas());
                        break;
                    case 2:
                        mPeda.CalcularTotal();
                        mPeda.CalcularDivicion();
                        mInterfaz.ImprimirTotal(mPeda);
                        break;
                }


            } while (opc != 3);
        }
        static void Main(string[] args)
        {
            Program mProgram = new Program();
            mProgram.Correr();
        }
    }
}
