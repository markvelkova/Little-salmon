using Pet;
using Stats;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace LittleSalmon
{
    public class SerializationUnit
    {
        public Pet.Pet pet { get; set; }
        public Stats.Stats stats { get; set; }
        public SerializationUnit(Pet.Pet pet, Stats.Stats stats)
        {
            this.pet = pet;
            this.stats = stats;
        }
        public SerializationUnit(string json)
        {
            using var doc = JsonDocument.Parse(json);
            var root = doc.RootElement;

            string petJson = root.GetProperty("pet").GetRawText();
            string statsJson = root.GetProperty("stats").GetRawText();

            pet = Pet.Pet.DeserializeFromJson(petJson);
            stats = Stats.Stats.DeserializeFromJson(statsJson);
        }
        public string SerializeToJson()
        {
            string json = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
            return json;
        }
    }
}
