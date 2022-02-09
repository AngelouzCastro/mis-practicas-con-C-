using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_EmpleadoPO
{
    class Administrativo:Empleado
    {
        public override void CalcularTotalAPagar()
        {
            TotalAPagar = 100 * HT;
        }
    }
}
