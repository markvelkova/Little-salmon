namespace LittleSalmon
{
    partial class UCGame_HeadsOrTails
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
            coinPicture = new PictureBox();
            Label_Result = new Label();
            Label_WinSoFar = new Label();
            Label_CurrentFoodCount = new Label();
            myButton_ResetFairness = new CustomControls.MyButton();
            myButton_Randomize = new CustomControls.MyButton();
            myButton_HeadsBet = new CustomControls.MyButton();
            myButton_JustFlip = new CustomControls.MyButton();
            myButton_TailsBet = new CustomControls.MyButton();
            myButton_Return = new CustomControls.MyButton();
            ((System.ComponentModel.ISupportInitialize)coinPicture).BeginInit();
            SuspendLayout();
            // 
            // coinPicture
            // 
            coinPicture.Location = new Point(241, 215);
            coinPicture.Name = "coinPicture";
            coinPicture.Size = new Size(150, 150);
            coinPicture.TabIndex = 4;
            coinPicture.TabStop = false;
            // 
            // Label_Result
            // 
            Label_Result.AutoSize = true;
            Label_Result.Location = new Point(275, 148);
            Label_Result.Name = "Label_Result";
            Label_Result.Size = new Size(36, 15);
            Label_Result.TabIndex = 8;
            Label_Result.Text = "hmm";
            // 
            // Label_WinSoFar
            // 
            Label_WinSoFar.AutoSize = true;
            Label_WinSoFar.Location = new Point(35, 30);
            Label_WinSoFar.Name = "Label_WinSoFar";
            Label_WinSoFar.Size = new Size(92, 15);
            Label_WinSoFar.TabIndex = 10;
            Label_WinSoFar.Text = "So far you won: ";
            // 
            // Label_CurrentFoodCount
            // 
            Label_CurrentFoodCount.AutoSize = true;
            Label_CurrentFoodCount.Location = new Point(35, 64);
            Label_CurrentFoodCount.Name = "Label_CurrentFoodCount";
            Label_CurrentFoodCount.Size = new Size(115, 15);
            Label_CurrentFoodCount.TabIndex = 11;
            Label_CurrentFoodCount.Text = "Current food count: ";
            // 
            // myButton_ResetFairness
            // 
            myButton_ResetFairness.AutoSize = true;
            myButton_ResetFairness.BackColor = Color.AntiqueWhite;
            myButton_ResetFairness.FlatStyle = FlatStyle.Popup;
            myButton_ResetFairness.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            myButton_ResetFairness.ForeColor = Color.Black;
            myButton_ResetFairness.Location = new Point(48, 264);
            myButton_ResetFairness.Name = "myButton_ResetFairness";
            myButton_ResetFairness.Size = new Size(149, 48);
            myButton_ResetFairness.TabIndex = 12;
            myButton_ResetFairness.Text = "humbly return\r\nto the default coin";
            myButton_ResetFairness.UseVisualStyleBackColor = false;
            myButton_ResetFairness.Click += resetButton_Click;
            // 
            // myButton_Randomize
            // 
            myButton_Randomize.AutoSize = true;
            myButton_Randomize.BackColor = Color.AntiqueWhite;
            myButton_Randomize.FlatStyle = FlatStyle.Popup;
            myButton_Randomize.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            myButton_Randomize.ForeColor = Color.Black;
            myButton_Randomize.Location = new Point(439, 264);
            myButton_Randomize.Name = "myButton_Randomize";
            myButton_Randomize.Size = new Size(148, 48);
            myButton_Randomize.TabIndex = 13;
            myButton_Randomize.Text = "confidently opt\r\nfor the unfair coin";
            myButton_Randomize.UseVisualStyleBackColor = false;
            myButton_Randomize.Click += randomizeButton_Click;
            // 
            // myButton_HeadsBet
            // 
            myButton_HeadsBet.AutoSize = true;
            myButton_HeadsBet.BackColor = Color.AntiqueWhite;
            myButton_HeadsBet.FlatStyle = FlatStyle.Popup;
            myButton_HeadsBet.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            myButton_HeadsBet.ForeColor = Color.Black;
            myButton_HeadsBet.Location = new Point(76, 478);
            myButton_HeadsBet.Name = "myButton_HeadsBet";
            myButton_HeadsBet.Size = new Size(96, 29);
            myButton_HeadsBet.TabIndex = 14;
            myButton_HeadsBet.Text = "heads";
            myButton_HeadsBet.UseVisualStyleBackColor = false;
            myButton_HeadsBet.Click += playButton_Click;
            // 
            // myButton_JustFlip
            // 
            myButton_JustFlip.AutoSize = true;
            myButton_JustFlip.BackColor = Color.AntiqueWhite;
            myButton_JustFlip.FlatStyle = FlatStyle.Popup;
            myButton_JustFlip.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            myButton_JustFlip.ForeColor = Color.Black;
            myButton_JustFlip.Location = new Point(275, 478);
            myButton_JustFlip.Name = "myButton_JustFlip";
            myButton_JustFlip.Size = new Size(97, 29);
            myButton_JustFlip.TabIndex = 15;
            myButton_JustFlip.Text = "just flip";
            myButton_JustFlip.UseVisualStyleBackColor = false;
            myButton_JustFlip.Click += playButton_Click;
            // 
            // myButton_TailsBet
            // 
            myButton_TailsBet.AutoSize = true;
            myButton_TailsBet.BackColor = Color.AntiqueWhite;
            myButton_TailsBet.FlatStyle = FlatStyle.Popup;
            myButton_TailsBet.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            myButton_TailsBet.ForeColor = Color.Black;
            myButton_TailsBet.Location = new Point(462, 478);
            myButton_TailsBet.Name = "myButton_TailsBet";
            myButton_TailsBet.Size = new Size(97, 29);
            myButton_TailsBet.TabIndex = 16;
            myButton_TailsBet.Text = "tails";
            myButton_TailsBet.UseVisualStyleBackColor = false;
            myButton_TailsBet.Click += playButton_Click;
            // 
            // myButton_Return
            // 
            myButton_Return.AutoSize = true;
            myButton_Return.BackColor = Color.AntiqueWhite;
            myButton_Return.FlatStyle = FlatStyle.Popup;
            myButton_Return.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            myButton_Return.ForeColor = Color.Black;
            myButton_Return.Location = new Point(508, 30);
            myButton_Return.Name = "myButton_Return";
            myButton_Return.Size = new Size(96, 29);
            myButton_Return.TabIndex = 17;
            myButton_Return.Text = "retreat";
            myButton_Return.UseVisualStyleBackColor = false;
            myButton_Return.Click += returnButton_Click;
            // 
            // UCGame_HeadsOrTails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(myButton_Return);
            Controls.Add(myButton_TailsBet);
            Controls.Add(myButton_JustFlip);
            Controls.Add(myButton_HeadsBet);
            Controls.Add(myButton_Randomize);
            Controls.Add(myButton_ResetFairness);
            Controls.Add(Label_CurrentFoodCount);
            Controls.Add(Label_WinSoFar);
            Controls.Add(Label_Result);
            Controls.Add(coinPicture);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UCGame_HeadsOrTails";
            Size = new Size(640, 638);
            ((System.ComponentModel.ISupportInitialize)coinPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private PictureBox coinPicture;
        private Button Button_Randomize;
        private Label Label_Result;
        private Button button_ReturnButton;
        private Label Label_WinSoFar;
        private Label Label_CurrentFoodCount;
        private CustomControls.MyButton myButton_ResetFairness;
        private CustomControls.MyButton myButton_Randomize;
        private CustomControls.MyButton myButton_HeadsBet;
        private CustomControls.MyButton myButton_JustFlip;
        private CustomControls.MyButton myButton_TailsBet;
        private CustomControls.MyButton myButton_Return;
    }
}
