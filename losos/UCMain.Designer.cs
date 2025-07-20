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
            TextBox_Reporter = new TextBox();
            Label_FoodCountLabel = new Label();
            TextBox_NewNameBox = new TextBox();
            Button_ChangeNameSubmit = new Button();
            Label_HungerLabel = new Label();
            Label_EnergyLabel = new Label();
            Label_MoodLabel = new Label();
            PictureBox_PetBox = new PictureBox();
            TextBox_Stats = new TextBox();
            Panel_Energy = new Panel();
            Panel_Mood = new Panel();
            Panel_Hunger = new Panel();
            myButton_ChooseColour = new WinFormsControlLibrary1.MyButton();
            myButton_ShowStats = new WinFormsControlLibrary1.MyButton();
            myButton_SelectGame = new WinFormsControlLibrary1.MyButton();
            myButton_Feed = new WinFormsControlLibrary1.MyButton();
            myButton_Sleep = new WinFormsControlLibrary1.MyButton();
            pictureBox_Dirty = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)PictureBox_PetBox).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Dirty).BeginInit();
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
            // TextBox_Reporter
            // 
            TextBox_Reporter.Font = new Font("Segoe UI", 7.8F, FontStyle.Regular, GraphicsUnit.Point, 238);
            TextBox_Reporter.Location = new Point(66, 409);
            TextBox_Reporter.Multiline = true;
            TextBox_Reporter.Name = "TextBox_Reporter";
            TextBox_Reporter.ReadOnly = true;
            TextBox_Reporter.ScrollBars = ScrollBars.Vertical;
            TextBox_Reporter.Size = new Size(471, 72);
            TextBox_Reporter.TabIndex = 8;
            // 
            // Label_FoodCountLabel
            // 
            Label_FoodCountLabel.AutoSize = true;
            Label_FoodCountLabel.Location = new Point(15, 111);
            Label_FoodCountLabel.Name = "Label_FoodCountLabel";
            Label_FoodCountLabel.Size = new Size(66, 15);
            Label_FoodCountLabel.TabIndex = 9;
            Label_FoodCountLabel.Text = "food count";
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
            // Label_HungerLabel
            // 
            Label_HungerLabel.AutoSize = true;
            Label_HungerLabel.Location = new Point(121, 28);
            Label_HungerLabel.Name = "Label_HungerLabel";
            Label_HungerLabel.Size = new Size(45, 15);
            Label_HungerLabel.TabIndex = 12;
            Label_HungerLabel.Text = "hunger";
            // 
            // Label_EnergyLabel
            // 
            Label_EnergyLabel.AutoSize = true;
            Label_EnergyLabel.Location = new Point(120, 59);
            Label_EnergyLabel.Name = "Label_EnergyLabel";
            Label_EnergyLabel.Size = new Size(43, 15);
            Label_EnergyLabel.TabIndex = 13;
            Label_EnergyLabel.Text = "energy";
            // 
            // Label_MoodLabel
            // 
            Label_MoodLabel.AutoSize = true;
            Label_MoodLabel.Location = new Point(120, 90);
            Label_MoodLabel.Name = "Label_MoodLabel";
            Label_MoodLabel.Size = new Size(39, 15);
            Label_MoodLabel.TabIndex = 14;
            Label_MoodLabel.Text = "mood";
            // 
            // PictureBox_PetBox
            // 
            PictureBox_PetBox.Location = new Point(170, 145);
            PictureBox_PetBox.Name = "PictureBox_PetBox";
            PictureBox_PetBox.Size = new Size(257, 258);
            PictureBox_PetBox.TabIndex = 15;
            PictureBox_PetBox.TabStop = false;
            // 
            // TextBox_Stats
            // 
            TextBox_Stats.Font = new Font("Segoe UI", 7F);
            TextBox_Stats.Location = new Point(347, 59);
            TextBox_Stats.Multiline = true;
            TextBox_Stats.Name = "TextBox_Stats";
            TextBox_Stats.ReadOnly = true;
            TextBox_Stats.ScrollBars = ScrollBars.Vertical;
            TextBox_Stats.Size = new Size(274, 344);
            TextBox_Stats.TabIndex = 16;
            // 
            // Panel_Energy
            // 
            Panel_Energy.BackColor = Color.White;
            Panel_Energy.Location = new Point(15, 49);
            Panel_Energy.Name = "Panel_Energy";
            Panel_Energy.Size = new Size(100, 26);
            Panel_Energy.TabIndex = 19;
            // 
            // Panel_Mood
            // 
            Panel_Mood.BackColor = Color.White;
            Panel_Mood.Location = new Point(15, 82);
            Panel_Mood.Name = "Panel_Mood";
            Panel_Mood.Size = new Size(100, 26);
            Panel_Mood.TabIndex = 20;
            // 
            // Panel_Hunger
            // 
            Panel_Hunger.BackColor = Color.White;
            Panel_Hunger.Location = new Point(15, 17);
            Panel_Hunger.Name = "Panel_Hunger";
            Panel_Hunger.Size = new Size(100, 26);
            Panel_Hunger.TabIndex = 20;
            // 
            // myButton_ChooseColour
            // 
            myButton_ChooseColour.AutoSize = true;
            myButton_ChooseColour.BackColor = Color.AntiqueWhite;
            myButton_ChooseColour.FlatStyle = FlatStyle.Popup;
            myButton_ChooseColour.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            myButton_ChooseColour.ForeColor = Color.Black;
            myButton_ChooseColour.Location = new Point(15, 145);
            myButton_ChooseColour.Name = "myButton_ChooseColour";
            myButton_ChooseColour.Size = new Size(123, 29);
            myButton_ChooseColour.TabIndex = 22;
            myButton_ChooseColour.Text = "change colour";
            myButton_ChooseColour.UseVisualStyleBackColor = true;
            myButton_ChooseColour.Click += Button_ChooseColor_Click;
            // 
            // myButton_ShowStats
            // 
            myButton_ShowStats.AutoSize = true;
            myButton_ShowStats.BackColor = Color.AntiqueWhite;
            myButton_ShowStats.FlatStyle = FlatStyle.Popup;
            myButton_ShowStats.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            myButton_ShowStats.ForeColor = Color.Black;
            myButton_ShowStats.Location = new Point(523, 18);
            myButton_ShowStats.Name = "myButton_ShowStats";
            myButton_ShowStats.Size = new Size(96, 29);
            myButton_ShowStats.TabIndex = 23;
            myButton_ShowStats.Text = "show stats";
            myButton_ShowStats.UseVisualStyleBackColor = true;
            myButton_ShowStats.Click += button_ShowStats_Click;
            // 
            // myButton_SelectGame
            // 
            myButton_SelectGame.AutoSize = true;
            myButton_SelectGame.BackColor = Color.AntiqueWhite;
            myButton_SelectGame.FlatStyle = FlatStyle.Popup;
            myButton_SelectGame.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            myButton_SelectGame.ForeColor = Color.Black;
            myButton_SelectGame.Location = new Point(120, 521);
            myButton_SelectGame.Name = "myButton_SelectGame";
            myButton_SelectGame.Size = new Size(76, 29);
            myButton_SelectGame.TabIndex = 24;
            myButton_SelectGame.Text = "games";
            myButton_SelectGame.UseVisualStyleBackColor = true;
            myButton_SelectGame.Click += button_GamesButton_Click;
            // 
            // myButton_Feed
            // 
            myButton_Feed.AutoSize = true;
            myButton_Feed.BackColor = Color.AntiqueWhite;
            myButton_Feed.FlatStyle = FlatStyle.Popup;
            myButton_Feed.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            myButton_Feed.ForeColor = Color.Black;
            myButton_Feed.Location = new Point(271, 521);
            myButton_Feed.Name = "myButton_Feed";
            myButton_Feed.Size = new Size(76, 29);
            myButton_Feed.TabIndex = 25;
            myButton_Feed.Text = "feed";
            myButton_Feed.UseVisualStyleBackColor = true;
            myButton_Feed.Click += button_Feed_Click;
            // 
            // myButton_Sleep
            // 
            myButton_Sleep.AutoSize = true;
            myButton_Sleep.BackColor = Color.AntiqueWhite;
            myButton_Sleep.FlatStyle = FlatStyle.Popup;
            myButton_Sleep.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            myButton_Sleep.ForeColor = Color.Black;
            myButton_Sleep.Location = new Point(416, 521);
            myButton_Sleep.Name = "myButton_Sleep";
            myButton_Sleep.Size = new Size(76, 29);
            myButton_Sleep.TabIndex = 26;
            myButton_Sleep.Text = "sleep";
            myButton_Sleep.UseVisualStyleBackColor = true;
            myButton_Sleep.Click += button_Sleep_Click;
            // 
            // pictureBox_Dirty
            // 
            pictureBox_Dirty.Location = new Point(291, 344);
            pictureBox_Dirty.Name = "pictureBox_Dirty";
            pictureBox_Dirty.Size = new Size(50, 50);
            pictureBox_Dirty.TabIndex = 27;
            pictureBox_Dirty.TabStop = false;
            pictureBox_Dirty.Click += dirtyComponent_Click;
            // 
            // UCMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(pictureBox_Dirty);
            Controls.Add(myButton_Sleep);
            Controls.Add(myButton_Feed);
            Controls.Add(myButton_SelectGame);
            Controls.Add(myButton_ShowStats);
            Controls.Add(myButton_ChooseColour);
            Controls.Add(Panel_Mood);
            Controls.Add(Panel_Hunger);
            Controls.Add(Panel_Energy);
            Controls.Add(TextBox_Stats);
            Controls.Add(PictureBox_PetBox);
            Controls.Add(Label_MoodLabel);
            Controls.Add(Label_EnergyLabel);
            Controls.Add(Label_HungerLabel);
            Controls.Add(Button_ChangeNameSubmit);
            Controls.Add(TextBox_NewNameBox);
            Controls.Add(Label_FoodCountLabel);
            Controls.Add(TextBox_Reporter);
            Controls.Add(Label_Name);
            Name = "UCMain";
            Size = new Size(640, 640);
            ((System.ComponentModel.ISupportInitialize)PictureBox_PetBox).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox_Dirty).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Label_Name;
        private ProgressBar ProgressBar_Mood;
        private TextBox TextBox_Reporter;
        private Label Label_FoodCountLabel;
        private TextBox TextBox_NewNameBox;
        private Button Button_ChangeNameSubmit;
        private Label Label_HungerLabel;
        private Label Label_EnergyLabel;
        private Label Label_MoodLabel;
        private PictureBox PictureBox_PetBox;
        private TextBox TextBox_Stats;
        private Panel Panel_HungerMeter;
        private Panel panel1;
        private Panel Panel_Energy;
        private Panel Panel_Mood;
        private Panel Panel_Hunger;
        private WinFormsControlLibrary1.MyButton myButton_ChooseColour;
        private WinFormsControlLibrary1.MyButton myButton_ShowStats;
        private WinFormsControlLibrary1.MyButton myButton_SelectGame;
        private WinFormsControlLibrary1.MyButton myButton_Feed;
        private WinFormsControlLibrary1.MyButton myButton_Sleep;
        private PictureBox pictureBox_Dirty;
    }
}
