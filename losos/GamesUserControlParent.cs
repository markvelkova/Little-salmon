using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinFormsControlLibrary1;

namespace losos
{
    public partial class GamesUserControlParent : UserControl
    {
        public event EventHandler? ReturnSelected;

        protected void returnButton_Click(object sender, EventArgs e)
        {
            ReturnSelected?.Invoke(this, EventArgs.Empty);
        }

    }
}
