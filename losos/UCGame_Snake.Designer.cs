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
            Button_Start = new Button();
            Label_Reward = new Label();
            Label_ArrowHint = new Label();
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
            // Button_Start
            // 
            Button_Start.Location = new Point(37, 27);
            Button_Start.Name = "Button_Start";
            Button_Start.Size = new Size(75, 23);
            Button_Start.TabIndex = 2;
            Button_Start.Text = "START";
            Button_Start.UseVisualStyleBackColor = true;
            Button_Start.Click += ButtonStart_Click;
            // 
            // Label_Reward
            // 
            Label_Reward.AutoSize = true;
            Label_Reward.Location = new Point(226, 31);
            Label_Reward.Name = "Label_Reward";
            Label_Reward.Size = new Size(43, 15);
            Label_Reward.TabIndex = 3;
            Label_Reward.Text = "reward";
            // 
            // Label_ArrowHint
            // 
            Label_ArrowHint.AutoSize = true;
            Label_ArrowHint.Location = new Point(168, 614);
            Label_ArrowHint.Name = "Label_ArrowHint";
            Label_ArrowHint.Size = new Size(168, 15);
            Label_ArrowHint.TabIndex = 4;
            Label_ArrowHint.Text = "Use your arrows, not your bow";
            // 
            // UCGame_Snake
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Label_ArrowHint);
            Controls.Add(Label_Reward);
            Controls.Add(Button_Start);
            Controls.Add(Button_ReturnButton);
            Controls.Add(Panel_Field);
            Name = "UCGame_Snake";
            Size = new Size(640, 640);
            KeyDown += Snake_KeyDown;
            PreviewKeyDown += Snake_PreviewKeyDown;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel Panel_Field;
        private System.Windows.Forms.Timer Timer_GameTimer;
        private Button Button_ReturnButton;
        private Button Button_Start;
        private Label Label_Reward;
        private Label Label_ArrowHint;
    }
}
