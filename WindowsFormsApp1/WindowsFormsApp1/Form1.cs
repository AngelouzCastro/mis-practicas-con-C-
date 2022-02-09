using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        Formulario2 mFormulario2;
        form3 mFormulario3;
        int suma;
        int num;
        public Form1()
        {
            mFormulario2 = new Formulario2();
            mFormulario3 = new form3();
            suma = 0;
            InitializeComponent();
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            int n, n1 ;
            n = int.Parse(TxtN.Text);
            n1 = int.Parse(TxtN1.Text);
            num = int.Parse(TxtEnviado.Text);
            suma = n + n1;
            LblResultado.Text = suma.ToString();
        }

        private void BtnFormulario2_Click(object sender, EventArgs e)
        {
            
            mFormulario2.setResultado(suma);
            mFormulario2.setEnviado(num);
            mFormulario2.nombre = TxtNombre.Text;
            mFormulario2.setEnviadoN(TxtNombre.Text);
            mFormulario2.ShowDialog();

        }

        private void BtnFormulario3_Click(object sender, EventArgs e)
        {
            mFormulario3.nombre = TxtNumerin.Text;
            mFormulario3.ShowDialog();
        }
    }
}
