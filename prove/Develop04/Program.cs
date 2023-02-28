using System;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {   
        void RunProgram()
        {
        
            string _userChoice = Menu("");
            string Menu(string _userChoice)
            {
                while (_userChoice != "4")
                {
                    //string _userChoice;
                    Console.WriteLine("Menu Options");
                    Console.WriteLine(" 1. Start Breathing Activity");
                    Console.WriteLine(" 2. Start Reflecting Activity");
                    Console.WriteLine(" 3. Start Listing Activity");
                    Console.WriteLine(" 4. Quit");
                    Console.WriteLine();
                    Console.WriteLine("Please enter your selection: ");
                    _userChoice = Console.ReadLine();



                    if (_userChoice == "1")
                    {
                        BreathingActivity breathing1 = new BreathingActivity();
                        breathing1.Run();
                    }

                    else if(_userChoice == "2")
                    {
                        ReflectingActivity reflect1 = new ReflectingActivity();
                        reflect1.Reflect();
                    }

                    else if(_userChoice == "3")
                    {
                        ListingActivity listing1 = new ListingActivity();
                        listing1.Listing();
                    }

                    else
                    {
                        Console.WriteLine();
                    }
                }
                return _userChoice;
            }
        }

        RunProgram();

    

    }
}