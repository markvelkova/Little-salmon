﻿namespace Games
{
    /// <summary>
    /// this is the classic game of heads or tails
    /// the fairness of the coin can be mended
    /// </summary>
    
    public static class Game_HeadsOrTails
    {
        public enum CoinOptions { Empty, Heads, Tails };
        private static Random random = new Random();
        private static int inclinationTowardsHeads = 50; // 0-100, the coin may be unfair, 80 mans 80% chance of heads
        public static CoinOptions FlipTheCoin()
        {
            // simulation of the coin toss
            int coinToss = random.Next(0, 100);
            bool wasHeads = coinToss < inclinationTowardsHeads; // if coinToss is less than inclination, it was heads
            // return true if the guess was correct
            if (wasHeads)
                return CoinOptions.Heads;
            else
                return CoinOptions.Tails;
        }
        public static void ResetFairness()
        {
            inclinationTowardsHeads = 50;
        }
        public static void SetRandomFairness()
        {
            inclinationTowardsHeads = random.Next(0, 100);
        }
    }
}
