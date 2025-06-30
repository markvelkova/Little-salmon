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
            StupidButton = new Button();
            SuspendLayout();
            // 
            // StupidButton
            // 
            StupidButton.Location = new Point(58, 85);
            StupidButton.Name = "StupidButton";
            StupidButton.Size = new Size(155, 29);
            StupidButton.TabIndex = 0;
            StupidButton.Text = "stupid button";
            StupidButton.UseVisualStyleBackColor = true;
            StupidButton.Click += button_StupidButton_Click;
            // 
            // UCMain
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(StupidButton);
            Name = "UCMain";
            Size = new Size(512, 460);
            ResumeLayout(false);
        }

        #endregion

        private Button StupidButton;
    }
}
