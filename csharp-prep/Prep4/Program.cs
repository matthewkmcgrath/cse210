using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers. Type 0 when finished.");
        int userInput = 0;
        do 
        {
        Console.Write("Enter Number: ");
        userInput = int.Parse(Console.ReadLine());
        numbers.Add(userInput);
        } while (userInput != 0);
        foreach (int x in numbers)
        {
            Console.WriteLine(x);
        }
        int quantity = numbers.Count;
        int total = 0;
        foreach (int x in numbers)
        {
            total += x;
        }
        int avg = total/quantity;
        int max = numbers.Max();
        Console.WriteLine($"Your list has {quantity} items");
        Console.WriteLine($"The total of your list is {total}");
        Console.WriteLine($"The average of your list is {avg}");
        Console.WriteLine($"The max number is {max}");
    }
}