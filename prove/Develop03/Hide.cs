public class Hide
{
    //private List<string> RandomPick(string scripture) 
    List<int> prevPicked = new List<int>();
    
    public List<string> RandomPick(string scripture)
    {
        
        //List<string> scriptureList = new List<string>();
        //string[] scriptureList = "";
        //scriptureList = scripture.Split();
        


        List<int> PickNumbers(List<int> prevPicked, int count)
        {
            foreach (int value in Enumerable.Range(1, count))
            {
                
                var random = new Random();
                bool isDuplicate = prevPicked.Contains(pickedNumber);
                while (isDuplicate = true)
                {
                    int pickedNumber = random.Next(23);
                    List<int> thePicked = new List<int>();
                    thePicked.Add(pickedNumber)
                    
                }
                thePicked.Add(pickedNumber)
                

            }

            return thePicked;
        }
         
        //var random = new Random();
        //int index = random.Next(23);
        
        
        List<string> pickedIndex = new List<string>();
        pickedIndex = PickNumbers(prevPicked, 3)

        List<string> scriptureList = new List<string>();
        scriptureList = scripture.Split(' ').ToList();
        
        
        

        Console.WriteLine(index);

        foreach(var x in scriptureList)
        {
            Console.WriteLine(x);
        }
        //Console.WriteLine(scriptureList);
        //22
        return scriptureList;
    }
    
    
    
    //private string Hide(random_output, scripture)
    //{
        
    //    return hidden_scripture_string
    //}
}