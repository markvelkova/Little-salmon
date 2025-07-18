using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomControlsLibrary
{
    /// <summary>
    /// My own button class used everywhere
    /// </summary>
    public class MyButton : Button
    {
        public MyButton()
        {
            this.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowOnly;
        }
    }
}
