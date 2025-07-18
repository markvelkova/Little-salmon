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
            openFileDialog = new OpenFileDialog();
            myButton_StartNewGame = new WinFormsControlLibrary1.MyButton();
            myButton_LoadGame = new WinFormsControlLibrary1.MyButton();
            SuspendLayout();
            // 
            // openFileDialog
            // 
            openFileDialog.FileName = "openFileDialog";
            // 
            // myButton_StartNewGame
            // 
            myButton_StartNewGame.AutoSize = true;
            myButton_StartNewGame.Location = new Point(165, 212);
            myButton_StartNewGame.Name = "myButton_StartNewGame";
            myButton_StartNewGame.Size = new Size(201, 25);
            myButton_StartNewGame.TabIndex = 2;
            myButton_StartNewGame.Text = "start a new game";
            myButton_StartNewGame.UseVisualStyleBackColor = true;
            myButton_StartNewGame.Click += btnStartNewGame_Click;
            // 
            // myButton_LoadGame
            // 
            myButton_LoadGame.AutoSize = true;
            myButton_LoadGame.Location = new Point(165, 296);
            myButton_LoadGame.Name = "myButton_LoadGame";
            myButton_LoadGame.Size = new Size(201, 25);
            myButton_LoadGame.TabIndex = 3;
            myButton_LoadGame.Text = "load an old game";
            myButton_LoadGame.UseVisualStyleBackColor = true;
            myButton_LoadGame.Click += button_LoadGame_Click;
            // 
            // UCIntro
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(myButton_LoadGame);
            Controls.Add(myButton_StartNewGame);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UCIntro";
            Size = new Size(640, 638);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private OpenFileDialog openFileDialog;
        private WinFormsControlLibrary1.MyButton myButton_StartNewGame;
        private WinFormsControlLibrary1.MyButton myButton_LoadGame;
    }
}
