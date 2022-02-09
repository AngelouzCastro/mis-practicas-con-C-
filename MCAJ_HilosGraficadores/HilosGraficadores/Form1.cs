using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;

namespace HilosGraficadores
{
    public partial class FrmGrafica : Form
    {
        private int i;
        private int[] Puntos;
        private int Rango0_69;
        private int Rango70_79;
        private int Rango80_89;
        private int Rango90_100;
        private Graficador mGraficador1;
        private Graficador mGraficador2;
        private Graficador mGraficador3;
        private Graficador mGraficador4;

        public FrmGrafica()
        {
            InitializeComponent();
            Puntos = new int[20];
            i = 0;
            Rango0_69 = 0;
            Rango70_79 = 0;
            Rango80_89 = 0;
            Rango90_100 = 0;
        }

        private int[] GetCalificaciones()
        {
            return Puntos;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void FrmGrafica_Load(object sender, EventArgs e)
        {

        }

        private void TxtCalificacion_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)(Keys.Enter))
            {
                
                TextArea.Items.Add(TxtCalificacion.Text);

                if (int.Parse(TxtCalificacion.Text) <= 69 && int.Parse(TxtCalificacion.Text) > 0)
                {
                    Rango0_69++;
                }
                else if (int.Parse(TxtCalificacion.Text) >= 70 && int.Parse(TxtCalificacion.Text) <= 79)
                {
                    Rango70_79++;
                }
                else if (int.Parse(TxtCalificacion.Text) >= 80 && int.Parse(TxtCalificacion.Text) <= 89)
                {
                    Rango80_89++;
                }
                else if (int.Parse(TxtCalificacion.Text) >= 90 && int.Parse(TxtCalificacion.Text) <= 100)
                {
                    Rango90_100++;
                }

                i++;

                TxtCalificacion.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            mGraficador1 = new Graficador(55, 250, Rango0_69 * 10, this);
            mGraficador2 = new Graficador(130, 250, Rango70_79 * 10, this);
            mGraficador3 = new Graficador(200, 250, Rango80_89 * 10, this);
            mGraficador4 = new Graficador(300, 250, Rango90_100 * 10, this);

            Thread hilo1 = new Thread(mGraficador1.run);
            Thread hilo2 = new Thread(mGraficador2.run);
            Thread hilo3 = new Thread(mGraficador3.run);
            Thread hilo4 = new Thread(mGraficador4.run);


            hilo1.Start();
            hilo2.Start();
            hilo3.Start();
            hilo4.Start();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}