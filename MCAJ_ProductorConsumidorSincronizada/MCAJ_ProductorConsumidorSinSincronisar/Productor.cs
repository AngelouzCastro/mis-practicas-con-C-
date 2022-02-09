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
                while (mMemoriaCompartida.Ocupado)
                {
                    Thread.Sleep(100);
                }
                Console.WriteLine("Productor bloaque");
                mMemoriaCompartida.Ocupado = true;
                mMemoriaCompartida.Dato = i;
                mMemoriaCompartida.Ocupado = false;
                Console.WriteLine("Se Produjo: " + i);
                Console.WriteLine("Productor desbloquea");
                Thread.Sleep(1000);
            }
        }
         
    }
}
