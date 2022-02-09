using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_P15_Empresa2
{
    class Empresa
    {
        private string Nombre;
        private Departamento[] ListaDepartamento;
        private float Pago;

        public Empresa(int NumeroDepartamento)
        {
            Nombre = "";
            ListaDepartamento = new Departamento[NumeroDepartamento];
            Pago = 0;
        }

        public void SetNombre(string Nombre)
        {
            this.Nombre = Nombre;
        }

        public void SetDepartamento(Departamento mDepartamento, int Posicion)
        {
            ListaDepartamento[Posicion] = mDepartamento;
        }

        public void CalcularTotalEmpresa()
        {
            float Suma = 0;
            int i;

            for(i=0; i < ListaDepartamento.Length; i++)
            {
                Suma = Suma + ListaDepartamento[i].GetPago();
            }
            Pago = Suma;
        }

        public string GetNombre()
        {
            return Nombre;
        }

        public Departamento GetDepartamento(int Posicion)
        {
            return ListaDepartamento[Posicion];
        }

        public float GetTotalEmpresa()
        {
            return Pago;
        }

        public int GetNumeroDepartamento()
        {
            return ListaDepartamento.Length;
        }

    }
}
