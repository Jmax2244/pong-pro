using System;
using System.Windows.Forms;

namespace pong_pro
{
    public partial class GameForm : Form
    {
        public int PlayerScore { get; private set; }
        public int ComputerScore { get; private set; }

        private int ballSpeedX;
        private int ballSpeedY;
        private int playerSpeed;
        private int computerSpeed;

        private int playerGoals = 0; 
        private int computerGoals = 0; 
        private const int MaxGoals = 3; 

        public GameForm(int ballSpeed, int playerSpeed, int computerSpeed)
        {
            InitializeComponent();

            this.ballSpeedX = ballSpeed;
            this.ballSpeedY = ballSpeed;
            this.playerSpeed = playerSpeed;
            this.computerSpeed = computerSpeed;

            gameTimer.Start();
            PlayerScore = 0;
            ComputerScore = 0;
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            // ruchy kuleczki
            pnlBall.Left += ballSpeedX;
            pnlBall.Top += ballSpeedY;

            // kolizja sciany jo jo
            if (pnlBall.Top <= 0 || pnlBall.Bottom >= ClientSize.Height)
                ballSpeedY = -ballSpeedY;

            // kolizja paletki
            if (pnlBall.Bounds.IntersectsWith(pnlPlayer.Bounds))
                ballSpeedX = Math.Abs(ballSpeedX);

            // kolizja paletki tego drugiego kolezszki
            if (pnlBall.Bounds.IntersectsWith(pnlComputer.Bounds))
                ballSpeedX = -Math.Abs(ballSpeedX);

            MoveComputerPaddle();

           
            if (pnlBall.Left < 0) 
            {
                computerGoals++;
                ComputerScore++;
                CheckGameOver();
                ResetBall();
            }
            else if (pnlBall.Right > ClientSize.Width) 
            {
                playerGoals++;
                PlayerScore++;
                CheckGameOver();
                ResetBall();
            }
        }

        private void MoveComputerPaddle()
        {
            int targetPosition = pnlBall.Top - pnlComputer.Height / 2;

            if (pnlComputer.Top < targetPosition)
                pnlComputer.Top += computerSpeed;
            else if (pnlComputer.Top > targetPosition)
                pnlComputer.Top -= computerSpeed;

            if (pnlComputer.Top < 0)
                pnlComputer.Top = 0;
            if (pnlComputer.Bottom > ClientSize.Height)
                pnlComputer.Top = ClientSize.Height - pnlComputer.Height;
        }

        private void ResetBall()
        {
            pnlBall.Location = new System.Drawing.Point(ClientSize.Width / 2, ClientSize.Height / 2);
            ballSpeedX = -ballSpeedX; 
        }

        private void CheckGameOver()
        {
            
            if (playerGoals >= MaxGoals || computerGoals >= MaxGoals)
            {
                gameTimer.Stop(); 

                
                string resultMessage = $"Wynik końcowy: Gracz {PlayerScore} - Komputer {ComputerScore}";
                MessageBox.Show(resultMessage, "Koniec gry", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close(); 
            }
        }

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            if (e.KeyCode == Keys.Up && pnlPlayer.Top > 0)
                pnlPlayer.Top -= playerSpeed;
            else if (e.KeyCode == Keys.Down && pnlPlayer.Bottom < ClientSize.Height)
                pnlPlayer.Top += playerSpeed;
        }
    }
}
