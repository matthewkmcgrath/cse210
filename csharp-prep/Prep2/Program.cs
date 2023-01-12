using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("Please input your grade: ");
        string letterGrade = "";
        string grade = Console.ReadLine();
        int gradenum = int.Parse(grade);
        if (gradenum < 90)
        {
            letterGrade = "B";
            if (gradenum < 80)
            {
                letterGrade = "C";
                if (gradenum < 70)
                {
                    letterGrade = "D";
                    if (gradenum < 60)
                    {
                        letterGrade = "F";
                    }
                    
                    
                }
            }
        }
        else if (gradenum >= 90)
        {
            letterGrade = "A";
        }
        Console.WriteLine($"Your letter grade is {letterGrade}");
        if (gradenum >= 70)
        {
            Console.WriteLine("Congratulations, you passed");
        }
        else if (gradenum < 70)
        {
            Console.WriteLine("Sorry, you failed the class");
        }
    }
}