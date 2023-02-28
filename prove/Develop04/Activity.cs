public class Activity
{
    string _activity = "";
    string _startString;
    
    public void activitySetter(string _userChoice)
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

    }

    public string getStartBreathing()
    {   
        _startString = $"Welcome to {_activity} \nIn seconds, enter how long you would like the activity to take place: "; 
        return _startString;
    }

    public string getStartReflecting()
    {   
        Console.Clear();
        _startString = $"Welcome to {_activity} \nThis activity will help you reflect on times in \nyour life when you have shown strength and resilience.\nThis will help you recognize the power you have and \nhow you can use it in other aspects of your life."; 
        return _startString;
    }

    public string getStartListing()
    {
        Console.Clear();
        _startString = $"Welcome to {_activity} \nThis activity will help you reflect on the good \nthings in your life by having you list as many things \nas you can in a certain area.";
        return _startString;
    }

    
}