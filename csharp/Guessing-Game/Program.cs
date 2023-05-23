using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Welcome! This is the guessing game!");
        Console.WriteLine("Guess the SECRET number!");
        Console.WriteLine("...................................");
        Console.WriteLine(" ");

        Random random = new Random();
        int secretNumber = random.Next(1, 101); // Generate a random secret number between 1 and 100
        int maxGuesses;
        int numGuesses = 0;
        int currentGuesses;

        Console.WriteLine("Choose a difficulty level: ");
        Console.WriteLine("1 - Easy");
        Console.WriteLine("2 - Medium");
        Console.WriteLine("3 - Hard");
        Console.WriteLine("4 - Cheater");
        
        Console.Write("Enter a difficulty number here!");
        int difficultyLevel = int.Parse(Console.ReadLine()); // Read the difficulty level chosen by the user

        switch (difficultyLevel)
        {
            case 1:
                maxGuesses = 8; // Set the maximum number of guesses to 8 for Easy level
                currentGuesses = maxGuesses - 1;
                break;
            case 2:
                maxGuesses = 6; // Set the maximum number of guesses to 6 for Medium level
                currentGuesses = maxGuesses - 1;
                break;
            case 3:
                maxGuesses = 4; // Set the maximum number of guesses to 4 for Hard level
                currentGuesses = maxGuesses - 1;
                break;
            case 4:
                maxGuesses = int.MaxValue; // Set maxGuesses to a very large value for Cheater level
                currentGuesses = int.MaxValue;
                break;
            default:
                Console.WriteLine("Invalid difficulty level. Setting to Medium by default.");
                maxGuesses = 6; // Default to Medium level if an invalid difficulty level is chosen
                currentGuesses = maxGuesses - 1;
                break;
        }

        while (numGuesses < maxGuesses)
        {
            Console.Write("Enter your guess: ");
            string userInput = Console.ReadLine();
            int userGuess = int.Parse(userInput); // Read the user's guess

            if (userGuess == secretNumber) // Check if the user's guess is correct
            {
                Console.WriteLine("You guessed right! Congrats!");
                break;
            }
            else
            {
                Console.WriteLine("Sorry, try again! You have " + currentGuesses + " guesses left!");
                currentGuesses--;
                numGuesses++;
            }

            if (userGuess > secretNumber)
            {
                Console.WriteLine("Your guess was too high!");
            }
            else
            {
                Console.WriteLine("Your guess was too low!");
            }
        }

        if (numGuesses == maxGuesses)
        {
            Console.WriteLine("Sorry, you ran out of guesses! The secret number was: " + secretNumber);
        }
    }
}
