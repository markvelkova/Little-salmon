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
    public enum GameMode { easy = 1, medium = 2, hard = 3, insane = 5 };
    public partial class UCGame_SpeedyCount : GamesUserControlParent
    {
        private string equationLabelDefaultText = "?????"; // default text for the equation label
        private SpeedCounting.SimpleEquation CurrentEquation;
        private int Reward = 0;
        private int TimeLimit { get; set; } = 600; // time limit in seconds, default is 60 seconds - 600 tenths of second
        private int TimeLeft { get; set; }
        private GameMode currentGameMode = GameMode.easy; // current game mode, default is easy
        int TotalReward { get; set; } = 0; // total reward for the game, can be used to display the score at the end of the game
        private List<SpeedCounting.UserCalculationResult> UserCalculationResults { get; set; }

        MeterDisplayer timeBar; 
        
        

        public UCGame_SpeedyCount()
        {
            InitializeComponent();
            this.BackColor = MainForm.MyDefaultBackColor; // set the background color to the default one
            timeBar = new MeterDisplayer(Panel_Time, new Panel(), new Mirror(() => TimeLeft), TimeLimit);

            CheckListBox_Difficulty.SetItemChecked(0,true); // set the first item (easy) checked by default

            TimeLeft = TimeLimit; // initialize the time left to the time limit
            SetTimeBarValue(timeBar); // set the time bar value and color
            ResetEquationLabel();
            UsefulForDesign.CenterControlHorizontally(TextBox_Answer); // center the answer text box horizontally
            UsefulForDesign.CenterControlHorizontally(Panel_Time); // center the time panel horizontally
            myButton_Start.Text = "START";

        }

        #region equation label
        private void displayEquation(SpeedCounting.IEquation equation)
        {
            // display the equation in the label
            Label_Equation.Text = equation.EquationString;
            UsefulForDesign.CenterControl(Label_Equation);
        }



        /// <summary>
        /// reset the equation label to default text
        /// </summary>
        private void ResetEquationLabel()
        {
            UsefulForDesign.CenterControl(Label_Equation); // center the label
            Label_Equation.Text = equationLabelDefaultText;
        }
        #endregion

        #region game logic
        /// <summary>
        /// generate equation and display it in the label
        /// </summary>
        private void GenerateNewEquation()
        {
            CurrentEquation = new SpeedCounting.SimpleEquation();
            displayEquation(CurrentEquation); // display the generated equation
            Label_CurrentRewardDisplay.Text = TotalReward.ToString(); // display the current reward
        }

        private void textBox_Answer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // prevent the OBNOXIOUS beep sound on Enter key press
                GetAndCheckAnswer();

                GenerateNewEquation(); // generate a new equation after checking the answer
                TextBox_Answer.Text = ""; // clear the answer text box
                TextBox_Answer.Focus(); // set focus to the answer text box
            }
        }

        private void Button_Start_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void StartGame()
        {
            TotalReward = 0; // reset the total reward
            ReadDifficultyInputs();
            GenerateNewEquation(); // generate a new equation
            TextBox_Answer.Text = ""; // clear the answer text box
            TextBox_Answer.Focus(); // set focus to the answer text box
            myButton_Start.Enabled = false;
            Timer_GameTimer.Start(); // start the game timer
            UserCalculationResults = new();
        }

        private void ReadDifficultyInputs()
        {
            if (CheckListBox_Difficulty.CheckedItems.Count == 0)
            {
                MessageBox.Show("Please select a difficulty level.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return; // do not start the game if no difficulty is selected
            }
            // read the difficulty level from the checked items in the list box
            if (CheckListBox_Difficulty.CheckedItems.Contains("easy"))
            {
                currentGameMode = GameMode.easy;
                SpeedCounting.MaxOperandValue = 5; // set the maximum operand value for easy mode
                SpeedCounting.MinOperandValue = -5; // set the minimum operand value for easy mode
            }

            else if (CheckListBox_Difficulty.CheckedItems.Contains("medium"))
            {
                currentGameMode = GameMode.medium;
                SpeedCounting.MaxOperandValue = 10; // set the maximum operand value for medium mode
                SpeedCounting.MinOperandValue = -10; // set the minimum operand value for medium mode
            }
            else if (CheckListBox_Difficulty.CheckedItems.Contains("hard"))
            {
                currentGameMode = GameMode.hard;
                SpeedCounting.MaxOperandValue = 50; // set the maximum operand value for hard mode
                SpeedCounting.MinOperandValue = -50; // set the minimum operand value for hard mode
            }
            else if (CheckListBox_Difficulty.CheckedItems.Contains("insane"))
            {
                currentGameMode = GameMode.insane;
                SpeedCounting.MaxOperandValue = 100; // set the maximum operand value for insane mode
                SpeedCounting.MinOperandValue = -100; // set the minimum operand value for insane mode
            }

            // read the operand limit
            SpeedCounting.MaxOperands = (int)Numeric_MaxOpNum.Value;

        }
        private void checkedListBox_OnlyOneItemCheck(object sender, ItemCheckEventArgs e)
        {
            CheckedListBox clb = sender as CheckedListBox;
            if (e.NewValue == CheckState.Checked)
            {
                for (int i = 0; i < clb.Items.Count; i++)
                {
                    if (i != e.Index)
                    {
                        clb.SetItemChecked(i, false);
                    }
                }
            }
        }

        private void EndGame()
        {

            MessageBox.Show("Time over! You earned a total reward of " + TotalReward + " food.", "Time Over", MessageBoxButtons.OK, MessageBoxIcon.Information);

            myButton_Start.Enabled = true; // enable the start button
            Timer_GameTimer.Stop(); // stop the game timer
            TextBox_Answer.BackColor = Color.White;
            ResetEquationLabel(); // reset the equation label to default text
            EvaluateResults();
            MainForm.thePet.AddFood(TotalReward);
        }

        private void EvaluateResults()
        {
            AdjustStatWrapper("played", 1); // adjust the played stat for the current game mode

            var correctAnswers = from result in UserCalculationResults
                                 where result.IsCorrect
                                 select result;
            AdjustStatWrapper("correct", correctAnswers.Count()); // adjust the correct stat for the current game mode

            if (correctAnswers.Count() > MainForm.theStats.GetStat(MainForm.theStats.GetSpeedyStatName(currentGameMode.ToString(), "record")))
            {
                AdjustStatWrapper("record", correctAnswers.Count()); // adjust the record stat for the current game mode
                MessageBox.Show("You set up a new record!!!", "New record", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

            var incorrectAnswers = from result in UserCalculationResults
                                   where !result.IsCorrect && !result.IsInvalid
                                   select result;
            AdjustStatWrapper("total incorrect", incorrectAnswers.Count()); // adjust the total incorrect stat for the current game mode
            

            var invalidAnswers = from result in incorrectAnswers
                                 where result.IsInvalid
                                 select result;
            AdjustStatWrapper("invalid", invalidAnswers.Count()); // adjust the invalid stat for the current game mode

            var almostCorrectAnswers = from result in incorrectAnswers
                                       where !result.IsInvalid && Math.Abs(result.UserResult - result.CorrectResult) == 1
                                       select result;
            AdjustStatWrapper("almost correct", almostCorrectAnswers.Count()); // adjust the almost correct stat for the current game mode

            var tenLostSomewhere = from result in incorrectAnswers
                                   where !result.IsInvalid && Math.Abs(result.UserResult - result.CorrectResult) == 10
                                   select result;
            AdjustStatWrapper("ten away", tenLostSomewhere.Count()); // adjust the ten away stat for the current game mode
        }
        private void AdjustStatWrapper(string statName, int value)
        {
            MainForm.theStats.AdjustStat(MainForm.theStats.GetSpeedyStatName(currentGameMode.ToString(), statName), value);
        }

        private void GetAndCheckAnswer()
        {
            SpeedCounting.UserCalculationResult userResult = CurrentEquation.CheckUserResult(TextBox_Answer.Text);
            if (userResult.IsCorrect)
            {
                HandleGoodAnswer();
            }
            else // invalid or wrong
            {
                HandleBadAnswer();
            }
            UserCalculationResults.Add(userResult); // add the user result to the list of results
        }
        #endregion

        #region rewards
        private void HandleGoodAnswer()
        {
            TotalReward += (int)currentGameMode * 1 + CurrentEquation.Operands.Length - 2; 
            TextBox_Answer.BackColor = Color.LightGreen; // change the answer text box background color to light green
        }
        private void HandleBadAnswer()
        {
            TextBox_Answer.BackColor = Color.LightPink; // change the answer text box background color to light pink
        }
        #endregion


        #region time flow
        /// <summary>
        /// adjusts the time bar value and color based on value mirrored
        /// </summary>
        private void SetTimeBarValue(MeterDisplayer m)
        {
            float percentage = (float)m.Mirror.Value / m.Max;
            int barWidth = (int)(m.BackgroundPanel.Width * percentage);

            m.BarPanel.Width = barWidth;
            m.BarPanel.Height = m.BackgroundPanel.Height;

            percentage *= 100;

            if (percentage < 15)
                m.BarPanel.BackColor = Color.Red;
            else if (percentage < 30)
                m.BarPanel.BackColor = Color.Orange;
            else if (percentage < 50)
                m.BarPanel.BackColor = Color.Yellow;
            else if (percentage < 80)
                m.BarPanel.BackColor = Color.Green;
            else
                m.BarPanel.BackColor = Color.Blue;
            m.BackgroundPanel.Controls.Clear();
            m.BackgroundPanel.Controls.Add(m.BarPanel);
        }

        private void Timer_GameTimer_Tick(object sender, EventArgs e)
        {
            if (TimeLeft <= 0)
            {
                Timer_GameTimer.Stop(); // stop the timer when time is up
                EndGame(); // end the game
                return;
            }
            else
            {
                TimeLeft--; // decrease the time left
                SetTimeBarValue(timeBar); // set the time bar value and color
            }
        }
        #endregion
    }

}
