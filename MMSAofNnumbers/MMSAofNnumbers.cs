using System;
namespace MMSAofNnumbers
{
    class mmsaOfNnumbers
    {
        static void Main()
        {
            double minValue = 0;
            double maxValue = 0;
            double sumValue = 0;
            int count = int.Parse(Console.ReadLine());

            for (int i = 0; i < count; i++)
            {
                double number = double.Parse(Console.ReadLine());
                if (i == 0)
                {
                    minValue = number;
                    maxValue = number;
                }
                if (number > maxValue)
                {   
                    maxValue=number;
                }   
                if (number < minValue)
                {   
                    minValue=number;
                }
                sumValue += number;
            }
            Console.WriteLine("min={0:F2}", minValue);
            Console.WriteLine("max={0:F2}", maxValue);
            Console.WriteLine("sum={0:F2}", sumValue);
            Console.WriteLine("avg={0:F2}", sumValue / count);
        }
    }
}
