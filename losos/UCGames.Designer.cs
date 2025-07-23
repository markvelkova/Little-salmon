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
            myButton_Return = new CustomControls.MyButton();
            SuspendLayout();
            // 
            // myButton_Return
            // 
            myButton_Return.AutoSize = true;
            myButton_Return.BackColor = Color.AntiqueWhite;
            myButton_Return.FlatStyle = FlatStyle.Popup;
            myButton_Return.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            myButton_Return.ForeColor = Color.Black;
            myButton_Return.Location = new Point(505, 41);
            myButton_Return.Name = "myButton_Return";
            myButton_Return.Size = new Size(76, 29);
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
            Name = "UCGames";
            Size = new Size(640, 640);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private CustomControls.MyButton myButton_Return;
    }
}
