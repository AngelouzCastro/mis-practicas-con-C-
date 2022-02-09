using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCAJ_Graficoyo
{
    public partial class FrmPrincipal : Form    
    {
        private Graphics mGrafico;
        private int PosX;
        private int PosY;
        private int DirX;
        private int DirY;
        private int DirY2;

        public FrmPrincipal()
        {
            InitializeComponent();
            mGrafico = this.CreateGraphics();
            PosX = 0;
            PosY = this.Height / 2;
            DirX = 0;
            DirY = 0;
            DirY2 = new Random().Next(2);
        }

       

       

         

       
    }
}
