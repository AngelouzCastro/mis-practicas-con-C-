using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_VentaDeGanado
{
    abstract class Ganado
    {
        public double Peso;
        public double Total;

        public Ganado()
        {
            Peso = 0;
            Total = 0;
        }

        public void SetPeso(double Peso)
        {
            this.Peso = Peso;
        }

        public double GetPeso()
        {
            return Peso;
        }

        public abstract void CalcularTotal();

        public double GetTotal()
        {
            return Total;
        }
    }
}
