
using System;

class Pet
{
    public string Name { get; set; }
    public int Hunger { get; set; }
    public int Happiness { get; set; }
    public int Energy { get; set; }

    public Pet(string name)
    {
        Name = name;
        Hunger = 50;
        Happiness = 50;
        Energy = 50;
    }

    public void Feed()
    {
        Console.WriteLine($"{Name} is eating.");
        Hunger -= 10;
        CheckStatus();
    }

    public void Play()
    {
        Console.WriteLine($"{Name} is playing.");
        Hunger += 5;
        Happiness += 10;
        Energy -= 10;
        CheckStatus();
    }

    public void Sleep()
    {
        Console.WriteLine($"{Name} is sleeping.");
        Energy += 20;
        Hunger += 5;
        CheckStatus();
    }

    public void CheckStatus()
    {
        if (Hunger <= 0 || Happiness <= 0 || Energy <= 0)
        {
            Console.WriteLine($"{Name} is not feeling well. Game over!");
            Environment.Exit(0);
        }

        Console.WriteLine($"{Name}'s status - Hunger: {Hunger}, Happiness: {Happiness}, Energy: {Energy}");
    }
}

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome to the first assignment");

        // Display the pet options
        Console.WriteLine("Choose a pet: ");
        Console.WriteLine("1. Dog");
        Console.WriteLine("2. Cat");
        Console.WriteLine("3. Sparrow");

        Console.Write("Enter your choice: ");
        string petChoice = Console.ReadLine();

        // Prompt the user to enter the pet's name
        Console.Write("Enter your pet's name: ");
        string petName = Console.ReadLine();

        Pet pet;

        // Create the chosen pet object based on user input
        switch (petChoice)
        {
            case "1":
                pet = new Pet(petName + " (Dog)");
                break;
            case "2":
                pet = new Pet(petName + " (Cat)");
                break;
            case "3":
                pet = new Pet(petName + " (Sparrow)");
                break;
            default:
                Console.WriteLine("Invalid choice. Exiting the program.");
                return;
        }

        Console.WriteLine($"You now have a pet named {pet.Name}!");

        // Main game loop
        while (true)
        {
            Console.WriteLine("\nChoose an action:");
            Console.WriteLine("1. Feed");
            Console.WriteLine("2. Play");
            Console.WriteLine("3. Sleep");
            Console.WriteLine("4. Quit");

            Console.Write("Enter your choice: ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    pet.Feed();
                    break;

                case "2":
                    pet.Play();
                    break;

                case "3":
                    pet.Sleep();
                    break;

                case "4":
                    Console.WriteLine("Thanks for playing!");
                    Environment.Exit(0);
                    break;

                default:
                    Console.WriteLine("Invalid choice. Please try again.");
                    break;
            }
        }
    }
}


