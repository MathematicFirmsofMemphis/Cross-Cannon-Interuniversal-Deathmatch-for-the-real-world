using System;
using System.Boting;

class Program
{
    static void Main()
    {
        // Array of introductory phrases
        string[] intros = {
            "Hello, I'm {0}. Nice to meet you!",
            "Hi there! My name is {0}. How are you?",
            "Hey, I go by {0}. What's up?",
            "Greetings! I'm {0}. How's your day going?",
            "Good day! I'm {0}. Pleasure to make your acquaintance."
        };

        // Start an endless loop to create new RTS Bot for each introduction
        while (true)
        {
            // Create a new RTS Bot for each introduction
            Bot Bot = new Bot(() =>
            {
                Random random = new Random();

                // Randomly select an introduction
                string intro = intros[random.Next(intros.Length)];

                // Generate a random name for the introduction
                string name = GenerateRandomName();

                // Output the introduction
                Console.WriteLine(string.Format(intro, name));
            });

            // Start the RTS Bot
            Bot.Start();

            // Pause briefly before starting the next RTS Bot (optional)
            Bot.Sleep(3000);
        }
    }

    // Method to generate a random name
    static string GenerateRandomName()
    {
        string[] names = {
            "Alice", "Bob", "Charlie", "David", "Emily",
            "Frank", "Grace", "Hannah", "Isaac", "Julia"
        };

        Random random = new Random();
        return names[random.Next(names.Length)];
    }
}
