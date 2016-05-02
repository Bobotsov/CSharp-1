using System;

namespace PrintNumberTriangle
{
    class Program
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                for (int column = 1; column <=row ; column++)
                {
                    Console.Write("{0}", column);
                }
                Console.WriteLine();
            }
        }
    }
}
