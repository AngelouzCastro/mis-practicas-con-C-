using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_P15_Empresa2
{
    class Interfaz
    {
        private string NombreEmpresa;
        private string NombreDepartamento;
        private string NombreEmpleado;
        private float Pago;
        private int NumeroDepartamento;
        private int NumeroEmpleado;
        private int Opcion;

        public Interfaz()
        {
        NombreEmpresa = "";
        NombreDepartamento = "";
        NombreEmpleado = "";
        Pago = 0;
        NumeroDepartamento = 0;
        NumeroEmpleado = 0;
        Opcion = 0;
        }

        public void PedirNombreEmpresa()
        {
            Console.Write("Dame nombre de la Empresa: ");
            NombreEmpresa = Console.ReadLine();
        }

        public void PedirNombreDepartamento()
        {
            Console.Write("Dame nombre del departamento: ");
            NombreDepartamento = Console.ReadLine();
        }

        public void PedirNombreEmpleado()
        {
            Console.Write("Dame nombre del Emplado: ");
            NombreEmpleado = Console.ReadLine();
        }

        public void PedirPago()
        {
            Console.Write("De cuanto es tu pago: ");
            Pago = float.Parse(Console.ReadLine());
        }

        public void PedirNumeroDepartamento()
        {
            Console.Write("Dame numero de departamentos: ");
            NumeroDepartamento = int.Parse(Console.ReadLine());
            
        }

        public void PedirNumeroEmpleados()
        {
            Console.Write("Dame numero de Empleados: ");
            NumeroEmpleado = int.Parse(Console.ReadLine());
        }

        public void ImprimirMenu()
        {
            Console.WriteLine("MENU DE OPCIONES");
            Console.WriteLine("1. Alta de Emprsa");
            Console.WriteLine("2. Calcular y mostrar Empresa");
            Console.WriteLine("3. Salir");
            Console.Write("Elige opción: ");
            Opcion = int.Parse(Console.ReadLine());
        }

        public string GetNombreEmpresa()
        {
            return NombreEmpresa;
        }

        public string GetNombreDepartamento()
        {
            return NombreDepartamento;
        }

        public string GetNombreEmpleado()
        {
            return NombreEmpleado;
        }

        public float GetPago()
        {
            return Pago;
        }

        public int GetNumeroDepartamento()
        {
            return NumeroDepartamento;
        }

        public int GetNumeroEmpleado()
        {
            return NumeroEmpleado;
        }

        public int GetOpcion()
        {
            return Opcion;
        }

        public void ImprimirEmpresa(Empresa mEmpresa)
        {
            Departamento mDepartamento;
            Empleado mEmpleado;
            int i, j;

            Console.WriteLine("E M P R E S A");
            Console.WriteLine("Nombre: " + mEmpresa.GetNombre());
            Console.WriteLine("Total Pago: " + mEmpresa.GetTotalEmpresa());
            for (i = 0; i < mEmpresa.GetNumeroDepartamento(); i++)
            {
                mDepartamento = mEmpresa.GetDepartamento(i);
                Console.WriteLine("\tD E P A R T A M E N T O");
                Console.WriteLine("\tNombre: " + mDepartamento.GetNombre());
                Console.WriteLine("\tPago Por Departamento: " + mDepartamento.GetPago());
                for (j = 0; j < mDepartamento.GetNumeroEmpleados(); i++)
                {
                    mEmpleado = mDepartamento.GetEmpleado(i);
                    Console.WriteLine("\t\tE M P L E A D O");
                    Console.WriteLine("\t\tNombre: " + mEmpleado.GetNombre());
                    Console.WriteLine("\t\tPago: " + mEmpleado.GetPago());
                }

            }
        }

    }
}
