namespace downbadArcade
{
    partial class Pong
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Pong));
            this.Player = new System.Windows.Forms.PictureBox();
            this.ball = new System.Windows.Forms.PictureBox();
            this.cpu = new System.Windows.Forms.PictureBox();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.playerScore = new System.Windows.Forms.Label();
            this.cpuLabel = new System.Windows.Forms.Label();
            this.cpu1 = new System.Windows.Forms.PictureBox();
            this.timeToGoFast = new System.Windows.Forms.PictureBox();
            this.twoPlayersLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpu1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeToGoFast)).BeginInit();
            this.SuspendLayout();
            // 
            // Player
            // 
            this.Player.BackColor = System.Drawing.Color.Yellow;
            this.Player.Location = new System.Drawing.Point(12, 186);
            this.Player.Margin = new System.Windows.Forms.Padding(6);
            this.Player.Name = "Player";
            this.Player.Size = new System.Drawing.Size(27, 127);
            this.Player.TabIndex = 0;
            this.Player.TabStop = false;
            // 
            // ball
            // 
            this.ball.BackColor = System.Drawing.Color.White;
            this.ball.Location = new System.Drawing.Point(434, 239);
            this.ball.Margin = new System.Windows.Forms.Padding(6);
            this.ball.Name = "ball";
            this.ball.Size = new System.Drawing.Size(27, 26);
            this.ball.TabIndex = 1;
            this.ball.TabStop = false;
            // 
            // cpu
            // 
            this.cpu.BackColor = System.Drawing.Color.Fuchsia;
            this.cpu.Location = new System.Drawing.Point(1794, 442);
            this.cpu.Margin = new System.Windows.Forms.Padding(6);
            this.cpu.Name = "cpu";
            this.cpu.Size = new System.Drawing.Size(54, 244);
            this.cpu.TabIndex = 2;
            this.cpu.TabStop = false;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.timerTick);
            // 
            // playerScore
            // 
            this.playerScore.AutoSize = true;
            this.playerScore.Location = new System.Drawing.Point(105, 9);
            this.playerScore.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.playerScore.Name = "playerScore";
            this.playerScore.Size = new System.Drawing.Size(36, 25);
            this.playerScore.TabIndex = 3;
            this.playerScore.Text = "00";
            // 
            // cpuLabel
            // 
            this.cpuLabel.AutoSize = true;
            this.cpuLabel.ForeColor = System.Drawing.Color.Red;
            this.cpuLabel.Location = new System.Drawing.Point(735, 9);
            this.cpuLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.cpuLabel.Name = "cpuLabel";
            this.cpuLabel.Size = new System.Drawing.Size(36, 25);
            this.cpuLabel.TabIndex = 4;
            this.cpuLabel.Text = "00";
            // 
            // cpu1
            // 
            this.cpu1.BackColor = System.Drawing.Color.Fuchsia;
            this.cpu1.Location = new System.Drawing.Point(897, 230);
            this.cpu1.Name = "cpu1";
            this.cpu1.Size = new System.Drawing.Size(27, 127);
            this.cpu1.TabIndex = 5;
            this.cpu1.TabStop = false;
            // 
            // timeToGoFast
            // 
            this.timeToGoFast.BackColor = System.Drawing.Color.Transparent;
            this.timeToGoFast.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("timeToGoFast.BackgroundImage")));
            this.timeToGoFast.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.timeToGoFast.Location = new System.Drawing.Point(177, 313);
            this.timeToGoFast.Name = "timeToGoFast";
            this.timeToGoFast.Size = new System.Drawing.Size(59, 44);
            this.timeToGoFast.TabIndex = 6;
            this.timeToGoFast.TabStop = false;
            this.timeToGoFast.Visible = false;
            // 
            // twoPlayersLabel
            // 
            this.twoPlayersLabel.AutoSize = true;
            this.twoPlayersLabel.ForeColor = System.Drawing.Color.White;
            this.twoPlayersLabel.Location = new System.Drawing.Point(272, 9);
            this.twoPlayersLabel.Name = "twoPlayersLabel";
            this.twoPlayersLabel.Size = new System.Drawing.Size(348, 25);
            this.twoPlayersLabel.TabIndex = 7;
            this.twoPlayersLabel.Text = "Press [ E ] to toggle 2 player mode!";
            this.twoPlayersLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Pong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(928, 574);
            this.Controls.Add(this.twoPlayersLabel);
            this.Controls.Add(this.timeToGoFast);
            this.Controls.Add(this.cpu1);
            this.Controls.Add(this.cpuLabel);
            this.Controls.Add(this.playerScore);
            this.Controls.Add(this.cpu);
            this.Controls.Add(this.ball);
            this.Controls.Add(this.Player);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Lime;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "Pong";
            this.Text = "Pong Game";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.Player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ball)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cpu1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.timeToGoFast)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox Player;
        private System.Windows.Forms.PictureBox ball;
        private System.Windows.Forms.PictureBox cpu;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label playerScore;
        private System.Windows.Forms.Label cpuLabel;
        private System.Windows.Forms.PictureBox cpu1;
        private System.Windows.Forms.PictureBox timeToGoFast;
        private System.Windows.Forms.Label twoPlayersLabel;
    }
}