using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace losos
{
    /// <summary>
    /// wrapper over delegate for getter of a property given
    /// </summary>
    public class Mirror
    {
        private Func<int> getter;

        public Mirror(Func<int> getFunc)
        {
            getter = getFunc;
        }
        public int Value
        {
            get => getter();
        }
    }
    /// <summary>
    /// wrapper over the background and foreground panels of the progress bar, used to display the progress bar in a panel.
    /// </summary>
    public class MeterDisplayer
    {
        public Panel BackgroundPanel { get; set; }
        public Panel BarPanel { get; set; }
        public Mirror Mirror { get; set; } // used to get the value of the progress bar
        public int Max { get; set; } = 100; // default max value for the progress bar

        public MeterDisplayer(Panel panel, Panel barPanel, Mirror mirrorValue)
        {
            BackgroundPanel = panel;
            BarPanel = barPanel;
            Mirror = mirrorValue;
        }
        public MeterDisplayer(Panel panel, Panel barPanel, Mirror mirrorValue, int max)
        {
            BackgroundPanel = panel;
            BarPanel = barPanel;
            Mirror = mirrorValue;
            Max = max;
        }
    }
}
