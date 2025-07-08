namespace stats
{
    public class Stats
    {
        public Dictionary<string, int> StatsDict { get; set; }
        private Dictionary<string, int> DefaultStatsDict = new Dictionary<string, int>
        {
            { "Coins flipped", 0 },
            { "Lucky coin guesses", 0 },
            { "Food units fed", 0 },
            { "Food units fell", 0 }
        };
        public Stats()
        {
            StatsDict = new Dictionary<string, int>();
            SetAllDefault();
        }

        public void AdjustStat(string name, int value)
        {
            if (StatsDict.ContainsKey(name))
                StatsDict[name] += value;
            else 
                StatsDict.Add(name, value);
        }

        public void SetAllDefault()
        {
            foreach (string key in DefaultStatsDict.Keys)
            {
                if (StatsDict.ContainsKey(key))
                    StatsDict[key] = DefaultStatsDict[key];
                else
                    StatsDict.Add(key, DefaultStatsDict[key]);
            }
        }
    }
}
