using System;

namespace RemoveVowels
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma frase: ");
            string input = Console.ReadLine();

            string result = RemoveVowels(input);
            Console.WriteLine("Frase sem vogais: " + result);
        }

        static string RemoveVowels(string input)
        {
            string vowels = "aeiouAEIOU";
            string result = "";

            foreach (char c in input)
            {
                if (!vowels.Contains(c))
                    result += c;
            }

            return result;
        }
    }
}
