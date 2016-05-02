using System;

class AgeAfterTenY
{
    static void Main()
    {
        DateTime userBirthday = DateTime.Parse(Console.ReadLine()); //please use the following format MM.DD.YYYY
        long result = DateTime.Today.Subtract(userBirthday).Ticks;

        Console.WriteLine(new DateTime(result).Year - 1);
        Console.WriteLine(new DateTime(result).AddYears(10).Year - 1);
    }
}
