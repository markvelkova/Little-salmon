using System.Text.Json;

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
            { "Food units fell", 0 },
            { "Starry sky clicked", 0 },
            { "Starry sky reward record", 0 },
            { "Starry sky clicks record", 0 }
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

        public int GetStat(string name)
        {
            if (StatsDict.ContainsKey(name))
                return StatsDict[name];
            else
                return 0;
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

        public static Stats DeserializeFromJson(string json)
        {
            Stats stats;
            try
            {
                stats = JsonSerializer.Deserialize<Stats>(json);
            }
            catch (Exception e)
            {
                throw new StatsDeserializationException("Invalid stats json given.", e);
            }
            if (stats == null)
                throw new StatsDeserializationException("Empty stats json given.");
            return stats;
        }
    }
}
