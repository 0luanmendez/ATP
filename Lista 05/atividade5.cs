using System;

class Program
{
    static int[] SortearNumeros()
    {
        int[] sorteio = new int[3];
        Random rnd = new Random();
        for (int i = 0; i < 3; i++)
        {
            sorteio[i] = rnd.Next(10, 51); // Números aleatórios entre 10 e 50
        }
        return sorteio;
    }

    static void Main()
    {
        int[] numerosSorteados = SortearNumeros();
        int tentativas = 0;
        int palpite;

        Console.WriteLine("Tente adivinhar um dos números sorteados entre 10 e 50.");

        do
        {
            Console.Write("Digite seu palpite: ");
            palpite = int.Parse(Console.ReadLine());
            tentativas++;
        } while (palpite != numerosSorteados[0] && palpite != numerosSorteados[1] && palpite != numerosSorteados[2]);

        Console.WriteLine($"Parabéns! Você acertou o número {palpite} depois de {tentativas} tentativas.");
    }
}
