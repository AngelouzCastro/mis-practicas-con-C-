using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MCAJ_Aeropuerto
{
    class Vuelo
    {
        public float peso { get; set; }
        public int boleto { get; set; }
        public float total { get; set; }
        //public float total;
        

        

        public void calcularTotal(int cont)
        {
            if(cont > 2)
            {
                if(peso > 25)
                {
                    total = total + 210;
                }else {
                    total = total + 200;
                }

            }else
            {
                if(peso > 25)
                {
                    total = total + 10;
                }else
                {
                    total = total + 0;
                }
            }
        }
        
    }
}
