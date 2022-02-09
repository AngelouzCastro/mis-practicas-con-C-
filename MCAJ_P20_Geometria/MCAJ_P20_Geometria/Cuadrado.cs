using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_P20_Geometria
{
    class Cuadrado
    {
        private float LadoCuadrado;
        private float ResultadoArea;
        private float ResultadoPerimetro;

        public Cuadrado()
        {
            LadoCuadrado = 0;
            ResultadoArea = 0;
            ResultadoPerimetro = 0;
        }

        public void SetLadoCuadrado(float LadoCuadrado)
        {
            this.LadoCuadrado = LadoCuadrado;
        }

        public void CalcularAreaCuadrado()
        { 

            ResultadoArea = LadoCuadrado * LadoCuadrado;
            
        }

        public void CalcularPerimetroCuadrado()
        {
            
            ResultadoPerimetro = LadoCuadrado * 4;
        }

        public float GetLadoCuadrado()
        {
            return LadoCuadrado;
        }

        public float GetAreaCuadrado()
        {
            return ResultadoArea;
        }

        public float GetPerimetroCuadrado()
        {
            return ResultadoPerimetro;
        }



    }
}
