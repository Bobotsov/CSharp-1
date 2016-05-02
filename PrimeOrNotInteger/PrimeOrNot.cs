using System;


namespace PrimeOrNotInteger
{
    class PrimeOrNot
    {
        static void Main()
        {
            Console.WriteLine("Enter a positive integer number: ");
            string consoleArgument = Console.ReadLine();
            uint number = uint.Parse(consoleArgument);
            uint divider = 2;
            uint maxDivider = (uint)Math.Sqrt(number);
            bool prime = true;
            while (prime && (divider <= maxDivider))
            {
                if (number % divider == 0)
                {
                    prime = false;
                }
                divider++;
            }
            Console.WriteLine("Prime? {0}", prime);

        }
    }
}
