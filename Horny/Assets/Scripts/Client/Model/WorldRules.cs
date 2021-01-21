namespace Client.Model
{
    public class WorldRules
    {
        public int FirstStarScore;
        public int SecondStarScore;
        public int ThirdStarScore;
        public int SwipeCount;

        public WorldRules(World world)
        {
            FirstStarScore = world.WorldObject.FirstStarScore; 
            SecondStarScore = world.WorldObject.SecondStarScore; 
            ThirdStarScore = world.WorldObject.ThirdStarScore; 
            SwipeCount = world.WorldObject.SwipeCount; 
        }

        public int GetStarByScore(int score)
        {
            if (score >= ThirdStarScore)
                return 3;
            if (score >= SecondStarScore)
                return 2;
            if (score >= FirstStarScore)
                return 1;
            return 0; 
        }
    }
}