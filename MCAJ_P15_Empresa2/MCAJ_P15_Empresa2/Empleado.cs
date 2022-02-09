using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_P15_Empresa2
{
    class Empleado
    {
        private string Nombre;
        private float Pago;

        public void SetNombre(string Nombre)
        {
            this.Nombre = Nombre;
        }

        public void SetPago(float Pago)
        {
            this.Pago = Pago;
        }

        public string GetNombre()
        {
            return Nombre;
        }

        public float GetPago()
        {
            return Pago;
        }

    }
}
