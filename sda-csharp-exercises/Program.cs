using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Arithmetic(int length, int number, int difference )
        {
            int value = number;
            for (int i = 0; i < length; i++)
            {
                Console.Write($"{ value}, ");
                value = value + difference;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Podaj pierwszą liczbę ciągu arytmetycznego:");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj długość ciągu arytmetycznego:");
            int length = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Podaj różnicę:");
            int difference = Convert.ToInt32(Console.ReadLine());

            Arithmetic(length, number, difference);
        }
    }
}
