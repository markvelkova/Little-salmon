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
    /// <summary>
    /// together with ../games/Game_HeadsOrTails does the flip the coin game
    /// player can either bet on heads or tails or just flip
    /// bad bet result - MISSING
    /// good bet result - MISSING
    /// 
    /// player can choose between a fair coin and a randomly unfair coin 
    /// </summary>
    public partial class UCHeadsOrTails : UserControl
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
        public UCHeadsOrTails()
        {
            InitializeComponent();
            coinPictures = FileHelper.SplitIcons(new Bitmap(FileHelper.GetPathToResources("coinIcons.png")), _iconWidth);
            coinPicture.Image = coinPictures[0];
            _random = new Random();
            ResetLabel();
        }



        #region label stuff
        private void ResetLabel() => Label_Result.Text = _labelIndifferent;
        private void LabelSetResult(string[] options)
        {
            int i = _random.Next(0, options.Length);
            Label_Result.Text = options[i];
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
            // give money / food
        }
        private void HandleBadGuess()
        {
            LabelSetResult(_labelsDefeated);
            // give nothing
        }

        private async void PerformTurn(bool shouldEvaluate)
        {
            coinPicture.Image = coinPictures[(int)Game_HeadsOrTails.CoinOptions.Empty]; // interstate
            _coinResult = Game_HeadsOrTails.FlipTheCoin();
            await Task.Delay(_coinSpeed);
            ShowFlipResult();
            if (shouldEvaluate)
                Evaluate();
        }

        private void Evaluate()
        {
            if (_coinResult == _coinGuess)
                HandleGoodGuess();
            else
                HandleBadGuess();
        }

        #region button click functions
        public event EventHandler ReturnSelected;
        private void returnButton_Click(object sender, EventArgs e)
        {
            ReturnSelected?.Invoke(this, EventArgs.Empty);
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            ResetLabel();
            if (sender == Button_HeadsBet)
                _coinGuess = Game_HeadsOrTails.CoinOptions.Heads;
            else if (sender == Button_TailsBet)
                _coinGuess = Game_HeadsOrTails.CoinOptions.Tails;
            bool shouldEvaluate = sender != Button_JustFlip;
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
