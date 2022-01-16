using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Console.WriteLine("Podaj liczbę wyświetlonych linii:");
                int _numberOfLines = Convert.ToInt32(Console.ReadLine());

                int _price = 5;

                for (int i = 0; i < _numberOfLines; i++)
                {
                    Console.WriteLine($"Liczba sztuk: {i + 1}, łączna cena: {_price * (i + 1)}zł.");
                }
            }
        }
    }
}
