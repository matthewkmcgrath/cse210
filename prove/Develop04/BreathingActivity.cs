public class BreathingActivity
{

    public int time;
    public int iterations;

    public void setTime()
    {
        string stringSeconds = Console.ReadLine();
        int seconds = int.Parse(stringSeconds);
        time = seconds;
    }


    public void Load()
    {
        iterations = time/4;
        foreach (int value in Enumerable.Range(1, iterations))
        {
            Console.Clear();
            Console.WriteLine("o . .    Breathe in");
            Console.WriteLine(".   .");
            Console.WriteLine(". . .");
            Thread.Sleep(500);
            Console.Clear();

            Console.WriteLine(". o .    Breathe in");
            Console.WriteLine(".   .");
            Console.WriteLine(". . .");
            Thread.Sleep(500);
            Console.Clear();

            Console.WriteLine(". . o    Breathe in");
            Console.WriteLine(".   .");
            Console.WriteLine(". . .");
            Thread.Sleep(500);
            Console.Clear();

            Console.WriteLine(". . .    Breathe in");
            Console.WriteLine(".   o");
            Console.WriteLine(". . .");
            Thread.Sleep(500);
            Console.Clear();

            Console.WriteLine(". . .    Breathe out");
            Console.WriteLine(".   .");
            Console.WriteLine(". . o");
            Thread.Sleep(500);
            Console.Clear();

            Console.WriteLine(". . .    Breathe out");
            Console.WriteLine(".   .");
            Console.WriteLine(". o .");
            Thread.Sleep(500);
            Console.Clear();

            Console.WriteLine(". . .    Breathe out");
            Console.WriteLine(".   .");
            Console.WriteLine("o . .");
            Thread.Sleep(500);
            Console.Clear();

            Console.WriteLine(". . .    Breathe out");
            Console.WriteLine("o   .");
            Console.WriteLine(". . .");
            Thread.Sleep(500);
            Console.Clear();
        }    
    }
}