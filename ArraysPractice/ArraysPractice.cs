using System;


namespace ArraysPractice
{
    class ArraysPractice
    {
        static void Main()
        {
            //int[] a = new int[10];
            string[] cards = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            Console.WriteLine(cards[11]);
            foreach (var item in cards)
            {
                Console.WriteLine(item);
            }
             
        }
    }
}
