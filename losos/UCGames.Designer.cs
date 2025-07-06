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
            Button_ReturnButton = new Button();
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
            // Button_ReturnButton
            // 
            Button_ReturnButton.Location = new Point(386, 18);
            Button_ReturnButton.Name = "Button_ReturnButton";
            Button_ReturnButton.Size = new Size(75, 23);
            Button_ReturnButton.TabIndex = 1;
            Button_ReturnButton.Text = "BACK";
            Button_ReturnButton.UseVisualStyleBackColor = true;
            Button_ReturnButton.Click += button_Return_Click;
            // 
            // UCGames
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Button_ReturnButton);
            Controls.Add(Button_SelectFlipCoin);
            Name = "UCGames";
            Size = new Size(492, 365);
            ResumeLayout(false);
        }

        #endregion

        private Button Button_SelectFlipCoin;
        private Button Button_ReturnButton;
    }
}
