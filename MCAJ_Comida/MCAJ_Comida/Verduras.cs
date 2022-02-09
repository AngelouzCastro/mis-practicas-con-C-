using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_Comida
{
    class Verduras : Comida
    {
        private int Unidades;

        public Verduras()
        {
            Unidades = 0;
        }

        public void SetUnidades(int Unidades)
        {
            this.Unidades = Unidades;
        }

        public int GetUnidades()
        {
            return Unidades;
        }

        public void CalcularTotal()
        {
            Total = Precio * Unidades;
        }
    }
}
