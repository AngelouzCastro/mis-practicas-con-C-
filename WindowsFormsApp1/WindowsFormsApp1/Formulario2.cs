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
    public partial class Formulario2 : Form
    {
        //string suma;
        //int num;
        public string nombre { get; set; }

        public Formulario2()
        {
            InitializeComponent();
          
            
            
        }

        private void Formulario2_Load(object sender, EventArgs e)
        {

        }

        public void setResultado(int suma)
        {
            this.LblResultado2.Text = suma.ToString();
        }
        public void setEnviado(int num)
        {
            this.LblEnviado.Text = num.ToString();
        }
        public void setEnviadoN(string nom)
        {
            this.label1.Text = nom;
        }

        private void BtnCalcular_Click(object sender, EventArgs e)
        {
            string suma = "";
               LblResultado.Text = LblResultado2.Text + " "+LblEnviado.Text;
            LblNombre.Text = nombre;
        }
    }
}
