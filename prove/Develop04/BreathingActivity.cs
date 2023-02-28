public class BreathingActivity
{

    public void Run()
    {
        int time = 0;
        int iterations;
        Activity activity1 = new Activity();
        BreathingActivity breathing1 = new BreathingActivity();
        string startString = activity1.getStartBreathing(); // getter for start string
        Console.WriteLine(startString); // write start string to console
        time = activity1.setTime(); // read time from user
        
        iterations = time/4;

        foreach (int value in Enumerable.Range(1, iterations))
        {
            activity1.Load(500, "Breathe In", "Breathe Out");
        }
        
    }
    

    


    
}