using Games;
using System.Windows.Forms;
using Pet;
using Stats;

namespace LittleSalmon
{
    public partial class MainForm : Form
    {
        // thePet is STATIC therefore only one at time
        // can be reached from anywhere as MainForm.Pet
        // same for the Stats
        public static Pet.Pet thePet = new();
        public static Stats.Stats theStats = new();
        System.Windows.Forms.Timer petLifeTimer = new System.Windows.Forms.Timer
        {
            Interval = 1000 // 1 second interval
        };

        // MainScreen is the main screen of the application with Pet display
        private UCMain MainScreen = new UCMain();

        public MainForm()
        {
            InitializeComponent();
            petLifeTimer.Tick += petLifeTimer_Tick;
            MainScreen.GamesButtonClicked += (s, e) => ShowGames();
            MainScreen.StartOver += (s, e) => ShowIntro();
            ShowIntro();
        }


        /// <summary>
        /// basic colour, kinda blue, for background, can be changed globally by user from UCMain
        /// </summary>
        public static Color MyDefaultBackColor { get; set; } = Color.FromArgb(0, 162, 232);


        #region time flow
        /// <summary>
        /// Event that is raised when the Pet dies.
        /// </summary>
        public static event EventHandler? PetDead;
        private void HandlePetDeath()
        {
            petLifeTimer.Stop();
            PetDead?.Invoke(this, EventArgs.Empty);
        }

        /// <summary>
        /// event that is raised every second to update the Pet's life state.
        /// UCMain uses this event to update the Pet's display and Stats.
        /// </summary>
        public static event EventHandler? PetLifeTick;
        private void petLifeTimer_Tick(object? sender, EventArgs e)
        {
            if (thePet.LifeState != Pet.Pet.LifeStates.Dead)
                thePet.Update();
            if (thePet.LifeState == Pet.Pet.LifeStates.Dead)
            {
                HandlePetDeath();
            }
            PetLifeTick?.Invoke(this, EventArgs.Empty); // raise the event (contains things from UCMain)
        }
        #endregion

        /// <summary>
        /// from the "Intro" screen the player can choose to start a new game or load an existing game
        /// existing game must be a valid json of the right format (intended to be obtained from the very game)
        /// </summary>
        private void ShowIntro()
        {
            petLifeTimer.Stop(); // start the Pet life timer
            var intro = new UCIntro();
            intro.StartNewGameClicked += (s, e) => ShowMain();
            intro.LoadGameClicked += (s, e) => ShowMain();
            SwitchScreen(intro);
        }

        /// <summary>
        /// from the "Main" screen the player can choose from following:
        /// Games
        /// feed
        /// sleep
        /// wash
        /// </summary>
        private void ShowMain()
        {
            petLifeTimer.Start(); // start the Pet life timer
            SwitchScreen(MainScreen);
        }

        /// <summary>
        /// from "Games" screen the player can choose a game to play or return to the main screen
        /// </summary>
        private void ShowGames()
        {
            var games = new UCGames();
            thePet.PlayingGames = false; // the player does not play Games any more
            games.ReturnSelected += (s, e) => ShowMain();
            games.FlipACoinSelected += (s,e) => GameScreenShow(new UCGame_HeadsOrTails());
            games.StarrySkySelected += (s, e) => GameScreenShow(new UCGame_StarrySky());
            games.SpeedyCountSelected += (s, e) => GameScreenShow(new UCGame_SpeedyCount());
            games.SnakeSelected += (s, e) => GameScreenShow(new UCGame_Snake());
            SwitchScreen(games);
        }

        #region individual games Show...

        private void GameScreenShow(GamesUserControlParent gameScreen)
        {
            thePet.PlayingGames = true; // set the Pet to playing Games state
            gameScreen.ReturnSelected += (s, e) => ShowGames();
            SwitchScreen(gameScreen);
        }
        #endregion

        /// <summary>
        /// this method sets arrows as input keys, which uses the snake game
        /// </summary>
        /// <param name="e"></param>
        protected override void OnPreviewKeyDown(PreviewKeyDownEventArgs e)
        {
            base.OnPreviewKeyDown(e);

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.Down ||
                e.KeyCode == Keys.Left || e.KeyCode == Keys.Right)
            {
                e.IsInputKey = true;
            }
        }

        /// <summary>
        /// hides current controls and shows the new control. if the new control isn't loaded yet, it loads it.
        /// </summary>
        /// <param name="newControl"></param>
        private void SwitchScreen(UserControl newControl)
        {
            foreach (Control ctrl in this.Controls)
            {
                ctrl.Visible = false;
            }

            if (!this.Controls.Contains(newControl))
            {
                newControl.Dock = DockStyle.Fill;
                this.Controls.Add(newControl);
            }

            newControl.Visible = true;
        }

        #region saving
        /// <summary>
        /// displays dialog that appears when the form is closing, asking if the user wants to save the game
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void DisplayFormClosingReaction(object sender, FormClosingEventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Do you want to save your progress?",
                "Save",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
            );
            // opens saving dialog
            if (result == DialogResult.Yes)
            {
                SaveGame();
            }
            // if cancel is chosen, nothing happens, dialog ends
            else if (result == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
            // if no chosen, nothing happens, it closes
        }

        /// <summary>
        /// Saves the game to json, from which it can be loaded again
        /// </summary>
        private void SaveGame()
        {
            SerializationUnit gameToSave = new SerializationUnit(thePet, theStats);
            string json = gameToSave.SerializeToJson();

            SaveFileDialog saveFileDialog = new SaveFileDialog
            {
                Filter = "JSON files (*.json)|*.json|All files (*.*)|*.*",
                Title = "Save Game",
                FileName = $"{thePet.Name}.json"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    File.WriteAllText(saveFileDialog.FileName, json);
                    MessageBox.Show("Game saved.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error while saving: {ex.Message}", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion
    }
}
