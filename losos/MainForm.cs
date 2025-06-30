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

        private void ShowMain()
        {
            var main = new UCMain();
            SwitchScreen(main);
        }

        private void SwitchScreen(UserControl newControl)
        {
            this.Controls.Clear();
            this.Controls.Add(newControl);
            //newControl.Dock = DockStyle.Fill;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
