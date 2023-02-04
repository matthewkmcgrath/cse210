using System;

public class Entry
{
    public string _dateText;
    public string _prompt;
    public string _entry;
    public string _response;

    public string NewEntry()
    {
        DateTime _currentTime = DateTime.Now;
        string _dateText = _currentTime.ToShortDateString();
        Console.WriteLine($"{_dateText}");
        string _prompt = PickPrompt();
        Console.WriteLine($"{_prompt}");
        Console.Write($"-> ");
        string _response = Console.ReadLine();
        string _entry = ($"Date: {_dateText} - Prompt: {_prompt} Response: {_response}");
        return _entry;


        string PickPrompt()
        {
            Random rnd = new Random();
            int selection = rnd.Next(1, 6);
            Console.WriteLine($"the selection is {selection}");
            if (selection == 1)
            {
                string _prompte = "Who was the most interesting person you interacted with today?";
                return _prompte;
            }
            else if (selection == 2)
            {
                string _prompte = "What was the funniest part of your day?";
                return _prompte;
            }
            else if (selection == 3)
            {
                string _prompte = "What was your favorite meal of the day?";
                return _prompte;
            }
            else if (selection == 4)
            {
                string _prompte = "What would you change about today if you could?";
                return _prompte;
            }
            else if (selection == 5)
            {
                string _prompte = "What is something you learned today?";
                return _prompte;
            }
            else
            {
                string _error = "Something has gone horribly wrong";
                return _error;
            }
        }
    }
}