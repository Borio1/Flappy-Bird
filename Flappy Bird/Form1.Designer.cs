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
            this.time = new System.Windows.Forms.Timer(this.components);
            this.bird = new System.Windows.Forms.PictureBox();
            this.topPipe = new System.Windows.Forms.PictureBox();
            this.bottomPipe = new System.Windows.Forms.PictureBox();
            this.Score = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.topPipe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPipe)).BeginInit();
            this.SuspendLayout();
            // 
            // time
            // 
            this.time.Interval = 20;
            this.time.Tick += new System.EventHandler(this.time_Tick);
            // 
            // bird
            // 
            this.bird.BackColor = System.Drawing.Color.Yellow;
            this.bird.Location = new System.Drawing.Point(50, 270);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(40, 40);
            this.bird.TabIndex = 2;
            this.bird.TabStop = false;
            // 
            // topPipe
            // 
            this.topPipe.BackColor = System.Drawing.Color.Lime;
            this.topPipe.Location = new System.Drawing.Point(1200, -400);
            this.topPipe.Name = "topPipe";
            this.topPipe.Size = new System.Drawing.Size(40, 600);
            this.topPipe.TabIndex = 3;
            this.topPipe.TabStop = false;
            // 
            // bottomPipe
            // 
            this.bottomPipe.BackColor = System.Drawing.Color.Lime;
            this.bottomPipe.Location = new System.Drawing.Point(1200, 400);
            this.bottomPipe.Name = "bottomPipe";
            this.bottomPipe.Size = new System.Drawing.Size(40, 600);
            this.bottomPipe.TabIndex = 4;
            this.bottomPipe.TabStop = false;
            // 
            // Score
            // 
            this.Score.Enabled = false;
            this.Score.Location = new System.Drawing.Point(12, 12);
            this.Score.Name = "Score";
            this.Score.Size = new System.Drawing.Size(100, 20);
            this.Score.TabIndex = 5;
            this.Score.Text = "Score: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 661);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.bottomPipe);
            this.Controls.Add(this.topPipe);
            this.Controls.Add(this.bird);
            this.MaximumSize = new System.Drawing.Size(1000, 700);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "Form1";
            this.Text = " ";
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.topPipe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bottomPipe)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.PictureBox topPipe;
        private System.Windows.Forms.PictureBox bottomPipe;
        private System.Windows.Forms.TextBox Score;
    }
}

