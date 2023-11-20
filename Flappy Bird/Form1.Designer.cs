namespace Flappy_Bird
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.time = new System.Windows.Forms.Timer(this.components);
            this.bird = new System.Windows.Forms.PictureBox();
            this.topPipe = new System.Windows.Forms.PictureBox();
            this.bottomPipe = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.TextBox();
            this.bottomPipeTip = new System.Windows.Forms.PictureBox();
            this.topPipeTip = new System.Windows.Forms.PictureBox();
            this.additions = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPipeTip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topPipeTip)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.additions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // time
            // 
            this.time.Interval = 20;
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // bird
            // 
            this.bird.BackColor = System.Drawing.Color.Transparent;
            this.bird.ErrorImage = ((System.Drawing.Image)(resources.GetObject("bird.ErrorImage")));
            this.bird.Image = ((System.Drawing.Image)(resources.GetObject("bird.Image")));
            this.bird.ImageLocation = "";
            this.bird.Location = new System.Drawing.Point(50, 270);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(40, 40);
            this.bird.TabIndex = 2;
            this.bird.TabStop = false;
            // 
            // topPipe
            // 
            this.topPipe.BackColor = System.Drawing.Color.Lime;
            this.topPipe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("topPipe.BackgroundImage")));
            this.topPipe.Location = new System.Drawing.Point(1200, -460);
            this.topPipe.Name = "topPipe";
            this.topPipe.Size = new System.Drawing.Size(60, 600);
            this.topPipe.TabIndex = 3;
            this.topPipe.TabStop = false;
            // 
            // bottomPipe
            // 
            this.bottomPipe.BackColor = System.Drawing.Color.Lime;
            this.bottomPipe.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bottomPipe.BackgroundImage")));
            this.bottomPipe.Location = new System.Drawing.Point(1200, 460);
            this.bottomPipe.Name = "bottomPipe";
            this.bottomPipe.Size = new System.Drawing.Size(60, 600);
            this.bottomPipe.TabIndex = 4;
            this.bottomPipe.TabStop = false;
            // 
            // Score
            // 
            this.Score.Enabled = false;
            this.Score.Location = new System.Drawing.Point(872, 12);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(100, 20);
            this.Score.TabIndex = 5;
            this.Score.Text = "Score: 0";
            // 
            // bottomPipeTip
            // 
            this.bottomPipeTip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bottomPipeTip.BackgroundImage")));
            this.bottomPipeTip.Location = new System.Drawing.Point(1185, 400);
            this.bottomPipeTip.Name = "bottomPipeTip";
            this.bottomPipeTip.Size = new System.Drawing.Size(90, 60);
            this.bottomPipeTip.TabIndex = 6;
            this.bottomPipeTip.TabStop = false;
            // 
            // topPipeTip
            // 
            this.topPipeTip.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("topPipeTip.BackgroundImage")));
            this.topPipeTip.ErrorImage = ((System.Drawing.Image)(resources.GetObject("topPipeTip.ErrorImage")));
            this.topPipeTip.Location = new System.Drawing.Point(1185, 140);
            this.topPipeTip.Name = "topPipeTip";
            this.topPipeTip.Size = new System.Drawing.Size(90, 60);
            this.topPipeTip.TabIndex = 7;
            this.topPipeTip.TabStop = false;
            // 
            // additions
            // 
            this.additions.BackColor = System.Drawing.Color.Transparent;
            this.additions.Image = ((System.Drawing.Image)(resources.GetObject("additions.Image")));
            this.additions.InitialImage = ((System.Drawing.Image)(resources.GetObject("additions.InitialImage")));
            this.additions.Location = new System.Drawing.Point(41, 279);
            this.additions.Name = "additions";
            this.additions.Size = new System.Drawing.Size(60, 21);
            this.additions.TabIndex = 8;
            this.additions.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(759, 38);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(200, 80);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Location = new System.Drawing.Point(516, 259);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(40, 40);
            this.pictureBox2.TabIndex = 10;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.additions);
            this.Controls.Add(this.topPipeTip);
            this.Controls.Add(this.bottomPipeTip);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.bottomPipe);
            this.Controls.Add(this.topPipe);
            this.Controls.Add(this.bird);
            this.MaximumSize = new System.Drawing.Size(10000, 7000);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPipeTip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topPipeTip)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.additions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox topPipe;
        private System.Windows.Forms.PictureBox bottomPipe;
        private System.Windows.Forms.TextBox Score;
        private System.Windows.Forms.PictureBox bottomPipeTip;
        private System.Windows.Forms.PictureBox topPipeTip;
        private System.Windows.Forms.PictureBox additions;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

