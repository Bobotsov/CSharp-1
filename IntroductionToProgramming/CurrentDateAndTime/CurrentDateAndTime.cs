using System;

namespace CurrentDateAndTime
{
    class CurrentDateAndTime
    {
        static void Main(string[] args)
        {
            DateTime now = DateTime.Now;
            string date = now.GetDateTimeFormats('d')[0];
            string time = now.GetDateTimeFormats('t')[0];
            Console.WriteLine("Current date is: " + date);
            Console.WriteLine("Current time is: " + time);
        }
    }
}
