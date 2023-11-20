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
        public int gap;
        public int height;
        public Boolean lost = true;
        public Boolean passed = false;
        public Random random = new Random();
        PictureBox[] pipes = new PictureBox[3];
        public void time_Tick(object sender, EventArgs e)
        {
            a = a - 1;
            Score.Text = "Score: " + score;
            moveBird();
            movePipe();
            check();

        }
        void makePipes()
        {

        }
        void makeTopPipe()
        {
            height = random.Next(440 - gap);
            topPipe.Size = new Size(60, 600);
            topPipe.Location = new Point(1100, -560 + height);
            topPipeTip.Size = new Size(90, 60);
            topPipeTip.Location = new Point(topPipe.Location.X - (topPipeTip.Width - topPipe.Width)/2, topPipe.Location.Y + topPipe.Height);
        }
        void makeBottomPipe()
        {
            gap = 160;
            bottomPipe.Size = new Size(60, 750);
            bottomPipe.Location = new Point(topPipe.Location.X, topPipe.Location.Y + topPipe.Height + topPipeTip.Height + bottomPipeTip.Height + gap);
            bottomPipeTip.Size = new Size(90, 60);
            bottomPipeTip.Location = new Point(bottomPipe.Location.X - (bottomPipeTip.Width - bottomPipe.Width) / 2, topPipe.Location.Y + topPipe.Height + topPipeTip.Height + gap);
        }
        void lose()
        {
            bird.Location = new Point(50, 270);
            additions.Location = new Point(bird.Location.X - 9, bird.Location.Y + 9); 
            makeTopPipe();
            makeBottomPipe();
            score = 0;
        }
        void check()
        {
            if (bird.Bounds.IntersectsWith(topPipe.Bounds) || bird.Bounds.IntersectsWith(bottomPipe.Bounds) || bird.Bounds.IntersectsWith(topPipeTip.Bounds) || bird.Bounds.IntersectsWith(bottomPipeTip.Bounds) || bird.Location.Y >= 620)
            {
                time.Stop();
                lost = true;
            }
        }
        void moveBird()
        {
            if (bird.Location.Y - a <= 0) 
            {
                bird.Top = 0;
                additions.Top = 9;
                a = 0;
            }
            else
            {
                bird.Top -= a;
                additions.Top -= a;
            }
        }
        void movePipe()
        {
            topPipe.Left -= 7;
            bottomPipe.Left -= 7;
            topPipeTip.Left -= 7;
            bottomPipeTip.Left -= 7;

            if(topPipe.Left <= -90)
            {
                makeTopPipe();
                makeBottomPipe();
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
                if (lost)
                {
                    lost = false;
                    time.Enabled = true;
                    lose();
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            makeTopPipe();
            makeBottomPipe();

            bird.BringToFront();

            topPipe.BringToFront();
            topPipeTip.BringToFront();
            bottomPipe.BringToFront();
            bottomPipeTip.BringToFront();

            bird.Image = bird.png;


        }
    }
}
