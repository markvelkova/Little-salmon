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
        private int HungerMeter { get; set; }
        // optimal value is 100, more can be, but is bad

        private int EnergyMeter { get; set; }
        // full is 100, cannot be more
        private int MoodMeter { get; set; }
        // full is 100, cannot be more
        public enum FeedingResult { Fell, Successful, NoFood }
        private int _foodFellChance = 5;
        private int _minFoodFed = 1;
        private int _maxFoodFed = 4;
        private Random rnd = new Random();


        //creates new pet
        public Pet() 
        {
            Name = "Give me a name :(";
            FoodCount = 0;
            HungerMeter = 50;
            EnergyMeter = 100;
            MoodMeter = 20;
        }

        //creates pet from file
        public Pet(string filename) => throw new NotImplementedException();

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
    }
}
