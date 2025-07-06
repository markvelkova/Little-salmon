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
using games;
using System.Diagnostics.Eventing.Reader;

namespace losos
{
    public partial class UCHeadsOrTails : UserControl
    {
        private string _labelIndifferent = "hmm";
        private string[] _labelVictorious = { 
            "YEAH!", 
            "that's how it should be done", 
            "great!", 
            "are you a wizard?" };
        private string[] _labelDefeated ={
            "oh...",
            "that wasn't too good",
            "ehh",
            "somebody's gonna be pooooor"
            };
        private Game_HeadsOrTails.CoinOptions _coinResult;
        private Game_HeadsOrTails.CoinOptions _coinGuess;
        private Bitmap[] coinPictures;
        public UCHeadsOrTails()
        {
            InitializeComponent();
            coinPictures = FileHelper.SplitIcons(new Bitmap(FileHelper.GetPathToResources("coinIcons.png")), 150);
            coinPicture.Image = coinPictures[0];
        }

        private void ShowFlipResult()
        {
            if (_coinResult == Game_HeadsOrTails.CoinOptions.Heads)
                coinPicture.Image = coinPictures[1];
            else
                coinPicture.Image = coinPictures[2];
        }
        private void HandleGoodGuess()
        {
            MessageBox.Show("You guessed it right!");

            // give money / food
        }
        private void HandleBadGuess()
        {
            MessageBox.Show("Wrong guess, try again!");
            // give nothing
        }
        private void Evaluate()
        {
            if (_coinResult == _coinGuess)
                HandleGoodGuess();
            else
                HandleBadGuess();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (sender == Button_HeadsBet)
                _coinGuess = Game_HeadsOrTails.CoinOptions.Heads;
            else if (sender == Button_TailsBet)
                _coinGuess = Game_HeadsOrTails.CoinOptions.Tails;
            bool shouldEvaluate = sender != Button_JustFlip;
            PerformTurn(shouldEvaluate);
        }

        private async void PerformTurn(bool shouldEvaluate)
        {
            coinPicture.Image = coinPictures[0]; // interstate
            _coinResult = Game_HeadsOrTails.FlipTheCoin();
            await Task.Delay(500);
            ShowFlipResult();
            if (shouldEvaluate)
                Evaluate();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            Game_HeadsOrTails.ResetFairness();
        }
        private void randomizeButton_Click(object sender, EventArgs e)
        {
            Game_HeadsOrTails.SetRandomFairness();
        }
    }
}
