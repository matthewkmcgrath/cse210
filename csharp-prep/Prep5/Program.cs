using System;

class Program
{
    static void DisplayWelcome()
    {
        Console.WriteLine("Welcome to the program");
    }
    
    static string PromptUserName()
    {
        Console.Write("What is your name?: ");
        string userName = Console.ReadLine();
        return userName;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter a number: ");
        int userNumber = int.Parse(Console.ReadLine());
        return userNumber;
    }

    static int SquareNumber(int number)
    {
        int numSquared = (number * number);
        return numSquared;
    }

    static void DisplayResult(string userName, int numSquared)
    {
        Console.Write($"{userName}, the square of your number is {numSquared}");
    }

    static void Main(string[] args)
    {
        DisplayWelcome();
        string userName = PromptUserName();
        int userNumber = PromptUserNumber();
        int numSquared = SquareNumber(userNumber);
        DisplayResult(userName, numSquared);
    }
}