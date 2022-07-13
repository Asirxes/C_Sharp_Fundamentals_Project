namespace C_Sharp_Fundamentals_Project
{
    internal class Dates
    {
        public static double[] DatesIntoNumbers(DateTime date1,DateTime date2)
        {
            //Simple function appending array with data
            double[] result = new double[4];
            result[0] = Math.Abs((date1 - date2).TotalDays);
            result[1] = Math.Abs((date1 - date2).TotalHours);
            result[2] = Math.Abs((date1 - date2).TotalMinutes);
            result[3] = Math.Abs((date1 - date2).TotalSeconds);
            return result;
        }
    }
}
