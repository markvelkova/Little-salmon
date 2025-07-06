namespace losos
{
    partial class UCHeadsOrTails
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
            Button_HeadsBet = new Button();
            Button_TailsBet = new Button();
            coinPicture = new PictureBox();
            Button_JustFlip = new Button();
            Button_ResetFairness = new Button();
            Button_Randomize = new Button();
            Label_Result = new Label();
            button_ReturnButton = new Button();
            ((System.ComponentModel.ISupportInitialize)coinPicture).BeginInit();
            SuspendLayout();
            // 
            // Button_HeadsBet
            // 
            Button_HeadsBet.Location = new Point(62, 232);
            Button_HeadsBet.Name = "Button_HeadsBet";
            Button_HeadsBet.Size = new Size(75, 23);
            Button_HeadsBet.TabIndex = 2;
            Button_HeadsBet.Text = "Heads";
            Button_HeadsBet.UseVisualStyleBackColor = true;
            Button_HeadsBet.Click += playButton_Click;
            // 
            // Button_TailsBet
            // 
            Button_TailsBet.Location = new Point(276, 232);
            Button_TailsBet.Name = "Button_TailsBet";
            Button_TailsBet.Size = new Size(75, 23);
            Button_TailsBet.TabIndex = 3;
            Button_TailsBet.Text = "Tails";
            Button_TailsBet.UseVisualStyleBackColor = true;
            Button_TailsBet.Click += playButton_Click;
            // 
            // coinPicture
            // 
            coinPicture.Location = new Point(133, 57);
            coinPicture.Name = "coinPicture";
            coinPicture.Size = new Size(150, 150);
            coinPicture.TabIndex = 4;
            coinPicture.TabStop = false;
            // 
            // Button_JustFlip
            // 
            Button_JustFlip.Location = new Point(169, 232);
            Button_JustFlip.Name = "Button_JustFlip";
            Button_JustFlip.Size = new Size(75, 23);
            Button_JustFlip.TabIndex = 5;
            Button_JustFlip.Text = "just flip";
            Button_JustFlip.UseVisualStyleBackColor = true;
            Button_JustFlip.Click += playButton_Click;
            // 
            // Button_ResetFairness
            // 
            Button_ResetFairness.Location = new Point(52, 48);
            Button_ResetFairness.Name = "Button_ResetFairness";
            Button_ResetFairness.Size = new Size(75, 76);
            Button_ResetFairness.TabIndex = 6;
            Button_ResetFairness.Text = "humbly return to the default coin";
            Button_ResetFairness.UseVisualStyleBackColor = true;
            Button_ResetFairness.Click += resetButton_Click;
            // 
            // Button_Randomize
            // 
            Button_Randomize.Location = new Point(289, 48);
            Button_Randomize.Name = "Button_Randomize";
            Button_Randomize.Size = new Size(75, 76);
            Button_Randomize.TabIndex = 7;
            Button_Randomize.Text = "confidently opt for the unfair coin";
            Button_Randomize.UseVisualStyleBackColor = true;
            Button_Randomize.Click += randomizeButton_Click;
            // 
            // Label_Result
            // 
            Label_Result.AutoSize = true;
            Label_Result.Location = new Point(188, 30);
            Label_Result.Name = "Label_Result";
            Label_Result.Size = new Size(36, 15);
            Label_Result.TabIndex = 8;
            Label_Result.Text = "hmm";
            // 
            // button_ReturnButton
            // 
            button_ReturnButton.Location = new Point(353, 3);
            button_ReturnButton.Name = "button_ReturnButton";
            button_ReturnButton.Size = new Size(75, 23);
            button_ReturnButton.TabIndex = 9;
            button_ReturnButton.Text = "retreat";
            button_ReturnButton.UseVisualStyleBackColor = true;
            button_ReturnButton.Click += returnButton_Click;
            // 
            // UCHeadsOrTails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button_ReturnButton);
            Controls.Add(Label_Result);
            Controls.Add(Button_Randomize);
            Controls.Add(Button_ResetFairness);
            Controls.Add(Button_JustFlip);
            Controls.Add(coinPicture);
            Controls.Add(Button_TailsBet);
            Controls.Add(Button_HeadsBet);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UCHeadsOrTails";
            Size = new Size(431, 340);
            ((System.ComponentModel.ISupportInitialize)coinPicture).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button Button_HeadsBet;
        private Button Button_TailsBet;
        private PictureBox coinPicture;
        private Button Button_JustFlip;
        private Button Button_ResetFairness;
        private Button Button_Randomize;
        private Label Label_Result;
        private Button button_ReturnButton;
    }
}
