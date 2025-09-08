using System;

class Program
{
    static void Main(string[] args)
    {
        // ask the player what the tamagotchi should be called
        Console.WriteLine("Name your Tamagotchi:");
        string name = Console.ReadLine();
        Tamagotchi tama = new Tamagotchi(name);

        // keep playing as long as tamagotchi is alive
        while (tama.GetAlive())
        {
            // show how the tamagotchi feels
            tama.PrintStats();

            // show menu what we can do
            Console.WriteLine("Choose an action:");
            Console.WriteLine("1. Feed");
            Console.WriteLine("2. Say Hi");
            Console.WriteLine("3. Teach a new word");
            Console.WriteLine("4. Do nothing");

            // player picks a number
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                // give food
                tama.Feed();
            }
            else if (choice == "2")
            {
                // say hi to it
                tama.Hi();
            }
            else if (choice == "3")
            {
                // teach a new word
                Console.Write("Which word should be taught?: ");
                string word = Console.ReadLine();
                tama.Teach(word);
            }
            else
            {
                // if not 1, 2 or 3 → do nothing
                Console.WriteLine($"{tama.Name} does nothing...");
            }

            // time goes by, tamagotchi gets more hungry/bored
            tama.Tick();
            Console.WriteLine();
        }

        // if dead show game over
        Console.WriteLine($"{tama.Name} has died... Game over!");
    }
}
