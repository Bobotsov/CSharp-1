using System;


namespace FactorialFromNtoM
{
    class FactorialWithDoWhile
    {
        static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int max = Math.Max(n, m);
            int min = Math.Min(n, m);
            n = min;
            m = max;

            int result = 1;
            int number = n;
            do
            {
                result *= number;
                number++;
                    
            } while (number<=m);
            Console.WriteLine("product [n...m] is {0}", result);
        }
    }
}
