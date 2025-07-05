namespace losos
{
    partial class UCHeadsOrTails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCHeadsOrTails));
            Button_HeadsBet = new Button();
            Button_TailsBet = new Button();
            coinPicture = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)coinPicture).BeginInit();
            SuspendLayout();
            // 
            // Button_HeadsBet
            // 
            Button_HeadsBet.Location = new Point(62, 232);
            Button_HeadsBet.Name = "Button_HeadsBet";
            Button_HeadsBet.Size = new Size(75, 23);
            Button_HeadsBet.TabIndex = 2;
            Button_HeadsBet.Text = "Heads";
            Button_HeadsBet.UseVisualStyleBackColor = true;
            Button_HeadsBet.Click += button_HeadsBet_Click;
            // 
            // Button_TailsBet
            // 
            Button_TailsBet.Location = new Point(276, 232);
            Button_TailsBet.Name = "Button_TailsBet";
            Button_TailsBet.Size = new Size(75, 23);
            Button_TailsBet.TabIndex = 3;
            Button_TailsBet.Text = "Tails";
            Button_TailsBet.UseVisualStyleBackColor = true;
            Button_TailsBet.Click += button_TailsBet_Click;
            // 
            // coinPicture
            // 
            coinPicture.Image = (Image)resources.GetObject("coinPicture.Image");
            coinPicture.Location = new Point(133, 57);
            coinPicture.Name = "coinPicture";
            coinPicture.Size = new Size(150, 150);
            coinPicture.TabIndex = 4;
            coinPicture.TabStop = false;
            // 
            // UCHeadsOrTails
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(coinPicture);
            Controls.Add(Button_TailsBet);
            Controls.Add(Button_HeadsBet);
            Margin = new Padding(3, 2, 3, 2);
            Name = "UCHeadsOrTails";
            Size = new Size(431, 340);
            ((System.ComponentModel.ISupportInitialize)coinPicture).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button Button_HeadsBet;
        private Button Button_TailsBet;
        private PictureBox coinPicture;
    }
}
