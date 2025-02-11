using System;

internal class Program
{
    private static void Main(string[] args)
    {
        string Player1 = "Aritra";
        string Player2 = "Rup";
        int p1Score = 0, p2Score = 0;
        int p1Sum = 0, p2Sum = 0;
        int TotalPoints = 20;
        Random r = new Random(); 

        while (p1Sum < TotalPoints && p2Sum < TotalPoints)
        {
            Console.WriteLine($"{Player1}'s Turn");

            while (true)
            {
                Console.WriteLine("Press R to Roll or H to Hold:");
                string roll = Console.ReadLine().ToUpper();

                if (roll == "R")
                {
                    int rInt = r.Next(1, 7);
                    Console.WriteLine($"{Player1} rolled a {rInt}");

                    if (rInt == 1)
                    {
                        p1Score = 0;
                        Console.WriteLine($"{Player1} lost the turn. Score remains {p1Sum}.");
                        break; 
                    }
                    else
                    {
                        p1Score += rInt;
                        p1Sum += rInt;
                        Console.WriteLine($"{Player1} score is {p1Sum}");

                        if (p1Sum >= TotalPoints)
                        {
                            Console.WriteLine($"{Player1} wins!");
                            return;
                        }
                    }
                }
                else if (roll == "H")
                {
                    Console.WriteLine($"{Player1} holds with a score of {p1Sum}");
                    break;
                }
            }

            Console.WriteLine($"{Player2}'s Turn");

            while (true)
            {
                Console.WriteLine("Press R to Roll or H to Hold:");
                string roll = Console.ReadLine().ToUpper();

                if (roll == "R")
                {
                    int rInt = r.Next(1, 7);
                    Console.WriteLine($"{Player2} rolled a {rInt}");

                    if (rInt == 1)
                    {
                        p2Score = 0;
                        Console.WriteLine($"{Player2} lost the turn. Score remains {p2Sum}.");
                        break;
                    }
                    else
                    {
                        p2Score += rInt;
                        p2Sum += rInt;
                        Console.WriteLine($"{Player2} score is {p2Sum}");

                        if (p2Sum >= TotalPoints)
                        {
                            Console.WriteLine($"{Player2} wins!");
                            return;
                        }
                    }
                }
                else if (roll == "H")
                {
                    Console.WriteLine($"{Player2} holds with a score of {p2Sum}");
                    break;
                }
            }
        }
    }
}
