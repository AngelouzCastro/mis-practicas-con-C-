using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_P20_Geometria
{
    class Triangulo
    {
        private float BaseTriangulo;
        private float AlturaTriangulo;
        private float AreaTriangulo;
        private float PerimetroTriangulo;

        public Triangulo()
        {
            BaseTriangulo = 0;
            AlturaTriangulo = 0;
            AreaTriangulo = 0;
            PerimetroTriangulo = 0;
        }

        public void SetBaseTriangulo(float BaseTriangulo)
        {
            this.BaseTriangulo = BaseTriangulo;
        }

        public void SetAlturaTriangulo(float AlturaTriangulo)
        {
            this.AlturaTriangulo = AlturaTriangulo;
        }

        public void CalcularAreaTriangulo()
        {
            AreaTriangulo = (BaseTriangulo * AlturaTriangulo) / 2;
        }

        public void CalcularPerimetroTriangulo()
        {
            PerimetroTriangulo = BaseTriangulo * 3;
        }

        public float GetBaseTriangulo()
        {
            return BaseTriangulo;
        }

        public float GetAlturaTriangulo()
        {
            return AlturaTriangulo;
        }

        public float GetAreaTriangulo()
        {
            return AreaTriangulo;
        }

        public float GetPerimetroTriangulo()
        {
            return PerimetroTriangulo;
        }
    }
}
