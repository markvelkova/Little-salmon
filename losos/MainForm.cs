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
            SwitchScreen(games);
        }

        #region individual games Show...
        private void ShowHeadsOrTails()
        {
            var headsOrTails = new UCGame_HeadsOrTails();
            headsOrTails.ReturnSelected += (s, e) => ShowGames();
            SwitchScreen(headsOrTails);
        }
        #endregion

        private void SwitchScreen(UserControl newControl)
        {
            this.Controls.Clear();
            this.Controls.Add(newControl);
            newControl.Dock = DockStyle.Fill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
