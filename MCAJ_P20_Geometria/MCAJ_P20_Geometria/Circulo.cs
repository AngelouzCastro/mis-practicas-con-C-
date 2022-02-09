using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_P20_Geometria
{
    class Circulo
    {
        private double Radio;
        private double AreaCirculo;
        private double PerimetroCirculo;

        public Circulo()
        {
            Radio = 0;
            AreaCirculo = 0;
            PerimetroCirculo = 0;
        }

        public void SetRadio(double Radio)
        {
            this.Radio = Radio;
        }

        public void CalcularAreaCirculo()
        {

            AreaCirculo = (Radio * Radio) * 3.1416;
            
        }

        public void CalcularPerimetroCirculo()
        {
            PerimetroCirculo = (2 * Radio) * 3.1416;
        }

        public double GetRadio()
        {
            return Radio;
        }

        public double GetAreaCirculo()
        {
            return AreaCirculo;
        }

        public double GetPerimetroCirculo()
        {
            return PerimetroCirculo;
        }
    }
}
