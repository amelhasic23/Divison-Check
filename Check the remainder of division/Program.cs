using System;

class Program
{
    static void Main(string[] args)
    {
        int x = 523134;
        int y = 325423;
        int remainder = x % y;

        if (remainder == 0)
        {
            Console.WriteLine("No remainder");
        }
        else if (remainder > 1000)
        {
            Console.WriteLine("Remainder is above 1000");
        }
        else
        {
            Console.WriteLine("Remainder is below 1000");
        }
    }
}

