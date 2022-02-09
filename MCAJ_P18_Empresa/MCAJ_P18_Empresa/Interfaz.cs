using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_P18_Empresa
{
    class Interfaz
    {
        private float HTO;
        private int Piezas;

        private float HTS;

        private float HorasTrabajadasA;
        private string Tipo;

        private int Opcion;
        private float HT;

        public Interfaz()
        {
            HTO = 0;
            Piezas = 0;
            HTS = 0;
            HorasTrabajadasA = 0;
            Tipo = "";
            Opcion = 0;
            HT = 0;
        }

        public void PedirHorasTrabajadas()
        {
            Console.WriteLine("Dame Horas Trabajadas: ");
            HorasTrabajadasA = float.Parse(Console.ReadLine());
        }

        public void PedirHorasTrabajadasS()
        {
            Console.WriteLine("Dame Horas Trabajadas: ");
            HTS = float.Parse(Console.ReadLine());
        }

        public void PedirHorasTrabajadasO()
        {
            Console.WriteLine("Dame Horas Trabajadas: ");
            HTO = float.Parse(Console.ReadLine());
        }

        public void PedirTipo()
        {
            Console.WriteLine("Dame Tipo de Administrativo: [C/S] : ");
            Tipo = Console.ReadLine();
        }

        public void PedirPiezas()
        {
            Console.WriteLine("Cuantas Piezas Terminaste: ");
            Piezas = int.Parse(Console.ReadLine());
        }

        public void ImprimirMenu()
        {
            
            Console.WriteLine("\nSelecione tipo de Trabajador");
            Console.WriteLine("1. Empleado Administrativo: ");
            Console.WriteLine("2. Empleado de Servicios: ");
            Console.WriteLine("3. Empleado Operador: ");
            Console.WriteLine("4. Salir");
            Opcion = int.Parse(Console.ReadLine());
        }

        public float GetHorasTrabajadas()
        {
            return HorasTrabajadasA;
        }

        public float GetHorasTrabajadasS()
        {
            return HTS;
        }

        public float GetHorasTrabajadaO()
        {
            return HTO;
        }

        public string GetTipo()
        {
            return Tipo;
        }

        public int GetPiezas()
        {
            return Piezas;
        }

        public int GetOpcion()
        {
            return Opcion;
        }

        public void ImprimirAdministrativo(Administrativo mAdministrativo)
        {
            Console.WriteLine("Horas Trabajadas: " + mAdministrativo.GetHorasTrabajadasA());
            Console.WriteLine("Tipo: " + mAdministrativo.GetTipo());
            Console.WriteLine("Total Pago: $" + mAdministrativo.GetTotalPagarA());
        }

        public void ImprimirServicios(Servicios mServicios)
        {
            Console.WriteLine("Horas Trabajadas: " + mServicios.GetHorasTrabajadasS());
            Console.WriteLine("Total Pago: $" + mServicios.GetTotalPS());
        }

        public void ImprimirOperador(Operador mOperador)
        {
            Console.WriteLine("Horas Trabajadas: " + mOperador.GetHorasTrabajadasO());
            Console.WriteLine("piezas: " + mOperador.GetPiezas());
            Console.WriteLine("Total Pago: $" + mOperador.GetTotalPagarO());
        }
    }
}
