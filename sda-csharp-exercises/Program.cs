using System;

namespace sda_csharp_exercises
{
    class Program
    {
        static public void Triangle(int lines)
        {
            for (int i = 0; i < lines; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    Console.Write("*");

                }
                Console.WriteLine();
            }

            for (int i = lines - 1; i > 0; i--)
            {
                for (int j = i; j > 0; j--)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }

        static void Main(string[] args)

        {
            Console.WriteLine("Ile chcesz mieć linii?");
            int lines = Convert.ToInt32(Console.ReadLine());

            Triangle(lines);
        }

    }
}
