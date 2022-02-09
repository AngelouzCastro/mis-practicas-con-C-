using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_VentaDeGanado
{
    class Ovino :Ganado
    {
        public override void CalcularTotal()
        {
            Total = 21 * Peso;
        }
    }
}
