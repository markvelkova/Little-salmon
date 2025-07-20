using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace losos
{
    public partial class UCGames : UserControl
    {
        
        public event EventHandler FlipACoinSelected;
        public event EventHandler StarrySkySelected;
        public event EventHandler SpeedyCountSelected;
        public event EventHandler SnakeSelected;
        public UCGames()
        {
            InitializeComponent();
            this.BackColor = MainForm.MyDefaultBackColor;

            // put there the pictureboxes
            placePictureboxes();

        }

        private void placePictureboxes()
        {
            int initialX = 150;
            int initialY = 30;
            int numberOfGames = Enum.GetNames(typeof(Games)).Length;
            int spacing = (540 - (numberOfGames * 100)) / (numberOfGames -1); // calculate spacing based on the number of games
            Games[] gameValues = (Games[])Enum.GetValues(typeof(Games));

            for (int i = 0; i < numberOfGames; i++)
            {
                PictureBox pictureBox = new PictureBox
                {
                    Size = new Size(200, 100),
                    Location = new Point(initialX, initialY + (i * (100 + spacing))),
                    Image = gameIcones[i],
                    SizeMode = PictureBoxSizeMode.StretchImage,
                    Cursor = Cursors.Hand,
                    Tag = gameValues[i],
                    BorderStyle = BorderStyle.Fixed3D
                };
                pictureBox.Click += GamePictureBox_Click;
                this.Controls.Add(pictureBox);
            }

        }

        private void GamePictureBox_Click(object sender, EventArgs e)
        {
            if (sender is PictureBox pb && pb.Tag is Games selectedGame)
            {
                switch (selectedGame)
                {
                    case Games.HeadsOrTails:
                        FlipACoinSelected?.Invoke(this, EventArgs.Empty);
                        break;
                    case Games.StarrySky:
                        StarrySkySelected?.Invoke(this, EventArgs.Empty);
                        break;
                    case Games.Snake:
                        SnakeSelected?.Invoke(this, EventArgs.Empty);
                        break;
                    case Games.SpeedyCount:
                        SpeedyCountSelected?.Invoke(this, EventArgs.Empty);
                        break;
                }
            }
        }



        private void component_HeadOrTails_Click(object sender, EventArgs e)
        {
            FlipACoinSelected?.Invoke(this, EventArgs.Empty);
        }
        private void component_StarrySky_Click(object sender, EventArgs e)
        {
            StarrySkySelected?.Invoke(this, EventArgs.Empty);
        }
        private void component_SpeedyCount_Click(object sender, EventArgs e)
        {
            SpeedyCountSelected?.Invoke(this, EventArgs.Empty);
        }
        private void component_Snake_Click(object sender, EventArgs e)
        {
            SnakeSelected?.Invoke(this, EventArgs.Empty);
        }

        private Image[] gameIcones = FileHelper.SplitIcons(new Bitmap(FileHelper.GetPathToResources("gameIcons.png")), 200);
        private enum Games { HeadsOrTails, StarrySky, Snake, SpeedyCount };


        public event EventHandler ReturnSelected;
        private void button_Return_Click(object sender, EventArgs e)
        {
            ReturnSelected?.Invoke(this, EventArgs.Empty);
        }

    }
}
