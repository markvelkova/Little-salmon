namespace losos
{
    partial class UCGame_Snake
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
            Panel_Field = new Panel();
            Timer_GameTimer = new System.Windows.Forms.Timer(components);
            Button_ReturnButton = new Button();
            SuspendLayout();
            // 
            // Panel_Field
            // 
            Panel_Field.BackColor = Color.FromArgb(192, 255, 192);
            Panel_Field.Location = new Point(70, 70);
            Panel_Field.Name = "Panel_Field";
            Panel_Field.Size = new Size(500, 500);
            Panel_Field.TabIndex = 0;
            Panel_Field.Paint += Field_Paint;
            // 
            // Timer_GameTimer
            // 
            Timer_GameTimer.Tick += gameTimer_Tick;
            // 
            // Button_ReturnButton
            // 
            Button_ReturnButton.Location = new Point(539, 22);
            Button_ReturnButton.Name = "Button_ReturnButton";
            Button_ReturnButton.Size = new Size(75, 23);
            Button_ReturnButton.TabIndex = 1;
            Button_ReturnButton.Text = "retreat";
            Button_ReturnButton.UseVisualStyleBackColor = true;
            Button_ReturnButton.Click += returnButton_Click;
            // 
            // UCGame_Snake
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Button_ReturnButton);
            Controls.Add(Panel_Field);
            Name = "UCGame_Snake";
            Size = new Size(640, 640);
            KeyDown += Snake_KeyDown;
            PreviewKeyDown += Snake_PreviewKeyDown;
            ResumeLayout(false);
        }

        #endregion

        private Panel Panel_Field;
        private System.Windows.Forms.Timer Timer_GameTimer;
        private Button Button_ReturnButton;
    }
}
