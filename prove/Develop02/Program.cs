using System;

class Program
{
    static void Main(string[] args)
    {
        int choiceInt = 0;
        while (choiceInt != 5)
        
        {
            choiceInt = Menu(choiceInt);
        }

        int Menu(int choiceInt)
        {
            Console.WriteLine($"Welcome. What would you like to do?");
            Console.WriteLine($"1. Write");
            Console.WriteLine($"2. Display");
            Console.WriteLine($"3. Load");
            Console.WriteLine($"4. Save");
            Console.WriteLine($"5. Quit");
            Console.Write($"-> ");
            string userChoice = Console.ReadLine();
            choiceInt = int.Parse(userChoice);
            if (choiceInt == 1)
            {
                Entry entry1 = new Entry();
                string _journalEntry = entry1.NewEntry();
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
                Console.WriteLine("Adios");
            }
            return choiceInt;
        }
        
    }
}