using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGMI_Geometria
{
    class Cuadrado : Figura
    {
        
        private int Lado;

        public Cuadrado()
        {
            Lado = 0;
        }

        public void SetLado(int Lado)
        {
            this.Lado = Lado;
        }

        public void CalcularArea()
        {
            Area = (int)Math.Pow(Lado, 2);
        }

        public void CalcularPerimetro()
        {
            Perimetro = Lado * 4;
        }

        public int GetLado()
        {
            return Lado;
        }

        
    }
}
