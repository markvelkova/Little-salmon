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
            Button_LoadGame = new Button();
            openFileDialog = new OpenFileDialog();
            SuspendLayout();
            // 
            // button_StartNewGame
            // 
            button_StartNewGame.Location = new Point(224, 310);
            button_StartNewGame.Margin = new Padding(3, 2, 3, 2);
            button_StartNewGame.Name = "button_StartNewGame";
            button_StartNewGame.Size = new Size(201, 22);
            button_StartNewGame.TabIndex = 0;
            button_StartNewGame.Text = "start a new game";
            button_StartNewGame.UseVisualStyleBackColor = true;
            button_StartNewGame.Click += btnStartNewGame_Click;
            // 
            // Button_LoadGame
            // 
            Button_LoadGame.Location = new Point(224, 337);
            Button_LoadGame.Name = "Button_LoadGame";
            Button_LoadGame.Size = new Size(201, 23);
            Button_LoadGame.TabIndex = 1;
            Button_LoadGame.Text = "load an old game";
            Button_LoadGame.UseVisualStyleBackColor = true;
            Button_LoadGame.Click += button_LoadGame_Click;
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // UCIntro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Button_LoadGame);
            Controls.Add(button_StartNewGame);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UCIntro";
            Size = new Size(648, 393);
            ResumeLayout(false);
        }

        #endregion

        private Button button_StartNewGame;
        private Button Button_LoadGame;
        private OpenFileDialog openFileDialog;
    }
}
