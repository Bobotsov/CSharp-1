using System;
namespace NumberFrom1ToN
{
    class Program
    {
        static void Main()
        {
            uint number = uint.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if (i % 3 != 0 && i % 7 != 0)
                {
                    Console.Write(i + " ");
                }
            }
        }
    }
}

