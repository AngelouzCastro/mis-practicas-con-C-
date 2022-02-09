using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_Restaurante
{
    class Program
    {
        private Restaurante mRestaurante;
        private Iterfaz mInterfaz;

        public Program()
        {
            mRestaurante = new Restaurante();
            mInterfaz = new Iterfaz();
        }
        public void Correr()
        {
            int Opcion;

            do
            {
                mInterfaz.ImprimirMenu();
                Opcion = mInterfaz.GetOpcion();

                switch(Opcion)
                {
                    case 1:
                        mInterfaz.PedirBebida();
                        mInterfaz.PedirComida();
                        mRestaurante.SetBebida(mInterfaz.GetBebida());
                        mRestaurante.SetComida(mInterfaz.GetComida());
                        mRestaurante.CalcularTotal();
                        break;
                    case 2:
                        mRestaurante.CalcularTotal();
                        mInterfaz.ImprimirTotal(mRestaurante);
                        break;
                }

            } while (Opcion != 3);
        }

        static void Main(string[] args)
        {
            Program mProgram = new Program();
            mProgram.Correr();
        }
    }
}
