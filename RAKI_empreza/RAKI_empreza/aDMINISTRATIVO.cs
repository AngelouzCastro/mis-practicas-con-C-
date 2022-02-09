using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAKI_empreza
{
    class aDMINISTRATIVO : Empleado
    {
        private string Tipo;

        public aDMINISTRATIVO()
        {
            Tipo = "";
        }

        public void SetTipo(string Tipo)
        {
            this.Tipo = Tipo;
        }

        public void CalcularTotalPagarA()
        {
            if (Tipo == "C" || Tipo == "c")
            {
                Sueldo = HorasT * 100;
            }
            else
            {
                Sueldo = HorasT * 50;
            }
        }

        public string GetTipo()
        {
            return Tipo;
        }
    }
}
