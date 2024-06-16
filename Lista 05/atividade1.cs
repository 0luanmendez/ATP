using System;

class Program
{
    static void Main()
    {
        int[] N = new int[20];
        // Preencher o vetor N (neste exemplo, vou preencher manualmente para facilitar)
        for (int i = 0; i < 20; i++)
        {
            Console.Write($"Digite o valor de N[{i}]: ");
            N[i] = int.Parse(Console.ReadLine());
        }

        int menor = N[0];
        int posicao = 0;

        for (int i = 1; i < 20; i++)
        {
            if (N[i] < menor)
            {
                menor = N[i];
                posicao = i;
            }
        }

        Console.WriteLine($"O menor elemento de N é {menor} e sua posição dentro do vetor é {posicao}.");
    }
}
