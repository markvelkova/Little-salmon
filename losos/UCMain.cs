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
    public partial class UCMain : UserControl
    {
        public event EventHandler GamesButtonClicked;
        public UCMain()
        {
            InitializeComponent();
        }
        private void button_GamesButton_Click(object sender, EventArgs e)
        {
            GamesButtonClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
