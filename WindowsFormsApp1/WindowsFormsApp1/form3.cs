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
    public partial class form3 : Form
    {
        public form3()
        {
            InitializeComponent();
        }

        private void form3_Load(object sender, EventArgs e)
        {
            TxtNumeraso.Text = nombre;
        }
        public string nombre { get; set; }
    }
}
