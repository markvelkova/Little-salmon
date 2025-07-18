using System;
using System.Drawing;
using System.Windows.Forms;

namespace CustomControls
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
