﻿using System;
namespace PrintDeck
{
    class printDeck
    {
        static void Main()
        {
            string[] all = { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
            string card = Console.ReadLine();
            for (int i = 0; i < all.Length; i++)
            {
                    Console.WriteLine("{0} of spades, {0} of clubs, {0} of hearts, {0} of diamonds", all[i]);

                if (all[i]==card)
                {
                    break;
                }
                
            }
        }
    }
}