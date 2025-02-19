using System;
using System.Text;

internal class Program
{
    public static void CheckArrayElement(ref string[] range, ref bool isNumeric, int i, char c)
    {
        if (range[i] == c.ToString())
        {
            isNumeric = true;
            return;
        }
    }

    public static void CheckArray(ref string[] range, char c, ref bool isNumeric, ref bool isInvalid)
    {
        for (int i = 0; i < range.Length; i++)
        {
            CheckArrayElement(ref range, ref isNumeric, i, c);
        }
        if (!isNumeric)
        {
            isInvalid = true;
            return;
        }
    }
    public static void CheckStringInput(ref string amount, ref string[] range, ref bool isInvalid)
    {
        foreach (char c in amount)
        {
            bool isNumeric = false;

            CheckArray(ref range, c, ref isNumeric, ref isInvalid);
        }
    }
    private static void Main(string[] args)
    {
        bool calculateAgain = true;
        while (calculateAgain)
        {
            bool isInvalid = true;
            string amount = "";
            while (isInvalid)
            {
                Console.WriteLine("Enter Amount (must be a multiple of 100 and not exceed 50000): ");
                amount = Console.ReadLine();
                string[] range = { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

                isInvalid = false;

                CheckStringInput(ref amount, ref range, ref isInvalid);


                if (isInvalid)
                {
                    Console.WriteLine("Invalid input. Please enter a numeric value.");
                }
            }

            int number = Convert.ToInt32(amount);

            if (number > 50000 || number % 100 != 0)
            {
                Console.WriteLine("Invalid input. Please enter an amount less than or equal to 50000 and a multiple of 100.");
                continue;
            }

            int[] denomination = { 2000, 500, 200, 100 };
            int[] counts = new int[denomination.Length];

            for (int i = 0; i < denomination.Length; i++)
            {
                counts[i] = number / denomination[i];
                number %= denomination[i];
            }

            Console.WriteLine("Currency Denomination:");
            for (int i = 0; i < denomination.Length; i++)
            {
                Console.WriteLine($"{denomination[i]}: {counts[i]}");
            }

            Console.WriteLine(" ");
            Console.WriteLine("Would you like to play again? (Y/N)");

            string response = " ";
            while (response != "Y" && response != "N")
            {
                response = Console.ReadLine().ToUpper();
                if (response == "Y")
                {
                    calculateAgain = true;
                    Console.WriteLine(" ");
                }
                else if (response == "N")
                {
                    calculateAgain = false;
                    Console.WriteLine(" ");
                    Console.WriteLine("!!!Bye!!!");
                }
                else if (response != "Y" && response != "N")
                {
                    Console.WriteLine("Invalid Input");
                    Console.WriteLine("Please Enter Valid Input");
                }
            }
        }
    }
}
