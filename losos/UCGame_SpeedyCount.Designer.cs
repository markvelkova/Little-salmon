namespace losos
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
            Button_Start = new Button();
            Button_Return = new Button();
            TextBox_Answer = new TextBox();
            Panel_Time = new Panel();
            Timer_GameTimer = new System.Windows.Forms.Timer(components);
            Numeric_MaxOpNum = new NumericUpDown();
            CheckListBox_Difficulty = new CheckedListBox();
            Label_MaxOperandsLabel = new Label();
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
            // Button_Start
            // 
            Button_Start.AutoSize = true;
            Button_Start.Location = new Point(282, 526);
            Button_Start.Name = "Button_Start";
            Button_Start.Size = new Size(75, 25);
            Button_Start.TabIndex = 1;
            Button_Start.Text = "START";
            Button_Start.UseVisualStyleBackColor = true;
            Button_Start.Click += Button_Start_Click;
            // 
            // Button_Return
            // 
            Button_Return.Location = new Point(524, 28);
            Button_Return.Name = "Button_Return";
            Button_Return.Size = new Size(75, 23);
            Button_Return.TabIndex = 2;
            Button_Return.Text = "retreat";
            Button_Return.UseVisualStyleBackColor = true;
            Button_Return.Click += returnButton_Click;
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
            // UCGame_SpeedyCount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Label_MaxOperandsLabel);
            Controls.Add(CheckListBox_Difficulty);
            Controls.Add(Numeric_MaxOpNum);
            Controls.Add(Panel_Time);
            Controls.Add(TextBox_Answer);
            Controls.Add(Button_Return);
            Controls.Add(Button_Start);
            Controls.Add(Label_Equation);
            Name = "UCGame_SpeedyCount";
            Size = new Size(640, 640);
            ((System.ComponentModel.ISupportInitialize)Numeric_MaxOpNum).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_Equation;
        private Button Button_Start;
        private Button Button_Return;
        private TextBox TextBox_Answer;
        private Panel Panel_Time;
        private System.Windows.Forms.Timer Timer_GameTimer;
        private NumericUpDown Numeric_MaxOpNum;
        private CheckedListBox CheckListBox_Difficulty;
        private Label Label_MaxOperandsLabel;
    }
}
