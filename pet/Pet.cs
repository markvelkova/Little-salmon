using System.Text.Json;
using System.Text.Json.Serialization;

namespace pet
{
    /// <summary>
    /// Pet is the key compomenent
    /// has these internal stats - stomach fullness, energy, mood
    /// can die if critical region of stats is reached
    /// can be saved into a file
    /// </summary>
    public class Pet
    {
        public string Name { get; set; }
        public int FoodCount { get; set; }
        public int HungerMeter { get; private set; }
        // optimal value is 100, more cannot be rached, results in mood drop
        public int EnergyMeter { get; private set; }
        // full is 100, cannot be more
        //[JsonInclude]
        public int MoodMeter { get; private set; }
        // full is 100, cannot be more
        
        // feeding parameters
        public enum FeedingResult { Fell, Successful, NoFood }
        private int _foodFellChance = 5;
        private int _minFoodFed = 1;
        private int _maxFoodFed = 4;
        private Random rnd = new Random();
        
        // life parameters
        public enum LifeStates { Awake, Asleep, Dead };
        public LifeStates LifeState { get; set; }

        //creates new pet
        public Pet() 
        {
            Name = "Give me a name :(";
            FoodCount = 0;
            HungerMeter = 50;
            EnergyMeter = 100;
            MoodMeter = 20;
            LifeState = LifeStates.Awake;
        }

        //creates pet from file
        public Pet(string filename) => throw new NotImplementedException();

        #region serialization and deserialization
        public string SerializePet()
        {
            string json = JsonSerializer.Serialize(this, new JsonSerializerOptions { WriteIndented = true });
            return json;
        }

        public static Pet DeserializeFromJson(string json)
        {
            Pet pet;
            try
            {
                pet = JsonSerializer.Deserialize<Pet>(json);
            }
            catch (Exception e)
            {
                throw new PetDeserializationException("Invalid pet json given.", e);
            }
            if (pet == null)
                throw new PetDeserializationException("Empty pet json given.");
            return pet;
        }
        #endregion

        #region feeding
        public FeedingResult TryFeed()
        {
            if (FoodCount == 0)
                return FeedingResult.NoFood;
            int fallResult = rnd.Next(100);
            if (fallResult <= _foodFellChance)
                return FeedingResult.Fell;
            return FeedingResult.Successful;
        } 
        private void Feed()
        {
            int amount = rnd.Next(_minFoodFed,_maxFoodFed);
            HungerMeter += amount;
        }
        #endregion

        public void CheckIfShouldLive()
        {
             
        }

        public void Update() 
        {

        }
    }
}
