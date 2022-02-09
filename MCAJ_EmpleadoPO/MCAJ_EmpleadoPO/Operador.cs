using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_EmpleadoPO
{
    class Operador :Empleado
    {
        public override void CalcularTotalAPagar()
        {

            int HorasDobles;
            int PagoDoble;
            int Pago;
            if (HT > 40)
            {
                HorasDobles = HT - 40;
                PagoDoble = (HorasDobles * 200);
                Pago = (HT - HorasDobles) * 100;

                TotalAPagar = Pago + PagoDoble;
            }
            else if (HT <= 40)
            {
                TotalAPagar = 100 * HT;
            }
        }
    }
}
