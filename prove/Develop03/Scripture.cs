public class Scripture
{
    private string scripture = "So God created man in his own image, in the image of God he created him; male and female he created them.";
    private string reference = "Genesis 1:27";
    //private string newScripture = ""
    
    public string GetReference()
    {
        return reference;
    }

    public string GetScripture()
    {
        return scripture;
    }

    private void SetScripture(string newScripture)
    {
        scripture = newScripture;
    }


}