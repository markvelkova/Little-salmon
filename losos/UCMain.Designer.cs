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
            ProgressBar_Energy = new ProgressBar();
            ProgressBar_Hunger = new ProgressBar();
            ProgressBar_Mood = new ProgressBar();
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
            // ProgressBar_Energy
            // 
            ProgressBar_Energy.Location = new Point(14, 49);
            ProgressBar_Energy.Name = "ProgressBar_Energy";
            ProgressBar_Energy.Size = new Size(100, 23);
            ProgressBar_Energy.TabIndex = 2;
            // 
            // ProgressBar_Hunger
            // 
            ProgressBar_Hunger.Location = new Point(14, 19);
            ProgressBar_Hunger.Name = "ProgressBar_Hunger";
            ProgressBar_Hunger.Size = new Size(100, 23);
            ProgressBar_Hunger.TabIndex = 3;
            // 
            // ProgressBar_Mood
            // 
            ProgressBar_Mood.Location = new Point(14, 78);
            ProgressBar_Mood.Name = "ProgressBar_Mood";
            ProgressBar_Mood.Size = new Size(100, 23);
            ProgressBar_Mood.TabIndex = 4;
            // 
            // UCMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ProgressBar_Mood);
            Controls.Add(ProgressBar_Hunger);
            Controls.Add(ProgressBar_Energy);
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
        private ProgressBar ProgressBar_Energy;
        private ProgressBar ProgressBar_Hunger;
        private ProgressBar ProgressBar_Mood;
    }
}
