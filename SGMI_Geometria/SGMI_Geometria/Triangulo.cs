using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGMI_Geometria
{
    class Triangulo : Figura
    {
        
        private int Base;
        private int Altura;

        public Triangulo()
        {
            
            Base = 0;
            Altura = 0;
        }

        public void SetBase(int Base)
        {
            this.Base = Base;
        }

        public void SetAltura(int Altura)
        {
            this.Altura = Altura;
        }

        public void CalcularArea()
        {
            Area = (Base * Altura) / 2;
        }

        public void CalcularPerimetro()
        {
            Perimetro = Base * 3;
        }

        public int GetBase()
        {
            return Base;
        }

        public int GetAltura()
        {
            return Altura;
        }

        
    }
}
