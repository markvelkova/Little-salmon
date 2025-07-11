using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using games;

namespace losos
{
    public partial class UCStarrySky : UserControl
    {
        private Bitmap[] starPictures; // icons for the stars
        private int iconWidth { get; } = 400; // width of each star icon
        private int numberOfIcons; 
        private int numberOfClicks = 0; // number of clicks on the stars
        private double totalReward = 0; // total reward from clicking stars
        private int maxReward = 1;

        public UCStarrySky()
        {
            InitializeComponent();
            starPictures = FileHelper.SplitIcons(new Bitmap(FileHelper.GetPathToResources("starrySkyIcons.png")), iconWidth);
            numberOfIcons = starPictures.Length;
            pictureBox_Sky.Image = starPictures[0]; // set the first star icon as the initial image
        }

        private void UpdateLabels()
        {
            Label_Reward.Text = "Total reward: " + totalReward.ToString("F2");
            Label_Clicks.Text = "Number of clicks: " + numberOfClicks.ToString();
        }
        private void StarrySky_MouseClick(object sender, MouseEventArgs e)
        {
            PictureBox pb = sender as PictureBox;
            Bitmap bmp = (Bitmap)pb.Image;

            int x = e.X;
            int y = e.Y;

            if (pb.SizeMode == PictureBoxSizeMode.StretchImage) // in case of changed mode
            {
                x = e.X * bmp.Width / pb.Width;
                y = e.Y * bmp.Height / pb.Height;
            }
            Color color = bmp.GetPixel(e.X, e.Y);
            totalReward += Clicker.CalculateClickReward(color, maxReward);
            numberOfClicks++;
            UpdateLabels();
        }

        public event EventHandler ReturnSelected;
        private void returnButton_Click(object sender, EventArgs e)
        {
            ReturnSelected?.Invoke(this, EventArgs.Empty);
        }
    }
}
