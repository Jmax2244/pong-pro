namespace pong_pro
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtBallSpeed;
        private System.Windows.Forms.TextBox txtPlayerSpeed;
        private System.Windows.Forms.TextBox txtComputerSpeed;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Panel pnlLastGames;
        private System.Windows.Forms.Label lblLastGamesTitle;
        private System.Windows.Forms.Label[] lblLastGameRecords;
        private System.Windows.Forms.Label lblBallSpeed;
        private System.Windows.Forms.Label lblPlayerSpeed;
        private System.Windows.Forms.Label lblComputerSpeed;

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
            this.lblTitle = new System.Windows.Forms.Label();
            this.txtBallSpeed = new System.Windows.Forms.TextBox();
            this.txtPlayerSpeed = new System.Windows.Forms.TextBox();
            this.txtComputerSpeed = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.pnlLastGames = new System.Windows.Forms.Panel();
            this.lblLastGamesTitle = new System.Windows.Forms.Label();
            this.lblLastGameRecords = new System.Windows.Forms.Label[3];
            this.lblBallSpeed = new System.Windows.Forms.Label();
            this.lblPlayerSpeed = new System.Windows.Forms.Label();
            this.lblComputerSpeed = new System.Windows.Forms.Label();

            this.SuspendLayout();

            // Label Title
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.lblTitle.Location = new System.Drawing.Point(100, 20);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Text = "PONG pro pro";

            // Label Ball Speed
            this.lblBallSpeed.Location = new System.Drawing.Point(50, 70);
            this.lblBallSpeed.Name = "lblBallSpeed";
            this.lblBallSpeed.Size = new System.Drawing.Size(80, 20);
            this.lblBallSpeed.Text = "predkosc pilki:";

            // TextBox Ball Speed
            this.txtBallSpeed.Location = new System.Drawing.Point(150, 70);
            this.txtBallSpeed.Name = "txtBallSpeed";
            this.txtBallSpeed.Size = new System.Drawing.Size(50, 20);
            this.txtBallSpeed.Text = "5"; // Default value

            // Label Player Speed
            this.lblPlayerSpeed.Location = new System.Drawing.Point(50, 100);
            this.lblPlayerSpeed.Name = "lblPlayerSpeed";
            this.lblPlayerSpeed.Size = new System.Drawing.Size(80, 20);
            this.lblPlayerSpeed.Text = "predkosc_gracza:";

            // TextBox Player Speed
            this.txtPlayerSpeed.Location = new System.Drawing.Point(150, 100);
            this.txtPlayerSpeed.Name = "txtPlayerSpeed";
            this.txtPlayerSpeed.Size = new System.Drawing.Size(50, 20);
            this.txtPlayerSpeed.Text = "5"; // Default value

            // Label Computer Speed
            this.lblComputerSpeed.Location = new System.Drawing.Point(50, 130);
            this.lblComputerSpeed.Name = "lblComputerSpeed";
            this.lblComputerSpeed.Size = new System.Drawing.Size(100, 20);
            this.lblComputerSpeed.Text = "predkosc_komputera:";

            // TextBox Computer Speed
            this.txtComputerSpeed.Location = new System.Drawing.Point(150, 130);
            this.txtComputerSpeed.Name = "txtComputerSpeed";
            this.txtComputerSpeed.Size = new System.Drawing.Size(50, 20);
            this.txtComputerSpeed.Text = "5"; // Default value

            // Button Start
            this.btnStart.Location = new System.Drawing.Point(100, 170);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(150, 30);
            this.btnStart.Text = "Zaczynajmy to widzowie";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);

            // Panel Last Games
            this.pnlLastGames.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlLastGames.Location = new System.Drawing.Point(50, 220);
            this.pnlLastGames.Name = "pnlLastGames";
            this.pnlLastGames.Size = new System.Drawing.Size(200, 130);

            // Label Last Games Title
            this.lblLastGamesTitle.Location = new System.Drawing.Point(60, 10);
            this.lblLastGamesTitle.Name = "lblLastGamesTitle";
            this.lblLastGamesTitle.Size = new System.Drawing.Size(180, 20);
            this.lblLastGamesTitle.Text = "Ostatnie gry";
            this.pnlLastGames.Controls.Add(this.lblLastGamesTitle);

            // Labels for Last Game Records
            for (int i = 0; i < lblLastGameRecords.Length; i++)
            {
                lblLastGameRecords[i] = new System.Windows.Forms.Label();
                lblLastGameRecords[i].Location = new System.Drawing.Point(10, 30 + (i * 30));
                lblLastGameRecords[i].Size = new System.Drawing.Size(180, 20);
                lblLastGameRecords[i].Text = "";
                this.pnlLastGames.Controls.Add(lblLastGameRecords[i]);
            }

            // Add Controls to Form
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.txtBallSpeed);
            this.Controls.Add(this.txtPlayerSpeed);
            this.Controls.Add(this.txtComputerSpeed);
            this.Controls.Add(this.lblBallSpeed);
            this.Controls.Add(this.lblPlayerSpeed);
            this.Controls.Add(this.lblComputerSpeed);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.pnlLastGames);

            // Form Properties
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(300, 380);
            this.Name = "Form1";
            this.Text = "Pong pro";
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        #endregion
    }
}
