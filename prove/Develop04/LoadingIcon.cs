public class Icon
{
    public int time;

    public void Load(int time)
    {
        foreach (int value in Enumerable.Range(1, time))
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