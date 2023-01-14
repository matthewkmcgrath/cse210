using System;

class Program
{
    static void Main(string[] args)
    {
        //string numGuess;
        //string guess;
        //int numGuess;
        Random randomGenerator = new Random();
        int magicNumber = randomGenerator.Next(1, 101);
        Console.WriteLine("a secret, mysterious, magic number has been chosen");
        Console.WriteLine($"(the magic number is {magicNumber})");
        int numGuess = -1;

        

        while (numGuess != magicNumber)
        {
            Console.WriteLine("what is your guess?: ");
            numGuess = int.Parse(Console.ReadLine());
            if (numGuess < magicNumber)
            {
                Console.WriteLine("you guessed too low, try again");
            }
            else if (numGuess > magicNumber)
            {
                Console.WriteLine("you guessed too high, try again");
            }
            else if (numGuess == magicNumber)
            {
                Console.WriteLine("you got it, good job");
            }
        }
    }
}