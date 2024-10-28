using pong_pro;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace pong_pro
{
    public partial class Form1 : Form
    {
        private List<string> lastGames;

        public Form1()
        {
            InitializeComponent();
            lastGames = new List<string>();
            UpdateLastGames();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtBallSpeed.Text, out int ballSpeed) || ballSpeed < 1 || ballSpeed > 10 ||
                !int.TryParse(txtPlayerSpeed.Text, out int playerSpeed) || playerSpeed < 1 || playerSpeed > 10 ||
                !int.TryParse(txtComputerSpeed.Text, out int computerSpeed) || computerSpeed < 1 || computerSpeed > 10)
            {
                MessageBox.Show("WprowadŸ liczby z zakresu 1-10 dla prêdkoœci pi³ki, gracza i komputera.", "B³¹d", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            GameForm gameForm = new GameForm(ballSpeed, playerSpeed, computerSpeed);
            gameForm.ShowDialog();

            AddGameResult(gameForm.PlayerScore, gameForm.ComputerScore);
            UpdateLastGames();
        }

        private void AddGameResult(int playerScore, int computerScore)
        {
            string result = $"Gracz {playerScore} - Komputer {computerScore}, {DateTime.Now.ToShortDateString()}";
            lastGames.Insert(0, result);
            if (lastGames.Count > 3)
            {
                lastGames.RemoveAt(3);
            }
        }

        private void UpdateLastGames()
        {
            for (int i = 0; i < lastGames.Count; i++)
            {
                lblLastGameRecords[i].Text = lastGames[i];
            }

            for (int i = lastGames.Count; i < lblLastGameRecords.Length; i++)
            {
                lblLastGameRecords[i].Text = "";
            }
        }
    }
}
