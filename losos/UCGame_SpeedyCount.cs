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
    public partial class UCGame_SpeedyCount : UserControl
    {
        private string equationLabelDefaultText = "?????"; // default text for the equation label
        private SpeedCounting.SimpleEquation CurrentEquation;
        private int Reward = 0;
        private int TimeLimit { get; set; } = 600; // time limit in seconds, default is 60 seconds - 600 tenths of second
        private int TimeLeft { get; set; }
        private GameMode currentGameMode = GameMode.Easy; // current game mode, default is Easy
        int TotalReward { get; set; } = 0; // total reward for the game, can be used to display the score at the end of the game

        MeterDisplayer timeBar; 
        
        private enum GameMode { Easy = 1, Medium = 2, Hard = 3, Insane = 5 };

        public UCGame_SpeedyCount()
        {
            InitializeComponent();
            this.BackColor = MainForm.MyDefaultBackColor; // set the background color to the default one
            timeBar = new MeterDisplayer(Panel_Time, new Panel(), new Mirror(() => TimeLeft), TimeLimit);

            CheckListBox_Difficulty.SetItemChecked(0,true); // set the first item (Easy) checked by default

            TimeLeft = TimeLimit; // initialize the time left to the time limit
            SetTimeBarValue(timeBar); // set the time bar value and color
            ResetEquationLabel();
            CenterControlHorizontally(TextBox_Answer); // center the answer text box horizontally
            CenterControlHorizontally(Panel_Time); // center the time panel horizontally
            Button_Start.Text = "START";

        }

        #region equation label
        private void displayEquation(SpeedCounting.IEquation equation)
        {
            // display the equation in the label
            Label_Equation.Text = equation.EquationString;
            CenterControl(Label_Equation);
        }

        /// <summary>
        /// centers the control in the parent control
        /// </summary>
        /// <param name="control"></param>
        private void CenterControl(Control control)
        {
            CenterControlHorizontally(control);
            CenterControlVertically(control);
        }

        private void CenterControlHorizontally(Control control)
        {
            // center the label horizontally in the parent control
            control.Left = (this.Width - control.Width) / 2;
        }
        private void CenterControlVertically(Control control)
        {
            // center the label vertically in the parent control
            control.Top = (this.Height - control.Height) / 2;
        }

        /// <summary>
        /// reset the equation label to default text
        /// </summary>
        private void ResetEquationLabel()
        {
            CenterControl(Label_Equation); // center the label
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
            Label_CorrectResult.Text = CurrentEquation.Solution.ToString(); // display the correct result in the label
        }

        private void textBox_Answer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // prevent the OBNOXIOUS beep sound on Enter key press
                CheckAnswer();
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
            Button_Start.Enabled = false;
            Timer_GameTimer.Start(); // start the game timer
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
                currentGameMode = GameMode.Easy;
                SpeedCounting.MaxOperandValue = 5; // set the maximum operand value for Easy mode
                SpeedCounting.MinOperandValue = -5; // set the minimum operand value for Easy mode
            }

            else if (CheckListBox_Difficulty.CheckedItems.Contains("medium"))
            {
                currentGameMode = GameMode.Medium;
                SpeedCounting.MaxOperandValue = 10; // set the maximum operand value for Medium mode
                SpeedCounting.MinOperandValue = -10; // set the minimum operand value for Medium mode
            }
            else if (CheckListBox_Difficulty.CheckedItems.Contains("hard"))
            {
                currentGameMode = GameMode.Hard;
                SpeedCounting.MaxOperandValue = 50; // set the maximum operand value for Hard mode
                SpeedCounting.MinOperandValue = -50; // set the minimum operand value for Hard mode
            }
            else if (CheckListBox_Difficulty.CheckedItems.Contains("insane"))
            {
                currentGameMode = GameMode.Insane;
                SpeedCounting.MaxOperandValue = 100; // set the maximum operand value for Insane mode
                SpeedCounting.MinOperandValue = -100; // set the minimum operand value for Insane mode
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
            Button_Start.Enabled = true; // enable the start button
            Timer_GameTimer.Stop(); // stop the game timer
            TextBox_Answer.BackColor = Color.White;
            // MISSING REWARD HANDLING
        }

        private void CheckAnswer()
        {
            if (int.TryParse(TextBox_Answer.Text, out int answer))
            {
                if (CurrentEquation.Solution == answer)
                {
                    HandleGoodAnswer();
                    return;
                }
            }
            HandleBadAnswer();
            
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

        public event EventHandler ReturnSelected;
        private void returnButton_Click(object sender, EventArgs e)
        {
            ReturnSelected?.Invoke(this, EventArgs.Empty);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }

}
