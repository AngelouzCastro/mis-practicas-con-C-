using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_P15_Empresa2
{
    class Program
    {
        private Interfaz mInterfaz;
        private Empresa mEmpresa;
        private Departamento mDepartamento;
        private Empleado mEmpleado;

        public Program()
        {
            mInterfaz = new Interfaz();
        }

        public void Correr()
        {
            int opc;
            int i;
            int j;

            do
            {
                mInterfaz.ImprimirMenu();
                opc = mInterfaz.GetOpcion();

                switch (opc)
                {
                    case 1:
                        mInterfaz.PedirNombreEmpresa();
                        mInterfaz.PedirNumeroDepartamento();
                        mEmpresa = new Empresa(mInterfaz.GetNumeroDepartamento());
                        mEmpresa.SetNombre(mInterfaz.GetNombreEmpresa());
                        for (i = 0; i < mEmpresa.GetNumeroDepartamento(); i++)
                        {
                            mInterfaz.PedirNombreDepartamento();
                            mInterfaz.PedirNumeroEmpleados();
                            mDepartamento = new Departamento(mInterfaz.GetNumeroEmpleado());
                            mDepartamento.SetNombre(mInterfaz.GetNombreDepartamento());
                            for (j = 0; j < mDepartamento.GetNumeroEmpleados(); j++)
                            {
                                mEmpleado = new Empleado();
                                mInterfaz.PedirNombreEmpleado();
                                mEmpleado.SetNombre(mInterfaz.GetNombreEmpleado());
                                mInterfaz.PedirPago();
                                mEmpleado.SetPago(mInterfaz.GetPago());
                                mDepartamento.SetEmpleado(mEmpleado, j);
                            }
                            mDepartamento.CalcularPago();
                            mEmpresa.SetDepartamento(mDepartamento, i);
                        }
                        mEmpresa.CalcularTotalEmpresa();
                        break;
                    case 2:
                        mInterfaz.ImprimirEmpresa(mEmpresa);
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
