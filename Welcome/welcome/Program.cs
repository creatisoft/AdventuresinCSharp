/*
    project: welcome.csproj
    author: Christopher M | Creatisoft.com | x/twitter: @creatisoft 
    Oct-08-2025
*/

namespace welcome;

class Program
{
    static void Main(string[] args)
    {

        string _userName;


        Console.WriteLine("Hello, and welcome to my c# repository!");
        Console.WriteLine("***************************************");

        Console.WriteLine("May I ask what your name is?");

        //Converting null literal or possible null value to non-nullable type.
        //string? would fix this, but I'm still learning a bit more about this 
        _userName = Console.ReadLine();

        Console.WriteLine($"Hello, {_userName}! Thanks for stopping by!");
        Console.WriteLine("Here is a treasure map...");

        Console.WriteLine("***************************************");

        int[] _treatureMap = new int[] { 0, 0, 0, 3, 2, 5, 0, 0, 0 };

        for (int i = 0; i < 9; i++)
        {
            if (i % 3 == 0)
            {
                Console.WriteLine("");
            }
            Console.Write(_treatureMap[i]);
        }
        Console.WriteLine("");

        Console.WriteLine("***************************************");
        Console.WriteLine("Where do you think the treasure is?....");
        Console.WriteLine("(select a number)");

        int _userInput;

        _userInput = Convert.ToInt32(Console.ReadLine());

        if (_userInput == 2)
        {
            Console.WriteLine("***************************************");

            Console.WriteLine("Yay! See you next time.");
        }
        else
        {
            Console.WriteLine("***************************************");
            Console.WriteLine("Better luck next time. Bye!");
        }


    }
}
