using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static int PowerOf(int power, int number )
        {
            int value = number;
            for (int i = 1; i < power; i++)
            {
                value = value * number;
            }

            return value;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podstawa:");
            int thisNumber = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Potega:");
            int thisPower = Convert.ToInt32(Console.ReadLine());

            if (thisPower < 0)
            {
                Console.WriteLine("Wykładnik nie może być ujenmy!");
            }
            else if (thisNumber == 0)
            {
                Console.WriteLine($"Wynik to: 1");
            }
            else
            {
                Console.WriteLine($"Wynik to: {PowerOf(thisNumber, thisPower)}");
            }
        }
    }
}
