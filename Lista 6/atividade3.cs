using System;

namespace CifraDeCesar
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Digite uma frase: ");
            string input = Console.ReadLine();

            string encrypted = EncryptCesar(input, 3);
            Console.WriteLine("Nova string: " + encrypted);
        }

        static string EncryptCesar(string input, int shift)
        {
            string result = "";

            foreach (char c in input)
            {
                if (char.IsLetter(c))
                {
                    char baseChar = char.IsUpper(c) ? 'A' : 'a';
                    char shiftedChar = (char)(((c - baseChar + shift) % 26) + baseChar);
                    result += shiftedChar;
                }
                else
                {
                    result += c;
                }
            }

            return result;
        }
    }
}
