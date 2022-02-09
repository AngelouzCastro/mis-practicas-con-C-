using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_P18_Empresa
{
    class Servicios
    {
        private float HTS;
        private float TotalPagarS;

        public Servicios()
        {
            HTS = 0;
            TotalPagarS = 0;
        }

        public void SetHorasTrabajadasS(float HTS)
        {
            this.HTS = HTS;
        }
        public void CalcularTotalPS()
        {
            TotalPagarS = HTS * 40;
        }

        public float GetHorasTrabajadasS()
        {
            return HTS;
        }

        public float GetTotalPS()
        {
            return TotalPagarS;
        }

        
        
    }
}
