using System;
using System.Numerics;

namespace Nfactorial
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            BigInteger result = 1;
            while (true)
            {
                if (n==1)
                {
                    break;
                }
                result *= n;
                n--;
            }
            Console.WriteLine("n! = " + result);
        }
    }
}
