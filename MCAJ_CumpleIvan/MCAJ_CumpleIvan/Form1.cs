using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCAJ_CumpleIvan
{
    public partial class Form1 : Form
    {
        float valor;
        float precio;
        float pago;
        int contmil = 0, contq = 0, contdosi = 0, cont100 = 0, cont50 = 0, cont20 = 0, cont10 = 0
            , cont5 = 0, cont2 = 0, cont1 = 0, contc = 0;
        public Form1()
        {
            InitializeComponent();
            

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }
        public void limpiar()
        {
            LblMil.Text = "0";
            LblQuinientos.Text = "0";
            LblDocientos.Text = "0";
            LblCien.Text = "0";
            LblCincuenta.Text = "0";
            LblVeinte.Text = "0";
            LblDiez.Text = "0";
            LblCinco.Text = "0";
            LblDos.Text = "0";
            LblUno.Text = "0";
            LblCentavos.Text = "0";
        }
        public void contadores()
        {
            contmil = 0;
            contq = 0;
            contdosi = 0;
            cont100 = 0;
            cont50 = 0;
            cont20 = 0;
            cont10 = 0;
            cont5 = 0;
            cont2 = 0;
            cont1 = 0;
            contc = 0;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            limpiar();
            contadores();
            try {
                pago = float.Parse(TxtDinero.Text);
                precio = float.Parse(TxtPrecio.Text);
            }catch (Exception)
            {
                
            }
            if (pago >= precio)
            {
                valor = pago - precio;
                LblCambio.Text = valor + " $";
            }
            else
            {
                LblCambio.Text = "Saldo insuficiente";
            }
            while (valor > 0)
            {
                if (valor >= 1000)
                {
                    valor = valor - 1000;
                    contmil++;
                    LblMil.Text = contmil + "";
                }
                else if (valor >= 500)
                {
                    valor = valor - 500;
                    contq++;
                    LblQuinientos.Text = contq + "";
                }
                else if (valor >= 200)
                {
                    valor = valor - 200;
                    contdosi++;
                    LblDocientos.Text = contdosi + "";
                }
                else if (valor >= 100)
                {
                    valor = valor - 100;
                    cont100++;
                    LblCien.Text = cont100 + "";
                }
                else if (valor >= 50)
                {
                    valor = valor - 50;
                    cont50++;
                    LblCincuenta.Text = cont50 + "";
                }
                else if (valor >= 20)
                {
                    valor = valor - 20;
                    cont20++;
                    LblVeinte.Text = cont20 + "";
                }
                else if (valor >= 10)
                {
                    valor = valor - 10;
                    cont10++;
                    LblDiez.Text = cont10 + "";
                }
                else if (valor >= 5)
                {
                    valor = valor - 5;
                    cont5++;
                    LblCinco.Text = cont5 + "";
                }
                else if (valor >= 2)
                {
                    valor = valor - 2;
                    cont2++;
                    LblDos.Text = cont2 + "";
                }
                else if (valor >= 1)
                {
                    valor = valor - 1;
                    cont1++;
                    LblUno.Text = cont1 + "";
                }
                else if (valor >= 0.70 || valor >= 0.80 || valor >= 0.90)
                {
                    valor = valor - 1;
                    cont1++;
                    LblUno.Text = cont1 + "";
                }
                else if (valor <= 0.60)
                {
                    valor = valor - 0.50f;
                    contc++;
                    LblCentavos.Text = contc + "";
                }
                else
                {
                    valor = valor - valor;
                }
                
            }
        }
    }
}
