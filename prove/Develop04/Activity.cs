public class Activity
{
    public string _activity;
    string _startString;
    public int time;
    public int iterations;
    public string mesg1;
    public string mesg2;
    
    public string activitySetter(string _userChoice)
    {
        if (_userChoice == "1")
        {
            _activity = "the Breathing exercise";
        }
        else if (_userChoice == "2")
        {
            _activity = "the Reflecting exercise";
        }
        else if (_userChoice == "3")
        {
            _activity = "the Listing exercise";
        }
        else
        {
            _activity = "";
        }
        return _activity;

    }

    public int setTime()
    {
        string stringSeconds = Console.ReadLine();
        int seconds = int.Parse(stringSeconds);
        time = seconds;
        return time;
    }

    public void Load(int milliseconds, string mesg1, string mesg2)
    {
        
        Console.Clear();
        Console.WriteLine($"o . .    {mesg1}");
        Console.WriteLine(".   .");
        Console.WriteLine(". . .");
        Thread.Sleep(milliseconds);
        Console.Clear();
        Console.WriteLine($". o .    {mesg1}");
        Console.WriteLine(".   .");
        Console.WriteLine(". . .");
        Thread.Sleep(milliseconds);
        Console.Clear();
        Console.WriteLine($". . o    {mesg1}");
        Console.WriteLine(".   .");
        Console.WriteLine(". . .");
        Thread.Sleep(milliseconds);
        Console.Clear();
        Console.WriteLine($". . .    {mesg1}");
        Console.WriteLine(".   o");
        Console.WriteLine(". . .");
        Thread.Sleep(milliseconds);
        Console.Clear();
        Console.WriteLine($". . .    {mesg2}");
        Console.WriteLine(".   .");
        Console.WriteLine(". . o");
        Thread.Sleep(milliseconds);
        Console.Clear();
        Console.WriteLine($". . .    {mesg2}");
        Console.WriteLine(".   .");
        Console.WriteLine(". o .");
        Thread.Sleep(milliseconds);
        Console.Clear();
        Console.WriteLine($". . .    {mesg2}");
        Console.WriteLine(".   .");
        Console.WriteLine("o . .");
        Thread.Sleep(milliseconds);
        Console.Clear();
        Console.WriteLine($". . .    {mesg2}");
        Console.WriteLine("o   .");
        Console.WriteLine(". . .");
        Thread.Sleep(milliseconds);
        Console.Clear();
        
    }

    public string getStartBreathing()
    {   
        _activity = "Breathing";
        Console.Clear();
        _startString = $"Welcome to {_activity} \nIn seconds, enter how long you would like the activity to take place: "; 
        return _startString;
    }

    public string getStartReflecting()
    {   
        _activity = "Reflecting";
        Console.Clear();
        _startString = $"Welcome to {_activity} \nThis activity will help you reflect on times in \nyour life when you have shown strength and resilience.\nThis will help you recognize the power you have and \nhow you can use it in other aspects of your life."; 
        return _startString;
    }

    public string getStartListing()
    {
        _activity = "Listening";
        Console.Clear();
        _startString = $"Welcome to {_activity} \nThis activity will help you reflect on the good \nthings in your life by having you list as many things \nas you can in a certain area.";
        return _startString;
    }

    
}