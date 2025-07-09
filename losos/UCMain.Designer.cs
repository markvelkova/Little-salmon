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
            Label_Name = new Label();
            Button_SelectGame = new Button();
            ProgressBar_Energy = new ProgressBar();
            ProgressBar_Hunger = new ProgressBar();
            ProgressBar_Mood = new ProgressBar();
            Button_Feed = new Button();
            button2 = new Button();
            button3 = new Button();
            TextBox_Reporter = new TextBox();
            Label_FoodCountLabel = new Label();
            TextBox_NewNameBox = new TextBox();
            Button_ChangeNameSubmit = new Button();
            SuspendLayout();
            // 
            // Label_Name
            // 
            Label_Name.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            Label_Name.AutoSize = true;
            Label_Name.Location = new Point(287, 19);
            Label_Name.Name = "Label_Name";
            Label_Name.Size = new Size(41, 15);
            Label_Name.TabIndex = 0;
            Label_Name.Text = "NAME";
            Label_Name.Click += Label_Name_Click;
            Label_Name.MouseHover += LabelName_MouseHover;
            // 
            // Button_SelectGame
            // 
            Button_SelectGame.Location = new Point(93, 408);
            Button_SelectGame.Name = "Button_SelectGame";
            Button_SelectGame.Size = new Size(75, 23);
            Button_SelectGame.TabIndex = 1;
            Button_SelectGame.Text = "games";
            Button_SelectGame.UseVisualStyleBackColor = true;
            Button_SelectGame.Click += button_GamesButton_Click;
            // 
            // ProgressBar_Energy
            // 
            ProgressBar_Energy.Location = new Point(14, 49);
            ProgressBar_Energy.Name = "ProgressBar_Energy";
            ProgressBar_Energy.Size = new Size(100, 23);
            ProgressBar_Energy.TabIndex = 2;
            // 
            // ProgressBar_Hunger
            // 
            ProgressBar_Hunger.Location = new Point(14, 19);
            ProgressBar_Hunger.Name = "ProgressBar_Hunger";
            ProgressBar_Hunger.Size = new Size(100, 23);
            ProgressBar_Hunger.TabIndex = 3;
            // 
            // ProgressBar_Mood
            // 
            ProgressBar_Mood.Location = new Point(14, 78);
            ProgressBar_Mood.Name = "ProgressBar_Mood";
            ProgressBar_Mood.Size = new Size(100, 23);
            ProgressBar_Mood.TabIndex = 4;
            // 
            // Button_Feed
            // 
            Button_Feed.Location = new Point(213, 408);
            Button_Feed.Name = "Button_Feed";
            Button_Feed.Size = new Size(75, 23);
            Button_Feed.TabIndex = 5;
            Button_Feed.Text = "feed";
            Button_Feed.UseVisualStyleBackColor = true;
            Button_Feed.Click += button_Feed_Click;
            // 
            // button2
            // 
            button2.Location = new Point(342, 408);
            button2.Name = "button2";
            button2.Size = new Size(75, 23);
            button2.TabIndex = 6;
            button2.Text = "button2";
            button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Location = new Point(468, 408);
            button3.Name = "button3";
            button3.Size = new Size(75, 23);
            button3.TabIndex = 7;
            button3.Text = "button3";
            button3.UseVisualStyleBackColor = true;
            // 
            // TextBox_Reporter
            // 
            TextBox_Reporter.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TextBox_Reporter.Location = new Point(468, 19);
            TextBox_Reporter.Multiline = true;
            TextBox_Reporter.Name = "TextBox_Reporter";
            TextBox_Reporter.ReadOnly = true;
            TextBox_Reporter.ScrollBars = ScrollBars.Vertical;
            TextBox_Reporter.Size = new Size(137, 143);
            TextBox_Reporter.TabIndex = 8;
            // 
            // Label_FoodCountLabel
            // 
            Label_FoodCountLabel.AutoSize = true;
            Label_FoodCountLabel.Location = new Point(15, 111);
            Label_FoodCountLabel.Name = "Label_FoodCountLabel";
            Label_FoodCountLabel.Size = new Size(38, 15);
            Label_FoodCountLabel.TabIndex = 9;
            Label_FoodCountLabel.Text = "label1";
            // 
            // TextBox_NewNameBox
            // 
            TextBox_NewNameBox.BackColor = SystemColors.ActiveCaption;
            TextBox_NewNameBox.Location = new Point(186, 37);
            TextBox_NewNameBox.Name = "TextBox_NewNameBox";
            TextBox_NewNameBox.Size = new Size(192, 23);
            TextBox_NewNameBox.TabIndex = 10;
            // 
            // Button_ChangeNameSubmit
            // 
            Button_ChangeNameSubmit.AutoSize = true;
            Button_ChangeNameSubmit.BackColor = SystemColors.ActiveCaption;
            Button_ChangeNameSubmit.Location = new Point(384, 37);
            Button_ChangeNameSubmit.Name = "Button_ChangeNameSubmit";
            Button_ChangeNameSubmit.Size = new Size(33, 25);
            Button_ChangeNameSubmit.TabIndex = 11;
            Button_ChangeNameSubmit.Text = "ok";
            Button_ChangeNameSubmit.UseVisualStyleBackColor = false;
            Button_ChangeNameSubmit.Click += Button_ChangeNameSubmit_Click;
            // 
            // UCMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Button_ChangeNameSubmit);
            Controls.Add(TextBox_NewNameBox);
            Controls.Add(Label_FoodCountLabel);
            Controls.Add(TextBox_Reporter);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(Button_Feed);
            Controls.Add(ProgressBar_Mood);
            Controls.Add(ProgressBar_Hunger);
            Controls.Add(ProgressBar_Energy);
            Controls.Add(Button_SelectGame);
            Controls.Add(Label_Name);
            Name = "UCMain";
            Size = new Size(640, 640);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_Name;
        private Button Button_SelectGame;
        private ProgressBar ProgressBar_Energy;
        private ProgressBar ProgressBar_Hunger;
        private ProgressBar ProgressBar_Mood;
        private Button Button_Feed;
        private Button button2;
        private Button button3;
        private TextBox TextBox_Reporter;
        private Label Label_FoodCountLabel;
        private TextBox TextBox_NewNameBox;
        private Button Button_ChangeNameSubmit;
    }
}
