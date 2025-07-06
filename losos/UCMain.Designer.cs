namespace losos
{
    partial class UCMain
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
            label1 = new Label();
            Button_SelectGame = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(203, 49);
            label1.Name = "label1";
            label1.Size = new Size(106, 15);
            label1.TabIndex = 0;
            label1.Text = "placeholder mainu";
            // 
            // Button_SelectGame
            // 
            Button_SelectGame.Location = new Point(217, 272);
            Button_SelectGame.Name = "Button_SelectGame";
            Button_SelectGame.Size = new Size(75, 23);
            Button_SelectGame.TabIndex = 1;
            Button_SelectGame.Text = "games";
            Button_SelectGame.UseVisualStyleBackColor = true;
            Button_SelectGame.Click += button_GamesButton_Click;
            // 
            // UCMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Button_SelectGame);
            Controls.Add(label1);
            Name = "UCMain";
            Size = new Size(533, 402);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Button Button_SelectGame;
    }
}
