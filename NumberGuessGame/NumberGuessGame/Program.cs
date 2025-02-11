using System;

internal class Program
{
    private static void Main(string[] args)
    {
        bool playAgain = true;

        while (playAgain)
        {
            Random r = new Random();
            int rInt = r.Next(1, 11);
            int NumberOfGuesses = 0;  

            Console.WriteLine("Guess a number between 1 to 10:");

            while (NumberOfGuesses < 3)
            {
                Console.Write("Enter Your Number: ");
                int number = Convert.ToInt32((Console.ReadLine()));

                if (number < 1 || number > 10)
                {
                    Console.WriteLine("Please enter a number between 1 and 10.");
                    continue;
                }

                NumberOfGuesses++;

                if (number > rInt)
                {
                    Console.WriteLine($"{number} is too high.");
                }
                else if (number < rInt)
                {
                    Console.WriteLine($"{number} is too low.");
                }
                else
                {
                    Console.WriteLine("Congratulations! You guessed the correct number.");
                    break;
                }
            }

            if (NumberOfGuesses == 3)
            {
                Console.WriteLine($"Sorry, you lost! The correct number was {rInt}.");
            }

            Console.WriteLine("Would you like to play again? (Y/N)");
            string response = Console.ReadLine().ToUpper();

            if (response != "Y")
            {
                playAgain = false;
                Console.WriteLine("Thanks for playing!");
            }
        }
    }
}
