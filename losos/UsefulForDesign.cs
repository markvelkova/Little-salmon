using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace losos
{
    public static class UsefulForDesign
    {
        /// <summary>
        /// centers the control in the parent control
        /// </summary>
        /// <param name="control"></param>
        public static void CenterControl( Control control)
        {
            CenterControlHorizontally(control);
            CenterControlVertically(control);
        }

        public static void CenterControlHorizontally(Control control)
        {
            // center the label horizontally in the parent control
            control.Left = (control.Parent.Width - control.Width) / 2;
        }
        public static void CenterControlVertically(Control control)
        {
            // center the label vertically in the parent control
            control.Top = (control.Parent.Height - control.Height) / 2;
        }
    }
}