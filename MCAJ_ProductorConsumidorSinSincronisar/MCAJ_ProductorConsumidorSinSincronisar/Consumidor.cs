using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MCAJ_ProductorConsumidorSinSincronisar
{
    public class Consumidor
    {
        public MemoriaCompartida mMemoriaCompartida { get; set; }
        private int Suma;

        public Consumidor()
        {

        }

        public void Consumir()
        {
            Suma=0;

            for(int i=1; i <= 10; i++)
            {
                
                Suma = Suma + mMemoriaCompartida.Dato;
                Console.WriteLine("Se consumio: " + mMemoriaCompartida.Dato);
                //Thread.Sleep(1000);
            }
            
        }

        public int GetSuma()
        {
            return Suma;
        }
    }
}
