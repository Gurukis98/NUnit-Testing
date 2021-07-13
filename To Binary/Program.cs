using System;
using System.Collections.Generic;


namespace To_Binary
{
   public class Program
    {
       public static void binary(long x)
        {
            List<int> v = new List<int>();

            Console.WriteLine("Binary of " + x + " : ");

            while (x > 0)
            {
                v.Add((int)x % 2);
                x = x / 2;
            }

            for (int i = 0; i < v.Count; i++)
            {
                if (v[i] == 1)
                {
                    Console.WriteLine(i);

                    if (i != v.Count - 1)
                        Console.WriteLine(", ");
                }
            }
            Console.WriteLine();
        }
        public static void Main()
        {
            binary(106);
        }
    }
}
