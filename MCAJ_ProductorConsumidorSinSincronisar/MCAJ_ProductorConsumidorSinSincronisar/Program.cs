using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace MCAJ_ProductorConsumidorSinSincronisar
{
    class Program
    {
        private MemoriaCompartida mMemoriaCompartida;
        private Consumidor mConsumidor;
        private Productor mProductor;

        public Program()
        {
            mProductor = new Productor();
            mConsumidor = new Consumidor();
            mMemoriaCompartida = new MemoriaCompartida();

        }

        public void Correr()
        {
            mProductor.mMemoriaCompartida = mMemoriaCompartida;
            mConsumidor.mMemoriaCompartida = mMemoriaCompartida;

            Thread mHiloProductor = new Thread(mProductor.Producir);
            Thread mHiloConsumidor = new Thread(mConsumidor.Consumir);

            mHiloProductor.Start();
            mHiloConsumidor.Start();


            while (mHiloConsumidor.IsAlive || mHiloProductor.IsAlive) ;
            Console.WriteLine("la suma es: " + mConsumidor.GetSuma());
            Console.ReadKey();
        }


        static void Main(string[] args)
        {
            Program mProgram = new Program();
            mProgram.Correr();
        }
    }
}
