using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RAKI_empreza
{
    class Servicios:Empleado
    {
        public void CalcularTotalPS()
        {
            Sueldo = HorasT * 40;
        }
    }
}
