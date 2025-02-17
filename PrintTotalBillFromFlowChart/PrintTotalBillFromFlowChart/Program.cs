using System.Formats.Asn1;
using System.Reflection.Metadata.Ecma335;

internal class Program
{
    public static void TotalWaterBill()
    {
        Console.WriteLine("Enter Number of Units Consumed: ");
        Double NumberOfUnits = Convert.ToDouble(Console.ReadLine());
        int Meter_Charge = 75;
        Double Charge;
        Double units = 0;

        if (NumberOfUnits < 0)
        {
            units = -NumberOfUnits;
        }

        if (units <= 100)
        {
            Charge = units * 5;
        }
        else if (units <= 250)
        {
            Charge = units * 10;
        }
        else
        {
            Charge = units * 20;
        }

        Double Total_Water_Bill = Charge + Meter_Charge;
        Console.WriteLine(" ");
        Console.WriteLine($"Total Water Bill: {Total_Water_Bill}");
    }
    private static void Main(string[] args)
    {
        TotalWaterBill();
    }
}