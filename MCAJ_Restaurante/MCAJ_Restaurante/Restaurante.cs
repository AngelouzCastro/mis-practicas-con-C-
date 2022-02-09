using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_Restaurante
{
    class Restaurante
    {
        public string Bebida;
        public string Comida;
        public float Total;

        public Restaurante()
        {
            Bebida = "";
            Comida = "";
            Total = 0;

        }

        public void SetBebida(string Bebida)
        {
            this.Bebida = Bebida;
        }
        public void SetComida(string Comida)
        {
            this.Comida = Comida;
        }
        public void CalcularTotal()
        {
            float Suma = 0;
            if (Bebida == "s")
            {
                Suma = 10;
            }
            else
            {
                Suma = 0;
            }
            if (Comida == "m")
            {
                Suma = Suma + 100;
            }
            else if (Comida == "T")
            {
                Suma = Suma + 100;
            }
            else
            {
                Suma = Suma + 70;
            }
            Total = Suma;
        }

        public string GetBebida()
        {
            return Bebida;
        }
        public string GetComida()
        {
            return Comida;
        }
        public float GetTotal()
        {
            return Total;
        }
    }
}
