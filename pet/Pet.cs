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


        public bool PlayingGames = false;
        private int _lifeTicks;
        private int _hungerPointDuration = 8;
        private int _energyPointDuration = 5;
        private int _moodPointDuration = 5;

        // dirty stuff
        public bool IsDirty { get; private set; }
        private int _ticksSinceDirty = 0; // how many ticks since the pet was dirty, used to update the dirty state of the pet
        private int _minCleanReward = 5;
        private int _maxCleanReward = 12;



        private int _hungerMeter;
        [JsonInclude]
        public int HungerMeter
        {
            get => _hungerMeter;
            internal set => _hungerMeter = Math.Max(0, Math.Min(100, value));
        }

        private int _energyMeter;
        [JsonInclude]
        public int EnergyMeter
        {
            get => _energyMeter;
            internal set => _energyMeter = Math.Max(0, Math.Min(100, value));
        }

        private int _moodMeter;
        [JsonInclude]
        public int MoodMeter
        {
            get => _moodMeter;
            internal set => _moodMeter = Math.Max(0, Math.Min(100, value));
        }

        // feeding parameters
        public enum FeedingResult { Fell, Successful, TooMuch, NoFood }
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
        /// <summary>
        /// Tries to feed the pet and if successful, performs the feeding or overfeeding action.
        /// </summary>
        /// <returns>
        /// FeedingResult.NoFood if no food
        /// FeedingResult.Fell if it fell
        /// FeedingReslut.Successful if it was fed successfully, in this case it feeds!!!
        /// </returns>
        public FeedingResult TryFeed()
        {
            // we had no food - nothing happens
            if (FoodCount == 0)
                return FeedingResult.NoFood;

            // we had food, but it fell - nothing happens
            int fallResult = rnd.Next(100);
            if (fallResult <= _foodFellChance)
                return FeedingResult.Fell;

            // we gave it food, but it was too much - mood went down
            if (HungerMeter >= 100)
            {
                FoodCount -= 1; // we used one food item
                OverFeed();
                _ticksSinceDirty++;
                return FeedingResult.TooMuch;
            }
            // we gave it food successfully, while it was hungry
            else
            {
                FoodCount -= 1; // we used one food item
                Feed();
                _ticksSinceDirty++;
                return FeedingResult.Successful;
            }  
        }

        /// <summary>
        /// Does the feeding itself, randomly choses the amount of food fed to the pet and increases  the hunger meter by that amount.
        /// </summary>
        private void Feed()
        {
            int amount = rnd.Next(_minFoodFed,_maxFoodFed);
            HungerMeter += amount;
        }
        private void OverFeed()
        {
            int amount = rnd.Next(_minFoodFed, _maxFoodFed);
            BeSad(amount); // overfeeding makes the pet sad
        }
        #endregion


        #region mood
        public void BeHappier(int amount)
        {
            MoodMeter += amount;
        }
        public void BeSad(int amount)
        {
            MoodMeter -= amount;
        }
        #endregion


        #region adding food
        /// <summary>
        /// Adds or substracts food to the pet's food count, cap on 0
        /// </summary>
        public void AddFood(int amount)
        {
            FoodCount += amount;
            if (FoodCount < 0) FoodCount = 0; // cap at 0
        }
        #endregion

        #region sleeping
        /// <summary>
        /// sets life state to asleep, which means the pet is sleeping and its energy meter will go up
        /// </summary>
        public void Sleep()
        {
            LifeState = LifeStates.Asleep;
        }
        /// <summary>
        /// sets life state to awake, which means the pet is awake and its energy meter will go down
        /// </summary>
        public void WakeUp()
        {
            LifeState = LifeStates.Awake;
        }

        #endregion

        private void CheckIfShouldLive()
        {
            if (HungerMeter <= 0 || EnergyMeter <= 0 || MoodMeter <= 0)
            {
                LifeState = LifeStates.Dead;
            }
        }

        private void UpdateMoodAwake()
        {
            if (_lifeTicks % _moodPointDuration == 0)
            {
                // mood goes up by 3 if playing games, otherwise it goes down by 1
                if (PlayingGames)
                    MoodMeter += 3; // every x seconds, mood goes up by 3 if playing games
                else
                    MoodMeter -= 1; // every x seconds, mood goes down by 1
            }
        }
        private void UpdateHungerAwake()
        {
            if (_lifeTicks % _hungerPointDuration == 0)
                HungerMeter -= 1; // every x seconds, hunger goes down by 1
        }
        private void UpdateEnergyAwake()
        {
            if (_lifeTicks % _energyPointDuration == 0)
                EnergyMeter -= 1; // every x seconds, energy goes down by 1
        }
        private void UpdateEnergyAsleep()
        {
            if (_lifeTicks % _energyPointDuration == 0)
                EnergyMeter += 2; // every x seconds, energy goes up by 2 while sleeping
        }

        private void UpdateDirty()
        {
            if (!IsDirty)
            {
                _ticksSinceDirty++;
                int prob = rnd.Next(_ticksSinceDirty, 120);
                if (prob >= 110)
                {
                    IsDirty = true;
                    _ticksSinceDirty = 0; // reset the dirty ticks counter
                }
                else
                {
                    IsDirty = false;
                }
            }
        }

        public void Clean()
        {
            FoodCount += rnd.Next(_minCleanReward, _maxCleanReward);
            IsDirty = false;
        }

        public void Update()
        {
            _lifeTicks++;
            switch (LifeState)
            {
                case LifeStates.Awake:
                        UpdateEnergyAwake();
                        UpdateHungerAwake();
                        UpdateMoodAwake();
                    break;
                case LifeStates.Asleep:
                    if (EnergyMeter >= 100) // in this case the pet doesn't need to sleep anymore and starts to feel hunger and bad mood again
                    {
                        UpdateHungerAwake();
                        UpdateMoodAwake();
                    }
                    else 
                        UpdateEnergyAsleep();
                    break;
                case LifeStates.Dead:
                    return; // no updates for dead pets, no more checking???
            }
            UpdateDirty();
            CheckIfShouldLive();
        }
    }
}
