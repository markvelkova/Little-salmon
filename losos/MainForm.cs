using games;

namespace losos
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            ShowIntro();
        }


        private void ShowIntro()
        {
            var intro = new UCIntro();
            intro.StartNewGameClicked += (s, e) => ShowMain();
            SwitchScreen(intro);
        }
        /// <summary>
        /// from the "Main" screen the player can choose from following:
        /// games
        /// feed 
        /// MISSING
        /// and see stats
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
            var headsOrTails = new UCHeadsOrTails();
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
