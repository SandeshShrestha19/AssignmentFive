using System;
using System.Diagnostics.CodeAnalysis;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter a number: ");
        double firstNum = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter another number: ");
        double secondNum = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine();

        Console.WriteLine("The sum of the two numbers is " + Addition(firstNum, secondNum));

        Console.WriteLine("The difference of the two numbers is " + Subtraction(firstNum, secondNum));

        Console.WriteLine("The product of the two numbers is " + Multiplication(firstNum, secondNum));

        Console.WriteLine("The division of the two numbers is " + Division(firstNum, secondNum));

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
}

