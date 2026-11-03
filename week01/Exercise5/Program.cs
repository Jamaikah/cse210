using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();

        string UserName = PromptUserName();
        int favnum = PromptUserNumber();
        int squared = SquareNumber(favnum);

        DisplayResult(UserName, squared);
    }

    static void DisplayMessage()
    {
        Console.WriteLine("Welcome to the Program!");
    }

    static string PromptUserName()
    {
        Console.Write("Please enter your name: ");
        string name = Console.ReadLine();

        return name;
    }

    static int PromptUserNumber()
    {
        Console.Write("Please enter your favorite number: ");
        int favnum = int.Parse(Console.ReadLine());

        return favnum;
    }

    static int SquareNumber(int favnum)
    {
        int squared = favnum * favnum;

        return squared;
    }

    static void DisplayResult(string name, int squared)
    {
        Console.WriteLine($"{name}, the square of your number is {squared}");
    }
}
