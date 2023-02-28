using System;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        
        string _userChoice;
        Console.WriteLine("Menu Options");
        Console.WriteLine(" 1. Start Breathing Activity");
        Console.WriteLine(" 2. Start Reflecting Activity");
        Console.WriteLine(" 3. Start Listing Activity");
        Console.WriteLine(" 4. Quit");
        Console.WriteLine();
        Console.WriteLine("Please enter your selection: ");
        _userChoice = Console.ReadLine();

        Activity activity1 = new Activity(); // new class instance

        if (_userChoice == "1")
        {
            string startString = activity1.getStartBreathing(); // getter for start string
            Console.WriteLine(startString); // write start string to console
            activity1.setTime(); // read time from user
            activity1.Load();
        }

        else if(_userChoice == "2")
        {
            string startString = activity1.getStartReflecting(); // getter for start string
            Console.WriteLine(startString); // write start string to console
            // call to the reflecting activity class
        }

        else if(_userChoice == "3")
        {
            string startString = activity1.getStartListing(); // getter for start string
            Console.WriteLine(startString); // write start string to console
            // call to the listing activity class
        }

        else
        {
            Console.WriteLine();
        }

    

    }
}