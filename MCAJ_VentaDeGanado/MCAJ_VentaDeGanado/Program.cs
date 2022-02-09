using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_VentaDeGanado
{
    class Program
    {
        private Interfaz mInterfaze;
        private Ganado mGanado;
        private Ovino mOvino;
        private Vacuno mVacuno;

        public Program()
        {
            mInterfaze = new Interfaz();
            mOvino = new Ovino();
            mVacuno = new Vacuno();
        }

        public void Correr()
        {
            double Peso, Total;
            int Opc;
            do
            {
                mInterfaze.ImprimirMenu();
                Opc = mInterfaze.GetOpcio();



                if (Opc == 1)
                {
                    mGanado = new Ovino();
                }
                else if (Opc == 2)
                {
                    mGanado = new Vacuno();
                }
                if (Opc != 3)
                {
                    mInterfaze.PedirPeso();
                    Peso = mInterfaze.GetPeso();
                    mGanado.SetPeso(Peso);
                    mGanado.CalcularTotal();
                    mInterfaze.ImprimirTotal(mGanado);
                }
            } while (Opc < 3);
            }

            static void Main(string[] args)
            {
            Program mProgram = new Program();
            mProgram.Correr();
            }
        }
    }
