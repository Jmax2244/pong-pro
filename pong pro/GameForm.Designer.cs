namespace pong_pro
{
    partial class GameForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Panel pnlPlayer;
        private System.Windows.Forms.Panel pnlComputer;
        private System.Windows.Forms.Panel pnlBall;
        private System.Windows.Forms.Timer gameTimer;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pnlPlayer = new System.Windows.Forms.Panel();
            this.pnlComputer = new System.Windows.Forms.Panel();
            this.pnlBall = new System.Windows.Forms.Panel();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);

            this.SuspendLayout();

            // Player Paddle
            this.pnlPlayer.BackColor = System.Drawing.Color.Blue;
            this.pnlPlayer.Size = new System.Drawing.Size(10, 60);
            this.pnlPlayer.Location = new System.Drawing.Point(30, 100);

            // Computer Paddle
            this.pnlComputer.BackColor = System.Drawing.Color.Red;
            this.pnlComputer.Size = new System.Drawing.Size(10, 60);
            this.pnlComputer.Location = new System.Drawing.Point(460, 100);

            // Ball
            this.pnlBall.BackColor = System.Drawing.Color.Black;
            this.pnlBall.Size = new System.Drawing.Size(10, 10);
            this.pnlBall.Location = new System.Drawing.Point(240, 140);

            // Game Timer
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);

            // Add Controls to Form
            this.Controls.Add(this.pnlPlayer);
            this.Controls.Add(this.pnlComputer);
            this.Controls.Add(this.pnlBall);

            // Form Properties
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(500, 300);
            this.Name = "GameForm";
            this.Text = "Pong Game";
            this.ResumeLayout(false);
        }

        #endregion
    }
}
