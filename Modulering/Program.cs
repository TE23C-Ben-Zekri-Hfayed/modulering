using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Name your Tamagotchi:");
        string name = Console.ReadLine();
        Tamagotchi tama = new Tamagotchi(name);

        while (tama.GetAlive())
        {
            tama.PrintStats();
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Feed");
            Console.WriteLine("2. Say Hi");
            Console.WriteLine("3. Teach a new word");
            Console.WriteLine("4. Do nothing");

            string choice = Console.ReadLine();

            if (choice == "1")
            {
                tama.Feed();
            }
            else if (choice == "2")
            {
                tama.Hi();
            }
            else if (choice == "3")
            {
                Console.Write("Which word should be taught?: ");
                string word = Console.ReadLine();
                tama.Teach(word);
            }
            else
            {
                Console.WriteLine($"{tama.Name} does nothing...");
            }

            tama.Tick();
            Console.WriteLine();
        }

        Console.WriteLine($"{tama.Name} has died... Game over!");
    }
}
