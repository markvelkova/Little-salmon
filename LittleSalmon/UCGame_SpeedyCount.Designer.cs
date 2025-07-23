namespace LittleSalmon
{
    partial class UCGame_SpeedyCount
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
            Label_Equation = new Label();
            TextBox_Answer = new TextBox();
            Panel_Time = new Panel();
            Timer_GameTimer = new System.Windows.Forms.Timer(components);
            Numeric_MaxOpNum = new NumericUpDown();
            CheckListBox_Difficulty = new CheckedListBox();
            Label_MaxOperandsLabel = new Label();
            Label_CurrentRewardDisplay = new Label();
            Label_CurrentRewardLabel = new Label();
            myButton_Return = new CustomControls.MyButton();
            myButton_Start = new CustomControls.MyButton();
            ((System.ComponentModel.ISupportInitialize)Numeric_MaxOpNum).BeginInit();
            SuspendLayout();
            // 
            // Label_Equation
            // 
            Label_Equation.AutoSize = true;
            Label_Equation.Font = new Font("Segoe UI", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Label_Equation.Location = new Point(273, 189);
            Label_Equation.Name = "Label_Equation";
            Label_Equation.Size = new Size(63, 30);
            Label_Equation.TabIndex = 0;
            Label_Equation.Text = "?????";
            Label_Equation.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // TextBox_Answer
            // 
            TextBox_Answer.Font = new Font("Segoe UI", 18F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TextBox_Answer.Location = new Point(273, 481);
            TextBox_Answer.Name = "TextBox_Answer";
            TextBox_Answer.Size = new Size(100, 39);
            TextBox_Answer.TabIndex = 3;
            TextBox_Answer.KeyDown += textBox_Answer_KeyDown;
            // 
            // Panel_Time
            // 
            Panel_Time.Location = new Point(20, 161);
            Panel_Time.Name = "Panel_Time";
            Panel_Time.Size = new Size(600, 25);
            Panel_Time.TabIndex = 4;
            // 
            // Timer_GameTimer
            // 
            Timer_GameTimer.Tick += Timer_GameTimer_Tick;
            // 
            // Numeric_MaxOpNum
            // 
            Numeric_MaxOpNum.Location = new Point(172, 46);
            Numeric_MaxOpNum.Maximum = new decimal(new int[] { 10, 0, 0, 0 });
            Numeric_MaxOpNum.Minimum = new decimal(new int[] { 2, 0, 0, 0 });
            Numeric_MaxOpNum.Name = "Numeric_MaxOpNum";
            Numeric_MaxOpNum.Size = new Size(120, 23);
            Numeric_MaxOpNum.TabIndex = 5;
            Numeric_MaxOpNum.Value = new decimal(new int[] { 2, 0, 0, 0 });
            // 
            // CheckListBox_Difficulty
            // 
            CheckListBox_Difficulty.FormattingEnabled = true;
            CheckListBox_Difficulty.Items.AddRange(new object[] { "easy", "medium", "hard", "insane" });
            CheckListBox_Difficulty.Location = new Point(20, 28);
            CheckListBox_Difficulty.Name = "CheckListBox_Difficulty";
            CheckListBox_Difficulty.Size = new Size(121, 112);
            CheckListBox_Difficulty.TabIndex = 6;
            CheckListBox_Difficulty.ItemCheck += checkedListBox_OnlyOneItemCheck;
            // 
            // Label_MaxOperandsLabel
            // 
            Label_MaxOperandsLabel.AutoSize = true;
            Label_MaxOperandsLabel.Location = new Point(172, 28);
            Label_MaxOperandsLabel.Name = "Label_MaxOperandsLabel";
            Label_MaxOperandsLabel.Size = new Size(164, 15);
            Label_MaxOperandsLabel.TabIndex = 7;
            Label_MaxOperandsLabel.Text = "maximal number of operands";
            // 
            // Label_CurrentRewardDisplay
            // 
            Label_CurrentRewardDisplay.AutoSize = true;
            Label_CurrentRewardDisplay.Font = new Font("Segoe UI", 22.2F, FontStyle.Regular, GraphicsUnit.Point, 238);
            Label_CurrentRewardDisplay.Location = new Point(473, 477);
            Label_CurrentRewardDisplay.Name = "Label_CurrentRewardDisplay";
            Label_CurrentRewardDisplay.Size = new Size(34, 41);
            Label_CurrentRewardDisplay.TabIndex = 8;
            Label_CurrentRewardDisplay.Text = "0";
            // 
            // Label_CurrentRewardLabel
            // 
            Label_CurrentRewardLabel.AutoSize = true;
            Label_CurrentRewardLabel.Location = new Point(473, 453);
            Label_CurrentRewardLabel.Name = "Label_CurrentRewardLabel";
            Label_CurrentRewardLabel.Size = new Size(84, 15);
            Label_CurrentRewardLabel.TabIndex = 11;
            Label_CurrentRewardLabel.Text = "current reward";
            // 
            // myButton_Return
            // 
            myButton_Return.AutoSize = true;
            myButton_Return.BackColor = Color.AntiqueWhite;
            myButton_Return.FlatStyle = FlatStyle.Popup;
            myButton_Return.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            myButton_Return.ForeColor = Color.Black;
            myButton_Return.Location = new Point(527, 28);
            myButton_Return.Name = "myButton_Return";
            myButton_Return.Size = new Size(93, 29);
            myButton_Return.TabIndex = 12;
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
            myButton_Start.Location = new Point(273, 536);
            myButton_Start.Name = "myButton_Start";
            myButton_Start.Size = new Size(96, 29);
            myButton_Start.TabIndex = 13;
            myButton_Start.Text = "START";
            myButton_Start.UseVisualStyleBackColor = false;
            myButton_Start.Click += Button_Start_Click;
            // 
            // UCGame_SpeedyCount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(myButton_Start);
            Controls.Add(myButton_Return);
            Controls.Add(Label_CurrentRewardLabel);
            Controls.Add(Label_CurrentRewardDisplay);
            Controls.Add(Label_MaxOperandsLabel);
            Controls.Add(CheckListBox_Difficulty);
            Controls.Add(Numeric_MaxOpNum);
            Controls.Add(Panel_Time);
            Controls.Add(TextBox_Answer);
            Controls.Add(Label_Equation);
            Name = "UCGame_SpeedyCount";
            Size = new Size(640, 640);
            ((System.ComponentModel.ISupportInitialize)Numeric_MaxOpNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_Equation;
        private TextBox TextBox_Answer;
        private Panel Panel_Time;
        private System.Windows.Forms.Timer Timer_GameTimer;
        private NumericUpDown Numeric_MaxOpNum;
        private CheckedListBox CheckListBox_Difficulty;
        private Label Label_MaxOperandsLabel;
        private Label Label_CurrentRewardDisplay;
        private Label Label_CurrentRewardLabel;
        private CustomControls.MyButton myButton_Return;
        private CustomControls.MyButton myButton_Start;
    }
}
