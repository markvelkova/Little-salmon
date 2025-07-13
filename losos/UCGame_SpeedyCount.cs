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
        public UCGame_SpeedyCount()
        {
            InitializeComponent();
            this.BackColor = MainForm.MyDefaultBackColor; // set the background color to the default one
            ResetEquationLabel();
        }

        #region equation label
        private void displayEquation(SpeedCounting.IEquation equation)
        {
            // display the equation in the label
            Label_Equation.Text = equation.EquationString;
            CenterTheLabel(Label_Equation);
        }

        /// <summary>
        /// centers the label in the parent control
        /// </summary>
        /// <param name="label"></param>
        private void CenterTheLabel(Label label)
        {
            // center the label in the parent control
            label.Left = (this.Width - label.Width) / 2;
            label.Top = (this.Height - label.Height) / 2;
        }

        /// <summary>
        /// reset the equation label to default text
        /// </summary>
        private void ResetEquationLabel()
        {
            Label_Equation.Text = equationLabelDefaultText; 
        }
        #endregion
        
        private void button_GiveEquation_Click(object sender, EventArgs e)
        {
            // generate a new equation with a random number of operands
            Random rnd = new Random();
            int numberOfOperands = rnd.Next(SpeedCounting.SimpleEquation.MinOperands, SpeedCounting.SimpleEquation.MaxOperands + 1);
            SpeedCounting.SimpleEquation equation = new SpeedCounting.SimpleEquation(numberOfOperands);
            displayEquation(equation); // display the generated equation
        }

        public event EventHandler ReturnSelected;
        private void returnButton_Click(object sender, EventArgs e)
        {
            ReturnSelected?.Invoke(this, EventArgs.Empty);
        }
    }

}
