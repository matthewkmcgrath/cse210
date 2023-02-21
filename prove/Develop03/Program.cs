using System;

class Program
{
    static void Main(string[] args)
    {
        //string userChoice = "";

        Scripture ScriptureClass = new Scripture(); //initializes scripture class
        string theScripture = ScriptureClass.GetScripture(); //calls GetScripture method to read scripture into a variable
        Hide hideClass = new Hide();// initializes hide class
        List<string> scriptureList = new List<string>(); //makes a new list called scriptureList
        scriptureList = hideClass.RandomPick(theScripture); //converts scripture to list and removes words

        //while (userChoice != "q")
        //{
            //Console.WriteLine("yeah");
            //EndChecker endchecker1 = new EndChecker();
            //userChoice = endchecker1;
            //Console.WriteLine(userChoice);
        //}
    }
}