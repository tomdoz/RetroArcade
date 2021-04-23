using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace downbadArcade
{


    public partial class Pong : Form
    {
        Random rand = new Random();       
        bool goup;
        bool godown;
        bool cpuUp;
        bool cpuDown;
        bool ballSpeedIncreaseTime = false;
        bool ballSpeedIncrease = false;
        int speed= 5;
        int ballx = 5;
        int bally = 5;
        int score = 0;
        int cpuPoint = 0;
        int randNum = 0;
        bool twoPlayer;
        
        

        public Pong()
        {
            SetRand();
            InitializeComponent();
        }

        private void SetRand()
        {
            randNum = rand.Next(6);
        }

        private void Keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.E)
            {
                if (twoPlayer == true)
                {
                    twoPlayer = false;
                }
                else
                {
                    twoPlayer = true;
                }

            }
            if (e.KeyCode == Keys.W)
            {
                goup = true;
            }
            if (e.KeyCode == Keys.S)
            {
                godown = true;
            }
            if (twoPlayer == true)
            {
                if (e.KeyCode == Keys.Up)
                {
                    cpuUp = true;
                }
                if (e.KeyCode == Keys.Down)
                {
                    cpuDown = true;
                }
            }
            if (e.KeyCode == Keys.Enter)
            {
                gameTimer.Enabled = true;
            }
        }

        private void Keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.W)
            {
                goup = false;
            }

            if (e.KeyCode == Keys.S)
            {
                godown = false;
            }

            if (e.KeyCode == Keys.Up)
            {
                cpuUp = false;
            }

            if (e.KeyCode == Keys.Down)
            {
                cpuDown = false;
            }
    
        }
        
        private void timerTick(object sender, EventArgs e)
        {
            playerScore.Text = "" + score;
            cpuLabel.Text = "" + cpuPoint;
            ball.Top -= bally;
            ball.Left -= ballx;
           
            if (score == randNum)
            {
                timeToGoFast.Visible = true;
                timeToGoFast.Enabled = true;
            }

            if (ball.Bounds.IntersectsWith(timeToGoFast.Bounds) && timeToGoFast.Visible == true)
            {
                ballSpeedIncreaseTime = true;
                timeToGoFast.Visible = false;
                timeToGoFast.Enabled = false;
                randNum = randNum - 1;
            }

            if (ballSpeedIncrease == true)
            {
                ballx++;
                bally++;
                ballSpeedIncrease = false;
            }

            if (twoPlayer == false)
            {
                cpu1.Top += speed;
                if (score < 5)
                {
                    if (cpu1.Top < 0 || cpu1.Top > 455)
                    {
                        speed = -speed;
                    }
                }
                else
                {
                    cpu1.Top = ball.Top - 30;
                }
            }
          
            if (ball.Left < 0)
            {
                ball.Left = 434;
                ballx = -ballx;
                ballx -= 2;
                cpuPoint++;
            }

            if (ball.Left + ball.Width > ClientSize.Width)
            {
                ball.Left = 434;
                ballx = -ballx;
                ballx += 2;
                score++;

            }

            if (ball.Top < 0 || ball.Top + ball.Height > ClientSize.Height)
            {
                bally = -bally;
            }

            if (ball.Bounds.IntersectsWith(Player.Bounds) || ball.Bounds.IntersectsWith(cpu1.Bounds))
            {
                ballx = -ballx;
                if (ballSpeedIncreaseTime == true)
                {
                    ballSpeedIncrease = true;
                }

            }

            if (goup == true && Player.Top >0)
            {
                Player.Top -= 8;
            }
            
            if (godown == true && Player.Top < 455)
            {
                Player.Top += 8;
            }

            if (cpuUp == true && cpu1.Top > 0)
            {
                cpu1.Top -= 8;
            }

            if (cpuDown == true && cpu1.Top < 455)
            {
                cpu1.Top += 8;
            }

            if (score == 10)
            {
                gameTimer.Stop();
                MessageBox.Show("You win this game!");
            }

            if (cpuPoint == 10)
            {
                gameTimer.Stop();
                MessageBox.Show("CPU wins, you lose :(");
            }
        }

    }
}
