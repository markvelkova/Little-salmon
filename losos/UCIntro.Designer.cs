namespace losos
{
    partial class UCIntro
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
            button_StartNewGame = new Button();
            SuspendLayout();
            // 
            // button_StartNewGame
            // 
            button_StartNewGame.Location = new Point(256, 414);
            button_StartNewGame.Name = "button_StartNewGame";
            button_StartNewGame.Size = new Size(230, 29);
            button_StartNewGame.TabIndex = 0;
            button_StartNewGame.Text = "začít novou hru";
            button_StartNewGame.UseVisualStyleBackColor = true;
            button_StartNewGame.Click += this.btnStartNewGame_Click;
            // 
            // UCIntro
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button_StartNewGame);
            Name = "UCIntro";
            Size = new Size(740, 524);
            ResumeLayout(false);
        }

        #endregion

        private Button button_StartNewGame;
    }
}
