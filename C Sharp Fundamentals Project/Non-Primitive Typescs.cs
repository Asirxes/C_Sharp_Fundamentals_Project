namespace C_Sharp_Fundamentals_Project
{

    internal class Non_Primitive_Typescs
    {
        private enum Average
        {
            BelowAverage,
            Average,
            OverAverage
        }
        //The class is responsible for generating 100 random
        //integers from the range 0-100, selecting the smallest of them
        //(the number provided by the user) and returning the value based on the average of the smallest numbers using enum
        public static int Smallests(int amount)
        {
            
            List<int> smallests = new List<int>();
            int[] randomInts = new int[100];
            Random rnd = new Random();
            for (int i = 0; i < 100; i++)
            {
                randomInts[i] = rnd.Next(101);
            }
            for (int i = 0; i < amount; i++)
            {
                smallests.Add(randomInts.Min());
                randomInts[Array.IndexOf(randomInts, randomInts.Min())] = 101;
            }
            int sum = 0;
            for(int i = 0; i < smallests.Count; i++)
            {
                sum += smallests[i];
            }
            double average = sum / smallests.Count;
            if(average < 33)
            {
                return (int)Average.BelowAverage;
            }else if(average > 33 && average < 66)
            {
                return (int)Average.Average;
            }
            return (int)Average.OverAverage;
        }
    }
}
