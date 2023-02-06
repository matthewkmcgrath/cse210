using System.IO;

public class ImportExport
{
    public string _dateText;
    
    public List<string> Import()
    {
        Console.WriteLine("Please enter a filename for import: ");
        Console.WriteLine("-> ");
        string fileName = Console.ReadLine();
        //List<string> importedList = System.IO.File.ReadAllLines(fileName);
        List<string> importedList = File.ReadAllLines(fileName).ToList();
        return importedList;

    }

    public void Export(List<string> list)
    {
        Console.WriteLine("Please enter a filename for export: ");
        Console.WriteLine("-> ");
        string fileName = Console.ReadLine();
        string finalFileName = ($"{fileName}.txt");
        Console.WriteLine($"Your file will be called: '{finalFileName}'. Correct?");
        Console.WriteLine("Y/n: ");
        string verification = Console.ReadLine();
        if (verification == "n")
        {
            Console.WriteLine("Alright.");
        } 

        else
        {
            System.IO.File.WriteAllLines(finalFileName, list);
            Console.WriteLine("File saved successfully.");
        }
    }
}