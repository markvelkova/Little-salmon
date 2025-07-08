using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using pet;

namespace losos
{
    public partial class UCMain : UserControl
    {
        public event EventHandler GamesButtonClicked;
        public UCMain()
        {
            InitializeComponent();
            this.BackColor = MainForm.MyDefaultBackColor;
            UpdatePetStatusDisplay();
        }

        /// <summary>
        /// Updates the pet's status display with current values from the pet object.
        /// </summary>
        private void UpdatePetStatusDisplay()
        {
            Label_Name.Text = MainForm.thePet.Name;
            SetProgressBarValue(ProgressBar_Energy, MainForm.thePet.EnergyMeter);
            SetProgressBarValue(ProgressBar_Mood, MainForm.thePet.MoodMeter);
            SetProgressBarValue(ProgressBar_Hunger, MainForm.thePet.HungerMeter);
        }

        /// <summary>
        /// adjusts the progress bar value and color based on the given value.
        /// </summary>
        /// <param name="progressBar"></param>
        /// <param name="value"></param>
        private void SetProgressBarValue(ProgressBar progressBar, int value)
        {
            if (value < 0) 
                value = 0;
            else if (value < 15)
                progressBar.ForeColor = Color.Red;
            else if (value < 30)
                progressBar.ForeColor = Color.Orange;
            else if (value < 50)
                progressBar.ForeColor = Color.Yellow;
            else 
                progressBar.ForeColor = Color.Green;
            if (value > 100) value = 100;
            progressBar.Value = value;
        }
        private void button_GamesButton_Click(object sender, EventArgs e)
        {
            GamesButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
