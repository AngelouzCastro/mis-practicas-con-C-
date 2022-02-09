using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_P18_Empresa
{
    class Program
    {
        private Interfaz mInterfaz;
        private Administrativo mAdministrativo;
        private Servicios mServicios;
        private Operador mOperador;

        public Program()
        {
            mInterfaz = new Interfaz();
            mAdministrativo = new Administrativo();
            mServicios = new Servicios();
            mOperador = new Operador();
        }

        public void Correr()
        {
            int Opc;

            do
            {
                mInterfaz.ImprimirMenu();
                Opc = mInterfaz.GetOpcion();

                switch (Opc)
                {
                    //Administrativo
                    case 1:
                        mInterfaz.PedirHorasTrabajadas();
                        mAdministrativo.SetHorasTrabajadasA(mInterfaz.GetHorasTrabajadas());
                        mInterfaz.PedirTipo();
                        mAdministrativo.SetTipo(mInterfaz.GetTipo());
                        mAdministrativo.CalcularTotalPagarA();
                        mInterfaz.ImprimirAdministrativo(mAdministrativo);
                        break;

                    //Servicios
                    case 2:
                        mInterfaz.PedirHorasTrabajadasS();
                        mServicios.SetHorasTrabajadasS(mInterfaz.GetHorasTrabajadasS());
                        mServicios.CalcularTotalPS();
                        mInterfaz.ImprimirServicios(mServicios);
                        break;

                    //Operador
                    case 3:
                        mInterfaz.PedirHorasTrabajadasO();
                        mOperador.SetHorasTrabajadasO(mInterfaz.GetHorasTrabajadaO());
                        mInterfaz.PedirPiezas();
                        mOperador.SetPiezas(mInterfaz.GetPiezas());
                        mOperador.CalcularTotalPagarO();
                        mInterfaz.ImprimirOperador(mOperador);
                        break;
                }
            } while (Opc != 4);
        }

        static void Main(string[] args)
        {
            Program mProgram = new Program();
            mProgram.Correr();
        }
    }
}
