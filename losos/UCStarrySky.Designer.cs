namespace losos
{
    partial class UCStarrySky
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
            timer = new System.Windows.Forms.Timer(components);
            Label_Countdown = new Label();
            Button_Start = new Button();
            Label_Reward = new Label();
            Label_Clicks = new Label();
            Button_Return = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Sky).BeginInit();
            SuspendLayout();
            // 
            // pictureBox_Sky
            // 
            pictureBox_Sky.Location = new Point(114, 143);
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
            // Label_Countdown
            // 
            Label_Countdown.AutoSize = true;
            Label_Countdown.BackColor = Color.Red;
            Label_Countdown.Font = new Font("Segoe UI", 72F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Label_Countdown.ForeColor = Color.Yellow;
            Label_Countdown.Location = new Point(260, 288);
            Label_Countdown.Name = "Label_Countdown";
            Label_Countdown.Size = new Size(106, 128);
            Label_Countdown.TabIndex = 2;
            Label_Countdown.Text = "3";
            Label_Countdown.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // Button_Start
            // 
            Button_Start.Location = new Point(275, 96);
            Button_Start.Name = "Button_Start";
            Button_Start.Size = new Size(75, 23);
            Button_Start.TabIndex = 3;
            Button_Start.Text = "START";
            Button_Start.UseVisualStyleBackColor = true;
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
            // Button_Return
            // 
            Button_Return.Location = new Point(528, 23);
            Button_Return.Name = "Button_Return";
            Button_Return.Size = new Size(75, 23);
            Button_Return.TabIndex = 6;
            Button_Return.Text = "retreat";
            Button_Return.UseVisualStyleBackColor = true;
            Button_Return.Click += returnButton_Click;
            // 
            // UCStarrySky
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Button_Return);
            Controls.Add(Label_Clicks);
            Controls.Add(Label_Reward);
            Controls.Add(Button_Start);
            Controls.Add(Label_Countdown);
            Controls.Add(Label_TimeLeft);
            Controls.Add(pictureBox_Sky);
            Name = "UCStarrySky";
            Size = new Size(640, 640);
            ((System.ComponentModel.ISupportInitialize)pictureBox_Sky).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox_Sky;
        private Label Label_TimeLeft;
        private System.Windows.Forms.Timer timer;
        private Label Label_Countdown;
        private Button Button_Start;
        private Label Label_Reward;
        private Label Label_Clicks;
        private Button Button_Return;
    }
}
