using System;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();

        Console.WriteLine("Enter a list of numbers. Type 0 when finished.");

        int num = -1;
        while (num != 0)
        {
            Console.Write("Enter number: ");
            string response = Console.ReadLine();

            num = int.Parse(response);

            if (num != 0)
            {
                numbers.Add(num);
            }
        }
        int sum = 0;
        foreach (int number in numbers)
        {
            sum += number;
        }

        Console.WriteLine($"The sum is {sum}");


        float average = ((float)sum) / numbers.Count;
        Console.WriteLine($"The average is {average}");

        int large = -1;
        foreach (int i in numbers)
        {
            sum += i;

            if (i > large)
            {
                large = i;
            }
        }

        Console.WriteLine($"The largest number is {large}");
    }
}