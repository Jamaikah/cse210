using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int magic_number = randomGenerator.Next(1, 100);

        int guess = 0;

        while (guess != magic_number)
        {
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());

            if (guess < magic_number)
            {
                Console.WriteLine("Higher");
            }

            else if (guess > magic_number)
            {
                Console.WriteLine("Lower");
            }

        }

        Console.WriteLine("You guessed it!");
    }
}