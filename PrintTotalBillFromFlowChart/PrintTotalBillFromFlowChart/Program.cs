using System;
using System.Formats.Asn1;
using System.Reflection.Metadata.Ecma335;
using System.Runtime.InteropServices;

internal class Program
{
    public static void CalculateBill(ref double numberOfUnits, ref double charge, ref int meter_Charge)
    {
        if (numberOfUnits <= 100)
        {
            charge = numberOfUnits * 5;
        }
        else if (numberOfUnits <= 250)
        {
            charge = numberOfUnits * 10;
        }
        else
        {
            charge = numberOfUnits * 20;
        }
        Double Total_Water_Bill = charge + meter_Charge;
        Console.WriteLine($"Total Water Bill: {Total_Water_Bill}\n");
    }

    public static void CheckArrayInput(ref string[] Range, ref string num, ref bool isInvalid, ref int i)
    {
        if (Range[i] == num)
        {
            isInvalid = true;
            return;
        }
    }

    public static void CheckInput(ref string[] Range, ref string num, ref bool isInvalid, ref double charge, ref int meter_Charge)
    {
        for (int i = 0; i <= Range.Length - 1; i++)
        {
            CheckArrayInput(ref Range, ref num, ref isInvalid, ref i);
        }
        if (isInvalid)
        {
            Console.WriteLine("Invalid Input!!! Please Enter a Number\n");
            return;
            //continue;
        }
        Double numberOfUnits = Convert.ToDouble(num);
        while (true)
        {
            CalculateBill(ref numberOfUnits, ref charge, ref meter_Charge);
            break;
        }
    }

    public static void CheckResponse(ref string response, ref bool billAgain)
    {
        while (response != "Y" && response != "N")
        {
            response = Console.ReadLine().ToUpper();
            if (response == "Y")
            {
                billAgain = true;
                Console.WriteLine(" ");
            }
            else if (response == "N")
            {
                billAgain = false;
                Console.WriteLine(" ");
                Console.WriteLine("!!!Thanks for Billing!!!");
            }
            else if (response != "Y" && response != "N")
            {
                Console.WriteLine("Invalid Input");
                Console.WriteLine("Please Enter Y or N");
            }
        }
    }
    private static void Main(string[] args)
    {
        bool billAgain = true;
        while (billAgain)
        {
            bool isInvalid = false;
            Console.WriteLine("Enter Number of Units Consumed: ");
            string num = Console.ReadLine().ToLower();
            int meter_Charge = 75;
            Double charge=0;
            string[] Range = { "a", "b", "c", "d", "e", "f", "g", "h", "i", "j", "k", "l", "m", "n", "o", "p", "q", "r", "s", "t", "u", "v", "w", "x", "y", "z" };
            
            CheckInput(ref Range, ref num, ref isInvalid, ref charge, ref meter_Charge);


            Console.WriteLine("Would You Like To Bill Again? (Y/N)");
            string response = " ";
            CheckResponse(ref response, ref billAgain);
        }
    }
}