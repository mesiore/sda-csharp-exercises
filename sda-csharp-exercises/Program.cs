using System;

namespace sda_csharp_exercises
{
    class Program
    {

        static public string CodeToLeet(string input)
        {
            char[] leetLetters = { '4', '3', '1', '0', '$', '7' };
            char[] naturalLetters = { 'a', 'e', 'i', 'o', 's', 't' };

            input = input.ToLower();

            string output = input;

            for (int i = 0; i < naturalLetters.Length; i++)
            {
                output = output.Replace(naturalLetters[i], leetLetters[i]);
            }

            return output;
        }

        static public string DecodeFromLeet(string input)
        {
            char[] leetLetters = { '4', '3', '1', '0', '$', '7' };
            char[] naturalLetters = { 'a', 'e', 'l', 'o', 's', 't' };

            input = input.ToLower();

            string output = input;

            for (int i = 0; i < leetLetters.Length; i++)
            {
                output = output.Replace(leetLetters[i], naturalLetters[i]);
            }

            return output;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Podaj tekst napisany normalnie:");

            string input1 = Console.ReadLine();

            Console.WriteLine("Podaj tekst napisany leetem:");

            string input2 = Console.ReadLine();

            Console.WriteLine($"Normalny tekst: \t\"{input1}\" \t");
            Console.WriteLine($"to L33t: \t\"{CodeToLeet(input1)}\"");
            Console.WriteLine($"L33t tekst: \t\"{input2}\" \t");
            Console.WriteLine($"to normal: \t\"{DecodeFromLeet(input2)}\"");

        }
    }
}
