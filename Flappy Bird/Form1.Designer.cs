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
            this.Score = new System.Windows.Forms.TextBox();
            this.additions = new System.Windows.Forms.PictureBox();
            this.bird = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.additions)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).BeginInit();
            this.SuspendLayout();
            // 
            // time
            // 
            this.time.Interval = 20;
            this.time.Tick += new System.EventHandler(this.time_Tick);
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
            // additions
            // 
            this.additions.BackColor = System.Drawing.Color.Transparent;
            this.additions.Image = global::Flappy_Bird.Properties.Resources.flappy_bird_additions_2;
            this.additions.InitialImage = global::Flappy_Bird.Properties.Resources.flappy_bird_additions_2;
            this.additions.Location = new System.Drawing.Point(41, 279);
            this.additions.Name = "additions";
            this.additions.Size = new System.Drawing.Size(60, 21);
            this.additions.TabIndex = 8;
            this.additions.TabStop = false;
            // 
            // bird
            // 
            this.bird.BackColor = System.Drawing.Color.Transparent;
            this.bird.Image = global::Flappy_Bird.Properties.Resources.flappy_bird_body;
            this.bird.ImageLocation = "";
            this.bird.Location = new System.Drawing.Point(50, 270);
            this.bird.Name = "bird";
            this.bird.Size = new System.Drawing.Size(40, 40);
            this.bird.TabIndex = 2;
            this.bird.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Aqua;
            this.ClientSize = new System.Drawing.Size(1365, 661);
            this.Controls.Add(this.additions);
            this.Controls.Add(this.Score);
            this.Controls.Add(this.bird);
            this.MaximumSize = new System.Drawing.Size(10000, 7000);
            this.MinimumSize = new System.Drawing.Size(1000, 700);
            this.Name = "Form1";
            this.Text = " ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.additions)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer time;
        private System.Windows.Forms.PictureBox bird;
        private System.Windows.Forms.TextBox Score;
        private System.Windows.Forms.PictureBox additions;
    }
}

