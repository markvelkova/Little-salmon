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
    public partial class UCHeadsOrTails : UserControl
    {
        private Game_HeadsOrTails.CoinOptions _coinResult;
        private Game_HeadsOrTails.CoinOptions _coinGuess;
        public UCHeadsOrTails()
        {
            InitializeComponent();
            coinPicture.Image = Properties.Resources.emptyCoin; // tady se musi pridat spravne do resources
        }

        public event EventHandler StupidButtonClicked;

        private void button_StupidButton_Click(object sender, EventArgs e)
        {
            StupidButtonClicked?.Invoke(this, EventArgs.Empty);
        }

        private void ShowFlipResult(Game_HeadsOrTails.CoinOptions result)
        {

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
        private void Evaluate(Game_HeadsOrTails.CoinOptions result, Game_HeadsOrTails.CoinOptions guess)
        {
            if (result == guess)
                HandleGoodGuess();
            else
                HandleBadGuess();
        }

        private void button_HeadsBet_Click(object sender, EventArgs e)
        {
            _coinGuess = Game_HeadsOrTails.CoinOptions.Heads;
            PerformTurn();
        }
        private void button_TailsBet_Click(object sender, EventArgs e)
        {
            _coinGuess = Game_HeadsOrTails.CoinOptions.Tails;
            PerformTurn();
        }

        private void PerformTurn()
        {
            _coinResult = Game_HeadsOrTails.FlipTheCoin();
            ShowFlipResult(_coinResult);
            Evaluate(_coinResult, _coinGuess);
        }

    }
}
