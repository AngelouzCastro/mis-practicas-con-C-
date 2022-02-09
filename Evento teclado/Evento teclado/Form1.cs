using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Evento_teclado
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void textBox1_TextChanged(object sender, KeyPressEventArgs e)
        {
            //MessageBox.Shoe(e.KeyChar.ToString());
            char tecla = e.KeyChar;
            int ascii = (int)tecla;
            if ((ascii >= 97) && (ascii <= 122))
            {
                ascii = ascii - 32;
                tecla = (char)ascii;
                e.KeyChar = tecla;
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.KeyChar = '*';
        }
    }
}
