using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGMI_Geometria
{
    class Circulo : Figura
    {
        private int Radio;

        public Circulo()
        {
            
            Radio = 0;
        }

        public void SetRadio(int Radio)
        {
            this.Radio = Radio;
        }


        public void CalcularArea()
        {
            Area = (int)(Math.PI * Math.Pow(Radio, 2));
            // Area = 3.1416 * Radio * Radio;
        }

        public void CalcularPerimetro()
        {
            Perimetro = (int)Math.PI * (Radio * 2);
        }

        public int GetRadio()
        {
            return Radio;
        }

       
    }
}
