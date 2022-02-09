using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_CandidatasFinal
{
    class Cand1 : Candidatas
    {
        public void CalcularTotalVotos()
        {
            TotalVotos = TotalVotos + Votos;
        }
        public int GetTotalVotos()
        {
            return TotalVotos;
        }
    }
}
