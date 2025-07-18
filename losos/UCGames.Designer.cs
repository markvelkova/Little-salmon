namespace losos
{
    partial class UCGames
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
            Button_SelectFlipCoin = new Button();
            Button_SelectStarrySky = new Button();
            Button_SelectSpeedyCount = new Button();
            Button_SelectSnake = new Button();
            myButton_Return = new WinFormsControlLibrary1.MyButton();
            SuspendLayout();
            // 
            // Button_SelectFlipCoin
            // 
            Button_SelectFlipCoin.Location = new Point(63, 59);
            Button_SelectFlipCoin.Name = "Button_SelectFlipCoin";
            Button_SelectFlipCoin.Size = new Size(114, 23);
            Button_SelectFlipCoin.TabIndex = 0;
            Button_SelectFlipCoin.Text = "FLIP A COIN";
            Button_SelectFlipCoin.UseVisualStyleBackColor = true;
            Button_SelectFlipCoin.Click += button_FlipACoin_Click;
            // 
            // Button_SelectStarrySky
            // 
            Button_SelectStarrySky.Location = new Point(63, 88);
            Button_SelectStarrySky.Name = "Button_SelectStarrySky";
            Button_SelectStarrySky.Size = new Size(114, 23);
            Button_SelectStarrySky.TabIndex = 2;
            Button_SelectStarrySky.Text = "STARRY SKY";
            Button_SelectStarrySky.UseVisualStyleBackColor = true;
            Button_SelectStarrySky.Click += button_StarrySky_Click;
            // 
            // Button_SelectSpeedyCount
            // 
            Button_SelectSpeedyCount.Location = new Point(63, 117);
            Button_SelectSpeedyCount.Name = "Button_SelectSpeedyCount";
            Button_SelectSpeedyCount.Size = new Size(114, 23);
            Button_SelectSpeedyCount.TabIndex = 3;
            Button_SelectSpeedyCount.Text = "SPEEDY COUNT";
            Button_SelectSpeedyCount.UseVisualStyleBackColor = true;
            Button_SelectSpeedyCount.Click += button_SpeedyCount_Click;
            // 
            // Button_SelectSnake
            // 
            Button_SelectSnake.Location = new Point(63, 146);
            Button_SelectSnake.Name = "Button_SelectSnake";
            Button_SelectSnake.Size = new Size(114, 23);
            Button_SelectSnake.TabIndex = 4;
            Button_SelectSnake.Text = "SNAKE";
            Button_SelectSnake.UseVisualStyleBackColor = true;
            Button_SelectSnake.Click += button_Snake_Click;
            // 
            // myButton_Return
            // 
            myButton_Return.AutoSize = true;
            myButton_Return.Location = new Point(393, 17);
            myButton_Return.Name = "myButton_Return";
            myButton_Return.Size = new Size(76, 25);
            myButton_Return.TabIndex = 5;
            myButton_Return.Text = "BACK";
            myButton_Return.UseVisualStyleBackColor = true;
            myButton_Return.Click += button_Return_Click;
            // 
            // UCGames
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(myButton_Return);
            Controls.Add(Button_SelectSnake);
            Controls.Add(Button_SelectSpeedyCount);
            Controls.Add(Button_SelectStarrySky);
            Controls.Add(Button_SelectFlipCoin);
            Name = "UCGames";
            Size = new Size(492, 365);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Button_SelectFlipCoin;
        private Button Button_SelectStarrySky;
        private Button Button_SelectSpeedyCount;
        private Button Button_SelectSnake;
        private WinFormsControlLibrary1.MyButton myButton_Return;
    }
}
