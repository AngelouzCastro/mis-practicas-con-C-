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
        public bool Ocupado { get; set; }
        private int Suma;

        public Consumidor()
        {

        }

        public void Consumir()
        {
            Suma=0;

            for(int i=1; i <= 10; i++)
            {
                while (mMemoriaCompartida.Ocupado == true)
                {
                    Thread.Sleep(100);
                }
                Console.WriteLine("Consumidor bloquea");
                mMemoriaCompartida.Ocupado = true;
                Suma = Suma + mMemoriaCompartida.Dato; 
                mMemoriaCompartida.Ocupado = false;
                Console.WriteLine("Se consumio: " + mMemoriaCompartida.Dato);
                Console.WriteLine("Consumidor desbloquea");
                Thread.Sleep(1000);
            }
            
        }

        public int GetSuma()
        {
            return Suma;
        }
    }
}
