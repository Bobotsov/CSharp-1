using System;


namespace SquareSizedN
{
    class Program
    {
        static void Main()
        {
            Console.Write("Provide side value: ");
            int n = int.Parse(Console.ReadLine());
            for (int row = 1; row <= n; row++)
            {
                for (int i = 1; i <= n; i++)
                {
                    if (i==1 || i==n)
                    {
                        Console.Write("*");
                    }
                    continue;
                    //Console.Write("*");
                }
                Console.WriteLine();
            }
        }
    }
}
