using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_Comida
{
    //Clase deribada
    class Carnes : Comida
    {
        private double Peso;

        public Carnes()
        {
            Peso = 0;
        }

        public void SetPeso(double Peso)
        {
            this.Peso = Peso;
        }

        public double GetPeso()
        {
            return Peso;
        }

        //3.6 Redefinición de metodos de clase derivada
        public void CalcularTotal()
        {
            //3.3 Reutilisazión de miembros heredados
            // Reutilizo Total y Peso
            Total = Precio * Peso;
        }

    }
}
