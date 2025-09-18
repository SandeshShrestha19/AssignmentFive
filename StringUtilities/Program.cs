using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Enter one of the following number for respective task \n" +
            "1 for counting words \n" +
            "2 for reversing string \n" +
            "3 for checking if the input is palindrome or not \n" +
            "4 for removing spaces from the string: ");
        int choiceOfUser = Convert.ToInt32(Console.ReadLine());

        switch (choiceOfUser)
        {
            case 1:
                CountWords();
                break;
            case 2:
                ReverseString();
                break;
            case 3:
                IsPalindromeOrNot();
                break;
            case 4:
                RemoveSpaces();
                break;
            default:
                Console.WriteLine("Invalid Input!");
                break;
        }
        Console.ReadKey();
    }
    public static void CountWords()
    {
        Console.Write("Enter a word: ");
        string userInput = Console.ReadLine();
        string[] words = userInput.Split(' ');

        Console.WriteLine();

        int countOfWords = 0;
        foreach (string word in words)
        {
            countOfWords++;
        }
        Console.WriteLine($"The total number of words is {countOfWords}");
    }
    public static void ReverseString()
    {
        Console.Write("Enter a string: ");
        string userInput = Console.ReadLine();

        for(int i = userInput.Length - 1; i >= 0; i--)
        {
            Console.Write(userInput[i]);
        }
    }
    public static void IsPalindromeOrNot()
    {
        Console.Write("Enter a string: ");
        string userInput = Console.ReadLine();

        string copyOfInput = userInput;
        string reversedString = "";

        for (int i = userInput.Length - 1; i >= 0; i--)
        {
           reversedString += userInput[i];
        }
        if(reversedString == copyOfInput)
        {
            Console.WriteLine($"{userInput} is palindrome.");
        }
        else
        {
            Console.WriteLine($"{userInput} isn't palindrome.");
        }
    }
    public static void RemoveSpaces()
    {
        Console.Write("Enter a string: ");
        string userInput = Console.ReadLine();

        string stringWithoutSpaces = userInput.Replace(" ", "");
        Console.WriteLine($"The string without spaces of input is {stringWithoutSpaces}.");
    }
}