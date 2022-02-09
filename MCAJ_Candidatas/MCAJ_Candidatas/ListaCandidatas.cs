using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_Candidatas
{
    class ListaCandidatas
    {
        private Candidatas[]ListaC;
        private int TotalVotos;

        public ListaCandidatas(int NumCand)
        {
            ListaC = new Candidatas[NumCand];
            TotalVotos = 0;
        }

        public void SetCandidatas(Candidatas mCandidatas, int i)
        {
            ListaC[i] = mCandidatas;
        }

        public void CalcularTV()
        {
            int Suma = 0;
            int i;
            
            for(i=0; i<ListaC.Length; i++)
            {
                Suma = Suma + ListaC[i].GetVotos();
            }
            TotalVotos = Suma;
        }

        public int GetTotalVotos()
        {
            return TotalVotos;
        }

        public int GetNumeroCandidatas()
        {
            return ListaC.Length;
        }

        public Candidatas GetCandidatas(int i)
        {
            return ListaC[i];
        }

    }
}
