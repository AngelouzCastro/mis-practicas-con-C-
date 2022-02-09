using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HilosGraficadores
{
    class Graficador
    {
        private int posX, posY, Valor;
        private FrmGrafica mFrmGrafica;
        private Graphics g;

        public Graficador(int posX, int posY, int Valor, FrmGrafica mFrmGrafica)
        {
            this.posX = posX;
            this.posY = posY;
            this.Valor = Valor;
            this.mFrmGrafica = mFrmGrafica;
            g = this.mFrmGrafica.CreateGraphics();


        }

        public void run()
        {
            for (int i = posY - 10; i >= posY - Valor; i = i - 10)
            {
                g.FillEllipse(new SolidBrush(Color.Red), posX, i, 10, 10);
                
                    Thread.Sleep(1000);
                
                
            }
        }
    }

   
}
