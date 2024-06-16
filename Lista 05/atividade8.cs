using System;

class Program
{
    static void Main()
    {
        int[,] matriz = new int[4, 4];
        Random rnd = new Random();

        // Preencher a matriz 4x4
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < 4; j++)
            {
                matriz[i, j] = rnd.Next(1, 101); // Números aleatórios entre 1 e 100
            }
        }

        Console.WriteLine("Matriz gerada:");
        ImprimirMatriz(matriz);

        int somaAbaixoDiagonal = 0;

        // Calcular a soma dos elementos abaixo da diagonal principal
        for (int i = 0; i < 4; i++)
        {
            for (int j = 0; j < i; j++)
            {
                somaAbaixoDiagonal += matriz[i, j];
            }
        }

        Console.WriteLine($"Soma dos elementos abaixo da diagonal principal: {somaAbaixoDiagonal}");

        // Mostrar a diagonal principal
        Console.WriteLine("Elementos da diagonal principal:");
        for (int i = 0; i < 4; i++)
        {
            Console.Write(matriz[i, i] + " ");
        }
        Console.WriteLine();
    }

    static void ImprimirMatriz(int[,] matriz)
    {
        for (int i = 0; i < matriz.GetLength(0); i++)
        {
            for (int j = 0; j < matriz.GetLength(1); j++)
            {
                Console.Write(matriz[i, j] + "\t");
            }
            Console.WriteLine();
        }
    }
}
