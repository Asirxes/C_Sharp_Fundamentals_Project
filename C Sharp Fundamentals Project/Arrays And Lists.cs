namespace C_Sharp_Fundamentals_Project
{
    internal class Arrays_And_Lists
    {
        public static void Posts()
        {
            //A function with which we can add, delete, show and modify posts in the list
            string input;
            List<string> posts = new List<string>();
            int index;
            while (true)
            {
                Console.Write("Please select what you want to do (Add , Delete, Modify, Show, Quit): ");
                input = Console.ReadLine();
                if (String.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("Enter valid value!");
                    continue;
                }
                if (input[0].ToString().ToUpper() + input.Substring(1).ToLower() == "Add")
                {
                    Console.Write("What do you want to Add: ");
                    input = Console.ReadLine();
                    while (true)
                    {
                        if (String.IsNullOrWhiteSpace(input))
                        {
                            Console.WriteLine("Enter valid value!");
                            continue;
                        }
                        posts.Add(input);
                        break;
                    }

                }
                if (input[0].ToString().ToUpper() + input.Substring(1).ToLower() == "Delete")
                {
                    Console.Write("What do you want to delete: ");
                    input = Console.ReadLine();
                    while (true)
                    {
                        if (String.IsNullOrWhiteSpace(input))
                        {
                            Console.WriteLine("Enter valid value!");
                            continue;
                        }
                        if (!posts.Remove(input))
                        {
                            Console.WriteLine("There is no such a post in a list!");
                            break;
                        }
                        break;
                    }
                }
                if (input[0].ToString().ToUpper() + input.Substring(1).ToLower() == "Show")
                {
                    if (!posts.Any())
                    {
                        Console.WriteLine("There is no posts right now!");
                        continue;
                    }
                    for (int i = 0; i < posts.Count; i++)
                    {
                        Console.WriteLine(posts[i]);
                    }
                }
                if (input[0].ToString().ToUpper() + input.Substring(1).ToLower() == "Modify")
                {
                    while (true)
                    {
                        Console.Write("What do you want to modify: ");
                        input = Console.ReadLine();
                        if (String.IsNullOrWhiteSpace(input))
                        {
                            Console.WriteLine("Enter valid value!");
                            continue;
                        }
                        index = posts.IndexOf(input);
                        if (!posts.Remove(input))
                        {
                            Console.WriteLine("There is no such a post in a list!");
                            break;
                        }
                        Console.Write("What do you want to modify to: ");
                        input = Console.ReadLine();
                        if (String.IsNullOrWhiteSpace(input))
                        {
                            Console.WriteLine("Enter valid value!");
                            continue;
                        }
                        posts.Insert(index,input);
                        break;
                    }

                }
                if (input[0].ToString().ToUpper() + input.Substring(1).ToLower() == "Quit")
                {
                    break;
                }
            }
        }
    }
}
