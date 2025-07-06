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
        public UCGames()
        {
            InitializeComponent();
        }
        private void button_FlipACoin_Click(object sender, EventArgs e)
        {
            FlipACoinSelected?.Invoke(this, EventArgs.Empty);
        }
        private void button_Return_Click(object sender, EventArgs e)
        {
            ReturnSelected?.Invoke(this, EventArgs.Empty);
        }
    }
}
