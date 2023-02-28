public class ListingActivity
{
    public void Listing()
    {
        int time = 0;
        int iterations;
        Activity activity1 = new Activity();
        string startString = activity1.getStartListing(); // getter for start string
        Console.WriteLine(startString); // write start string to console
        Random random = new Random();

        Console.WriteLine();
        Console.WriteLine("Please enter, in seconds, how long you would like to reflect for: ");
        time = activity1.setTime();

        var prompts = new List<string>{ "Who are people that you appreciate?", "What are personal strengths of yours?","Who are people that you have helped this week?","When have you felt the Holy Ghost this month?","Who are some of your personal heroes?"};
        int index = random.Next(prompts.Count);
        Console.WriteLine();
        Console.WriteLine();
        
        iterations = 10;
        int countdown = 10;
        foreach (int value in Enumerable.Range(1, iterations))
        {   
            countdown -= 1;
            string countdownStr = ($"Coundown: {countdown.ToString()} | Your prompt is: {prompts[index]}");
            activity1.Load(125, countdownStr, countdownStr);
        }
        
        //DateTime startTime = DateTime.Now;
        //DateTime futureTime = startTime.AddSeconds(5);

        //Thread.Sleep(3000);
        

        //DateTime currentTime = DateTime.Now;
        //if (currentTime < futureTime)
        //{
        //    Console.WriteLine("We have not arrived at our future time yet...");
        //}

        //Thread.Sleep(time*1000);
        //while( != 1)
        //{
        //    Console.WriteLine("yeah");
        //}

    }
}