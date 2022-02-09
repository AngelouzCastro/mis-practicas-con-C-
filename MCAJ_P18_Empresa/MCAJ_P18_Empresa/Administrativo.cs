using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_P18_Empresa
{
    class Administrativo
    {
        private float HorasTrabajadasA;
        private float TotalPagarA;
        private string Tipo;

        public Administrativo()
        {
            HorasTrabajadasA = 0;
            TotalPagarA = 0;
            Tipo = "";
        }

        public void SetHorasTrabajadasA(float HorasTraA)
        {
            this.HorasTrabajadasA = HorasTraA;
        }

        public void SetTipo(string Tipo)
        {
            this.Tipo = Tipo;
        }

        public void CalcularTotalPagarA()
        {
            if (Tipo == "C" || Tipo == "c")
            {
                TotalPagarA = HorasTrabajadasA * 100;
            }
            else
            {
                TotalPagarA = HorasTrabajadasA * 50;
            }
        }

        public float GetHorasTrabajadasA()
        {
            return HorasTrabajadasA;
        }

        public string GetTipo()
        {
            return Tipo;
        }

        public float GetTotalPagarA()
        {
            return TotalPagarA;
        }

    }
}
