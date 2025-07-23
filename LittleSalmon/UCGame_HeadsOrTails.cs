using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using Games;
using System.Diagnostics.Eventing.Reader;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace LittleSalmon
{
    /// <summary>
    /// together with ../Games/Game_HeadsOrTails does the flip the coin game
    /// player can either bet on heads or tails or just flip
    /// bad bet result - 1
    /// good bet result - 1
    /// 
    /// player can choose between a fair coin and a randomly unfair coin 
    /// </summary>
    public partial class UCGame_HeadsOrTails : GamesUserControlParent
    {
        private string _labelIndifferent = "hmm"; // default label value
        private string[] _labelsVictorious = {
            "YEAH!",
            "that's how it should be done",
            "great!",
            "are you a wizard?" }; // label values in case of a good bet
        private string[] _labelsDefeated ={
            "oh...",
            "that wasn't too good",
            "ehh",
            "somebody's gonna be pooooor"
            }; // label values in case of a bad bet
        private Game_HeadsOrTails.CoinOptions _coinResult; // flip result
        private Game_HeadsOrTails.CoinOptions _coinGuess; // what was guessed
        private Bitmap[] coinPictures; // at least three icons expected in this order - empty, heads, tails
        private Random _random; // for choosing the label text option
        private int _iconWidth { get; } = 150; // icon width, must correspond with the bitmap given
        private int _coinSpeed = 200; // duration of flipping in ms
        public int Reward { get; set; } = 1; // how much food is given for a good guess, default 10
        private int _soFarWon = 0;

        public UCGame_HeadsOrTails()
        {
            InitializeComponent();
            this.BackColor = MainForm.MyDefaultBackColor;
            coinPictures = FileHelper.SplitIcons(new Bitmap(FileHelper.GetPathToResources("coinIcons.png")), _iconWidth);
            coinPicture.Image = coinPictures[0];
            _random = new Random();
            ResetResultLabel();
            ResetWinSoFarLabel();
            SetLabelWinSoFar();
            UpdateCurrentFoodCountLabel();
        }



        #region label result stuff
        private void ResetResultLabel() => Label_Result.Text = _labelIndifferent;
        private void LabelSetResult(string[] options)
        {
            int i = _random.Next(0, options.Length);
            Label_Result.Text = options[i];
        }
        #endregion

        #region label win so far stuff
        private void ResetWinSoFarLabel() => _soFarWon = 0;
        private void SetLabelWinSoFar()
        {
            if (_soFarWon == 0)
                Label_WinSoFar.Text = "You haven't won anything yet.";
            else
                Label_WinSoFar.Text = $"You have won {_soFarWon} food units so far.";
        }
        #endregion
        #region current food count label
        private void UpdateCurrentFoodCountLabel()
        {
            Label_CurrentFoodCount.Text = $"Current food count: {MainForm.thePet.FoodCount}";
        }
        #endregion


        private void ShowFlipResult()
        {
            int index = (int)_coinResult;
            coinPicture.Image = coinPictures[index];
        }
        private void HandleGoodGuess()
        {
            LabelSetResult(_labelsVictorious);
            MainForm.theStats.AdjustStat("Lucky coin guesses", 1); // increment lucky coin guesses

            _soFarWon += Reward;

            MainForm.thePet.AddFood(Reward);
        }
        private void HandleBadGuess()
        {
            LabelSetResult(_labelsDefeated);

            if (MainForm.thePet.FoodCount >= Reward) // cap on 0, so that the Pet doesn't have negative nuber of food
            {
                MainForm.thePet.AddFood(-Reward);
                _soFarWon -= Reward;
            }
        }

        private async void PerformTurn(bool shouldEvaluate)
        {
            MainForm.theStats.AdjustStat("Coins flipped", 1); // increment coins flipped
            coinPicture.Image = coinPictures[(int)Game_HeadsOrTails.CoinOptions.Empty]; // interstate
            _coinResult = Game_HeadsOrTails.FlipTheCoin();
            await Task.Delay(_coinSpeed);
            ShowFlipResult();
            if (shouldEvaluate)
                Evaluate();
            SetLabelWinSoFar();
            UpdateCurrentFoodCountLabel();
        }

        private void Evaluate()
        {
            if (_coinResult == _coinGuess)
                HandleGoodGuess();
            else
                HandleBadGuess();
        }

        #region button click functions

        private void playButton_Click(object sender, EventArgs e)
        {
            ResetResultLabel();
            if (sender == myButton_HeadsBet)
                _coinGuess = Game_HeadsOrTails.CoinOptions.Heads;
            else if (sender == myButton_TailsBet)
                _coinGuess = Game_HeadsOrTails.CoinOptions.Tails;
            bool shouldEvaluate = sender != myButton_JustFlip;
            PerformTurn(shouldEvaluate);
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Game_HeadsOrTails.ResetFairness();
        }
        private void randomizeButton_Click(object sender, EventArgs e)
        {
            Game_HeadsOrTails.SetRandomFairness();
        }

#endregion
    }
}
