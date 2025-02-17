internal class Program
{
    public static void TotalWaterBill()
    {
        Console.WriteLine("Enter Number of Units Consumed: ");
        int unit = Convert.ToInt32(Console.ReadLine());
        int Meter_Charge = 75;
        int Charge;

        if (unit <= 100)
        {
            Charge = unit * 5;
        }
        else if (unit <= 250)
        {
            Charge = unit * 10;
        }
        else
        {
            Charge = unit * 20;
        }
        int Total_Water_Bill = Charge + Meter_Charge;
        Console.WriteLine(Total_Water_Bill);
    }
    private static void Main(string[] args)
    {
        TotalWaterBill();
    }
}