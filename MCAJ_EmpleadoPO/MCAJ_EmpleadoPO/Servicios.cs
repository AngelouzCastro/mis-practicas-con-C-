using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_EmpleadoPO
{
    class Servicios :Empleado
    {
        public override void CalcularTotalAPagar()
        {
            TotalAPagar = 40 * HT;
        }
    }
}
