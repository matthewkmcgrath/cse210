using System;

class Program
{
    static void Main(string[] args)
    {
        //string userChoice = "";
        //int choiceInt = 0;
        Console.WriteLine($"Welcome. What would you like to do?");
        Console.WriteLine($"1. Write");
        Console.WriteLine($"2. Display");
        Console.WriteLine($"3. Load");
        Console.WriteLine($"4. Save");
        Console.WriteLine($"5. Quit");
        Console.Write($"-> ");
        string userChoice = Console.ReadLine();
        int choiceInt = int.Parse(userChoice);
        if (choiceInt == 1)
        {
            Console.WriteLine("You have picked 1");
        }
        else if (choiceInt == 2)
        {
            Console.WriteLine("You have picked 2");
        }
        else if (choiceInt == 3)
        {
            Console.WriteLine("You have picked 3");
        }
        else if (choiceInt == 4)
        {
            Console.WriteLine("You have picked 4");
        }
        else if (choiceInt == 5)
        {
            Console.WriteLine("You have picked 5");
        }
    }
}