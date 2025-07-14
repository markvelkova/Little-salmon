using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace losos
{
    public partial class UCGames : UserControl
    {
        public event EventHandler ReturnSelected;
        public event EventHandler FlipACoinSelected;
        public event EventHandler StarrySkySelected;
        public event EventHandler SpeedyCountSelected;
        public UCGames()
        {
            InitializeComponent();
            this.BackColor = MainForm.MyDefaultBackColor;
        }
        private void button_FlipACoin_Click(object sender, EventArgs e)
        {
            FlipACoinSelected?.Invoke(this, EventArgs.Empty);
        }
        private void button_Return_Click(object sender, EventArgs e)
        {
            ReturnSelected?.Invoke(this, EventArgs.Empty);
        }
        private void button_StarrySky_Click(object sender, EventArgs e)
        {
            StarrySkySelected?.Invoke(this, EventArgs.Empty);
        }
        private void button_SpeedyCount_Click(object sender, EventArgs e)
        {
            SpeedyCountSelected?.Invoke(this, EventArgs.Empty);
        }
    }
}
