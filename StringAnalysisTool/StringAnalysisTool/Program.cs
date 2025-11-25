namespace StringAnalysisTool;

class Program
{
    static void Main(string[] args)
    {
        //int countVowels = 0;
        string sampleString = "This is a sample string";
        ReverseString(sampleString);

        CountVowels(sampleString);
        CountSpaces(sampleString);
    }

    public static void CountSpaces(string sampleString)
    {
        int numberOfSpace = 0;
        for (int i = 0; i < sampleString.Length; i++)
        {
            if (sampleString[i] == ' ')
            {
                numberOfSpace = numberOfSpace + 1;
            }
        }
        Console.WriteLine($"Number of spaces: {numberOfSpace}");
    }

    public static void CountVowels(string sampleString) 
        {
        int countVowels = 0;
        for (int i = 0; i < sampleString.Length; i++)
        {
            if (sampleString[i] == 'a' || sampleString[i] == 'e' || sampleString[i] == 'i' || sampleString[i] == 'o'
                || sampleString[i] == 'u')
            {
                countVowels = countVowels + 1;
            }
        }
        
        Console.WriteLine($"Number of vowels: {countVowels}");
    }
    
    public static void ReverseString(string sampleString)
    {
        Console.Write("Reversed string: ");
        for (int i = sampleString.Length - 1; i >= 0; i--)
        {
            Console.Write(sampleString[i]);
        }
        Console.WriteLine("\n");
    }
    
    
}