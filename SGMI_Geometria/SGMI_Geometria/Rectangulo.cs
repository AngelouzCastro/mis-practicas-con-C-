using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGMI_Geometria
{
    class Rectangulo : Figura
    {
        
        private int Base;
        private int Altura;

        public Rectangulo()
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
            Area = Base * Altura;
        }

        public void CalcularPerimetro()
        {
            Perimetro = (Base * 2) + (Altura * 2);
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
