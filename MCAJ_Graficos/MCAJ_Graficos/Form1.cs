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

namespace MCAJ_Graficos
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {

        }

        private void BtnGraficar_Click(object sender, EventArgs e)
        {
            Graphics mGrafico = this.CreateGraphics();

            int PosX = int.Parse(TxtPosX.Text);
            int PosY = int.Parse(TxtPosY.Text);
            Pen mLapiz = new Pen(Color.Black, 10);

            mGrafico.DrawRectangle(mLapiz,PosX, PosY,100,100);
        }

        private void BtnAnimar_Click(object sender, EventArgs e)
        {
            Graphics mGrafico = this.CreateGraphics();
            Pen mLapiz = new Pen(Color.Red);

            for(int i=10;i<800; i += 100)
            {
                for(int j = 10; j < 600; j += 100)
                {
                    mGrafico.DrawEllipse(mLapiz, 0, 0, i, j);
                    Thread.Sleep(500);
                }
            }
            mLapiz = new Pen(Color.IndianRed);
            for(int i=10; i < 800; i += 50)
            {
                mGrafico.DrawRectangle(mLapiz, i, 300, 100, 100);
                Thread.Sleep(200);
            }
        }
        public void Dibujar(int posx, int posy)
        {
            Graphics mGrafico = this.CreateGraphics();
            Pen mLapiz1 = new Pen(Color.Black, 15);
            Pen mLapiz2 = new Pen(Color.Black, 5);
            mGrafico.DrawEllipse(mLapiz1, posx,posy, 10, 10);
            mGrafico.DrawLine(mLapiz2, posx + 5, posy + 5, posx + 5, posy + 55);
            mGrafico.DrawLine(mLapiz2, posx + 5, posy + 55, posx - 15, posy + 65);
            mGrafico.DrawLine(mLapiz2, posx + 5, posy + 55, posx + 20, posy + 65);
            mGrafico.DrawLine(mLapiz2, posx - 15, posy + 30, posx + 25, posy + 30);
        }

    }
}
