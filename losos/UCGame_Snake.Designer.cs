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
            Label_Reward = new Label();
            Label_ArrowHint = new Label();
            myButton_Return = new WinFormsControlLibrary1.MyButton();
            myButton_Start = new WinFormsControlLibrary1.MyButton();
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
            // myButton_Return
            // 
            myButton_Return.AutoSize = true;
            myButton_Return.BackColor = Color.AntiqueWhite;
            myButton_Return.FlatStyle = FlatStyle.Popup;
            myButton_Return.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            myButton_Return.ForeColor = Color.Black;
            myButton_Return.Location = new Point(528, 31);
            myButton_Return.Name = "myButton_Return";
            myButton_Return.Size = new Size(93, 29);
            myButton_Return.TabIndex = 5;
            myButton_Return.Text = "retreat";
            myButton_Return.UseVisualStyleBackColor = false;
            myButton_Return.Click += returnButton_Click;
            // 
            // myButton_Start
            // 
            myButton_Start.AutoSize = true;
            myButton_Start.BackColor = Color.AntiqueWhite;
            myButton_Start.FlatStyle = FlatStyle.Popup;
            myButton_Start.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            myButton_Start.ForeColor = Color.Black;
            myButton_Start.Location = new Point(19, 31);
            myButton_Start.Name = "myButton_Start";
            myButton_Start.Size = new Size(96, 29);
            myButton_Start.TabIndex = 6;
            myButton_Start.Text = "START";
            myButton_Start.UseVisualStyleBackColor = false;
            myButton_Start.Click += ButtonStart_Click;
            // 
            // UCGame_Snake
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(myButton_Start);
            Controls.Add(myButton_Return);
            Controls.Add(Label_ArrowHint);
            Controls.Add(Label_Reward);
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
        private Label Label_Reward;
        private Label Label_ArrowHint;
        private WinFormsControlLibrary1.MyButton myButton_Return;
        private WinFormsControlLibrary1.MyButton myButton_Start;
    }
}
