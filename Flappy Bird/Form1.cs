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
        public List<Pipe> pipes = new List<Pipe>();
        public void time_Tick(object sender, EventArgs e)
        {
            a = a - 1;
            if (a < 0)
            {
                bird.Image = Flappy_Bird.Properties.Resources.flappy_bird_body_wing_up;
                additions.Image = Flappy_Bird.Properties.Resources.flappy_bird_additions_mouth_open_2;
            }
            Score.Text = "Score: " + score;
            moveBird();
            movePipe();
            check();

        }
        void makePipe()
        {
            pipes.Add(new Pipe(-300, 160));
        }
        void lose()
        {
            bird.Location = new Point(50, 270);
            additions.Location = new Point(bird.Location.X - 9, bird.Location.Y + 9);
            pipes.Clear();
            makePipe();
            score = 0;
        }
        void check()
        {
            for (int i = 0; i < pipes.Count; i++)
            {
                for(int x = 0; x < 4; x++)
                {
                    if (bird.Bounds.IntersectsWith(pipes[i].getPipe()[x].Bounds) || bird.Location.Y >= 620)
                    {
                        time.Stop();
                        lost = true;
                    }
                }
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
            for (int i = 0; i < pipes.Count; i++)
            {
                pipes[i].movePipe(7);
            }
        }
        
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space) 
            {
                a = 15;
                bird.Image = Flappy_Bird.Properties.Resources.flappy_bird_body;
                additions.Image = Flappy_Bird.Properties.Resources.flappy_bird_additions_2;
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
            makePipe();

            bird.BringToFront();

            for(int i = 0; i < 4; i++)
            {
                pipes[0].getPipe()[i].BringToFront();
            }
        }
    }
    public class Pipe
    {
        private PictureBox[] pipe;
        private int height;
        private int gap;
        
        public Pipe(int height, int gap)
        {
            this.height = height;
            this.gap = gap;

            this.pipe = new PictureBox[4];

            for(int i = 0; i < 4; i++)
            {
                pipe[i] = new PictureBox();
                pipe[i].BackColor = Color.Transparent;
                pipe[i].Visible = true;
                pipe[i].Enabled = true;
                pipe[i].Show();
                pipe[i].Refresh();
                pipe[i].WaitOnLoad = true;
            }
            pipe[0].Image = Flappy_Bird.Properties.Resources.flappy_pipe_body_flipped;
            pipe[1].Image = Flappy_Bird.Properties.Resources.flappy_pipe_top_flipped;
            pipe[2].Image = Flappy_Bird.Properties.Resources.flappy_pipe_top;
            pipe[3].Image = Flappy_Bird.Properties.Resources.flappy_pipe_body_3;

            pipe[0].Location = new Point(1200, height);
            pipe[1].Location = new Point(pipe[0].Location.X, height + pipe[0].Height);
            pipe[2].Location = new Point(pipe[0].Location.X, pipe[1].Location.Y + pipe[0].Height + gap);
            pipe[3].Location = new Point(pipe[0].Location.X, pipe[1].Location.Y + pipe[1].Height);

            pipe[0].Size = new Size(60, 600);
            pipe[1].Size = new Size(90, 60);
            pipe[2].Size = new Size(90, 60);
            pipe[3].Size = new Size(60, 600);
        }
        public void movePipe(int x)
        {
            for (int i = 0; i < pipe.Length; i++)
            {
                pipe[i].Left -= x;
            }
        }
        public void removePipe()
        {
            for (int i = 0; i < pipe.Length; i++)
            {
                pipe[i] = null;
            }
        }
        public PictureBox[] getPipe()
        {
            return pipe;
        }
    }
}
