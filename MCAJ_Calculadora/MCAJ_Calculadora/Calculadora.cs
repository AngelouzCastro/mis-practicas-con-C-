using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MCAJ_Calculadora
{
    class Calculadora
    {
        private int numero1;
        private int numero2;
        private int Resultado;

        public Calculadora()
        {
            numero1 = 0;
            numero2 = 0;
            Resultado = 0;

        }

        public void Setnumero1(int numero1)
        {
            this.numero1 = numero1;
        }

        public void Setnumero2(int numero2)
        {
            this.numero2 = numero2;
        }

        public void CalcularSuma()
        {
            Resultado = numero1 + numero2;
        }

        public void CalcularResta()
        {
            Resultado = numero1 - numero2;
        }
        public void CalcularMultiplicacion()
        {
            Resultado = numero1 * numero2;
        }
        public void CalcularDivision()
        {
            Resultado = numero1 / numero2;
        }

        public int Getnumero1()
        {
            return numero1;
        }

        public int Getnumero2()
        {
            return numero2;
        }

        public int GetResultado()
        {
            return Resultado;
        }
    }
}
