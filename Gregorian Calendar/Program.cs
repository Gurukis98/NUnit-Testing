using System;

namespace Gregorian_Calendar
{
   public class Program
    {
       public static void Main(string[] args)
        {
            DateTime date = new DateTime(1998, 10, 30);
            Console.WriteLine("Date: " + date);
            Console.WriteLine("Day of a Week");
            Console.WriteLine(date.ToString("dddd \n"));

	    Console.WriteLine("Enter The Year");
            int y = int.Parse(Console.ReadLine());
       	    Console.WriteLine("Enter The Month");
	    int m = int.Parse(Console.ReadLine());
	    Console.WriteLine("Enter The Day");
	    int d = int.Parse(Console.ReadLine());

            int y0 = (y - (14 - m) / 12);
            Console.WriteLine("\ny0 = " + y0);
	    int x = (y0 + y0 / 4 - y0 / 100 + y0 / 400);
            Console.WriteLine("x = " + x);
	    int m0 = (m + 12 * ((14 - m) / 12) - 2);
            Console.WriteLine("m0 = " + m0);
	    int d0 = ((d + x + 31 * m0 / 12) % 7);
            Console.WriteLine("d0 = " + d0);
	}
    }
}
