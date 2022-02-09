using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_ClaseGenerica
{
    class Intercambio<TipoDeDatoX>
    {
        public void Intercambiar(ref TipoDeDatoX a, ref TipoDeDatoX b)
        {
            TipoDeDatoX c;
            c = a;
            a = b;
            b = c;
        }
    }
}
