using System;
using System.Collections;
using System.Threading;
using System.Drawing;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;

namespace MCAJ_Aeropuerto
{
    public partial class Form1 : Form
    {
        private Vuelo mVuelo;
        private ArrayList ListaVuelos;
        private int cont;
        private float suma;
        private float dinero;
        Pen mLapiz = new Pen(Color.Black, 10);

        public Form1()
        {
            InitializeComponent();
            
            ListaVuelos = new ArrayList();
            cont = 0;

            
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            cont = cont + 1;
            suma = 0;
            dinero = 0;
            mVuelo = new Vuelo();

            Graphics mGrafico = this.CreateGraphics();
           

            float y =100;
            //y = y + 100;

            mVuelo.boleto = int.Parse(TxtBoleto.Text);
            mVuelo.peso = float.Parse(TxtMaleta.Text);
            mVuelo.calcularTotal(cont);
            ListaVuelos.Add(mVuelo);

            DtgTabla.DataSource = null;
            DtgTabla.DataSource = ListaVuelos;

            foreach (Vuelo mVuelo in ListaVuelos)
            {
                suma = suma + mVuelo.peso;
                Graphics mGrafico2 = this.CreateGraphics();
                mGrafico2.DrawLine(mLapiz, 509, y + 100, mVuelo.peso + 519, y + 100);
                y = y + 30;

            }
            LblTotalPeso.Text = suma.ToString();
            
            foreach (Vuelo mVuelo in ListaVuelos)
            {
                
                dinero = dinero + mVuelo.total;
                
            }
            LblDinero.Text = dinero.ToString();
            TxtMaleta.Clear();
            

            
            
        }
        

        public ArrayList GetArrayList()
        {
            return ListaVuelos;
        }
        public float GetPesoTotal()
        {
            return suma;
        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void BtnGraficar_Click(object sender, EventArgs e)
        {
            float y = 100;
            foreach (Vuelo mVuelo in ListaVuelos)
            {
               
                suma = suma + mVuelo.peso;
                Graphics mGrafico2 = this.CreateGraphics();
                mGrafico2.DrawLine(mLapiz, 509, y + 100, mVuelo.peso + 600, y + 100);
                y = y + 50;
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
