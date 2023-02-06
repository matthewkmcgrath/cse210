using System;

class Program
{
    static void Main(string[] args)
    {
        string[] returnedArray = {"", ""};
        int choiceInt = 0;
        List<string> entries = new List<string>();
        while (returnedArray[0] != "5")
        {
            returnedArray = Menu(returnedArray);
            entries.Add(returnedArray[1]);
        }

        //string[] Menu(int choiceInt, string entries)
        string[] Menu(string[] returnedArray)
        {
            string journalEntry = "";
            //string entries = returnedArray[1];
            Console.WriteLine($"Welcome. What would you like to do?");
            Console.WriteLine($"1. Write");
            Console.WriteLine($"2. Display");
            Console.WriteLine($"3. Load");
            Console.WriteLine($"4. Save");
            Console.WriteLine($"5. Quit");
            Console.Write($"-> ");
            string userChoice = Console.ReadLine();
            returnedArray[0] = userChoice;
            choiceInt = int.Parse(userChoice);
            if (choiceInt == 1)
            {
                Console.WriteLine();
                Entry entry1 = new Entry();
                journalEntry = entry1.NewEntry();
                returnedArray[1] = journalEntry;
                Console.WriteLine();
                //Console.WriteLine(journalEntry);


                
            }
            else if (choiceInt == 2)
            {
                Console.WriteLine();
                foreach (var entry in entries)
                {
                    Console.WriteLine(entry);
                }
                Console.WriteLine();
            }
            else if (choiceInt == 3)
            {
                Console.WriteLine();
                ImportExport import1 = new ImportExport();
                entries = import1.Import();
                Console.WriteLine();
            }
            else if (choiceInt == 4)
            {
                Console.WriteLine();
                ImportExport export1 = new ImportExport();
                export1.Export(entries);
                Console.WriteLine();
            }
            else if (choiceInt == 5)
            {
                Console.WriteLine();
                Console.WriteLine("Adios");
                Console.WriteLine();
            }
            //entries += journalEntry;//?????
            return returnedArray;
        }
        
    }
}