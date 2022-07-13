namespace C_Sharp_Fundamentals_Project
{
    internal class Primitive_Types_And_Expressions
    {
        //This class contains all the functions that support the functionality
        //of the basic calculator and method Calculator which is operatring calulator frokm given operator from Main
        public static double Addition(double firstNumber, double secondNumber)
        {
            
            return firstNumber + secondNumber;
        }
        public static double Subtraction(double firstNumber, double secondNumber)
        {
            return firstNumber - secondNumber;
        }
        public static double Multiplication(double firstNumber, double secondNumber)
        {
            return firstNumber * secondNumber;
        }
        public static double Division(double firstNumber, double secondNumber)
        {
            return firstNumber / secondNumber;
        }
        public static double Calculator(double firstNumber,double secondNumber, string operation)
        {
            switch (operation)
            {
                case "+":
                    return Addition(firstNumber, secondNumber);
                case "-":
                    return Subtraction(firstNumber, secondNumber);
                case "*":
                    return Multiplication(firstNumber, secondNumber);
                case "/":
                    return Division(firstNumber, secondNumber);
            }
            return 0;
        }
        
    }
}
