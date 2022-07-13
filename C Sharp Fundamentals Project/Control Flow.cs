namespace C_Sharp_Fundamentals_Project
{
    internal class Control_Flow
    {
        //Class that writes values to the list
        public static List<int> FizzBuzz(int amount)
        {
            List<int> list = new List<int>();
            for (int i = 1; i < amount + 1; i++)
            {
                list.Add(i);
            }
            return list;
        }
    }
}
