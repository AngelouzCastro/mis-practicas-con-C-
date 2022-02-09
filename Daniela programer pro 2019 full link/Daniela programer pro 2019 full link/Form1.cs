using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Daniela_programer_pro_2019_full_link
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
        }

        private void BtnSaludar_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hola mundo Cruel :,(");
        }

        private void BtnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void TxtNombre_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
