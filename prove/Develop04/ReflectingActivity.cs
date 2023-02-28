public class ReflectingActivity
{
    public void Reflect()
    {
        Random random = new Random();
        var prompts = new List<string>{ "Think of a time when you stood up for someone else.","Think of a time when you did something really difficult.","Think of a time when you helped someone in need.","Think of a time when you did something truly selfless."};
        int index = random.Next(prompts.Count);
        Console.WriteLine();
        Console.WriteLine("press any key to continue");
        Console.ReadLine();
        Console.WriteLine(prompts[index]);
        Console.WriteLine();
        
    }
}