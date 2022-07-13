namespace C_Sharp_Fundamentals_Project
{
    internal class WorkingWithFiles
    {
        //Simple function that checks if file exists, if not it will be created
        public static void Exist(string path)
        {
            if (!File.Exists(path))
            {
                File.CreateText(path);
                Console.WriteLine("File was created");
            }
            else
            {
                Console.WriteLine("File existed");
            }
        }
        //Function that adds given text to a given text file.
        public static void Append(string path,string text)
        {
            using(StreamWriter sw = File.AppendText(path))
            {
                sw.Write(text);
            }
        }
        //Function that reads file
        public static string ReadText(string path)
        {
            return File.ReadAllText(path);
        }
        //Function that clear file
        public static void ClearText(string path)
        {
            File.WriteAllText(path, String.Empty);
        }
    }
}
