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
    public partial class UCIntro : UserControl
    {
        public event EventHandler StartNewGameClicked;

        public UCIntro()
        {
            InitializeComponent();
        }
        

        private void btnStartNewGame_Click(object sender, EventArgs e)
        {
            StartNewGameClicked?.Invoke(this, EventArgs.Empty);
        }
    }
}
