using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter one of the following number for respective conversion \n" +
            "1 for Celsius to Fahrenheit \n" +
            "2 for Fahrenheit to Celsius \n" +
            "3 for Celsius to Kelvin \n" +
            "4 for Kelvin to Celsius: ");
        int choiceOfUser = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine();

        switch(choiceOfUser)
        {
            case 1: CelsToFahr();
                break;
            case 2: FahrToCels();
                break;
            case 3: CelsToKelv();
                break;
            case 4: KelvToCels();
                break;
            default: Console.WriteLine("Invalid input");
                break;
        }
        Console.ReadLine();
    }
    public static void CelsToFahr()
    {
        double tempCels, tempFahr;
        tempCels = ReadTemperature("Celsius");
        tempFahr = (tempCels * 9 / 5) + 32;
        Console.WriteLine($"Celsius in Fahrenheit is {tempFahr}.");
    }
    public static void FahrToCels()
    {
        double tempFahr, tempCels;
        tempFahr = ReadTemperature("Fahrenheit");
        tempCels = (tempFahr - 32) * 5 / 9;
        Console.WriteLine($"Fahrenheit in Celsius is {tempCels}.");
    }
    public static void CelsToKelv()
    {
        double tempCels, tempKelv;
        tempCels = ReadTemperature("Celsius");
        tempKelv = tempCels + 273.15;
        Console.WriteLine($"Celsius in Kelvin is {tempKelv}.");
    }
    public static void KelvToCels()
    {
        double tempKelv, tempCels, tempFahr;
        tempKelv = ReadTemperature("Kelvin");
        tempCels = tempKelv - 273.15;
        Console.WriteLine($"Kelvin in Celsius is {tempCels}.");

        Console.WriteLine();

        Console.WriteLine("Do you want to change the above Kelvin into Fahrenheit as well? (y/n):");
        string userInput = Console.ReadLine();
        Console.WriteLine();

        if(userInput == "y")
        {
            Console.WriteLine("Now converting that Kelvin back to Fahrenheit:");
            tempFahr = ((tempKelv - 273.15) * 9 / 5) + 32;
            Console.WriteLine($"Same Kelvin in Fahrenheit is {tempFahr}.");
        }
        else
        {
            Console.WriteLine("End!");
        }
    }
    public static double ReadTemperature(string unit)
    {
        Console.Write($"Enter the temperature in {unit}: ");
        return Convert.ToDouble(Console.ReadLine());
    }
}