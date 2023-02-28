public class ReflectingActivity
{
    public void Reflect()
    {
        int time = 0;
        int iterations;
        Activity activity1 = new Activity();
        string startString = activity1.getStartReflecting(); // getter for start string
        Console.WriteLine(startString); // write start string to console
        Random random = new Random();

        Console.WriteLine();
        Console.WriteLine("Please enter, in seconds, how long you would like to reflect for: ");
        time = activity1.setTime();
        iterations = time/16;

        var prompts = new List<string>{ "Think of a time when you stood up for someone else.","Think of a time when you did something really difficult.","Think of a time when you helped someone in need.","Think of a time when you did something truly selfless."};
        int index = random.Next(prompts.Count);
        Console.WriteLine();
        Console.WriteLine($"Your prompt is: {prompts[index]}");
        Console.WriteLine();
        Console.Write("press any key to continue");
        Console.ReadLine();
        var questions = new List<string>{ "Why was this experience meaningful to you?","Have you ever done anything like this before?","How did you get started?","How did you feel when it was complete?","What made this time different than other times when you were not as successful?","What is your favorite thing about this experience?","What could you learn from this experience that applies to other situations?","What did you learn about yourself through this experience?","How can you keep this experience in mind in the future?"};
        
        
        
        
        foreach (int value in Enumerable.Range(1, iterations))
        {   
            int questionIndex0 = random.Next(questions.Count);
            activity1.Load(2000, questions[questionIndex0], questions[questionIndex0]);
        
        }
    }
}