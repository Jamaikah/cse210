using System;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();

        bool choices = true;

        Journal journal = new Journal();
        PromptGenerator generator = new PromptGenerator();


        while (choices)
        {
            int option = DisplayMenu();

            if (option == 1)
            {
                // This is what I've done to exceed the requirements. Although the functional requirements state that the user should write an entry and be shown a random prompt, I still added an option for users who just want to express their thoughts or answer random questions. I thought this would give users more freedom when writing in their journals and encourage them to write more often. The random prompt is still there for those who want questions to answer. I just wanted to give users the option to express their thoughts and feelings freely.
                Console.WriteLine("How's it going? Do you want to write anything or a random question you may want to answer?");
                Console.WriteLine("Press Enter if you want to write your own thoughts or enter 'random' if you want random questions.");
                Console.Write("> ");
                string note = Console.ReadLine().ToLower();

                if (note == "")
                {
                    Console.WriteLine("Express your thoughts.");
                    Console.Write("> ");
                    string thoughts = Console.ReadLine();
                    Console.WriteLine();

                    DateTime theCurrentTime = DateTime.Now;
                    string date = theCurrentTime.ToShortDateString();

                    Entry entry = new Entry();
                    entry._date = date;
                    entry._promptText = note;
                    entry._entryText = thoughts;

                    journal.AddEntry(entry);
                }

                else if(note == "random")
                {
                    string prompt = generator.GetRandomPrompt();
                    Console.WriteLine(prompt);
                    Console.Write("> ");
                    string response = Console.ReadLine();
                    Console.WriteLine();

                    DateTime theCurrentTime = DateTime.Now;
                    string date = theCurrentTime.ToShortDateString();

                    Entry entry = new Entry();
                    entry._date = date;
                    entry._promptText = prompt;
                    entry._entryText = response;

                    journal.AddEntry(entry);
                }
            }

            else if (option == 2)
            {
                journal.DisplayAll();
            }

            else if (option == 3)
            {
                Console.Write("What's the file name? ");
                string file = Console.ReadLine();

                journal.LoadFromFile(file);
            }

            else if (option == 4)
            {
                Console.Write("What's the file name? ");
                string file = Console.ReadLine();

                journal.SaveToFile(file);
            }

            else if (option == 5)
            {
                choices = false;
            }

            else
            {
                Console.WriteLine("Invalid choice. Please try again.");
            }
        }


    }
    static void DisplayMessage()
    {
    Console.WriteLine("Welcome to the Journal Program!");
    }
    
    static int DisplayMenu()
    {
        Console.WriteLine("Please choose the following choices:\n1. Write\n2. Display\n3. Load\n4. Save\n5. Quit");
        Console.Write("What would you like to do? ");
        return int.Parse(Console.ReadLine());
    }
}