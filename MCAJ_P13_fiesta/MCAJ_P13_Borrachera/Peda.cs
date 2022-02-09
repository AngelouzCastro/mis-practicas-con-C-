using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_P13_Borrachera
{
    class Peda
    {
        private int Personas;
        private float Total;
        private float Divicion;

        public Peda()
        {
            Personas = 0;
            Divicion = 0;
            Total = 0;
        }

        public void SetPersonas(int Personas)
        {
            this.Personas = Personas;
        }

        public void CalcularTotal()
        {
            float Cawasaqui;
            float Cigarros;
            int Semillas;
            int CajaC = 0;
            int cont = 0;

            Cawasaqui = Personas * 4;
            Cawasaqui = Cawasaqui * 25;

            if (Personas >= 4)
            {
                CajaC = Personas;
                while (CajaC >= 4)
                {
                    if (CajaC >= 4)
                    {
                        CajaC = CajaC - 4;
                        cont = cont + 1;
                    }
                    else
                    {
                        CajaC = 0;
                    }

                }

                Cigarros = cont * 50;

                Semillas = Personas * 2;
                Semillas = Semillas * 5;

                Total = Cawasaqui + Cigarros + Semillas + 500;
            }
            else
            {
                Semillas = Personas * 2;
                Semillas = Semillas * 5;

                Total = Cawasaqui + Semillas + 500;
            }
        }

        public void CalcularDivicion()
        {
            Divicion = Total / Personas;
        }

        public int GetPersonas()
        {
            return Personas;
        }

        public float GetTotal()
        {
            return Total;
        }

        public float GetDivicion()
        {
            return Divicion;
        }


    }
}
