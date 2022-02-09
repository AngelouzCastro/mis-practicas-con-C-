using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAKI_empreza
{
    class Empleado
    {
        protected float HorasT;
        protected float Sueldo;
        protected string Nombre;

        public Empleado()
        {
            HorasT = 0;
            Sueldo = 0;
            Nombre = "";
        }

        public void SetHorasT(float HorasT)
        {
            this.HorasT = HorasT;
        }

        public void SetSueldoPorH(float Sueldo)
        {
            this.Sueldo = Sueldo;
        }

        public void SetNombre(string Nombre)
        {
            this.Nombre = Nombre;
        }

        public float GetHorasT()
        {
            return HorasT;
        }

        public float GetSueldo()
        {
            return Sueldo;
        }

        public string GetNombre()
        {
            return Nombre;
        }



    }
}
