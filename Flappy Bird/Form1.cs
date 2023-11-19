using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flappy_Bird
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public int a = 0;
        public int score = 0;
        public Boolean passed = false;
        public Random random = new Random();
        public void time_Tick(object sender, EventArgs e)
        {
            a = a - 1;
            Score.Text = "Score: " + score;
            moveBird();
            movePipe();
            check();

        }
        void lose()
        {
            bird.Location = new Point(50, 270);
            topPipe.Left = 1160;
            bottomPipe.Left = 1160;
            score = 0;
        }
        void check()
        {
            if (bird.Bounds.IntersectsWith(topPipe.Bounds) || bird.Bounds.IntersectsWith(bottomPipe.Bounds))
            {
                time.Stop();
                lose();
            }
        }
        void moveBird()
        {
            if (bird.Location.Y - a <= 0) 
            {
                bird.Top = 0;
                a = 0;
            }
            else
            {
                bird.Top -= a;
            }
        }
        void movePipe()
        {
            int hole;
            topPipe.Left -= 7;
            bottomPipe.Left -= 7;
            if(topPipe.Left <= -40)
            {
                topPipe.Left += 1200;
                bottomPipe.Left += 1200;
                hole = random.Next(330);
                if (score < 50)
                {
                    topPipe.Top = hole - 530 + score;
                    bottomPipe.Top = hole + 270 - score;
                }
                else
                {
                    topPipe.Top = hole - 580;
                    bottomPipe.Top = hole + 220;
                }
                passed = false;
            }
            if (topPipe.Left <= 0 && !passed)
            {
                passed = true;
                score++;
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) 
            {
                a = 15;
                time.Enabled = true;
            }
        }
    }
}
