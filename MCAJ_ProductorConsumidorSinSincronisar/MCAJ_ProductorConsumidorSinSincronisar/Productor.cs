using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MCAJ_ProductorConsumidorSinSincronisar
{
    public class Productor
    {
        public MemoriaCompartida mMemoriaCompartida { get; set; }

        
        public void Producir()
        {
            for (int i = 1; i <= 10; i++)
            {
                mMemoriaCompartida.Dato = i;
                Console.WriteLine("Se Produjo: " + i);
               // Thread.Sleep(1000);
            }
        }
         
    }
}
