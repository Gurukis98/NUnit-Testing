using System;

namespace Vending_Machine
{
   public class Program
   {
            public static void countCurrency(int amount)
            {
                int[] notes = new int[] { 2000, 500, 200, 100, 50, 20, 10, 5, 2, 1 };
                int[] noteCounter = new int[10];

                for (int i = 0; i < 10; i++)
                {
                    if (amount >= notes[i])
                    {
                        noteCounter[i] = amount / notes[i];
                        amount = amount - noteCounter[i] * notes[i];
                    }
                }

                Console.WriteLine("Currency Count ->");

                for (int i = 0; i < 10; i++)
                {
                    if (noteCounter[i] != 0)
                    {
                        Console.WriteLine(notes[i] + " : " + noteCounter[i]);
                    }
                }
            }
            public static void Main()
            {
                int amount = 123456;
                countCurrency(amount);
                Console.WriteLine("Amount = " + amount);
            }
   }
}
