using System;
using System.Collections.Generic;
using System.Text;

namespace OnlineLibraryApp
{
    public static class Utilities
    {
        // combination of random number and random string

        // Random Double
        public static decimal RandomDecimal(Random random)
        {
            double minDouble = 0.01;
            double maxDouble = 9.99;
            int decimal_position = 2;

            // Calculation
            decimal value = Math.Round(new decimal(random.NextDouble() * (maxDouble - minDouble) + minDouble),
                decimal_position);
            return value;
        }

        /*
         * -- CODE ATTRIBUTION --
         * link: https://www.educative.io/edpresso/how-to-generate-a-random-string-in-c-sharp
         */
        // Random String
        public static string RandomString(int size, Random random)
        {
            StringBuilder builder = new StringBuilder();

            char letter;
            for (int i = 0; i < size; i++)
            {
                letter = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(letter);
            }

            return builder.ToString();
        }
    }
}
