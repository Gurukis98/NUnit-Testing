using System;

namespace Newton_s_Method
{
   public class Program
    {
       public static double squareRoot(double n, double l)
        {
            double t = n;
            double root;
            int count = 0;

            while (true)
            {
                count++;
                root = 0.5 * (t + (n / t));

                if (Math.Abs(root - t) < l)
                    break;

                t = root;
            }

            return root;
        }
        public static void Main()
        {
            double n = 81;
            double l = 0.00001;

            Console.WriteLine(squareRoot(n, l));
        }
    }
}
