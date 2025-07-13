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

        private enum GameMode { Easy, Medium, Hard, Insane };

        public UCGame_SpeedyCount()
        {
            InitializeComponent();
            this.BackColor = MainForm.MyDefaultBackColor; // set the background color to the default one
            ResetEquationLabel();
            CenterControlHorizontally(TextBox_Answer); // center the answer text box horizontally
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

        /// <summary>
        /// generate equation and display it in the label
        /// </summary>
        private void GenerateNewEquation()
        {
            CurrentEquation = new SpeedCounting.SimpleEquation();
            displayEquation(CurrentEquation); // display the generated equation
        }

        private void textBox_Answer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.SuppressKeyPress = true; // prevent the OBNOXIOUS beep sound on Enter key press
                CheckAnswer();
                GenerateNewEquation(); // generate a new equation after checking the answer
            }
        }

        private void Button_Start_Click(object sender, EventArgs e)
        {
            StartGame();
        }

        private void StartGame()
        {
            GenerateNewEquation(); // generate a new equation
            TextBox_Answer.Text = ""; // clear the answer text box
            TextBox_Answer.Focus(); // set focus to the answer text box
            Button_Start.Enabled = false;
        }

        private void EndGame()
        {
            Button_Start.Enabled = true; // enable the start button
            ///MISSING REWARD HANDLING
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

        #region rewards
        private void HandleGoodAnswer()
        {
            
        }
        private void HandleBadAnswer()
        {
            
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
