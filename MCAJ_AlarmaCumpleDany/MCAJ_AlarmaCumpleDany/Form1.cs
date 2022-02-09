using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MCAJ_AlarmaCumpleDany
{
    public partial class Form1 : Form
    {
        System.Timers.Timer timer;
        SoundPlayer player;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            timer = new System.Timers.Timer();
            timer.Interval = 1000;
            timer.Elapsed += Timer_Elapsed;
        }

        delegate void UpdateLable(Label lbl, string value);

        void UpdateDataLable(Label lbl, string value)
        {
            lbl.Text = value;
        }

        private void Timer_Elapsed(object sender, System.Timers.ElapsedEventArgs e)
        {
            //throw new NotImplementedException();
            DateTime currenTime = DateTime.Now;
            DateTime userTime = dateTimePicker.Value;
            if(currenTime.Hour == userTime.Hour && currenTime.Minute == userTime.Minute && currenTime.Second == userTime.Second)
            {
                timer.Stop();
                try
                {
                    UpdateLable upd = UpdateDataLable;
                    if (lblStatus.InvokeRequired)
                        Invoke(upd, lblStatus, "Parar");
                    player = new SoundPlayer(Application.StartupPath + @"\Sound\Alarma.wav");
                    player.PlayLooping();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void BtnCorrer_Click(object sender, EventArgs e)
        {
            timer.Start();
            lblStatus.Text = "Abilitada";
        }

        private void BtnParar_Click(object sender, EventArgs e)
        {
           
           
            timer.Stop();
            lblStatus.Text = "Desabilitada";
            Close();


        }

        
    }
}
