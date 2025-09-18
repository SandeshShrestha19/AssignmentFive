using System;
class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        double firstNum = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter another number: ");
        double secondNum = Convert.ToDouble(Console.ReadLine());

        ShowResult(firstNum, secondNum);

        Console.ReadKey();
    }
    //Addition
    public static double Addition(double firstNum, double secondNum) => firstNum + secondNum;
    //Subtraction
    public static double Subtraction(double firstNum, double secondNum) => firstNum - secondNum;
    //Multiplication
    public static double Multiplication(double firstNum, double secondNum) => firstNum * secondNum;
    //Division
    public static double Division(double firstNum, double secondNum)
    {
        if (secondNum != 0)
        {
            return firstNum / secondNum;
        }
        else
        {
            Console.WriteLine("Error: Division by zero isn't possible!");
            return 0;
        }
    }
    public static void ShowResult(double firstNum, double secondNum)
    {

        Console.Write("Choose an operator: +, -, *, / : ");
        string choice = Console.ReadLine();

        Console.WriteLine();

        switch (choice)
        {
            case "+":
                Console.WriteLine("Result: " + Addition(firstNum, secondNum));
                break;
            case "-":
                Console.WriteLine("Result: " + Subtraction(firstNum, secondNum));
                break;
            case "*":
                Console.WriteLine("Result: " + Multiplication(firstNum, secondNum));
                break;
            case "/":
                Console.WriteLine("Result: " + Division(firstNum, secondNum));
                break;
            default:
                Console.WriteLine("Invalid choice!");
                break;
        }
    }
}

