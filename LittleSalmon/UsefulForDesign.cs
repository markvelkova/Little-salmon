using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LittleSalmon
{
    public static class UsefulForDesign
    {
        /// <summary>
        /// centers the control in the parent control
        /// </summary>
        /// <param name="control"></param>
        public static void CenterControl(Control control)
        {
            CenterControlHorizontally(control);
            CenterControlVertically(control);
        }

        /// <summary>
        /// Center the control in its parent control horizontally. Raises InvalidOperationException if the control has no parent.
        /// </summary>
        /// <param name="control"></param>
        /// <exception cref="InvalidOperationException"></exception>
        public static void CenterControlHorizontally(Control control)
        {
            // center the label horizontally in the parent control
            if (control.Parent == null)
                throw new InvalidOperationException("Control must have a parent to be centered.");
            control.Left = (control.Parent.Width - control.Width) / 2;
        }
        /// <summary>
        /// Center the control in its parent control vertically. Raises InvalidOperationException if the control has no parent.
        /// </summary>
        /// <param name="control"></param>
        /// <exception cref="InvalidOperationException"></exception>
        public static void CenterControlVertically(Control control)
        {
            // center the label vertically in the parent control
            if (control.Parent == null)
                throw new InvalidOperationException("Control must have a parent to be centered.");
            control.Top = (control.Parent.Height - control.Height) / 2;
        }
    }
}