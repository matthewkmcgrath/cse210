using System;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        
        

        Activity activity1 = new Activity(); // new class instance
        string startString = activity1.getStart(); // getter for start string
        Console.WriteLine(startString); // write start string to console
        activity1.setTime(); // read time from user
        activity1.Load(); // load spinner

    }
}