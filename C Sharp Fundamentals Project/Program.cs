//This project shows the author's basic C # skills
namespace C_Sharp_Fundamentals_Project
{
    public class Program
    {
        public static void Main(string[] args)
        {
            ////----------------------------------------------------Primitive Types And Expressions-------------------------------------------------------------------
            ////Main function that let's user enter value, validate them and then shows a result of chosen mathematical action
            //string userInput = "";
            //double firstNumber;
            //double secondNumber;
            //string operation = "";
            //while (userInput != "exit")
            //{
            //    Console.Write("Please enter a first number or type \"exit\" to exit program: ");
            //    userInput = Console.ReadLine();
            //    if (userInput == "exit")
            //    {
            //        continue;
            //    }
            //    else if (!double.TryParse(userInput, out firstNumber))
            //    {
            //        continue;
            //    }
            //    userInput = "";
            //    while (!(userInput == "+" || userInput == "-" || userInput == "*" || userInput == "/"))
            //    {
            //        Console.Write("Pleas enter a operation to do (+ to Addition, - to Subtraction, * to Multiplication, / to Division) or exit to exit a program: ");
            //        userInput = Console.ReadLine();
            //        if (userInput == "exit")
            //        {
            //            break;
            //        }
            //    }
            //    if (userInput == "exit")
            //    {
            //        continue;
            //    }
            //    operation = userInput;
            //    userInput = "";
            //    while (!double.TryParse(userInput, out secondNumber))
            //    {
            //        Console.Write("Please enter a second number or type \"exit\" to exit program: ");
            //        userInput = Console.ReadLine();
            //        if (userInput == "exit")
            //        {
            //            break;
            //        }
            //    }
            //    if (userInput == "exit")
            //    {
            //        continue;
            //    }

            //    if (secondNumber == 0 && userInput == "/")
            //    {
            //        Console.WriteLine("You're trying to divide by 0! Please start from the beggining and follow mathematical rules!");
            //        continue;
            //    }
            //    Console.WriteLine("Result: " + Primitive_Types_And_Expressions.Calculator(firstNumber, secondNumber, operation));


            //}
            ////------------------------------------------Non-Primitive Types---------------------------------------------------------------------------------------
            ////The main function gets and validates the number of items and displays the return value
            //int input;
            //while (true)
            //{
            //    Console.Write("Please enter a number beetween a 1 and 100: ");
            //    if (Int32.TryParse(Console.ReadLine(), out input))
            //    {
            //        if (input > 0 && input < 100)
            //        {
            //            Console.WriteLine(Non_Primitive_Typescs.Smallests(input));
            //            break;
            //        }
            //    }
            //    Console.WriteLine("Entered Invalid number! Please follow the rules!");
            //}
            ////-----------------------------------------------------------------------Control Flow----------------------------------------------------------------------
            ////Classic fizzbuzz program with a function that writes numbers to lists
            //int input;

            //while (true)
            //{
            //    Console.Write("Please enter a number greater than 0: ");
            //    if (Int32.TryParse(Console.ReadLine(), out input))
            //    {
            //        if (input > 0)
            //        {
            //            break;
            //        }
            //    }
            //    Console.WriteLine("Entered Invalid number! Please follow the rules!");
            //}
            //List<int> list = Control_Flow.FizzBuzz(input);
            //for (int i = 0; i < list.Count; i++)
            //{
            //    if (list[i] % 3 == 0 && list[i] % 5 == 0)
            //    {
            //        Console.WriteLine("FizzBuzz");
            //    }
            //    else if (list[i] % 3 == 0)
            //    {
            //        Console.WriteLine("Fizz");
            //    }
            //    else if (list[i] % 5 == 0)
            //    {
            //        Console.WriteLine("Buzz");
            //    }
            //    else
            //    {
            //        Console.WriteLine(list[i]);
            //    }
            //}
            ////--------------------------------------------------------Arrays and Lists------------------------------------------------------------------------
            ////Simple function call
            //Arrays_And_Lists.Posts();
            ////-------------------------------------------------------------Working with Dates-----------------------------------------------------------------
            ////The function gets and validates two dates from the user and then gives the difference between them in days, hours, minutes and seconds.
            //DateTime date1 = new DateTime();
            //while (true)
            //{
            //    Console.Write(@"Please enter first date time in DD/MM/YYYY HH:MM:SS format: ");   
            //    if(DateTime.TryParse(Console.ReadLine(),out date1))
            //    {
            //        break;
            //    };
            //    Console.WriteLine("Please enter a date in valid format!");
            //}
            //DateTime date2 = new DateTime();
            //while (true)
            //{
            //    Console.Write(@"Please enter second date time in DD/MM/YYYY HH:MM:SS format: ");
            //    if (DateTime.TryParse(Console.ReadLine(), out date2))
            //    {
            //        break;
            //    };
            //    Console.WriteLine("Please enter a date in valid format!");
            //}
            //double[] result = Dates.DatesIntoNumbers(date1, date2);
            //Console.WriteLine("Time span in days: " + result[0]);
            //Console.WriteLine("Time span in hours: " + result[1]);
            //Console.WriteLine("Time span in minutes: " + result[2]);
            //Console.WriteLine("Time span in seconds: " + result[3]);
            ////--------------------------------------------------------------Working with Text-----------------------------------------------
            ////A simple program that converts words separated by a space into CamelCase word
            //Console.Write("Please enter a few words separated by space to make camel case value: ");
            //string input = Console.ReadLine();
            //Console.WriteLine(Text.ToCamelCase(input));
            //----------------------------------------------------------------------Working with Files---------------------------------
            //The program will ask the user if he wants to overwrite the file, clean it or display it.
            //The user will also provide the location of the file, if it does not exist, it will be created.
            Console.Write("Please enter a path of the file: ");
            string path = Console.ReadLine();
            WorkingWithFiles.Exist(path);
            string input = "";
            string input2 = "";
            while (true)
            {
                Console.Write("What you want to do? Add(Add to text file), Read(Read file), Clear(Clear file) or Quit(Quit Program): ");
                input = Console.ReadLine();
                if(input.Trim().ToLower() == "quit")
                {
                    break;
                }
                if(input.Trim().ToLower() == "add")
                {
                    Console.Write("What you want to add to text file?: ");
                    input2 = Console.ReadLine();
                    WorkingWithFiles.Append(path, input2);
                }else if(input.Trim().ToLower() == "read")
                {
                    Console.WriteLine(WorkingWithFiles.ReadText(path)); 
                }
                else if(input.Trim().ToLower() == "clear")
                {
                    WorkingWithFiles.ClearText(path);
                    Console.WriteLine("Text cleared");
                }
                else
                {
                    Console.WriteLine("Wrong command!");
                }
            }
        }
    }
}