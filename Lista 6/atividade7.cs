using System;
using System.IO;

class Program
{
    static void Main()
    {
        Console.Write("Digite o número de letras (N): ");
        int n = int.Parse(Console.ReadLine());

        // Solicita as N letras e salva no arquivo
        using (StreamWriter writer = new StreamWriter("letras.txt"))
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write($"Digite a {i + 1}ª letra: ");
                char letra = Console.ReadKey().KeyChar;
                writer.WriteLine(letra);
            }
        }

        // Lê as letras do arquivo e conta as vogais
        int vogais = 0;
        using (StreamReader reader = new StreamReader("letras.txt"))
        {
            while (!reader.EndOfStream)
            {
                char letra = reader.ReadLine()[0];
                if ("aeiouAEIOU".Contains(letra))
                    vogais++;
            }
        }

        Console.WriteLine($"\nQuantidade de vogais: {vogais}");
    }
}
