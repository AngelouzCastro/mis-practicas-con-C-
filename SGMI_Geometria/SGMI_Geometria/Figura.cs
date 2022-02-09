using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace SGMI_Geometria
{
    class Figura
    {
        protected int Area;
        protected int Perimetro;

        public Figura()
        {
            Area = 0;
            Perimetro = 0;
        }

        public int GetArea()
        {
            return Area;
        }

        public int GetPerimetro()
        {
            return Perimetro;
        }
    }
}
