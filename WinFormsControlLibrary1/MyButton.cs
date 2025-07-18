using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinFormsControlLibrary1
{
    [System.ComponentModel.DesignerCategory("Code")]
    public class MyButton : Button
    {
        public MyButton()
        {
            //this.Font = new Font("Bahnschrift", 12F, FontStyle.Regular, GraphicsUnit.Point, 238);
            this.AutoSize = true;
            this.AutoSizeMode = AutoSizeMode.GrowOnly;
        }
    }
}
