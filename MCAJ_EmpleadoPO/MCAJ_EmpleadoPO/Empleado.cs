using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_EmpleadoPO
{
    abstract class Empleado
    {
        protected string Nombre;
        protected int HT;
        protected float TotalAPagar;

        public Empleado()
        {
            Nombre = "";
        }
        public void SetNombre(string Nombre)
        {
            this.Nombre = Nombre;
        }
        public string GetNombre()
        {
            return Nombre;
        }
        public int GetHT()
        {
            return HT;
        }
        public void SetHT(int HT)
        {
            this.HT = HT;
        }
        public float GetTotalAPagar()
        {
            return TotalAPagar;
        }
        public abstract void CalcularTotalAPagar();

    }
}
