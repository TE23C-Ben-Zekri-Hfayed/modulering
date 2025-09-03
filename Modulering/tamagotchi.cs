using System;
using System.Collections.Generic;

public class Tamagotchi
{
    private int hunger;
    private int boredom;
    private List<string> words;
    private bool isAlive;

    public string Name { get; set; }

    public Tamagotchi(string name)
    {
        Name = name;
        hunger = 0;
        boredom = 0;
        words = new List<string>();
        isAlive = true;
    }

    public void Feed()
    {
        hunger -= new Random().Next(1, 4); // random decrease
        if (hunger < 0) hunger = 0;
    }

    public void Hi()
    {
        if (words.Count > 0)
        {
            Random rnd = new Random();
            int index = rnd.Next(words.Count);
            Console.WriteLine($"{Name} says: {words[index]}!");
        }
        else
        {
            Console.WriteLine($"{Name} has nothing to say yet.");
        }
        ReduceBoredom();
    }

    public void Teach(string word)
    {
        words.Add(word);
        Console.WriteLine($"{Name} learned \"{word}\"!");
        ReduceBoredom();
    }

    public void Tick()
    {
        hunger++;
        boredom++;
        if (hunger > 10 || boredom > 10)
        {
            isAlive = false;
        }
    }

    public void PrintStats()
    {
        Console.WriteLine($"--- {Name}'s Stats ---");
        Console.WriteLine($"Hunger: {hunger}");
        Console.WriteLine($"Boredom: {boredom}");
        Console.WriteLine($"Alive: {isAlive}");
    }

    public bool GetAlive()
    {
        return isAlive;
    }

    private void ReduceBoredom()
    {
        boredom -= new Random().Next(1, 3);
        if (boredom < 0) boredom = 0;
    }
}
