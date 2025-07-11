using System;
using System.Drawing;


namespace games
{
    public static class Clicker
    {
        public static double CalculateClickReward(Color color, int maxReward)
        {
            return (color.R + color.G + color.B) / 3.0 / 255 * maxReward;
        }
    }
}
