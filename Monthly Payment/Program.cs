using System;

namespace Monthly_Payment
{
   public class Program
    {
       public static void Main(string[] args)
        {
            int Y = int.Parse (Console.ReadLine());
            int R = int.Parse(Console.ReadLine());
            int P = int.Parse(Console.ReadLine());
            int n = 12 * Y;
            double r = R / (12 * 100);
            var payment = P * ((r / 1 - (Math.Pow(1 + r, -n))));
            Console.WriteLine("N = " + n);
            Console.WriteLine("Percent = " + r);
            Console.WriteLine("Payment = " + payment);
        }
    }
}
