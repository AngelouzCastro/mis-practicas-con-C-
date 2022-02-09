using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_P16_Bascula
{
    class Program
    {
        private Interfaz mInterfaz;
        private Bascula mBascula;

        public void Correr()
        {
            float Peso;
            float Tara;
            float Precio;
            float Total;

            mBascula = new Bascula();
            mInterfaz = new Interfaz();

            mInterfaz.PedirPeso();
            Peso = mInterfaz.GetPeso();
            mBascula.SetPeso(Peso);

            mInterfaz.PedirTara();
            Tara = mInterfaz.GetTara();
            mBascula.SetTara(Tara);

            mInterfaz.PedirPrecio();
            Precio = mInterfaz.GetPrecio();
            mBascula.SetPrecio(Precio);

            mBascula.CalcularTotal();
            Total = mBascula.GetTotal();
            mInterfaz.ImprimirBascula(Total);
        }

        static void Main(string[] args)
        {
            Program mProgram = new Program();
            mProgram.Correr();
        }
    }
}
