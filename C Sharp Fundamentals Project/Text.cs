using System.Text;

namespace C_Sharp_Fundamentals_Project
{
    internal class Text
    {
        public static string ToCamelCase(string input)
        {
            //Simple function that is using string builder to easily build CamelSace words
            StringBuilder result = new StringBuilder();
            string[] words = input.Split(' ');
            foreach(string word in words)
            {
                result.Append(word[0].ToString().ToUpper() + word.Substring(1).ToLower());
            }
            return result.ToString();
        }
    }
}
