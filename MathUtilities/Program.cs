using System;
using System.Numerics;
using System.Security.Cryptography.X509Certificates;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter one of the following number for related task \n" +
            "1 for calculation of area of circle \n" +
            "2 for calculation of area of rectanlge \n" +
            "3 for calculation of area of triangle \n" +
            "4 for checking if the number is prime or not \n" +
            "and 5 for calculation of factorial of a number: ");
        int userChoice = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine();

        switch (userChoice)
        {
            case 1:
                CalculateAreaOfCircle();
                break;
            case 2:
                CalculateAreaOfRectangle();
                break;
            case 3:
                CalculateAreaOfTriangle();
                break;
            case 4:
                CheckNumberIsPrimeOrNot();
                break;
            case 5:
                CalculateFactorialOfNumber();
                break;
            default:
                Console.WriteLine("Choose a number between 1-5!");
                break;
        }

        Console.ReadLine();
    }
    public static void CalculateAreaOfCircle()
    {
        Console.Write("Enter the radius of the circle: ");
        double radiusOfCircle = Convert.ToDouble(Console.ReadLine());

        double areaOfCircle = Math.PI * Math.Pow(radiusOfCircle, 2);
        Console.WriteLine($"The area of the circle is {areaOfCircle} sq.units.");
    }
    public static void CalculateAreaOfRectangle()
    {
        Console.Write("Enter the length of the rectangle: ");
        double lengthOfRectangle = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the width of the reactangle: ");
        double widththOfRectangle = Convert.ToDouble(Console.ReadLine());

        double areaOfRectangle = lengthOfRectangle * widththOfRectangle;
        Console.WriteLine($"The area of the rectangle is {areaOfRectangle} sq.units.");
    }
    public static void CalculateAreaOfTriangle()
    {
        Console.Write("Enter the base of the triangle: ");
        double baseOfTriangle = Convert.ToDouble(Console.ReadLine());

        Console.Write("Enter the height of the triangle: ");
        double heightOfTriangle = Convert.ToDouble(Console.ReadLine());

        double areaOfTriangle = (baseOfTriangle * heightOfTriangle) / 2;
        Console.WriteLine($"The area of the triangle is {areaOfTriangle} sq.units.");
    }
    public static void CheckNumberIsPrimeOrNot()
    {
        Console.Write("Enter a number you want to check: ");
        int inputNumber = Convert.ToInt32(Console.ReadLine());

        if (inputNumber == 0 || inputNumber == 1)
        {
            Console.WriteLine($"{inputNumber} isn't a prime number.");
        }
        else if (inputNumber == 2)
        {
            Console.WriteLine("2 is a prime number.");
        }
        else
        {
            bool isPrime = true;
            for (int i = 2; i <= Math.Sqrt(inputNumber); i++)
            {
                if (inputNumber % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }
            if (isPrime)
            {
                Console.WriteLine($"{inputNumber} is a prime number.");
            }
            else
            {
                Console.WriteLine($"{inputNumber} is not a prime number.");
            }
        }
    }
    public static void CalculateFactorialOfNumber()
    {
        Console.Write("Enter a number you want to get the factorial of: ");
        int inputNumber = Convert.ToInt32(Console.ReadLine());

        BigInteger factorialResult = 1;

        for (int i = inputNumber; i >= 1; i--)
        {
            factorialResult *= i;
        }
        Console.WriteLine($"Factorial of {inputNumber} is {factorialResult}.");

        //Above function can be performed using recursion as well

        /* public static long Factorial(int inputNumber)
        {
            if (inputNumber == 0 || inputNumber == 1)
            {
                return 1;
            }
            else
            {
                return inputNumber * Factorial(inputNumber - 1);
            }
        }
        */
    }

}
