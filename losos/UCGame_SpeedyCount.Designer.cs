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
            Label_Equation = new Label();
            Button_Start = new Button();
            Button_Return = new Button();
            TextBox_Answer = new TextBox();
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
            // UCGame_SpeedyCount
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(TextBox_Answer);
            Controls.Add(Button_Return);
            Controls.Add(Button_Start);
            Controls.Add(Label_Equation);
            Name = "UCGame_SpeedyCount";
            Size = new Size(640, 640);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_Equation;
        private Button Button_Start;
        private Button Button_Return;
        private TextBox TextBox_Answer;
    }
}
