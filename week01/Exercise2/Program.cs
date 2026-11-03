using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Write("What is your percentage? ");
        string input = Console.ReadLine();
        int percentage = int.Parse(input);

        string letter = "";

        if (percentage >= 90)
        {
            letter = "A";
        }

        else if (percentage >= 80)
        {
            letter = "B";
        }

        else if (percentage >= 70)
        {
            letter = "C";
        }

        else if (percentage >= 60)
        {
            letter = "D";
        }

        else if (percentage < 60)
        {
            letter = "F";
        }

        Console.WriteLine($"Your letter grade is {letter}.");

        if (percentage > 70)
        {
            Console.WriteLine("Congratulations! You passed.");
        }

        else
        {
            Console.WriteLine("Sorry. You did not pass.");
        }
    }
}