using System;

namespace Gregorian_Calendar
{
   public class Program
    {
       public static void Main(string[] args)
        {
			DateTime d1 = new DateTime(1998, 10, 30);
			Console.WriteLine("DOB: " + d1);

			DateTime d2 = new DateTime(2021, 07, 07);
			Console.WriteLine("Date: " + d2);

			DateTime d3 = new DateTime(2021, 07, 07, 5, 10, 20);
			Console.WriteLine("Date and Time: " + d3);

			int y = 1998;
			int m = 10;
			int d = 30;
            int y0 = (y - (14 - m) / 12);
            Console.WriteLine("y0 = " + y0);
			int x = (y0 + y0 / 4 - y0 / 100 + y0 / 400);
            Console.WriteLine("x = " + x);
			int m0 = (m + 12 * ((14 - m) / 12) - 2);
            Console.WriteLine("m0 = " + m0);
			int d0 = ((d + x + 31 * m0 / 12) % 7);
            Console.WriteLine("d0 = " + d0);
		}
    }
}
