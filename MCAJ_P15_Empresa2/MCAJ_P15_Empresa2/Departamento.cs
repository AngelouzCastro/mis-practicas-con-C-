using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_P15_Empresa2
{
    class Departamento {
        private string Clave;
        private string Nombre;
        private Empleado[] ListaEmpleados;
        private float Pago;

        public Departamento(int NumeroEmpleados)
        {
            
            Nombre = "";
            ListaEmpleados = new Empleado[NumeroEmpleados];
            Pago = 0;
        }
        

        public void SetNombre(string Nombre)
        {
            this.Nombre = Nombre;
        }

        public void SetEmpleado(Empleado mEmpleado, int Posicion)
        {
            ListaEmpleados[Posicion] = mEmpleado;
        }

        public Empleado GetEmpleado(int Posicion)
        {
            return ListaEmpleados[Posicion];
        }

        public void CalcularPago()
        {
            float Suma;
            int i;

            Suma = 0;
            for (i = 0; i < ListaEmpleados.Length; i++)
            {
                Suma = Suma + ListaEmpleados[i].GetPago();
            }

             Pago= Suma;
        }

        

        public string GetNombre()
        {
            return Nombre;
        }

        public float GetPago()
        {
            return Pago;
        }

        public int GetNumeroEmpleados()
        {
            return ListaEmpleados.Length;
        }
    }
    /*
    class Departamento
    {
        private string Nombre;
        private Empleado[] ListaEmpleados;
        private float Pago;

        public Departamento(int NumeroEmpleados)
        {
            Nombre = "";
            ListaEmpleados = new Empleado[NumeroEmpleados];
            Pago  = 0;
        }

        public void SetNombre(string Nombre)
        {
            this.Nombre = Nombre;
        }

        public void SetEmpleado(Empleado mEmpleado, int Posicion)
        {
            ListaEmpleados[Posicion] = mEmpleado;
        }

        public Empleado GetEmpleado(int Posicion)
        {
            return ListaEmpleados[Posicion];
        }

        public void CalcularPago()
        {
            float Suma = 0;
            int i;

            for(i=0; i < ListaEmpleados.Length; i++)
            {
                Suma = Suma + ListaEmpleados[i].GetPago();
            }
            Pago = Suma;
        }
        

        public string GetNombre()
        {
            return Nombre;
        }

        public float GetPago()
        {
            return Pago;
        }

        public int GetNumeroEmpleados()
        {
            return ListaEmpleados.Length;
        }
    }*/
}

