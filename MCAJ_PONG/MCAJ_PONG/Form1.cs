using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;

namespace MCAJ_PONG
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Bitmap btm;
        Graphics g;
        Graphics SCG;
        Rectangle ball;
        Rectangle Rside;
        Rectangle LSide;
        Thread th;
        int ball_speed = 7;
        int ball_speedY = 7;
        int move_speed = 7;
    
        Point moveTo = Point.Empty;
        Point ballMove = Point.Empty;

        bool drawing=true;


        private void Form1_Load(object sender, EventArgs e)
        {
            btm = new Bitmap(this.Width, this.Height);
            g = Graphics.FromImage(btm);
            SCG = this.CreateGraphics();

            ball = new Rectangle(this.Width / 2, this.Height / 2, 40, 40);
            Rside = new Rectangle(this.Width - 50, this.Height / 2, 30, 150);
            LSide = new Rectangle(5, this.Height / 2, 30, 150);

            th = new Thread(draw);
            th.IsBackground = true;
            th.Start();
        }

        public void draw()
        {
            try
            {
                while (drawing)
                {
                    g.Clear(Color.White);

                    if (moveTo.Y > Rside.Y + 100) Rside.Y += move_speed;
                    if (moveTo.Y < Rside.Y + 100) Rside.Y -= move_speed;
                    if (ball.Y > LSide.Y + 100) LSide.Y += move_speed;
                    if (ball.Y < LSide.Y + 100) LSide.Y -= move_speed;

                    ball.X += ball_speed;

                    if (ballMove.Y > ball.Y) ball.Y += ball_speedY;
                    if (ballMove.Y < ball.Y) ball.Y -= ball_speedY;

                    if (Rside.IntersectsWith(ball))
                    {
                        ball_speed *= -1;
                    }

                    if (ball.Y < 20) ballMove.Y = this.Height;
                    if (ball.Y > this.Height - 80) ballMove.Y = 0;

                    if (ball.X < -40) ball.X = this.Width / 2;
                    if (ball.X > this.Width) ball.X = this.Width / 2;

                    g.FillRectangle(Brushes.Black, Rside);
                    g.FillRectangle(Brushes.Black, LSide);
                    g.FillRectangle(Brushes.Black, ball);

                    SCG.DrawImage(btm, 0, 0, this.Width, this.Height);
                }
            }
            catch { }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            ballMove = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            moveTo = e.Location;
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                
            }
        }
    }
}
