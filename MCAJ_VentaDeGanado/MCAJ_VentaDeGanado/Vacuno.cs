using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_VentaDeGanado
{
    class Vacuno :Ganado
    {
        public override void CalcularTotal()
        {
            Peso = Peso * .5;
            Total = Peso * 22;
        }
    }
}
