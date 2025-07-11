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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UCMain));
            Label_Name = new Label();
            Button_SelectGame = new Button();
            ProgressBar_Energy = new ProgressBar();
            ProgressBar_Hunger = new ProgressBar();
            ProgressBar_Mood = new ProgressBar();
            Button_Feed = new Button();
            Button_Sleep = new Button();
            TextBox_Reporter = new TextBox();
            Label_FoodCountLabel = new Label();
            TextBox_NewNameBox = new TextBox();
            Button_ChangeNameSubmit = new Button();
            Label_HungerLabel = new Label();
            Label_EnergyLabel = new Label();
            Label_MoodLabel = new Label();
            PictureBox_PetBox = new PictureBox();
            TextBox_Stats = new TextBox();
            Button_Stats = new Button();
            ((System.ComponentModel.ISupportInitialize)PictureBox_PetBox).BeginInit();
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
            Button_SelectGame.Location = new Point(120, 523);
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
            Button_Feed.Location = new Point(262, 523);
            Button_Feed.Name = "Button_Feed";
            Button_Feed.Size = new Size(75, 23);
            Button_Feed.TabIndex = 5;
            Button_Feed.Text = "feed";
            Button_Feed.UseVisualStyleBackColor = true;
            Button_Feed.Click += button_Feed_Click;
            // 
            // Button_Sleep
            // 
            Button_Sleep.Location = new Point(396, 523);
            Button_Sleep.Name = "Button_Sleep";
            Button_Sleep.Size = new Size(75, 23);
            Button_Sleep.TabIndex = 6;
            Button_Sleep.Text = "sleep";
            Button_Sleep.UseVisualStyleBackColor = true;
            Button_Sleep.Click += button_Sleep_Click;
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
            Label_HungerLabel.Location = new Point(120, 20);
            Label_HungerLabel.Name = "Label_HungerLabel";
            Label_HungerLabel.Size = new Size(45, 15);
            Label_HungerLabel.TabIndex = 12;
            Label_HungerLabel.Text = "hunger";
            // 
            // Label_EnergyLabel
            // 
            Label_EnergyLabel.AutoSize = true;
            Label_EnergyLabel.Location = new Point(120, 49);
            Label_EnergyLabel.Name = "Label_EnergyLabel";
            Label_EnergyLabel.Size = new Size(43, 15);
            Label_EnergyLabel.TabIndex = 13;
            Label_EnergyLabel.Text = "energy";
            // 
            // Label_MoodLabel
            // 
            Label_MoodLabel.AutoSize = true;
            Label_MoodLabel.Location = new Point(120, 78);
            Label_MoodLabel.Name = "Label_MoodLabel";
            Label_MoodLabel.Size = new Size(39, 15);
            Label_MoodLabel.TabIndex = 14;
            Label_MoodLabel.Text = "mood";
            // 
            // PictureBox_PetBox
            // 
            PictureBox_PetBox.Image = (Image)resources.GetObject("PictureBox_PetBox.Image");
            PictureBox_PetBox.Location = new Point(170, 145);
            PictureBox_PetBox.Name = "PictureBox_PetBox";
            PictureBox_PetBox.Size = new Size(257, 258);
            PictureBox_PetBox.TabIndex = 15;
            PictureBox_PetBox.TabStop = false;
            // 
            // TextBox_Stats
            // 
            TextBox_Stats.Font = new Font("Segoe UI", 7F);
            TextBox_Stats.Location = new Point(458, 59);
            TextBox_Stats.MaximumSize = new Size(163, 344);
            TextBox_Stats.Multiline = true;
            TextBox_Stats.Name = "TextBox_Stats";
            TextBox_Stats.ReadOnly = true;
            TextBox_Stats.ScrollBars = ScrollBars.Vertical;
            TextBox_Stats.Size = new Size(163, 344);
            TextBox_Stats.TabIndex = 16;
            // 
            // Button_Stats
            // 
            Button_Stats.Location = new Point(498, 30);
            Button_Stats.Name = "Button_Stats";
            Button_Stats.Size = new Size(75, 23);
            Button_Stats.TabIndex = 17;
            Button_Stats.Text = "show stats";
            Button_Stats.UseVisualStyleBackColor = true;
            Button_Stats.Click += button_ShowStats_Click;
            // 
            // UCMain
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(Button_Stats);
            Controls.Add(TextBox_Stats);
            Controls.Add(PictureBox_PetBox);
            Controls.Add(Label_MoodLabel);
            Controls.Add(Label_EnergyLabel);
            Controls.Add(Label_HungerLabel);
            Controls.Add(Button_ChangeNameSubmit);
            Controls.Add(TextBox_NewNameBox);
            Controls.Add(Label_FoodCountLabel);
            Controls.Add(TextBox_Reporter);
            Controls.Add(Button_Sleep);
            Controls.Add(Button_Feed);
            Controls.Add(ProgressBar_Mood);
            Controls.Add(ProgressBar_Hunger);
            Controls.Add(ProgressBar_Energy);
            Controls.Add(Button_SelectGame);
            Controls.Add(Label_Name);
            Name = "UCMain";
            Size = new Size(640, 640);
            ((System.ComponentModel.ISupportInitialize)PictureBox_PetBox).EndInit();
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
        private Button Button_Sleep;
        private TextBox TextBox_Reporter;
        private Label Label_FoodCountLabel;
        private TextBox TextBox_NewNameBox;
        private Button Button_ChangeNameSubmit;
        private Label Label_HungerLabel;
        private Label Label_EnergyLabel;
        private Label Label_MoodLabel;
        private PictureBox PictureBox_PetBox;
        private TextBox TextBox_Stats;
        private Button Button_Stats;
    }
}
