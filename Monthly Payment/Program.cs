using System;

namespace Monthly_Payment
{
   public class Program
    {
       public static void Main(string[] args)
        {
            Console.WriteLine("Enter the Year");
            int Y = int.Parse (Console.ReadLine());
            Console.WriteLine("Enter the Intrest");
            double R = double.Parse(Console.ReadLine());
            Console.WriteLine("Enter the Principal Amount");
            int P = int.Parse(Console.ReadLine());
            int n = 12 * Y;
            double r = R / (12 * 100);
            double payment = P * r / (1 - Math.Pow(1 + r, -n));
            Console.WriteLine("Monthly Payment = " + payment);
        }
    }
}
