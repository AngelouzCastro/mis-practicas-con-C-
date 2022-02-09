using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ComponenteSufamelico
{
    public partial class Sufamelico : UserControl
    {
        public Boolean valor { get; set; }
        public Sufamelico()
        {
            InitializeComponent();
            valor = false;
        }

        private void Txt1_KeyUp(object sender, KeyEventArgs e)
        {
            char[] letras = Txt1.Text.ToCharArray();
            int i = 0;
            lbl1.Text = "";
            if (valor == true)
            {
                feliz.Visible = true;
                for (i = 0; i < letras.Length; i++)
                {

                    if (letras[i] == 's' || letras[i] == 'S')
                    {
                        letras[i] = 'u';
                        lbl1.Text = lbl1.Text + letras[i];
                    }
                    else if (letras[i] == 'u' || letras[i] == 'U')
                    {
                        letras[i] = 's';
                        lbl1.Text = lbl1.Text + letras[i];
                    }
                    else if (letras[i] == 'f' || letras[i] == 'F')
                    {
                        letras[i] = 'a';
                        lbl1.Text = lbl1.Text + letras[i];
                    }
                    else if (letras[i] == 'a' || letras[i] == 'A')
                    {
                        letras[i] = 'f';
                        lbl1.Text = lbl1.Text + letras[i];
                    }
                    else if (letras[i] == 'm' || letras[i] == 'M')
                    {
                        letras[i] = 'e';
                        lbl1.Text = lbl1.Text + letras[i];
                    }
                    else if (letras[i] == 'e' || letras[i] == 'E')
                    {
                        letras[i] = 'm';
                        lbl1.Text = lbl1.Text + letras[i];
                    }
                    else if (letras[i] == 'l' || letras[i] == 'L')
                    {
                        letras[i] = 'i';
                        lbl1.Text = lbl1.Text + letras[i];
                    }
                    else if (letras[i] == 'i' || letras[i] == 'I')
                    {
                        letras[i] = 'l';
                        lbl1.Text = lbl1.Text + letras[i];
                    }
                    else if (letras[i] == 'c' || letras[i] == 'C')
                    {
                        letras[i] = 'o';
                        lbl1.Text = lbl1.Text + letras[i];
                    }
                    else if (letras[i] == 'o' || letras[i] == 'O')
                    {
                        letras[i] = 'c';
                        lbl1.Text = lbl1.Text + letras[i];
                    }
                    else
                    {
                        lbl1.Text = lbl1.Text + letras[i];
                    }
                }

                lbl1.Text = lbl1.Text.ToLower();

            }
            else
            {
                feliz.Visible = false;
                lbl1.Text = "sufamelico disabled";
            }
            

        }

        private void Sufamelico_Load(object sender, EventArgs e)
        {

        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void Txt1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
