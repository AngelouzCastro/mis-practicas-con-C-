using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCAJ_EjemploComponentes
{
    public partial class CajaDoble : UserControl
    {
        public int VecesRepeticion { get; set; }

        public CajaDoble()
        {
            InitializeComponent();
            VecesRepeticion = 1;
        }

        private void CajaDoble_Load(object sender, EventArgs e)
        {

        }

        private void Txt1_KeyPress(object sender, KeyPressEventArgs e)  
        {
          
        }

        private void CajaDoble_KeyUp(object sender, KeyEventArgs e)
        {
           
        }

        private void Txt1_KeyUp(object sender, KeyEventArgs e)
        {
            int i;
            Txt2.Text = "";
            for (i = 0; i < VecesRepeticion; i++)
            {
                Txt2.Text = Txt2.Text + Txt1.Text;
            }
        }
    }
}
