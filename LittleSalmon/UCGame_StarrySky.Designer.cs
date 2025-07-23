namespace LittleSalmon
{
    partial class UCGame_StarrySky
    {
        /// <summary> 
        /// Vyžaduje se proměnná návrháře.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Uvolněte všechny používané prostředky.
        /// </summary>
        /// <param name="disposing">hodnota true, když by se měl spravovaný prostředek odstranit; jinak false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kód vygenerovaný pomocí Návrháře komponent

        /// <summary> 
        /// Metoda vyžadovaná pro podporu Návrháře - neupravovat
        /// obsah této metody v editoru kódu.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            pictureBox_Sky = new PictureBox();
            Label_TimeLeft = new Label();
            Timer_CountdownToStart = new System.Windows.Forms.Timer(components);
            Label_Countdown = new Label();
            Label_Reward = new Label();
            Label_Clicks = new Label();
            Timer_GameTimer = new System.Windows.Forms.Timer(components);
            Timer_ChangeImage = new System.Windows.Forms.Timer(components);
            myButton_Start = new CustomControls.MyButton();
            myButton_Return = new CustomControls.MyButton();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Sky).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_Sky
            // 
            pictureBox_Sky.Location = new Point(152, 156);
            pictureBox_Sky.Name = "pictureBox_Sky";
            pictureBox_Sky.Size = new Size(400, 400);
            pictureBox_Sky.TabIndex = 0;
            pictureBox_Sky.TabStop = false;
            pictureBox_Sky.MouseClick += StarrySky_MouseClick;
            // 
            // Label_TimeLeft
            // 
            Label_TimeLeft.AutoSize = true;
            Label_TimeLeft.Location = new Point(26, 23);
            Label_TimeLeft.Name = "Label_TimeLeft";
            Label_TimeLeft.Size = new Size(59, 15);
            Label_TimeLeft.TabIndex = 1;
            Label_TimeLeft.Text = "Time left: ";
            // 
            // Timer_CountdownToStart
            // 
            Timer_CountdownToStart.Interval = 1000;
            Timer_CountdownToStart.Tick += timer_Countdown_Tick;
            // 
            // Label_Countdown
            // 
            Label_Countdown.AutoSize = true;
            Label_Countdown.BackColor = Color.Red;
            Label_Countdown.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Label_Countdown.ForeColor = Color.Yellow;
            Label_Countdown.Location = new Point(272, 270);
            Label_Countdown.Name = "Label_Countdown";
            Label_Countdown.Size = new Size(106, 128);
            Label_Countdown.TabIndex = 2;
            Label_Countdown.Text = "3";
            Label_Countdown.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Label_Reward
            // 
            Label_Reward.AutoSize = true;
            Label_Reward.Location = new Point(26, 54);
            Label_Reward.Name = "Label_Reward";
            Label_Reward.Size = new Size(43, 15);
            Label_Reward.TabIndex = 4;
            Label_Reward.Text = "reward";
            // 
            // Label_Clicks
            // 
            Label_Clicks.AutoSize = true;
            Label_Clicks.Location = new Point(26, 84);
            Label_Clicks.Name = "Label_Clicks";
            Label_Clicks.Size = new Size(36, 15);
            Label_Clicks.TabIndex = 5;
            Label_Clicks.Text = "clicks";
            // 
            // Timer_GameTimer
            // 
            Timer_GameTimer.Tick += timer_GameTimer_Tick;
            // 
            // Timer_ChangeImage
            // 
            Timer_ChangeImage.Interval = 500;
            Timer_ChangeImage.Tick += timer_ChangeImage_Tick;
            // 
            // myButton_Start
            // 
            myButton_Start.AutoSize = true;
            myButton_Start.BackColor = Color.AntiqueWhite;
            myButton_Start.FlatStyle = FlatStyle.Popup;
            myButton_Start.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            myButton_Start.ForeColor = Color.Black;
            myButton_Start.Location = new Point(297, 105);
            myButton_Start.Name = "myButton_Start";
            myButton_Start.Size = new Size(93, 29);
            myButton_Start.TabIndex = 7;
            myButton_Start.Text = "START";
            myButton_Start.UseVisualStyleBackColor = false;
            myButton_Start.Click += button_StartGame_Click;
            // 
            // myButton_Return
            // 
            myButton_Return.AutoSize = true;
            myButton_Return.BackColor = Color.AntiqueWhite;
            myButton_Return.FlatStyle = FlatStyle.Popup;
            myButton_Return.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            myButton_Return.ForeColor = Color.Black;
            myButton_Return.Location = new Point(517, 23);
            myButton_Return.Name = "myButton_Return";
            myButton_Return.Size = new Size(96, 29);
            myButton_Return.TabIndex = 8;
            myButton_Return.Text = "retreat";
            myButton_Return.UseVisualStyleBackColor = false;
            myButton_Return.Click += returnButton_Click;
            // 
            // UCGame_StarrySky
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(myButton_Return);
            Controls.Add(myButton_Start);
            Controls.Add(Label_Clicks);
            Controls.Add(Label_Reward);
            Controls.Add(Label_Countdown);
            Controls.Add(Label_TimeLeft);
            Controls.Add(pictureBox_Sky);
            Name = "UCGame_StarrySky";
            Size = new Size(640, 640);
            ((System.ComponentModel.ISupportInitialize)pictureBox_Sky).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox_Sky;
        private Label Label_TimeLeft;
        private System.Windows.Forms.Timer Timer_CountdownToStart;
        private Label Label_Countdown;
        private Label Label_Reward;
        private Label Label_Clicks;
        private System.Windows.Forms.Timer Timer_GameTimer;
        private System.Windows.Forms.Timer Timer_ChangeImage;
        private CustomControls.MyButton myButton_Start;
        private CustomControls.MyButton myButton_Return;
    }
}
