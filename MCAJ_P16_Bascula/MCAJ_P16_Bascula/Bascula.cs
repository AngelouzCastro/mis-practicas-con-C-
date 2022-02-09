using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_P16_Bascula
{
    class Bascula
    {
        private float Peso;
        private float Tara;
        private float Precio;
        private float Total;

        public Bascula()
        {
            Peso = 0;
            Tara = 0;
            Precio = 0;
            Total = 0;
        }

        public void SetPeso(float Peso)
        {
            this.Peso = Peso;
        }

        public void SetTara(float Tara)
        {
            this.Tara = Tara;
        }

        public void SetPrecio(float Precio)
        {
            this.Precio = Precio;
        }

        public void CalcularTotal()
        {
            Total = (Peso - Tara) * Precio;
            Total = Total * (float)1.16;
        }

        public float GetPeso()
        {
            return Peso;
        }

        public float GetTara()
        {
            return Tara;
        }

        public float GetPrecio()
        {
            return Precio;
        }

        public float GetTotal()
        {
            return Total;
        }

    }
}
