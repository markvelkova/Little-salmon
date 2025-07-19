using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using games;

namespace losos
{
    public partial class UCGame_StarrySky : GamesUserControlParent
    {
        private Bitmap[] starPictures; // icons for the stars
        private int iconWidth { get; } = 400; // width of each star icon
        private int numberOfIcons; 
        private int numberOfClicks = 0; // number of clicks on the stars
        private double totalReward = 0; // total reward from clicking stars
        private int maxReward = 1;
        private int countdownTime = 3; // countdown time to game start in seconds - constant
        private double gameDuration = 100; // duration of the game in tenths of seconds - constant

        private int currentCountdownTimeLeft = 3; // countdown time to game start in seconds
        private double currentGameDurationLeft = 100; // duration of the game in tenths of seconds

        public UCGame_StarrySky()
        {
            InitializeComponent();
            this.BackColor = MainForm.MyDefaultBackColor; // set the background color to the default one
            starPictures = FileHelper.SplitIcons(new Bitmap(FileHelper.GetPathToResources("starrySkyIcons.png")), iconWidth);
            numberOfIcons = starPictures.Length;
            pictureBox_Sky.Image = starPictures[0]; // set the first star icon as the initial image
            Label_Countdown.Visible = false; // hide the countdown label initially
            UpdateGameStatusLabels(); // update the game status labels
        }

        #region game start end

        private void startCountDown()
        {
            Label_Countdown.Visible = true;
            Label_Countdown.Text = currentCountdownTimeLeft.ToString();
            Timer_CountdownToStart.Start(); // start countdown timer
        }

        private void button_StartGame_Click(object sender, EventArgs e)
        {
            myButton_Start.Enabled = false; // disable start button to prevent multiple clicks
            startCountDown();
        }
        private void startGame()
        {
            currentCountdownTimeLeft = 3; // reset countdown time for next game
            Timer_CountdownToStart.Stop();
            Label_Countdown.Visible = false;
            Timer_GameTimer.Start(); // start game itself
            Timer_ChangeImage.Start(); // start changing images
            UpdateGameStatusLabels();
        }
        private void StopGame()
        {
            Timer_GameTimer.Stop(); // stop game timer
            Timer_ChangeImage.Stop(); // stop changing images
            myButton_Start.Enabled = true; // re-enable start button
            UpdateGameStatusLabels();
            HandleGameEnd();
            ResetForNextGame();
        }

        private void HandleGameEnd()
        {
            // Show the final message box with the results
            MessageBox.Show("Time over! You clicked " + numberOfClicks + " times and earned a total reward of " + ((int)totalReward).ToString() + " food.", "Time Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
            
            MainForm.thePet.FoodCount += (int)totalReward; // add the reward to the current food count
            UpdateStats(); // update the stats
        }

        /// <summary>
        /// updates theStats related to the starry sky game, such as the number of clicks, total reward, and records.
        /// </summary>
        private void UpdateStats()
        {
            //Adjust basic stat
            MainForm.AdjustStat("Starry sky clicked", numberOfClicks);
            // Adjust the starry sky reward record if needed
            int currentRecord = MainForm.theStats.GetStat("Starry sky reward record");
            if (currentRecord < (int)totalReward)
                MainForm.AdjustStat("Starry sky reward record", (int)totalReward);
            // Adjust the starry sky clicks record if needed
            currentRecord = MainForm.theStats.GetStat("Starry sky clicks record");
            if (currentRecord < numberOfClicks)
                MainForm.AdjustStat("Starry sky clicks record", numberOfClicks);
        }

        /// <summary>
        /// resets game stats for the next game
        /// specifically: number of clicks, total reward, countdown time, and game duration.
        /// </summary>
        private void ResetForNextGame()
        {
            numberOfClicks = 0; // reset number of clicks
            totalReward = 0; // reset total reward
            currentCountdownTimeLeft = countdownTime; // reset countdown time for next game
            currentGameDurationLeft = gameDuration; // reset game duration
            UpdateGameStatusLabels();
            pictureBox_Sky.Image = starPictures[0]; // reset the sky image to the first icon
        }
        #endregion

        #region timers

        /// <summary>
        /// this timer counts down the time left before the game starts and updates the countdown label.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_Countdown_Tick(object sender, EventArgs e)
        {
            if (currentCountdownTimeLeft > 1)
            {
                currentCountdownTimeLeft--;
                Label_Countdown.Text = currentCountdownTimeLeft.ToString();
            }
            else
            {
                startGame();
            }
        }

        /// <summary>
        /// This timer changes the image to a random one of the star icons every interval
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_ChangeImage_Tick(object sender, EventArgs e)
        {
            Random random = new Random();
            int index = random.Next(0, numberOfIcons);
            pictureBox_Sky.Image = starPictures[index];
        }
        /// <summary>
        /// This timer counts down the game duration and stops the game when the time is up.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer_GameTimer_Tick(object sender, EventArgs e)
        {
            if (currentGameDurationLeft > 0)
            {
                currentGameDurationLeft -= 1; // decrease game duration by 0.1 second (one tenth)
            }
            else
            {
                StopGame();
            }
            UpdateGameStatusLabels();
        }
        #endregion

        /// <summary>
        /// updates the labels that show the current game status, such as time left, total reward, and number of clicks.
        /// </summary>
        private void UpdateGameStatusLabels()
        {
            Label_TimeLeft.Text = "Time left: " + ((int)(currentGameDurationLeft/10)).ToString()+ "." + ((int)(currentGameDurationLeft % 10)).ToString() + " seconds";
            Label_Reward.Text = "Total reward: " + totalReward.ToString("F2");
            Label_Clicks.Text = "Number of clicks: " + numberOfClicks.ToString();
        }

        /// <summary>
        /// checks if the game is running and handles the mouse click on the starry sky.
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void StarrySky_MouseClick(object sender, MouseEventArgs e)
        {
            if (Timer_GameTimer.Enabled == true) // only if game is running
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
                UpdateGameStatusLabels();
            }
        }
    }
}
