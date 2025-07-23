using System.Text.Json;

namespace Stats
{
    public class Stats
    {
        public Dictionary<string, int> StatsDict { get; set; }
        private Dictionary<string, int> DefaultStatsDict = new Dictionary<string, int>
        {
            { "Seconds slept", 0 },
            { "Food units fed", 0 },
            { "Food units fell", 0 },
            { "Excrement disposed", 0 },
            { "Coins flipped", 0 },
            { "Lucky coin guesses", 0 },
            { "Starry sky clicked", 0 },
            { "Starry sky reward record", 0 },
            { "Starry sky clicks record", 0 },
            { "SpeedyCount easy record", 0 },
            { "SpeedyCount easy played", 0 },
            { "SpeedyCount easy correct", 0 },
            { "SpeedyCount easy total incorrect", 0 },
            { "SpeedyCount easy almost correct", 0 },
            { "SpeedyCount easy ten away", 0 },
            { "SpeedyCount easy invalid", 0 },
            { "SpeedyCount medium record", 0 },
            { "SpeedyCount medium played", 0 },
            { "SpeedyCount medium correct", 0 },
            { "SpeedyCount medium total incorrect", 0 },
            { "SpeedyCount medium almost correct", 0 },
            { "SpeedyCount medium ten away", 0 },
            { "SpeedyCount medium invalid", 0 },
            { "SpeedyCount hard record", 0 },
            { "SpeedyCount hard played", 0 },
            { "SpeedyCount hard correct", 0 },
            { "SpeedyCount hard total incorrect", 0 },
            { "SpeedyCount hard almost correct", 0 },
            { "SpeedyCount hard ten away", 0 },
            { "SpeedyCount hard invalid", 0 },
            { "SpeedyCount insane record", 0 },
            { "SpeedyCount insane played", 0 },
            { "SpeedyCount insane correct", 0 },
            { "SpeedyCount insane total incorrect", 0 },
            { "SpeedyCount insane almost correct", 0 },
            { "SpeedyCount insane ten away", 0 },
            { "SpeedyCount insane invalid", 0 },
            { "Snake food eaten", 0 },
            { "Snake record", 0 }
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
        public void AdjustSpeedyCountStat(string difficulty, string statDetail, int value)
        {
            string statName = GetSpeedyStatName(difficulty, statDetail);
            AdjustStat(statName, value);
        }

        public string GetSpeedyStatName(string difficulty, string statDetail)
        {
            return $"SpeedyCount {difficulty} {statDetail}";
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
