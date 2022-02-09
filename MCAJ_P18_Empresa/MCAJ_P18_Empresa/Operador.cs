using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_P18_Empresa
{
    class Operador
    {
        private float HTO;
        private float TPO;
        private int Piezas;

        public Operador()
        {
            HTO = 0;
            TPO = 0;
            Piezas = 0;
        }

        public void SetHorasTrabajadasO(float HTO)
        {
            this.HTO = HTO;
        }

        public void SetPiezas(int Piezas)
        {
            this.Piezas = Piezas;
        }

        public void CalcularTotalPagarO()
        {
            float Pz;
            Pz = Piezas * 2;

            TPO = HTO * 100;
            TPO = TPO + Pz;
        }

        public float GetHorasTrabajadasO()
        {
            return HTO;
        }

        public int GetPiezas()
        {
            return Piezas;
        }

        public float GetTotalPagarO()
        {
            return TPO;
        }

    }
}
