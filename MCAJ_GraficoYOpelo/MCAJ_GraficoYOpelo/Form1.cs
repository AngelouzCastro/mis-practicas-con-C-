using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCAJ_GraficoYOpelo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public void Dibujar1(int posx, int posy)
        {

            Graphics mGrafico = this.CreateGraphics();
            //Lapiz para la cabeza
            Pen mLapiz1 = new Pen(Color.Black, 5);
            //Lapiz para el cuerpo
            Pen mLapiz2 = new Pen(Color.Black, 5);
            //Lapiz para borrar
            Pen mLapiz3 = new Pen(this.BackColor, 5);
            Pen mLapiz4 = new Pen(Color.Brown , 5);
            Pen mLapiz5 = new Pen(Color.Green, 5);
            //Borrando dibujar 2

            mGrafico.DrawRectangle(mLapiz3, posx - 30, posy - 15, 8, 5);

            mGrafico.DrawLine(mLapiz3, posx - 15, posy + 20, posx + 5, posy + 30);
            mGrafico.DrawLine(mLapiz3, posx + 5, posy + 30, posx + 25, posy + 20);
            //Graficando nuevo dibujo
            mGrafico.DrawEllipse(mLapiz1, posx, posy, 10, 10);

            mGrafico.DrawLine(mLapiz4, posx - 5, posy-3, 90, 70);
            mGrafico.DrawLine(mLapiz4,posx,posy-6,100,70);
            mGrafico.DrawLine(mLapiz4, posx + 10, posy-6, 110, 70);
            mGrafico.DrawLine(mLapiz4, posx + 15, posy-3, 120, 70);

            mGrafico.DrawRectangle(mLapiz5,posx+30,posy-15,8,5);
            
            mGrafico.DrawLine(mLapiz2, posx + 5, posy + 5, posx + 5, posy + 55);
            mGrafico.DrawLine(mLapiz2, posx + 5, posy + 55, posx - 15, posy + 65);
            mGrafico.DrawLine(mLapiz2, posx + 5, posy + 55, posx + 20, posy + 65);
            mGrafico.DrawLine(mLapiz2, posx - 15, posy + 30, posx + 25, posy + 30);

        }
        public void Dibujar2(int posx, int posy)
        {
            Graphics mGrafico = this.CreateGraphics();
            Pen mLapiz1 = new Pen(Color.Black, 15);
            Pen mLapiz2 = new Pen(Color.Black, 5);
            Pen mLapiz3 = new Pen(this.BackColor, 5);
            Pen mLapiz4 = new Pen(Color.Blue, 5);
            Pen mLapiz5 = new Pen(Color.Green, 5);

            mGrafico.DrawLine(mLapiz3, posx - 15, posy + 30, posx + 25, posy + 30);
            mGrafico.DrawEllipse(mLapiz1, posx, posy, 10, 10);
            mGrafico.DrawLine(mLapiz2, posx + 5, posy + 5, posx + 5, posy + 55);
            mGrafico.DrawLine(mLapiz2, posx + 5, posy + 55, posx - 15, posy + 65);
            mGrafico.DrawLine(mLapiz2, posx + 5, posy + 55, posx + 15, posy + 65);
            mGrafico.DrawLine(mLapiz2, posx - 15, posy + 20, posx + 5, posy + 30);
            mGrafico.DrawLine(mLapiz2, posx + 5, posy + 30, posx + 25, posy + 20);

        }

        public void Dibujar4(int posx, int posy)
        {
            Graphics mGrafico = this.CreateGraphics();
            Pen mLapiz3 = new Pen(this.BackColor, 5);
            Pen mLapiz4 = new Pen(Color.Blue, 5);
            Pen mLapiz5 = new Pen(Color.Green, 5);

            mGrafico.DrawRectangle(mLapiz3, posx + 30, posy - 15, 8, 5);
            mGrafico.DrawLine(mLapiz3, posx + 15, posy - 3, 120, 70);
            mGrafico.DrawRectangle(mLapiz5, posx + 15, posy - 15, 8, 5);
            

        }
        public void Dibujar5(int posx, int posy)
        {
            Graphics mGrafico = this.CreateGraphics();
            Pen mLapiz3 = new Pen(this.BackColor, 5);
            Pen mLapiz4 = new Pen(Color.Red, 5);
            Pen mLapiz5 = new Pen(Color.Green, 5);

            mGrafico.DrawRectangle(mLapiz3, posx+15, posy-15, 8, 5);
            mGrafico.DrawRectangle(mLapiz5, posx, posy - 15, 8, 5);
            mGrafico.DrawLine(mLapiz3, posx + 10, posy - 6, 110, 70);


        }
        public void Dibujar6(int posx, int posy)
        {
            Graphics mGrafico = this.CreateGraphics();
            Pen mLapiz3 = new Pen(this.BackColor, 5);
            Pen mLapiz4 = new Pen(Color.Red, 5);
            Pen mLapiz5 = new Pen(Color.Green, 5);

            mGrafico.DrawRectangle(mLapiz3, posx, posy - 15, 8, 5);
            mGrafico.DrawRectangle(mLapiz5, posx-15, posy - 15, 8, 5);
            mGrafico.DrawLine(mLapiz3, posx, posy - 6, 100, 70);

        }

        public void Dibujar7(int posx, int posy)
        {
            Graphics mGrafico = this.CreateGraphics();
            Pen mLapiz3 = new Pen(this.BackColor, 5);
            Pen mLapiz4 = new Pen(Color.Red, 5);
            Pen mLapiz5 = new Pen(Color.Green, 5);

            mGrafico.DrawRectangle(mLapiz3, posx-15, posy - 15, 8, 5);
            mGrafico.DrawRectangle(mLapiz5, posx - 30, posy - 15, 8, 5);
            mGrafico.DrawLine(mLapiz3, posx - 5, posy - 3, 90, 70);


        }
       

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 10; i++)
            {
                this.Dibujar1(100, 100);
                Thread.Sleep(200);
                this.Dibujar2(100, 100);
                Thread.Sleep(200);
            }
            this.Dibujar4(100, 100);
            Thread.Sleep(200);
            this.Dibujar5(100, 100);
            Thread.Sleep(200);
            this.Dibujar6(100, 100);
            Thread.Sleep(200);
            this.Dibujar7(100, 100);
            


        }
    }
}
