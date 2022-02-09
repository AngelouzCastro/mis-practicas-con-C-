using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_P20_Geometria
{
    class Rectangulo
    {
        private float BaseRectangulo;
        private float AlturaRectangulo;
        private float AreaRectangulo;
        private float PerimetroRectangulo;

        public Rectangulo()
        {
            BaseRectangulo = 0;
            AlturaRectangulo = 0;
            AreaRectangulo = 0;
            PerimetroRectangulo = 0;
        }

        public void SetBaseRectangulo(float BaseRectangulo)
        {
            this.BaseRectangulo = BaseRectangulo;
        }

        public void SetAlturaRectangulo(float AlturaRectangulo)
        {
            this.AlturaRectangulo = AlturaRectangulo;
        }

        public void CalcularAreaRectangulo()
        {
            AreaRectangulo = BaseRectangulo * AlturaRectangulo;
        }

        public void CalcularPerimetroRectangulo()
        {
            PerimetroRectangulo = (BaseRectangulo * 2) + (AlturaRectangulo * 2);
        }

        public float GetBaseRectangulo()
        {
            return BaseRectangulo;
        }

        public float GetAlturaRectangulo()
        {
            return AlturaRectangulo;
        }

        public float GetAreaRectangulo()
        {
            return AreaRectangulo;
        }

        public float GetPerimetroRectangulo()
        {
            return PerimetroRectangulo;
        }
    }
}
