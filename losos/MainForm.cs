using games;
using pet;
using stats;

namespace losos
{
    public partial class MainForm : Form
    {
        // thePet is STATIC therefore only one at time
        // can be reached from anywhere as MainForm.Pet
        public static Pet thePet = new();
        public static Stats theStats = new();
        public MainForm()
        {
            InitializeComponent();
            ShowIntro();
            MessageBox.Show(new SerializationUnit(thePet,theStats).SerializeToJson());
        }

        /// <summary>
        /// basic colour, kinda blue, for background
        /// </summary>
        public static Color MyDefaultBackColor => Color.FromArgb(0, 162, 232);

        /// <summary>
        /// from the "Intro" screen the player can choose to start a new game or load an existing game
        /// existing game must be a valid json of the right format (intended to be obtained from the very game)
        /// </summary>
        private void ShowIntro()
        {
            var intro = new UCIntro();
            intro.StartNewGameClicked += (s, e) => ShowMain();
            intro.LoadGameClicked += (s, e) => ShowMain();
            SwitchScreen(intro);
        }

        /// <summary>
        /// from the "Main" screen the player can choose from following:
        /// games
        /// feed MISSING
        /// sleep MISSING
        /// wash MISSING
        /// </summary>
        private void ShowMain()
        {
            var main = new UCMain();
            main.GamesButtonClicked += (s, e) => ShowGames();
            SwitchScreen(main);
        }

        /// <summary>
        /// from "Games" screen the player can choose a game to play or return to the main screen
        /// </summary>
        private void ShowGames()
        {
            var games = new UCGames();
            games.ReturnSelected += (s, e) => ShowMain();
            games.FlipACoinSelected += (s, e) => ShowHeadsOrTails();
            games.StarrySkySelected += (s, e) => ShowStarrySky();
            SwitchScreen(games);
        }

        #region individual games Show...
        private void ShowHeadsOrTails()
        {
            var headsOrTails = new UCGame_HeadsOrTails();
            headsOrTails.ReturnSelected += (s, e) => ShowGames();
            SwitchScreen(headsOrTails);
        }
        private void ShowStarrySky()
        {
            var starrySky = new UCStarrySky();
            starrySky.ReturnSelected += (s, e) => ShowGames();
            SwitchScreen(starrySky);
        }
        #endregion

        private void SwitchScreen(UserControl newControl)
        {
            this.Controls.Clear();
            this.Controls.Add(newControl);
            newControl.Dock = DockStyle.Fill;
        }

        #region saving
        private void FormClosingReaction(object sender, FormClosingEventArgs e)
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

        /// <summary>
        /// adjusts the stat with the given name by the given value.
        /// wrapper in case stats changed its logic
        /// </summary>
        /// <param name="name"></param>
        /// <param name="value"></param>
        public static void AdjustStat(string name, int value)
        {
            theStats.AdjustStat(name, value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
