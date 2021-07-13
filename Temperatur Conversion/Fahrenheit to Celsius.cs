using System;

namespace Temperatur_Conversion
{
   public class Fahrenheit_to_Celsius
    {
        private void Main()
        {
            double celsius;

            double fahrenheit = 50;
            Console.WriteLine("Fahrenheit: " + fahrenheit);

            celsius = ((fahrenheit - 32) * 5 / 9);
            Console.WriteLine("Celsius = " + celsius);
        }
    }
}
